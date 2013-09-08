using System;

namespace Extensions
{
    /// <summary>コンストラクタが1個のバリアントです。</summary>
    public sealed class Variant<T1>
    {
        private Variant(){}
        private int label;

        /// <summary>1個目のコンストラクタです。</summary>
        private T1 value1;
        public static Variant<T1> C1(T1 v1)
        {
            var v =new Variant<T1>();
            v.label=1; v.value1 = v1;
            return v;
        }
        /// <summary>パターンマッチをします。</summary>
        public T Match<T>(Func<T1, T> C1)
        {
            switch (this.label)
            {
                default: return C1(this.value1);
            }
        }
    }
    /// <summary>コンストラクタが2個のバリアントです。</summary>
    public sealed class Variant<T1,T2>
    {
        private Variant(){}
        private int label;

        /// <summary>1個目のコンストラクタです。</summary>
        private T1 value1;
        public static Variant<T1,T2> C1(T1 v1)
        {
            var v =new Variant<T1,T2>();
            v.label=1; v.value1 = v1;
            return v;
        }
        /// <summary>2個目のコンストラクタです。</summary>
        private T2 value2;
        public static Variant<T1,T2> C2(T2 v2)
        {
            var v =new Variant<T1,T2>();
            v.label=2; v.value2 = v2;
            return v;
        }
        /// <summary>パターンマッチをします。</summary>
        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2)
        {
            switch (this.label)
            {
                case 1: return C1(this.value1);
                default: return C2(this.value2);
            }
        }
    }
    /// <summary>コンストラクタが3個のバリアントです。</summary>
    public sealed class Variant<T1,T2,T3>
    {
        private Variant(){}
        private int label;

        /// <summary>1個目のコンストラクタです。</summary>
        private T1 value1;
        public static Variant<T1,T2,T3> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3>();
            v.label=1; v.value1 = v1;
            return v;
        }
        /// <summary>2個目のコンストラクタです。</summary>
        private T2 value2;
        public static Variant<T1,T2,T3> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3>();
            v.label=2; v.value2 = v2;
            return v;
        }
        /// <summary>3個目のコンストラクタです。</summary>
        private T3 value3;
        public static Variant<T1,T2,T3> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3>();
            v.label=3; v.value3 = v3;
            return v;
        }
        /// <summary>パターンマッチをします。</summary>
        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3)
        {
            switch (this.label)
            {
                case 1: return C1(this.value1);
                case 2: return C2(this.value2);
                default: return C3(this.value3);
            }
        }
    }
    /// <summary>コンストラクタが4個のバリアントです。</summary>
    public sealed class Variant<T1,T2,T3,T4>
    {
        private Variant(){}
        private int label;

        /// <summary>1個目のコンストラクタです。</summary>
        private T1 value1;
        public static Variant<T1,T2,T3,T4> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3,T4>();
            v.label=1; v.value1 = v1;
            return v;
        }
        /// <summary>2個目のコンストラクタです。</summary>
        private T2 value2;
        public static Variant<T1,T2,T3,T4> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3,T4>();
            v.label=2; v.value2 = v2;
            return v;
        }
        /// <summary>3個目のコンストラクタです。</summary>
        private T3 value3;
        public static Variant<T1,T2,T3,T4> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3,T4>();
            v.label=3; v.value3 = v3;
            return v;
        }
        /// <summary>4個目のコンストラクタです。</summary>
        private T4 value4;
        public static Variant<T1,T2,T3,T4> C4(T4 v4)
        {
            var v =new Variant<T1,T2,T3,T4>();
            v.label=4; v.value4 = v4;
            return v;
        }
        /// <summary>パターンマッチをします。</summary>
        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3,Func<T4, T> C4)
        {
            switch (this.label)
            {
                case 1: return C1(this.value1);
                case 2: return C2(this.value2);
                case 3: return C3(this.value3);
                default: return C4(this.value4);
            }
        }
    }
    /// <summary>コンストラクタが5個のバリアントです。</summary>
    public sealed class Variant<T1,T2,T3,T4,T5>
    {
        private Variant(){}
        private int label;

        /// <summary>1個目のコンストラクタです。</summary>
        private T1 value1;
        public static Variant<T1,T2,T3,T4,T5> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3,T4,T5>();
            v.label=1; v.value1 = v1;
            return v;
        }
        /// <summary>2個目のコンストラクタです。</summary>
        private T2 value2;
        public static Variant<T1,T2,T3,T4,T5> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3,T4,T5>();
            v.label=2; v.value2 = v2;
            return v;
        }
        /// <summary>3個目のコンストラクタです。</summary>
        private T3 value3;
        public static Variant<T1,T2,T3,T4,T5> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3,T4,T5>();
            v.label=3; v.value3 = v3;
            return v;
        }
        /// <summary>4個目のコンストラクタです。</summary>
        private T4 value4;
        public static Variant<T1,T2,T3,T4,T5> C4(T4 v4)
        {
            var v =new Variant<T1,T2,T3,T4,T5>();
            v.label=4; v.value4 = v4;
            return v;
        }
        /// <summary>5個目のコンストラクタです。</summary>
        private T5 value5;
        public static Variant<T1,T2,T3,T4,T5> C5(T5 v5)
        {
            var v =new Variant<T1,T2,T3,T4,T5>();
            v.label=5; v.value5 = v5;
            return v;
        }
        /// <summary>パターンマッチをします。</summary>
        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3,Func<T4, T> C4,Func<T5, T> C5)
        {
            switch (this.label)
            {
                case 1: return C1(this.value1);
                case 2: return C2(this.value2);
                case 3: return C3(this.value3);
                case 4: return C4(this.value4);
                default: return C5(this.value5);
            }
        }
    }
    /// <summary>コンストラクタが6個のバリアントです。</summary>
    public sealed class Variant<T1,T2,T3,T4,T5,T6>
    {
        private Variant(){}
        private int label;

        /// <summary>1個目のコンストラクタです。</summary>
        private T1 value1;
        public static Variant<T1,T2,T3,T4,T5,T6> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6>();
            v.label=1; v.value1 = v1;
            return v;
        }
        /// <summary>2個目のコンストラクタです。</summary>
        private T2 value2;
        public static Variant<T1,T2,T3,T4,T5,T6> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6>();
            v.label=2; v.value2 = v2;
            return v;
        }
        /// <summary>3個目のコンストラクタです。</summary>
        private T3 value3;
        public static Variant<T1,T2,T3,T4,T5,T6> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6>();
            v.label=3; v.value3 = v3;
            return v;
        }
        /// <summary>4個目のコンストラクタです。</summary>
        private T4 value4;
        public static Variant<T1,T2,T3,T4,T5,T6> C4(T4 v4)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6>();
            v.label=4; v.value4 = v4;
            return v;
        }
        /// <summary>5個目のコンストラクタです。</summary>
        private T5 value5;
        public static Variant<T1,T2,T3,T4,T5,T6> C5(T5 v5)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6>();
            v.label=5; v.value5 = v5;
            return v;
        }
        /// <summary>6個目のコンストラクタです。</summary>
        private T6 value6;
        public static Variant<T1,T2,T3,T4,T5,T6> C6(T6 v6)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6>();
            v.label=6; v.value6 = v6;
            return v;
        }
        /// <summary>パターンマッチをします。</summary>
        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3,Func<T4, T> C4,Func<T5, T> C5,Func<T6, T> C6)
        {
            switch (this.label)
            {
                case 1: return C1(this.value1);
                case 2: return C2(this.value2);
                case 3: return C3(this.value3);
                case 4: return C4(this.value4);
                case 5: return C5(this.value5);
                default: return C6(this.value6);
            }
        }
    }
    /// <summary>コンストラクタが7個のバリアントです。</summary>
    public sealed class Variant<T1,T2,T3,T4,T5,T6,T7>
    {
        private Variant(){}
        private int label;

        /// <summary>1個目のコンストラクタです。</summary>
        private T1 value1;
        public static Variant<T1,T2,T3,T4,T5,T6,T7> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7>();
            v.label=1; v.value1 = v1;
            return v;
        }
        /// <summary>2個目のコンストラクタです。</summary>
        private T2 value2;
        public static Variant<T1,T2,T3,T4,T5,T6,T7> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7>();
            v.label=2; v.value2 = v2;
            return v;
        }
        /// <summary>3個目のコンストラクタです。</summary>
        private T3 value3;
        public static Variant<T1,T2,T3,T4,T5,T6,T7> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7>();
            v.label=3; v.value3 = v3;
            return v;
        }
        /// <summary>4個目のコンストラクタです。</summary>
        private T4 value4;
        public static Variant<T1,T2,T3,T4,T5,T6,T7> C4(T4 v4)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7>();
            v.label=4; v.value4 = v4;
            return v;
        }
        /// <summary>5個目のコンストラクタです。</summary>
        private T5 value5;
        public static Variant<T1,T2,T3,T4,T5,T6,T7> C5(T5 v5)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7>();
            v.label=5; v.value5 = v5;
            return v;
        }
        /// <summary>6個目のコンストラクタです。</summary>
        private T6 value6;
        public static Variant<T1,T2,T3,T4,T5,T6,T7> C6(T6 v6)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7>();
            v.label=6; v.value6 = v6;
            return v;
        }
        /// <summary>7個目のコンストラクタです。</summary>
        private T7 value7;
        public static Variant<T1,T2,T3,T4,T5,T6,T7> C7(T7 v7)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7>();
            v.label=7; v.value7 = v7;
            return v;
        }
        /// <summary>パターンマッチをします。</summary>
        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3,Func<T4, T> C4,Func<T5, T> C5,Func<T6, T> C6,Func<T7, T> C7)
        {
            switch (this.label)
            {
                case 1: return C1(this.value1);
                case 2: return C2(this.value2);
                case 3: return C3(this.value3);
                case 4: return C4(this.value4);
                case 5: return C5(this.value5);
                case 6: return C6(this.value6);
                default: return C7(this.value7);
            }
        }
    }
    /// <summary>コンストラクタが8個のバリアントです。</summary>
    public sealed class Variant<T1,T2,T3,T4,T5,T6,T7,T8>
    {
        private Variant(){}
        private int label;

        /// <summary>1個目のコンストラクタです。</summary>
        private T1 value1;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8>();
            v.label=1; v.value1 = v1;
            return v;
        }
        /// <summary>2個目のコンストラクタです。</summary>
        private T2 value2;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8>();
            v.label=2; v.value2 = v2;
            return v;
        }
        /// <summary>3個目のコンストラクタです。</summary>
        private T3 value3;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8>();
            v.label=3; v.value3 = v3;
            return v;
        }
        /// <summary>4個目のコンストラクタです。</summary>
        private T4 value4;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8> C4(T4 v4)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8>();
            v.label=4; v.value4 = v4;
            return v;
        }
        /// <summary>5個目のコンストラクタです。</summary>
        private T5 value5;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8> C5(T5 v5)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8>();
            v.label=5; v.value5 = v5;
            return v;
        }
        /// <summary>6個目のコンストラクタです。</summary>
        private T6 value6;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8> C6(T6 v6)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8>();
            v.label=6; v.value6 = v6;
            return v;
        }
        /// <summary>7個目のコンストラクタです。</summary>
        private T7 value7;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8> C7(T7 v7)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8>();
            v.label=7; v.value7 = v7;
            return v;
        }
        /// <summary>8個目のコンストラクタです。</summary>
        private T8 value8;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8> C8(T8 v8)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8>();
            v.label=8; v.value8 = v8;
            return v;
        }
        /// <summary>パターンマッチをします。</summary>
        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3,Func<T4, T> C4,Func<T5, T> C5,Func<T6, T> C6,Func<T7, T> C7,Func<T8, T> C8)
        {
            switch (this.label)
            {
                case 1: return C1(this.value1);
                case 2: return C2(this.value2);
                case 3: return C3(this.value3);
                case 4: return C4(this.value4);
                case 5: return C5(this.value5);
                case 6: return C6(this.value6);
                case 7: return C7(this.value7);
                default: return C8(this.value8);
            }
        }
    }
    /// <summary>コンストラクタが9個のバリアントです。</summary>
    public sealed class Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9>
    {
        private Variant(){}
        private int label;

        /// <summary>1個目のコンストラクタです。</summary>
        private T1 value1;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9>();
            v.label=1; v.value1 = v1;
            return v;
        }
        /// <summary>2個目のコンストラクタです。</summary>
        private T2 value2;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9>();
            v.label=2; v.value2 = v2;
            return v;
        }
        /// <summary>3個目のコンストラクタです。</summary>
        private T3 value3;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9>();
            v.label=3; v.value3 = v3;
            return v;
        }
        /// <summary>4個目のコンストラクタです。</summary>
        private T4 value4;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9> C4(T4 v4)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9>();
            v.label=4; v.value4 = v4;
            return v;
        }
        /// <summary>5個目のコンストラクタです。</summary>
        private T5 value5;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9> C5(T5 v5)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9>();
            v.label=5; v.value5 = v5;
            return v;
        }
        /// <summary>6個目のコンストラクタです。</summary>
        private T6 value6;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9> C6(T6 v6)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9>();
            v.label=6; v.value6 = v6;
            return v;
        }
        /// <summary>7個目のコンストラクタです。</summary>
        private T7 value7;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9> C7(T7 v7)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9>();
            v.label=7; v.value7 = v7;
            return v;
        }
        /// <summary>8個目のコンストラクタです。</summary>
        private T8 value8;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9> C8(T8 v8)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9>();
            v.label=8; v.value8 = v8;
            return v;
        }
        /// <summary>9個目のコンストラクタです。</summary>
        private T9 value9;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9> C9(T9 v9)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9>();
            v.label=9; v.value9 = v9;
            return v;
        }
        /// <summary>パターンマッチをします。</summary>
        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3,Func<T4, T> C4,Func<T5, T> C5,Func<T6, T> C6,Func<T7, T> C7,Func<T8, T> C8,Func<T9, T> C9)
        {
            switch (this.label)
            {
                case 1: return C1(this.value1);
                case 2: return C2(this.value2);
                case 3: return C3(this.value3);
                case 4: return C4(this.value4);
                case 5: return C5(this.value5);
                case 6: return C6(this.value6);
                case 7: return C7(this.value7);
                case 8: return C8(this.value8);
                default: return C9(this.value9);
            }
        }
    }
    /// <summary>コンストラクタが10個のバリアントです。</summary>
    public sealed class Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>
    {
        private Variant(){}
        private int label;

        /// <summary>1個目のコンストラクタです。</summary>
        private T1 value1;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
            v.label=1; v.value1 = v1;
            return v;
        }
        /// <summary>2個目のコンストラクタです。</summary>
        private T2 value2;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
            v.label=2; v.value2 = v2;
            return v;
        }
        /// <summary>3個目のコンストラクタです。</summary>
        private T3 value3;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
            v.label=3; v.value3 = v3;
            return v;
        }
        /// <summary>4個目のコンストラクタです。</summary>
        private T4 value4;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> C4(T4 v4)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
            v.label=4; v.value4 = v4;
            return v;
        }
        /// <summary>5個目のコンストラクタです。</summary>
        private T5 value5;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> C5(T5 v5)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
            v.label=5; v.value5 = v5;
            return v;
        }
        /// <summary>6個目のコンストラクタです。</summary>
        private T6 value6;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> C6(T6 v6)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
            v.label=6; v.value6 = v6;
            return v;
        }
        /// <summary>7個目のコンストラクタです。</summary>
        private T7 value7;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> C7(T7 v7)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
            v.label=7; v.value7 = v7;
            return v;
        }
        /// <summary>8個目のコンストラクタです。</summary>
        private T8 value8;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> C8(T8 v8)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
            v.label=8; v.value8 = v8;
            return v;
        }
        /// <summary>9個目のコンストラクタです。</summary>
        private T9 value9;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> C9(T9 v9)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
            v.label=9; v.value9 = v9;
            return v;
        }
        /// <summary>10個目のコンストラクタです。</summary>
        private T10 value10;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10> C10(T10 v10)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10>();
            v.label=10; v.value10 = v10;
            return v;
        }
        /// <summary>パターンマッチをします。</summary>
        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3,Func<T4, T> C4,Func<T5, T> C5,Func<T6, T> C6,Func<T7, T> C7,Func<T8, T> C8,Func<T9, T> C9,Func<T10, T> C10)
        {
            switch (this.label)
            {
                case 1: return C1(this.value1);
                case 2: return C2(this.value2);
                case 3: return C3(this.value3);
                case 4: return C4(this.value4);
                case 5: return C5(this.value5);
                case 6: return C6(this.value6);
                case 7: return C7(this.value7);
                case 8: return C8(this.value8);
                case 9: return C9(this.value9);
                default: return C10(this.value10);
            }
        }
    }
    /// <summary>コンストラクタが11個のバリアントです。</summary>
    public sealed class Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>
    {
        private Variant(){}
        private int label;

        /// <summary>1個目のコンストラクタです。</summary>
        private T1 value1;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
            v.label=1; v.value1 = v1;
            return v;
        }
        /// <summary>2個目のコンストラクタです。</summary>
        private T2 value2;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
            v.label=2; v.value2 = v2;
            return v;
        }
        /// <summary>3個目のコンストラクタです。</summary>
        private T3 value3;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
            v.label=3; v.value3 = v3;
            return v;
        }
        /// <summary>4個目のコンストラクタです。</summary>
        private T4 value4;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> C4(T4 v4)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
            v.label=4; v.value4 = v4;
            return v;
        }
        /// <summary>5個目のコンストラクタです。</summary>
        private T5 value5;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> C5(T5 v5)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
            v.label=5; v.value5 = v5;
            return v;
        }
        /// <summary>6個目のコンストラクタです。</summary>
        private T6 value6;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> C6(T6 v6)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
            v.label=6; v.value6 = v6;
            return v;
        }
        /// <summary>7個目のコンストラクタです。</summary>
        private T7 value7;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> C7(T7 v7)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
            v.label=7; v.value7 = v7;
            return v;
        }
        /// <summary>8個目のコンストラクタです。</summary>
        private T8 value8;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> C8(T8 v8)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
            v.label=8; v.value8 = v8;
            return v;
        }
        /// <summary>9個目のコンストラクタです。</summary>
        private T9 value9;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> C9(T9 v9)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
            v.label=9; v.value9 = v9;
            return v;
        }
        /// <summary>10個目のコンストラクタです。</summary>
        private T10 value10;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> C10(T10 v10)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
            v.label=10; v.value10 = v10;
            return v;
        }
        /// <summary>11個目のコンストラクタです。</summary>
        private T11 value11;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11> C11(T11 v11)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11>();
            v.label=11; v.value11 = v11;
            return v;
        }
        /// <summary>パターンマッチをします。</summary>
        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3,Func<T4, T> C4,Func<T5, T> C5,Func<T6, T> C6,Func<T7, T> C7,Func<T8, T> C8,Func<T9, T> C9,Func<T10, T> C10,Func<T11, T> C11)
        {
            switch (this.label)
            {
                case 1: return C1(this.value1);
                case 2: return C2(this.value2);
                case 3: return C3(this.value3);
                case 4: return C4(this.value4);
                case 5: return C5(this.value5);
                case 6: return C6(this.value6);
                case 7: return C7(this.value7);
                case 8: return C8(this.value8);
                case 9: return C9(this.value9);
                case 10: return C10(this.value10);
                default: return C11(this.value11);
            }
        }
    }
    /// <summary>コンストラクタが12個のバリアントです。</summary>
    public sealed class Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>
    {
        private Variant(){}
        private int label;

        /// <summary>1個目のコンストラクタです。</summary>
        private T1 value1;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
            v.label=1; v.value1 = v1;
            return v;
        }
        /// <summary>2個目のコンストラクタです。</summary>
        private T2 value2;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
            v.label=2; v.value2 = v2;
            return v;
        }
        /// <summary>3個目のコンストラクタです。</summary>
        private T3 value3;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
            v.label=3; v.value3 = v3;
            return v;
        }
        /// <summary>4個目のコンストラクタです。</summary>
        private T4 value4;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> C4(T4 v4)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
            v.label=4; v.value4 = v4;
            return v;
        }
        /// <summary>5個目のコンストラクタです。</summary>
        private T5 value5;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> C5(T5 v5)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
            v.label=5; v.value5 = v5;
            return v;
        }
        /// <summary>6個目のコンストラクタです。</summary>
        private T6 value6;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> C6(T6 v6)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
            v.label=6; v.value6 = v6;
            return v;
        }
        /// <summary>7個目のコンストラクタです。</summary>
        private T7 value7;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> C7(T7 v7)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
            v.label=7; v.value7 = v7;
            return v;
        }
        /// <summary>8個目のコンストラクタです。</summary>
        private T8 value8;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> C8(T8 v8)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
            v.label=8; v.value8 = v8;
            return v;
        }
        /// <summary>9個目のコンストラクタです。</summary>
        private T9 value9;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> C9(T9 v9)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
            v.label=9; v.value9 = v9;
            return v;
        }
        /// <summary>10個目のコンストラクタです。</summary>
        private T10 value10;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> C10(T10 v10)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
            v.label=10; v.value10 = v10;
            return v;
        }
        /// <summary>11個目のコンストラクタです。</summary>
        private T11 value11;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> C11(T11 v11)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
            v.label=11; v.value11 = v11;
            return v;
        }
        /// <summary>12個目のコンストラクタです。</summary>
        private T12 value12;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12> C12(T12 v12)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12>();
            v.label=12; v.value12 = v12;
            return v;
        }
        /// <summary>パターンマッチをします。</summary>
        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3,Func<T4, T> C4,Func<T5, T> C5,Func<T6, T> C6,Func<T7, T> C7,Func<T8, T> C8,Func<T9, T> C9,Func<T10, T> C10,Func<T11, T> C11,Func<T12, T> C12)
        {
            switch (this.label)
            {
                case 1: return C1(this.value1);
                case 2: return C2(this.value2);
                case 3: return C3(this.value3);
                case 4: return C4(this.value4);
                case 5: return C5(this.value5);
                case 6: return C6(this.value6);
                case 7: return C7(this.value7);
                case 8: return C8(this.value8);
                case 9: return C9(this.value9);
                case 10: return C10(this.value10);
                case 11: return C11(this.value11);
                default: return C12(this.value12);
            }
        }
    }
    /// <summary>コンストラクタが13個のバリアントです。</summary>
    public sealed class Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>
    {
        private Variant(){}
        private int label;

        /// <summary>1個目のコンストラクタです。</summary>
        private T1 value1;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
            v.label=1; v.value1 = v1;
            return v;
        }
        /// <summary>2個目のコンストラクタです。</summary>
        private T2 value2;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
            v.label=2; v.value2 = v2;
            return v;
        }
        /// <summary>3個目のコンストラクタです。</summary>
        private T3 value3;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
            v.label=3; v.value3 = v3;
            return v;
        }
        /// <summary>4個目のコンストラクタです。</summary>
        private T4 value4;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> C4(T4 v4)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
            v.label=4; v.value4 = v4;
            return v;
        }
        /// <summary>5個目のコンストラクタです。</summary>
        private T5 value5;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> C5(T5 v5)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
            v.label=5; v.value5 = v5;
            return v;
        }
        /// <summary>6個目のコンストラクタです。</summary>
        private T6 value6;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> C6(T6 v6)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
            v.label=6; v.value6 = v6;
            return v;
        }
        /// <summary>7個目のコンストラクタです。</summary>
        private T7 value7;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> C7(T7 v7)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
            v.label=7; v.value7 = v7;
            return v;
        }
        /// <summary>8個目のコンストラクタです。</summary>
        private T8 value8;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> C8(T8 v8)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
            v.label=8; v.value8 = v8;
            return v;
        }
        /// <summary>9個目のコンストラクタです。</summary>
        private T9 value9;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> C9(T9 v9)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
            v.label=9; v.value9 = v9;
            return v;
        }
        /// <summary>10個目のコンストラクタです。</summary>
        private T10 value10;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> C10(T10 v10)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
            v.label=10; v.value10 = v10;
            return v;
        }
        /// <summary>11個目のコンストラクタです。</summary>
        private T11 value11;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> C11(T11 v11)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
            v.label=11; v.value11 = v11;
            return v;
        }
        /// <summary>12個目のコンストラクタです。</summary>
        private T12 value12;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> C12(T12 v12)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
            v.label=12; v.value12 = v12;
            return v;
        }
        /// <summary>13個目のコンストラクタです。</summary>
        private T13 value13;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13> C13(T13 v13)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13>();
            v.label=13; v.value13 = v13;
            return v;
        }
        /// <summary>パターンマッチをします。</summary>
        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3,Func<T4, T> C4,Func<T5, T> C5,Func<T6, T> C6,Func<T7, T> C7,Func<T8, T> C8,Func<T9, T> C9,Func<T10, T> C10,Func<T11, T> C11,Func<T12, T> C12,Func<T13, T> C13)
        {
            switch (this.label)
            {
                case 1: return C1(this.value1);
                case 2: return C2(this.value2);
                case 3: return C3(this.value3);
                case 4: return C4(this.value4);
                case 5: return C5(this.value5);
                case 6: return C6(this.value6);
                case 7: return C7(this.value7);
                case 8: return C8(this.value8);
                case 9: return C9(this.value9);
                case 10: return C10(this.value10);
                case 11: return C11(this.value11);
                case 12: return C12(this.value12);
                default: return C13(this.value13);
            }
        }
    }
    /// <summary>コンストラクタが14個のバリアントです。</summary>
    public sealed class Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>
    {
        private Variant(){}
        private int label;

        /// <summary>1個目のコンストラクタです。</summary>
        private T1 value1;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
            v.label=1; v.value1 = v1;
            return v;
        }
        /// <summary>2個目のコンストラクタです。</summary>
        private T2 value2;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
            v.label=2; v.value2 = v2;
            return v;
        }
        /// <summary>3個目のコンストラクタです。</summary>
        private T3 value3;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
            v.label=3; v.value3 = v3;
            return v;
        }
        /// <summary>4個目のコンストラクタです。</summary>
        private T4 value4;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> C4(T4 v4)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
            v.label=4; v.value4 = v4;
            return v;
        }
        /// <summary>5個目のコンストラクタです。</summary>
        private T5 value5;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> C5(T5 v5)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
            v.label=5; v.value5 = v5;
            return v;
        }
        /// <summary>6個目のコンストラクタです。</summary>
        private T6 value6;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> C6(T6 v6)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
            v.label=6; v.value6 = v6;
            return v;
        }
        /// <summary>7個目のコンストラクタです。</summary>
        private T7 value7;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> C7(T7 v7)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
            v.label=7; v.value7 = v7;
            return v;
        }
        /// <summary>8個目のコンストラクタです。</summary>
        private T8 value8;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> C8(T8 v8)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
            v.label=8; v.value8 = v8;
            return v;
        }
        /// <summary>9個目のコンストラクタです。</summary>
        private T9 value9;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> C9(T9 v9)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
            v.label=9; v.value9 = v9;
            return v;
        }
        /// <summary>10個目のコンストラクタです。</summary>
        private T10 value10;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> C10(T10 v10)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
            v.label=10; v.value10 = v10;
            return v;
        }
        /// <summary>11個目のコンストラクタです。</summary>
        private T11 value11;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> C11(T11 v11)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
            v.label=11; v.value11 = v11;
            return v;
        }
        /// <summary>12個目のコンストラクタです。</summary>
        private T12 value12;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> C12(T12 v12)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
            v.label=12; v.value12 = v12;
            return v;
        }
        /// <summary>13個目のコンストラクタです。</summary>
        private T13 value13;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> C13(T13 v13)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
            v.label=13; v.value13 = v13;
            return v;
        }
        /// <summary>14個目のコンストラクタです。</summary>
        private T14 value14;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14> C14(T14 v14)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14>();
            v.label=14; v.value14 = v14;
            return v;
        }
        /// <summary>パターンマッチをします。</summary>
        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3,Func<T4, T> C4,Func<T5, T> C5,Func<T6, T> C6,Func<T7, T> C7,Func<T8, T> C8,Func<T9, T> C9,Func<T10, T> C10,Func<T11, T> C11,Func<T12, T> C12,Func<T13, T> C13,Func<T14, T> C14)
        {
            switch (this.label)
            {
                case 1: return C1(this.value1);
                case 2: return C2(this.value2);
                case 3: return C3(this.value3);
                case 4: return C4(this.value4);
                case 5: return C5(this.value5);
                case 6: return C6(this.value6);
                case 7: return C7(this.value7);
                case 8: return C8(this.value8);
                case 9: return C9(this.value9);
                case 10: return C10(this.value10);
                case 11: return C11(this.value11);
                case 12: return C12(this.value12);
                case 13: return C13(this.value13);
                default: return C14(this.value14);
            }
        }
    }
    /// <summary>コンストラクタが15個のバリアントです。</summary>
    public sealed class Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>
    {
        private Variant(){}
        private int label;

        /// <summary>1個目のコンストラクタです。</summary>
        private T1 value1;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
            v.label=1; v.value1 = v1;
            return v;
        }
        /// <summary>2個目のコンストラクタです。</summary>
        private T2 value2;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
            v.label=2; v.value2 = v2;
            return v;
        }
        /// <summary>3個目のコンストラクタです。</summary>
        private T3 value3;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
            v.label=3; v.value3 = v3;
            return v;
        }
        /// <summary>4個目のコンストラクタです。</summary>
        private T4 value4;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> C4(T4 v4)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
            v.label=4; v.value4 = v4;
            return v;
        }
        /// <summary>5個目のコンストラクタです。</summary>
        private T5 value5;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> C5(T5 v5)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
            v.label=5; v.value5 = v5;
            return v;
        }
        /// <summary>6個目のコンストラクタです。</summary>
        private T6 value6;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> C6(T6 v6)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
            v.label=6; v.value6 = v6;
            return v;
        }
        /// <summary>7個目のコンストラクタです。</summary>
        private T7 value7;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> C7(T7 v7)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
            v.label=7; v.value7 = v7;
            return v;
        }
        /// <summary>8個目のコンストラクタです。</summary>
        private T8 value8;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> C8(T8 v8)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
            v.label=8; v.value8 = v8;
            return v;
        }
        /// <summary>9個目のコンストラクタです。</summary>
        private T9 value9;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> C9(T9 v9)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
            v.label=9; v.value9 = v9;
            return v;
        }
        /// <summary>10個目のコンストラクタです。</summary>
        private T10 value10;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> C10(T10 v10)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
            v.label=10; v.value10 = v10;
            return v;
        }
        /// <summary>11個目のコンストラクタです。</summary>
        private T11 value11;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> C11(T11 v11)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
            v.label=11; v.value11 = v11;
            return v;
        }
        /// <summary>12個目のコンストラクタです。</summary>
        private T12 value12;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> C12(T12 v12)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
            v.label=12; v.value12 = v12;
            return v;
        }
        /// <summary>13個目のコンストラクタです。</summary>
        private T13 value13;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> C13(T13 v13)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
            v.label=13; v.value13 = v13;
            return v;
        }
        /// <summary>14個目のコンストラクタです。</summary>
        private T14 value14;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> C14(T14 v14)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
            v.label=14; v.value14 = v14;
            return v;
        }
        /// <summary>15個目のコンストラクタです。</summary>
        private T15 value15;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15> C15(T15 v15)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15>();
            v.label=15; v.value15 = v15;
            return v;
        }
        /// <summary>パターンマッチをします。</summary>
        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3,Func<T4, T> C4,Func<T5, T> C5,Func<T6, T> C6,Func<T7, T> C7,Func<T8, T> C8,Func<T9, T> C9,Func<T10, T> C10,Func<T11, T> C11,Func<T12, T> C12,Func<T13, T> C13,Func<T14, T> C14,Func<T15, T> C15)
        {
            switch (this.label)
            {
                case 1: return C1(this.value1);
                case 2: return C2(this.value2);
                case 3: return C3(this.value3);
                case 4: return C4(this.value4);
                case 5: return C5(this.value5);
                case 6: return C6(this.value6);
                case 7: return C7(this.value7);
                case 8: return C8(this.value8);
                case 9: return C9(this.value9);
                case 10: return C10(this.value10);
                case 11: return C11(this.value11);
                case 12: return C12(this.value12);
                case 13: return C13(this.value13);
                case 14: return C14(this.value14);
                default: return C15(this.value15);
            }
        }
    }
    /// <summary>コンストラクタが16個のバリアントです。</summary>
    public sealed class Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>
    {
        private Variant(){}
        private int label;

        /// <summary>1個目のコンストラクタです。</summary>
        private T1 value1;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> C1(T1 v1)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
            v.label=1; v.value1 = v1;
            return v;
        }
        /// <summary>2個目のコンストラクタです。</summary>
        private T2 value2;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> C2(T2 v2)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
            v.label=2; v.value2 = v2;
            return v;
        }
        /// <summary>3個目のコンストラクタです。</summary>
        private T3 value3;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> C3(T3 v3)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
            v.label=3; v.value3 = v3;
            return v;
        }
        /// <summary>4個目のコンストラクタです。</summary>
        private T4 value4;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> C4(T4 v4)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
            v.label=4; v.value4 = v4;
            return v;
        }
        /// <summary>5個目のコンストラクタです。</summary>
        private T5 value5;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> C5(T5 v5)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
            v.label=5; v.value5 = v5;
            return v;
        }
        /// <summary>6個目のコンストラクタです。</summary>
        private T6 value6;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> C6(T6 v6)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
            v.label=6; v.value6 = v6;
            return v;
        }
        /// <summary>7個目のコンストラクタです。</summary>
        private T7 value7;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> C7(T7 v7)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
            v.label=7; v.value7 = v7;
            return v;
        }
        /// <summary>8個目のコンストラクタです。</summary>
        private T8 value8;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> C8(T8 v8)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
            v.label=8; v.value8 = v8;
            return v;
        }
        /// <summary>9個目のコンストラクタです。</summary>
        private T9 value9;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> C9(T9 v9)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
            v.label=9; v.value9 = v9;
            return v;
        }
        /// <summary>10個目のコンストラクタです。</summary>
        private T10 value10;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> C10(T10 v10)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
            v.label=10; v.value10 = v10;
            return v;
        }
        /// <summary>11個目のコンストラクタです。</summary>
        private T11 value11;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> C11(T11 v11)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
            v.label=11; v.value11 = v11;
            return v;
        }
        /// <summary>12個目のコンストラクタです。</summary>
        private T12 value12;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> C12(T12 v12)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
            v.label=12; v.value12 = v12;
            return v;
        }
        /// <summary>13個目のコンストラクタです。</summary>
        private T13 value13;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> C13(T13 v13)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
            v.label=13; v.value13 = v13;
            return v;
        }
        /// <summary>14個目のコンストラクタです。</summary>
        private T14 value14;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> C14(T14 v14)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
            v.label=14; v.value14 = v14;
            return v;
        }
        /// <summary>15個目のコンストラクタです。</summary>
        private T15 value15;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> C15(T15 v15)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
            v.label=15; v.value15 = v15;
            return v;
        }
        /// <summary>16個目のコンストラクタです。</summary>
        private T16 value16;
        public static Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16> C16(T16 v16)
        {
            var v =new Variant<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16>();
            v.label=16; v.value16 = v16;
            return v;
        }
        /// <summary>パターンマッチをします。</summary>
        public T Match<T>(Func<T1, T> C1,Func<T2, T> C2,Func<T3, T> C3,Func<T4, T> C4,Func<T5, T> C5,Func<T6, T> C6,Func<T7, T> C7,Func<T8, T> C8,Func<T9, T> C9,Func<T10, T> C10,Func<T11, T> C11,Func<T12, T> C12,Func<T13, T> C13,Func<T14, T> C14,Func<T15, T> C15,Func<T16, T> C16)
        {
            switch (this.label)
            {
                case 1: return C1(this.value1);
                case 2: return C2(this.value2);
                case 3: return C3(this.value3);
                case 4: return C4(this.value4);
                case 5: return C5(this.value5);
                case 6: return C6(this.value6);
                case 7: return C7(this.value7);
                case 8: return C8(this.value8);
                case 9: return C9(this.value9);
                case 10: return C10(this.value10);
                case 11: return C11(this.value11);
                case 12: return C12(this.value12);
                case 13: return C13(this.value13);
                case 14: return C14(this.value14);
                case 15: return C15(this.value15);
                default: return C16(this.value16);
            }
        }
    }
}