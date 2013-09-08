using System;

namespace Extensions
{
    public static class Func
    {
        /// <summary>2引数関数をカリー化します。</summary>
        public static Func<T1, Func<T2, TResult>> Curry<T1,T2, TResult>(this Func<T1,T2, TResult> func)
        {
            return v1 => v2 => func(v1,v2);
        }
        /// <summary>カリー化された2引数関数をアンカリー化します。</summary>
        public static Func<T1,T2, TResult> UnCurry<T1,T2, TResult>(this Func<T1, Func<T2, TResult>> func)
        {
            return (v1,v2) => func(v1)(v2);
        }

        /// <summary>3引数関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, TResult>>> Curry<T1,T2,T3, TResult>(this Func<T1,T2,T3, TResult> func)
        {
            return v1 => v2 => v3 => func(v1,v2,v3);
        }
        /// <summary>カリー化された3引数関数をアンカリー化します。</summary>
        public static Func<T1,T2,T3, TResult> UnCurry<T1,T2,T3, TResult>(this Func<T1, Func<T2, Func<T3, TResult>>> func)
        {
            return (v1,v2,v3) => func(v1)(v2)(v3);
        }

        /// <summary>4引数関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>> Curry<T1,T2,T3,T4, TResult>(this Func<T1,T2,T3,T4, TResult> func)
        {
            return v1 => v2 => v3 => v4 => func(v1,v2,v3,v4);
        }
        /// <summary>カリー化された4引数関数をアンカリー化します。</summary>
        public static Func<T1,T2,T3,T4, TResult> UnCurry<T1,T2,T3,T4, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>> func)
        {
            return (v1,v2,v3,v4) => func(v1)(v2)(v3)(v4);
        }

