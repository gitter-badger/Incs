﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monsajem_Incs.Array.FixedSize
{
    public class Array<ArrayType>:
        OneArrayBase.Array<ArrayType, Array<ArrayType>>
    {
        private int MaxLen;
        public Array(int Count):base(new ArrayType[Count])
        {
            MaxLen = Count;
        }

        public Array(ArrayType[] Ar) : base(Ar)
        {
            Length = ar.Length;
            MaxLen = ar.Length;
        }

        public Array(ArrayType[] Ar,int Length) : base(Ar)
        {
            this.Length = Length;
            MaxLen = Length;
        }

        public override object MyOptions { 
            get => null;
            set { }
        }

        public override void DeleteFrom(int from)
        {
            Length = from;
        }
        internal override void AddLength(int Count)
        {
            if (Length >= MaxLen)
                throw new OverflowException($"Max size is {MaxLen}!");
            Length = Length + Count;
        }

        public bool IsFull { get => Length == MaxLen; }

        protected override Array<ArrayType> MakeSameNew()
        {
            return new Array<ArrayType>(ar.Length);
        }
    }
}