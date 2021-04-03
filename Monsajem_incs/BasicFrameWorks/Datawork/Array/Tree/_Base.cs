﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsajem_Incs.Collection.Array.TreeBased
{
    public partial class Array<ValueType> : Base.IArray<ValueType, Array<ValueType>>
    {

        public Array()
        { }
        public Array(ValueType[] Values)
        {
            this.Insert(Values);
        }

#if DEBUG
        private Array.ArrayBased.DynamicSize.Array<ValueType> Items =
            new Array.ArrayBased.DynamicSize.Array<ValueType>(100);

        private void Check()
        {
            for (int i = 0; i < Items.Length; i++)
            {
                Node Before; Node Next;
                var Current = GetItem(i, out Before, out Next);
                var ItemValue = Items[i];
                if (Current == null || Comparer.Compare(Current.Value, ItemValue) != 0)
                    throw new Exception("Some Item lost!");
                //if (Current.Balance > 1 || Current.Balance < -1)
                //    throw new Exception("Equality Faild!");
                if (Current.Holder == null && Current != Root)
                    throw new Exception("Some Data lost!");
                if (Current.Next != null)
                {
                    //if (Comparer.Compare(Current.Next.Value, Current.Value) < 0)
                    //    throw new Exception("Data not correct!");

                    if (Current.NextDeep > 0)
                    {
                        if (Current.NextDeep != Math.Max(Current.Next.BeforeDeep , Current.Next.NextDeep) + 1)
                            throw new Exception("Data not correct!");
                    }
                    else
                        throw new Exception("Data not correct!");

                    if (Current.NextLen > 0)
                    {
                        if (Current.NextLen != Current.Next.NextLen + Current.Next.BeforeLen + 1)
                            throw new Exception("Data not correct!");
                    }
                    else if (Current.Next != null)
                        throw new Exception("Data not correct!");

                    if (Current.Next.Holder != Current)
                        throw new Exception("Some Data lost!");
                }
                if (Current.Before != null)
                {
                    //if (Comparer.Compare(Current.Before.Value, Current.Value) > 0)
                    //    throw new Exception("Data not correct!");

                    if (Current.BeforeDeep > 0)
                    {
                        if (Current.BeforeDeep != Math.Max(Current.Before.BeforeDeep, Current.Before.NextDeep) + 1)
                            throw new Exception("Data not correct!");
                    }
                    else
                        throw new Exception("Data not correct!");

                    if (Current.BeforeLen > 0)
                    {
                        if (Current.BeforeLen != Current.Before.NextLen + Current.Before.BeforeLen + 1)
                            throw new Exception("Data not correct!");
                    }
                    else if (Current.Before != null)
                        throw new Exception("Data not correct!");

                    if (Current.Before.Holder != Current)
                        throw new Exception("Some Data lost!");
                }
                if (Current.Holder != null)
                {
                    if (Current.IsNext && Current != Current.Holder.Next)
                        throw new Exception("Some Data lost!");
                    else if (Current.IsNext == false && Current != Current.Holder.Before)
                        throw new Exception("Some Data lost!");
                    if (Items.Count((c) => Comparer.Compare(c, Current.Holder.Value) == 0) == 0)
                        throw new Exception("Some Data lost!");
                }
            }
        }
#endif

        public Node Root;
        public class Node
        {
            public Node(ValueType Value)
            {
                this.Hash = this.GetHashCode();
                this.Value = Value;
            }

            public int NextDeep;
            public int BeforeDeep;
            public int Balance { get => NextDeep - BeforeDeep; }
            public int NextLen;
            public int BeforeLen;

            public ValueType Value;
            public Node Holder;
            public bool IsNext;
            public Node Next;
            public Node Before;
            public int Hash;


            public override string ToString()
            {
                if (Holder == null)
                    return "Root";
                else
                {
                    if (IsNext)
                        return $"Body next: {Value}";
                    else
                        return $"Body before: {Value}";
                }
            }
        }

        private Node GetItem(
            int position,
            out Node Before,
            out Node Next)
        {
            Before = default;
            Next = default;
            if (position < 0)
                throw new Exception("Position must start at zero.");
            position++;
            var Current = Root;
            while (Current != null)
            {
                var cmp = position - (Current.BeforeLen + 1);
                if (cmp == 0)
                    return Current;
                else if (cmp > 0)
                {
                    Before = Current;
                    position -= Current.BeforeLen + 1;
                    Current = Current.Next;
                }
                else
                {
                    Next = Current;
                    Current = Current.Before;
                }
            }

            return null;
        }

        public override ValueType this[int Position]
        {
            get => GetItem(Position, out var x, out var y).Value;
            set => GetItem(Position, out var x, out var y).Value = value;
        }

        public override void Insert(ValueType Value, int Position)
        {
            Node Before; Node Next;int Deep;
            var Current = GetItem(Position, out Before, out Next);
            Insert(Value, Current, Before, Next);
#if DEBUG
            Items.Insert(Value, Position);
            Check();
#endif
        }

        public override int BinaryInsert(ValueType Value)
        {
            Node Before; Node Next; int Pos;
            var Current = Find(Value, out Before, out Next, out Pos);
            Insert(Value, Current, Before, Next);
#if DEBUG
            Items.BinaryInsert(Value);
            Check();
#endif

#if DEBUG
            var ItemResult = Items.BinarySearch(Value);
            if (Pos != ItemResult.Index)
                throw new Exception("Binary search result is wrong!");
#endif
            return Pos;
        }

        public override (int Index, ValueType Value) BinarySearch(ValueType key, int minNum, int maxNum)
        {
            (int Index, ValueType Value) Result = default;
            Node Before; Node Next; int Pos;
            var Current = Find(key, out Before, out Next, out Pos);
            if (Current != null)
                Result = (Pos, Current.Value);
            else
                Result = ((Pos + 1) * -1, default);
#if DEBUG
            var ItemResult = Items.BinarySearch(key);
            if (Result.Index != ItemResult.Index)
                throw new Exception("Binary search result is wrong!");
#endif
            return Result;
        }

        private void Insert(ValueType Value, Node Current, Node Before, Node Next)
        {
            if (Root == null)
            {
                Current = new Node(Value);
                Root = Current;
                Length++;
                return;
            }

            if (Current != null)
            {
                Next = Current;
                Before = null;
            }
            Current = new Node(Value);

            if (Before != null)
            {
                Current.IsNext = true;
                Current.Holder = Before;
                Next = Before.Next;
                Before.Next = Current;
                if (Next != null)
                {
                    Current.Next = Next;
                    Current.NextLen = Next.NextLen + Next.BeforeLen+1;
                    Next.Holder = Current;
                    Current.NextDeep = Math.Max(Next.BeforeDeep, Next.NextDeep)+1;
                    Before.NextLen = Current.NextLen;
                    Before.NextDeep = Current.NextDeep;
                }
            }
            else
            {
                Current.IsNext = false;
                Current.Holder = Next;
                Before = Next.Before;
                Next.Before = Current;
                if (Before != null)
                {
                    Current.Before = Before;
                    Current.BeforeLen = Before.NextLen + Before.BeforeLen+1;
                    Before.Holder = Current;
                    Current.BeforeDeep =Math.Max(Before.BeforeDeep,Before.NextDeep)+1;
                    Next.BeforeLen = Current.BeforeLen;
                    Next.BeforeDeep = Current.BeforeDeep;
                }
            }
            FixEquality(Current);
            Length++;
        }

        public override void DeleteByPosition(int Position)
        {
            Node Before; Node Next;
            var Item = GetItem(Position, out Before, out Next);
            Drop(Item);
            Length--;

#if DEBUG
            Items.DeleteByPosition(Position);
            Check();
#endif
        }

        public override (int Index, ValueType Value) BinaryDelete(ValueType Value)
        {
            Node Before; Node Next; int Pos;
            var Item = Find(Value, out Before, out Next, out Pos);
            if (Item == null)
                throw new Exception($"{Value} not found!");
            var Result = (Item.BeforeLen, Item.Value);
            Drop(Item);
            Length--;
#if DEBUG
            Items.BinaryDelete(Value);
            Check();
#endif
            return Result;
        }

        private void MoveToHolder(Node Node)
        {
            var Holder = Node.Holder;
            var Root = Holder.Holder;
            var HolderIsNext = Holder.IsNext;
            var NodeIsNext = Node.IsNext;
            if (Root != null)
            {
                if (HolderIsNext)
                {
                    Root.Next = Node;
                    Node.IsNext = true;
                }
                else
                {
                    Root.Before = Node;
                    Node.IsNext = false;
                }
            }
            else
                this.Root = Node;

            if (NodeIsNext)
            {
                Holder.NextLen = Node.BeforeLen;
                Node.BeforeLen = (Holder.NextLen + Holder.BeforeLen) + 1;
                var Before = Node.Before;
                Holder.Next = Before;
                if (Before != null)
                {
                    Before.Holder = Holder;
                    Before.IsNext = true;
                    Holder.NextDeep = Math.Max(Before.NextDeep, Before.BeforeDeep) + 1;
                }
                else
                    Holder.NextDeep = 0;
                Node.Before = Holder;
                Holder.IsNext = false;
                Node.BeforeDeep = Math.Max(Holder.NextDeep, Holder.BeforeDeep) + 1;
            }
            else
            {
                Holder.BeforeLen = Node.NextLen;
                Node.NextLen = (Holder.NextLen + Holder.BeforeLen) + 1;
                var Next = Node.Next;
                Holder.Before = Next;
                if (Next != null)
                {
                    Next.Holder = Holder;
                    Next.IsNext = false;
                    Holder.BeforeDeep = Math.Max(Next.NextDeep, Next.BeforeDeep) + 1;
                }
                else
                    Holder.BeforeDeep = 0;
                Node.Next = Holder;
                Holder.IsNext = true;
                Node.NextDeep = Math.Max(Holder.NextDeep, Holder.BeforeDeep) + 1;
            }
            
            Holder.Holder = Node;
            if (Root != null)
            {
                Node.Holder = Root;
                if(Node.IsNext)
                    Root.NextDeep = Math.Max(Node.NextDeep, Node.BeforeDeep) + 1;
                else
                    Root.BeforeDeep = Math.Max(Node.NextDeep, Node.BeforeDeep) + 1;
            }
            else
                Node.Holder = null;
        }

        private void Drop(Node Node)
        {
            DropWayLen(Node);
            var BeforeLen = Node.BeforeLen;
            var NextLen = Node.NextLen;
            if (BeforeLen == 0 && NextLen == 0)
            {
                DropFromHolder(Node, null);
                return;
            }
            else if (BeforeLen == 0)
            {
                DropFromHolder(Node, Node.Next);
                return;
            }
            else if (NextLen == 0)
            {
                DropFromHolder(Node, Node.Before);
                return;
            }

            var Holder = Node;
            if (Node.BeforeLen > Node.NextLen)
            {
                Node = Node.Before;
                while (Node.NextLen > 0)
                {
                    Node.NextLen--;
                    Node = Node.Next;
                }
                DropFromHolder(Node, Node.Before);
            }
            else
            {
                Node = Node.Next;
                while (Node.BeforeLen > 0)
                {
                    Node.BeforeLen--;
                    Node = Node.Before;
                }
                DropFromHolder(Node, Node.Next);
            }
            var Before = Holder.Before;
            var Next = Holder.Next;
            Node.Before = Before;
            Node.Next = Next;
            Node.BeforeLen = Before.BeforeLen + Before.NextLen + 1;
            Node.NextLen = Next.BeforeLen + Next.NextLen + 1;
            DropFromHolder(Holder, Node);
        }

        private void DropFromHolder(Node Node, Node Replace)
        {
            var Holder = Node.Holder;
            if (Holder == null)
            {
                Root = Replace;
                if (Replace != null)
                    Replace.Holder = null;
            }
            else
            {
                var len = 0;
                if (Replace != null)
                    len = Replace.NextLen + Replace.BeforeLen + 1;

                if (Node.IsNext)
                {
                    Holder.Next = Replace;
                    if (Replace != null)
                    {
                        Replace.Holder = Holder;
                        Replace.IsNext = true;
                    }
                    Holder.NextLen = len;
                }
                else
                {
                    Holder.Before = Replace;
                    if (Replace != null)
                    {
                        Replace.Holder = Holder;
                        Replace.IsNext = false;
                    }
                    Holder.BeforeLen = len;
                }
            }
            return;
        }

        private void DropWayLen(Node Child)
        {
            var Holder = Child.Holder;
            while (Holder != null)
            {
                if (Child.IsNext)
                    Holder.NextLen--;
                else
                    Holder.BeforeLen--;
                Holder = Child.Holder;
            }
        }

        public Node Find(ValueType Value)
        {
            Node Before; Node Next; int Pos;
            return Find(Value, out Before, out Next, out Pos);
        }

        public override object MyOptions { get => null; set { } }

        public Node Find(
            ValueType Value,
            out Node Before,
            out Node Next, 
            out int Position)
        {
            Before = default;
            Next = default;
            Position = 0;
            var Current = Root;
            while (Current != null)
            {
                var cmp = Comparer.Compare(Current.Value, Value);
                if (cmp == 0)
                {
                    Position += Current.BeforeLen;
                    return Current;
                }
                else if (cmp < 0)
                {
                    Position += Current.BeforeLen + 1;
                    Before = Current;
                    Current = Current.Next;
                }
                else
                {
                    Next = Current;
                    Current = Current.Before;
                }
            }
            if (Before != null)
                Position += Before.BeforeLen;
            return null;
        }

        private void FixEquality(Node node)
        {
            var Node = node;
            while (node!=null && node.Holder != null)
            {
                var Holder = node.Holder;
                var HolderDeep = Math.Max(node.NextDeep, node.BeforeDeep) + 1;
                if (node.IsNext == true)
                {
                    Holder.NextLen++;
                    Holder.NextDeep = HolderDeep;
                }
                else
                {
                    Holder.BeforeLen++;
                    Holder.BeforeDeep = HolderDeep;
                }

                if (Holder.Balance > 1 || Holder.Balance < -1)
                {
                    MoveToHolder(node);
                }
                else
                    node = node.Holder;
            }
        }

        protected override Array<ValueType> MakeSameNew()
        {
            return new Array<ValueType>();
        }
    }
}