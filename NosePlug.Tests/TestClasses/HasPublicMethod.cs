﻿using System;
using System.Threading.Tasks;

namespace NosePlug.Tests.TestClasses
{
    internal class HasPublicMethod
    {
        public static void NoParameters() { }

        public static void Overloaded(int value) { }
        public static void Overloaded(string @string, int value) { }

        public static int ReturnValue() => 42;

        public static void GuidParameter(Guid value) { }

        public static async Task AsyncMethod() { }
        public static async Task<int> AsyncMethodWithReturn() => 42;

        public static T GenericMethod<T>() { return default; }
    }
}