        /// <summary>5引数関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>> Curry<T1,T2,T3,T4,T5, TResult>(this Func<T1,T2,T3,T4,T5, TResult> func)
        {
            return v1 => v2 => v3 => v4 => v5 => func(v1,v2,v3,v4,v5);
        }
        /// <summary>カリー化された5引数関数をアンカリー化します。</summary>
        public static Func<T1,T2,T3,T4,T5, TResult> UnCurry<T1,T2,T3,T4,T5, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>> func)
        {
            return (v1,v2,v3,v4,v5) => func(v1)(v2)(v3)(v4)(v5);
        }

        /// <summary>6引数関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>> Curry<T1,T2,T3,T4,T5,T6, TResult>(this Func<T1,T2,T3,T4,T5,T6, TResult> func)
        {
            return v1 => v2 => v3 => v4 => v5 => v6 => func(v1,v2,v3,v4,v5,v6);
        }
        /// <summary>カリー化された6引数関数をアンカリー化します。</summary>
        public static Func<T1,T2,T3,T4,T5,T6, TResult> UnCurry<T1,T2,T3,T4,T5,T6, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>> func)
        {
            return (v1,v2,v3,v4,v5,v6) => func(v1)(v2)(v3)(v4)(v5)(v6);
        }

        /// <summary>7引数関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>> Curry<T1,T2,T3,T4,T5,T6,T7, TResult>(this Func<T1,T2,T3,T4,T5,T6,T7, TResult> func)
        {
            return v1 => v2 => v3 => v4 => v5 => v6 => v7 => func(v1,v2,v3,v4,v5,v6,v7);
        }
        /// <summary>カリー化された7引数関数をアンカリー化します。</summary>
        public static Func<T1,T2,T3,T4,T5,T6,T7, TResult> UnCurry<T1,T2,T3,T4,T5,T6,T7, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>> func)
        {
            return (v1,v2,v3,v4,v5,v6,v7) => func(v1)(v2)(v3)(v4)(v5)(v6)(v7);
        }

        /// <summary>8引数関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>> Curry<T1,T2,T3,T4,T5,T6,T7,T8, TResult>(this Func<T1,T2,T3,T4,T5,T6,T7,T8, TResult> func)
        {
            return v1 => v2 => v3 => v4 => v5 => v6 => v7 => v8 => func(v1,v2,v3,v4,v5,v6,v7,v8);
        }
        /// <summary>カリー化された8引数関数をアンカリー化します。</summary>
        public static Func<T1,T2,T3,T4,T5,T6,T7,T8, TResult> UnCurry<T1,T2,T3,T4,T5,T6,T7,T8, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>> func)
        {
            return (v1,v2,v3,v4,v5,v6,v7,v8) => func(v1)(v2)(v3)(v4)(v5)(v6)(v7)(v8);
        }

        /// <summary>9引数関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>> Curry<T1,T2,T3,T4,T5,T6,T7,T8,T9, TResult>(this Func<T1,T2,T3,T4,T5,T6,T7,T8,T9, TResult> func)
        {
            return v1 => v2 => v3 => v4 => v5 => v6 => v7 => v8 => v9 => func(v1,v2,v3,v4,v5,v6,v7,v8,v9);
        }
        /// <summary>カリー化された9引数関数をアンカリー化します。</summary>
        public static Func<T1,T2,T3,T4,T5,T6,T7,T8,T9, TResult> UnCurry<T1,T2,T3,T4,T5,T6,T7,T8,T9, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>> func)
        {
            return (v1,v2,v3,v4,v5,v6,v7,v8,v9) => func(v1)(v2)(v3)(v4)(v5)(v6)(v7)(v8)(v9);
        }

        /// <summary>10引数関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>> Curry<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, TResult>(this Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, TResult> func)
        {
            return v1 => v2 => v3 => v4 => v5 => v6 => v7 => v8 => v9 => v10 => func(v1,v2,v3,v4,v5,v6,v7,v8,v9,v10);
        }
        /// <summary>カリー化された10引数関数をアンカリー化します。</summary>
        public static Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, TResult> UnCurry<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>> func)
        {
            return (v1,v2,v3,v4,v5,v6,v7,v8,v9,v10) => func(v1)(v2)(v3)(v4)(v5)(v6)(v7)(v8)(v9)(v10);
        }

        /// <summary>11引数関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>> Curry<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, TResult>(this Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, TResult> func)
        {
            return v1 => v2 => v3 => v4 => v5 => v6 => v7 => v8 => v9 => v10 => v11 => func(v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11);
        }
        /// <summary>カリー化された11引数関数をアンカリー化します。</summary>
        public static Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, TResult> UnCurry<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>> func)
        {
            return (v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11) => func(v1)(v2)(v3)(v4)(v5)(v6)(v7)(v8)(v9)(v10)(v11);
        }

        /// <summary>12引数関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>> Curry<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, TResult>(this Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, TResult> func)
        {
            return v1 => v2 => v3 => v4 => v5 => v6 => v7 => v8 => v9 => v10 => v11 => v12 => func(v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12);
        }
        /// <summary>カリー化された12引数関数をアンカリー化します。</summary>
        public static Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, TResult> UnCurry<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>> func)
        {
            return (v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12) => func(v1)(v2)(v3)(v4)(v5)(v6)(v7)(v8)(v9)(v10)(v11)(v12);
        }

        /// <summary>13引数関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>> Curry<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, TResult>(this Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, TResult> func)
        {
            return v1 => v2 => v3 => v4 => v5 => v6 => v7 => v8 => v9 => v10 => v11 => v12 => v13 => func(v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12,v13);
        }
        /// <summary>カリー化された13引数関数をアンカリー化します。</summary>
        public static Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, TResult> UnCurry<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>> func)
        {
            return (v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12,v13) => func(v1)(v2)(v3)(v4)(v5)(v6)(v7)(v8)(v9)(v10)(v11)(v12)(v13);
        }

        /// <summary>14引数関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>> Curry<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, TResult>(this Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, TResult> func)
        {
            return v1 => v2 => v3 => v4 => v5 => v6 => v7 => v8 => v9 => v10 => v11 => v12 => v13 => v14 => func(v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12,v13,v14);
        }
        /// <summary>カリー化された14引数関数をアンカリー化します。</summary>
        public static Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, TResult> UnCurry<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>> func)
        {
            return (v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12,v13,v14) => func(v1)(v2)(v3)(v4)(v5)(v6)(v7)(v8)(v9)(v10)(v11)(v12)(v13)(v14);
        }

        /// <summary>15引数関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>> Curry<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, TResult>(this Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, TResult> func)
        {
            return v1 => v2 => v3 => v4 => v5 => v6 => v7 => v8 => v9 => v10 => v11 => v12 => v13 => v14 => v15 => func(v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12,v13,v14,v15);
        }
        /// <summary>カリー化された15引数関数をアンカリー化します。</summary>
        public static Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, TResult> UnCurry<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>> func)
        {
            return (v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12,v13,v14,v15) => func(v1)(v2)(v3)(v4)(v5)(v6)(v7)(v8)(v9)(v10)(v11)(v12)(v13)(v14)(v15);
        }

        /// <summary>16引数関数をカリー化します。</summary>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>>>>>>>>>> Curry<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, TResult>(this Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, TResult> func)
        {
            return v1 => v2 => v3 => v4 => v5 => v6 => v7 => v8 => v9 => v10 => v11 => v12 => v13 => v14 => v15 => v16 => func(v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12,v13,v14,v15,v16);
        }
        /// <summary>カリー化された16引数関数をアンカリー化します。</summary>
        public static Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, TResult> UnCurry<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>>>>>>>>>> func)
        {
            return (v1,v2,v3,v4,v5,v6,v7,v8,v9,v10,v11,v12,v13,v14,v15,v16) => func(v1)(v2)(v3)(v4)(v5)(v6)(v7)(v8)(v9)(v10)(v11)(v12)(v13)(v14)(v15)(v16);
        }


        /// <summary>0引数関数をUnitを取る関数にします。</summary>
        public static Func<Unit, TResult> Tuplize<TResult>(this Func<TResult> func)
        {
            return _ => func();
        }
        /// <summary>Unitを取る関数を0引数関数にします。</summary>
        public static Func<TResult> UnTuplize<TResult>(this Func<Unit, TResult> func)
        {
            return () => func(Unit._);
        }

        /// <summary>1引数関数を1要素のタプルを取る関数にします。</summary>
        public static Func<Tuple<T1>, TResult> Tuplize<T1, TResult>(this Func<T1, TResult> func)
        {
            return tuple => func(tuple.Item1);
        }
        /// <summary>1要素のタプルを取る関数を1引数関数にします。</summary>
        public static Func<T1, TResult> UnTuplize<T1, TResult>(this Func<Tuple<T1>, TResult> func)
        {
            return (v1) => func(Tuple.Create(v1));
        }
        /// <summary>2引数関数を2要素のタプルを取る関数にします。</summary>
        public static Func<Tuple<T1,T2>, TResult> Tuplize<T1,T2, TResult>(this Func<T1,T2, TResult> func)
        {
            return tuple => func(tuple.Item1,tuple.Item2);
        }
        /// <summary>2要素のタプルを取る関数を2引数関数にします。</summary>
        public static Func<T1,T2, TResult> UnTuplize<T1,T2, TResult>(this Func<Tuple<T1,T2>, TResult> func)
        {
            return (v1,v2) => func(Tuple.Create(v1,v2));
        }
        /// <summary>3引数関数を3要素のタプルを取る関数にします。</summary>
        public static Func<Tuple<T1,T2,T3>, TResult> Tuplize<T1,T2,T3, TResult>(this Func<T1,T2,T3, TResult> func)
        {
            return tuple => func(tuple.Item1,tuple.Item2,tuple.Item3);
        }
        /// <summary>3要素のタプルを取る関数を3引数関数にします。</summary>
        public static Func<T1,T2,T3, TResult> UnTuplize<T1,T2,T3, TResult>(this Func<Tuple<T1,T2,T3>, TResult> func)
        {
            return (v1,v2,v3) => func(Tuple.Create(v1,v2,v3));
        }
        /// <summary>4引数関数を4要素のタプルを取る関数にします。</summary>
        public static Func<Tuple<T1,T2,T3,T4>, TResult> Tuplize<T1,T2,T3,T4, TResult>(this Func<T1,T2,T3,T4, TResult> func)
        {
            return tuple => func(tuple.Item1,tuple.Item2,tuple.Item3,tuple.Item4);
        }
        /// <summary>4要素のタプルを取る関数を4引数関数にします。</summary>
        public static Func<T1,T2,T3,T4, TResult> UnTuplize<T1,T2,T3,T4, TResult>(this Func<Tuple<T1,T2,T3,T4>, TResult> func)
        {
            return (v1,v2,v3,v4) => func(Tuple.Create(v1,v2,v3,v4));
        }
        /// <summary>5引数関数を5要素のタプルを取る関数にします。</summary>
        public static Func<Tuple<T1,T2,T3,T4,T5>, TResult> Tuplize<T1,T2,T3,T4,T5, TResult>(this Func<T1,T2,T3,T4,T5, TResult> func)
        {
            return tuple => func(tuple.Item1,tuple.Item2,tuple.Item3,tuple.Item4,tuple.Item5);
        }
        /// <summary>5要素のタプルを取る関数を5引数関数にします。</summary>
        public static Func<T1,T2,T3,T4,T5, TResult> UnTuplize<T1,T2,T3,T4,T5, TResult>(this Func<Tuple<T1,T2,T3,T4,T5>, TResult> func)
        {
            return (v1,v2,v3,v4,v5) => func(Tuple.Create(v1,v2,v3,v4,v5));
        }
        /// <summary>6引数関数を6要素のタプルを取る関数にします。</summary>
        public static Func<Tuple<T1,T2,T3,T4,T5,T6>, TResult> Tuplize<T1,T2,T3,T4,T5,T6, TResult>(this Func<T1,T2,T3,T4,T5,T6, TResult> func)
        {
            return tuple => func(tuple.Item1,tuple.Item2,tuple.Item3,tuple.Item4,tuple.Item5,tuple.Item6);
        }
        /// <summary>6要素のタプルを取る関数を6引数関数にします。</summary>
        public static Func<T1,T2,T3,T4,T5,T6, TResult> UnTuplize<T1,T2,T3,T4,T5,T6, TResult>(this Func<Tuple<T1,T2,T3,T4,T5,T6>, TResult> func)
        {
            return (v1,v2,v3,v4,v5,v6) => func(Tuple.Create(v1,v2,v3,v4,v5,v6));
        }
        /// <summary>7引数関数を7要素のタプルを取る関数にします。</summary>
        public static Func<Tuple<T1,T2,T3,T4,T5,T6,T7>, TResult> Tuplize<T1,T2,T3,T4,T5,T6,T7, TResult>(this Func<T1,T2,T3,T4,T5,T6,T7, TResult> func)
        {
            return tuple => func(tuple.Item1,tuple.Item2,tuple.Item3,tuple.Item4,tuple.Item5,tuple.Item6,tuple.Item7);
        }
        /// <summary>7要素のタプルを取る関数を7引数関数にします。</summary>
        public static Func<T1,T2,T3,T4,T5,T6,T7, TResult> UnTuplize<T1,T2,T3,T4,T5,T6,T7, TResult>(this Func<Tuple<T1,T2,T3,T4,T5,T6,T7>, TResult> func)
        {
            return (v1,v2,v3,v4,v5,v6,v7) => func(Tuple.Create(v1,v2,v3,v4,v5,v6,v7));
        }
        /// <summary>カリー化された1引数関数の第1引数を最後に回すことで部分適用の適用しない部分を実現します。</summary>
        public static Func<T1, TResult> _<T1, TResult>(
            this Func<T1, TResult> func)
        {
            return v1 => func(v1);
        }
        /// <summary>カリー化された2引数関数の第1引数を最後に回すことで部分適用の適用しない部分を実現します。</summary>
        public static Func<T2, Func<T1, TResult>> _<T1,T2, TResult>(
            this Func<T1, Func<T2, TResult>> func)
        {
            return v2 => v1 => func(v1)(v2);
        }
        /// <summary>カリー化された3引数関数の第1引数を最後に回すことで部分適用の適用しない部分を実現します。</summary>
        public static Func<T2, Func<T3, Func<T1, TResult>>> _<T1,T2,T3, TResult>(
            this Func<T1, Func<T2, Func<T3, TResult>>> func)
        {
            return v2 => v3 => v1 => func(v1)(v2)(v3);
        }
        /// <summary>カリー化された4引数関数の第1引数を最後に回すことで部分適用の適用しない部分を実現します。</summary>
        public static Func<T2, Func<T3, Func<T4, Func<T1, TResult>>>> _<T1,T2,T3,T4, TResult>(
            this Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>> func)
        {
            return v2 => v3 => v4 => v1 => func(v1)(v2)(v3)(v4);
        }
        /// <summary>カリー化された5引数関数の第1引数を最後に回すことで部分適用の適用しない部分を実現します。</summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T1, TResult>>>>> _<T1,T2,T3,T4,T5, TResult>(
            this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>> func)
        {
            return v2 => v3 => v4 => v5 => v1 => func(v1)(v2)(v3)(v4)(v5);
        }
        /// <summary>カリー化された6引数関数の第1引数を最後に回すことで部分適用の適用しない部分を実現します。</summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T1, TResult>>>>>> _<T1,T2,T3,T4,T5,T6, TResult>(
            this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>> func)
        {
            return v2 => v3 => v4 => v5 => v6 => v1 => func(v1)(v2)(v3)(v4)(v5)(v6);
        }
        /// <summary>カリー化された7引数関数の第1引数を最後に回すことで部分適用の適用しない部分を実現します。</summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T1, TResult>>>>>>> _<T1,T2,T3,T4,T5,T6,T7, TResult>(
            this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>> func)
        {
            return v2 => v3 => v4 => v5 => v6 => v7 => v1 => func(v1)(v2)(v3)(v4)(v5)(v6)(v7);
        }
        /// <summary>カリー化された8引数関数の第1引数を最後に回すことで部分適用の適用しない部分を実現します。</summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T1, TResult>>>>>>>> _<T1,T2,T3,T4,T5,T6,T7,T8, TResult>(
            this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>> func)
        {
            return v2 => v3 => v4 => v5 => v6 => v7 => v8 => v1 => func(v1)(v2)(v3)(v4)(v5)(v6)(v7)(v8);
        }
        /// <summary>カリー化された9引数関数の第1引数を最後に回すことで部分適用の適用しない部分を実現します。</summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T1, TResult>>>>>>>>> _<T1,T2,T3,T4,T5,T6,T7,T8,T9, TResult>(
            this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>> func)
        {
            return v2 => v3 => v4 => v5 => v6 => v7 => v8 => v9 => v1 => func(v1)(v2)(v3)(v4)(v5)(v6)(v7)(v8)(v9);
        }
        /// <summary>カリー化された10引数関数の第1引数を最後に回すことで部分適用の適用しない部分を実現します。</summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T1, TResult>>>>>>>>>> _<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10, TResult>(
            this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>> func)
        {
            return v2 => v3 => v4 => v5 => v6 => v7 => v8 => v9 => v10 => v1 => func(v1)(v2)(v3)(v4)(v5)(v6)(v7)(v8)(v9)(v10);
        }
        /// <summary>カリー化された11引数関数の第1引数を最後に回すことで部分適用の適用しない部分を実現します。</summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T1, TResult>>>>>>>>>>> _<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11, TResult>(
            this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>> func)
        {
            return v2 => v3 => v4 => v5 => v6 => v7 => v8 => v9 => v10 => v11 => v1 => func(v1)(v2)(v3)(v4)(v5)(v6)(v7)(v8)(v9)(v10)(v11);
        }
        /// <summary>カリー化された12引数関数の第1引数を最後に回すことで部分適用の適用しない部分を実現します。</summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T1, TResult>>>>>>>>>>>> _<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12, TResult>(
            this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>> func)
        {
            return v2 => v3 => v4 => v5 => v6 => v7 => v8 => v9 => v10 => v11 => v12 => v1 => func(v1)(v2)(v3)(v4)(v5)(v6)(v7)(v8)(v9)(v10)(v11)(v12);
        }
        /// <summary>カリー化された13引数関数の第1引数を最後に回すことで部分適用の適用しない部分を実現します。</summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T1, TResult>>>>>>>>>>>>> _<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13, TResult>(
            this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>> func)
        {
            return v2 => v3 => v4 => v5 => v6 => v7 => v8 => v9 => v10 => v11 => v12 => v13 => v1 => func(v1)(v2)(v3)(v4)(v5)(v6)(v7)(v8)(v9)(v10)(v11)(v12)(v13);
        }
        /// <summary>カリー化された14引数関数の第1引数を最後に回すことで部分適用の適用しない部分を実現します。</summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T1, TResult>>>>>>>>>>>>>> _<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14, TResult>(
            this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>> func)
        {
            return v2 => v3 => v4 => v5 => v6 => v7 => v8 => v9 => v10 => v11 => v12 => v13 => v14 => v1 => func(v1)(v2)(v3)(v4)(v5)(v6)(v7)(v8)(v9)(v10)(v11)(v12)(v13)(v14);
        }
        /// <summary>カリー化された15引数関数の第1引数を最後に回すことで部分適用の適用しない部分を実現します。</summary>
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T1, TResult>>>>>>>>>>>>>>> _<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15, TResult>(
            this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>> func)
        {
            return v2 => v3 => v4 => v5 => v6 => v7 => v8 => v9 => v10 => v11 => v12 => v13 => v14 => v15 => v1 => func(v1)(v2)(v3)(v4)(v5)(v6)(v7)(v8)(v9)(v10)(v11)(v12)(v13)(v14)(v15);
        }
    }
}