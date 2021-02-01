﻿using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Linq;
using System.Runtime.CompilerServices;
using static Monsajem_Incs.ArrayExtentions.ArrayExtentions;

namespace Monsajem_Incs.DynamicAssembly
{
    public class DynamicMethodBuilder
    {
        public static DynamicMethod Method(
            string Name,
            Type[] Inputs,
            Type Output,
            Action<ILGenerator> ILGenerator)
        {
            var dynMethod = new DynamicMethod(Name,Output,Inputs,true);
            ILGenerator il = dynMethod.GetILGenerator();
            ILGenerator(il);
            return dynMethod;
        }

        public static DynamicMethod Method(
            string Name,
            MethodInfo LikeMethod,
            Action<ILGenerator> ILGenerator)=>
            Method(Name,
                LikeMethod.GetParameters().Select((c)=>c.ParameterType).ToArray(),
                LikeMethod.ReturnType,
                ILGenerator);

        public static DynamicMethod Method<t>(
            string Name,
            Action<ILGenerator> ILGenerator)
            where t:MulticastDelegate=>
               Method(Name, typeof(t).GetMethod("Invoke"),ILGenerator);

        public static Delegate Delegate(
            string Name,
            Type DelegateType,
            Action<ILGenerator> ILGenerator) =>
            Method(Name,DelegateType.GetMethod("Invoke"), ILGenerator).CreateDelegate(DelegateType);

        public static t Delegate<t>(
            string Name,
            Action<ILGenerator> ILGenerator)
            where t : MulticastDelegate =>
               (t)Method<t>(Name,ILGenerator).CreateDelegate(typeof(t));
    }
}
