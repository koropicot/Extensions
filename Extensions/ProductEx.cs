using System;

namespace Extensions
{
    public static class ProductEx
    {
        /// <summary>任意の型の値から0個の関数によって要素が0個の組を生成します。</summary>
        public static Product Produce<TSource>(
            this TSource source)
        {
            return Product.Creat();
        }
        /// <summary>任意の型の値から1個の関数によって要素が1個の組を生成します。</summary>
        public static Product<T1> Produce<TSource, T1>(
            this TSource source, Func<TSource, T1> f1)
        {
            return Product.Creat(f1(source));
        }
        /// <summary>任意の型の値から2個の関数によって要素が2個の組を生成します。</summary>
        public static Product<T1, T2> Produce<TSource, T1, T2>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2)
        {
            return Product.Creat(f1(source), f2(source));
        }
        /// <summary>任意の型の値から3個の関数によって要素が3個の組を生成します。</summary>
        public static Product<T1, T2, T3> Produce<TSource, T1, T2, T3>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3)
        {
            return Product.Creat(f1(source), f2(source), f3(source));
        }
        /// <summary>任意の型の値から4個の関数によって要素が4個の組を生成します。</summary>
        public static Product<T1, T2, T3, T4> Produce<TSource, T1, T2, T3, T4>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source));
        }
        /// <summary>任意の型の値から5個の関数によって要素が5個の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5> Produce<TSource, T1, T2, T3, T4, T5>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source));
        }
        /// <summary>任意の型の値から6個の関数によって要素が6個の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6> Produce<TSource, T1, T2, T3, T4, T5, T6>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source));
        }
        /// <summary>任意の型の値から7個の関数によって要素が7個の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7> Produce<TSource, T1, T2, T3, T4, T5, T6, T7>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source));
        }
        /// <summary>任意の型の値から8個の関数によって要素が8個の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8> Produce<TSource, T1, T2, T3, T4, T5, T6, T7, T8>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7, Func<TSource, T8> f8)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source), f8(source));
        }
        /// <summary>任意の型の値から9個の関数によって要素が9個の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9> Produce<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7, Func<TSource, T8> f8, Func<TSource, T9> f9)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source), f8(source), f9(source));
        }
        /// <summary>任意の型の値から10個の関数によって要素が10個の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Produce<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7, Func<TSource, T8> f8, Func<TSource, T9> f9, Func<TSource, T10> f10)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source), f8(source), f9(source), f10(source));
        }
        /// <summary>任意の型の値から11個の関数によって要素が11個の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Produce<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7, Func<TSource, T8> f8, Func<TSource, T9> f9, Func<TSource, T10> f10, Func<TSource, T11> f11)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source), f8(source), f9(source), f10(source), f11(source));
        }
        /// <summary>任意の型の値から12個の関数によって要素が12個の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Produce<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7, Func<TSource, T8> f8, Func<TSource, T9> f9, Func<TSource, T10> f10, Func<TSource, T11> f11, Func<TSource, T12> f12)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source), f8(source), f9(source), f10(source), f11(source), f12(source));
        }
        /// <summary>任意の型の値から13個の関数によって要素が13個の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Produce<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7, Func<TSource, T8> f8, Func<TSource, T9> f9, Func<TSource, T10> f10, Func<TSource, T11> f11, Func<TSource, T12> f12, Func<TSource, T13> f13)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source), f8(source), f9(source), f10(source), f11(source), f12(source), f13(source));
        }
        /// <summary>任意の型の値から14個の関数によって要素が14個の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Produce<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7, Func<TSource, T8> f8, Func<TSource, T9> f9, Func<TSource, T10> f10, Func<TSource, T11> f11, Func<TSource, T12> f12, Func<TSource, T13> f13, Func<TSource, T14> f14)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source), f8(source), f9(source), f10(source), f11(source), f12(source), f13(source), f14(source));
        }
        /// <summary>任意の型の値から15個の関数によって要素が15個の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Produce<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7, Func<TSource, T8> f8, Func<TSource, T9> f9, Func<TSource, T10> f10, Func<TSource, T11> f11, Func<TSource, T12> f12, Func<TSource, T13> f13, Func<TSource, T14> f14, Func<TSource, T15> f15)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source), f8(source), f9(source), f10(source), f11(source), f12(source), f13(source), f14(source), f15(source));
        }
        /// <summary>任意の型の値から16個の関数によって要素が16個の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Produce<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7, Func<TSource, T8> f8, Func<TSource, T9> f9, Func<TSource, T10> f10, Func<TSource, T11> f11, Func<TSource, T12> f12, Func<TSource, T13> f13, Func<TSource, T14> f14, Func<TSource, T15> f15, Func<TSource, T16> f16)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source), f8(source), f9(source), f10(source), f11(source), f12(source), f13(source), f14(source), f15(source), f16(source));
        }

        /// <summary>要素が1個のTupleからProductに変換します。/summary>
        public static Product<T1> ToProduct<T1>(
            this Tuple<T1> tuple)
        {
            return Product.Creat(tuple.Item1);
        }

        /// <summary>要素が1個のProductからTupleに変換します。/summary>
        public static Tuple<T1> ToTuple<T1>(
            this Product<T1> prod)
        {
            return new Tuple<T1>(prod.D1);
        }
        /// <summary>要素が2個のTupleからProductに変換します。/summary>
        public static Product<T1, T2> ToProduct<T1, T2>(
            this Tuple<T1, T2> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2);
        }

        /// <summary>要素が2個のProductからTupleに変換します。/summary>
        public static Tuple<T1, T2> ToTuple<T1, T2>(
            this Product<T1, T2> prod)
        {
            return new Tuple<T1, T2>(prod.D1, prod.D2);
        }
        /// <summary>要素が3個のTupleからProductに変換します。/summary>
        public static Product<T1, T2, T3> ToProduct<T1, T2, T3>(
            this Tuple<T1, T2, T3> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3);
        }

        /// <summary>要素が3個のProductからTupleに変換します。/summary>
        public static Tuple<T1, T2, T3> ToTuple<T1, T2, T3>(
            this Product<T1, T2, T3> prod)
        {
            return new Tuple<T1, T2, T3>(prod.D1, prod.D2, prod.D3);
        }
        /// <summary>要素が4個のTupleからProductに変換します。/summary>
        public static Product<T1, T2, T3, T4> ToProduct<T1, T2, T3, T4>(
            this Tuple<T1, T2, T3, T4> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
        }

        /// <summary>要素が4個のProductからTupleに変換します。/summary>
        public static Tuple<T1, T2, T3, T4> ToTuple<T1, T2, T3, T4>(
            this Product<T1, T2, T3, T4> prod)
        {
            return new Tuple<T1, T2, T3, T4>(prod.D1, prod.D2, prod.D3, prod.D4);
        }
        /// <summary>要素が5個のTupleからProductに変換します。/summary>
        public static Product<T1, T2, T3, T4, T5> ToProduct<T1, T2, T3, T4, T5>(
            this Tuple<T1, T2, T3, T4, T5> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);
        }

        /// <summary>要素が5個のProductからTupleに変換します。/summary>
        public static Tuple<T1, T2, T3, T4, T5> ToTuple<T1, T2, T3, T4, T5>(
            this Product<T1, T2, T3, T4, T5> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5);
        }
        /// <summary>要素が6個のTupleからProductに変換します。/summary>
        public static Product<T1, T2, T3, T4, T5, T6> ToProduct<T1, T2, T3, T4, T5, T6>(
            this Tuple<T1, T2, T3, T4, T5, T6> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6);
        }

        /// <summary>要素が6個のProductからTupleに変換します。/summary>
        public static Tuple<T1, T2, T3, T4, T5, T6> ToTuple<T1, T2, T3, T4, T5, T6>(
            this Product<T1, T2, T3, T4, T5, T6> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6);
        }
        /// <summary>要素が7個のTupleからProductに変換します。/summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7> ToProduct<T1, T2, T3, T4, T5, T6, T7>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7);
        }

        /// <summary>要素が7個のProductからTupleに変換します。/summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7> ToTuple<T1, T2, T3, T4, T5, T6, T7>(
            this Product<T1, T2, T3, T4, T5, T6, T7> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7);
        }
        /// <summary>要素が8個のTupleからProductに変換します。/summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8> ToProduct<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8>> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Rest.Item1);
        }

        /// <summary>要素が8個のProductからTupleに変換します。/summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Product<T1, T2, T3, T4, T5, T6, T7, T8> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8>>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7,new Tuple<T8>(prod.D8));
        }
        /// <summary>要素が9個のTupleからProductに変換します。/summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9> ToProduct<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9>> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Rest.Item1, tuple.Rest.Item2);
        }

        /// <summary>要素が9個のProductからTupleに変換します。/summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this Product<T1, T2, T3, T4, T5, T6, T7, T8, T9> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9>>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7,new Tuple<T8, T9>(prod.D8, prod.D9));
        }
        /// <summary>要素が10個のTupleからProductに変換します。/summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ToProduct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10>> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Rest.Item1, tuple.Rest.Item2, tuple.Rest.Item3);
        }

        /// <summary>要素が10個のProductからTupleに変換します。/summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10>>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7,new Tuple<T8, T9, T10>(prod.D8, prod.D9, prod.D10));
        }
        /// <summary>要素が11個のTupleからProductに変換します。/summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ToProduct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11>> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Rest.Item1, tuple.Rest.Item2, tuple.Rest.Item3, tuple.Rest.Item4);
        }

        /// <summary>要素が11個のProductからTupleに変換します。/summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11>>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7,new Tuple<T8, T9, T10, T11>(prod.D8, prod.D9, prod.D10, prod.D11));
        }
        /// <summary>要素が12個のTupleからProductに変換します。/summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ToProduct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12>> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Rest.Item1, tuple.Rest.Item2, tuple.Rest.Item3, tuple.Rest.Item4, tuple.Rest.Item5);
        }

        /// <summary>要素が12個のProductからTupleに変換します。/summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12>>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7,new Tuple<T8, T9, T10, T11, T12>(prod.D8, prod.D9, prod.D10, prod.D11, prod.D12));
        }
        /// <summary>要素が13個のTupleからProductに変換します。/summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ToProduct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13>> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Rest.Item1, tuple.Rest.Item2, tuple.Rest.Item3, tuple.Rest.Item4, tuple.Rest.Item5, tuple.Rest.Item6);
        }

        /// <summary>要素が13個のProductからTupleに変換します。/summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13>>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7,new Tuple<T8, T9, T10, T11, T12, T13>(prod.D8, prod.D9, prod.D10, prod.D11, prod.D12, prod.D13));
        }
        /// <summary>要素が14個のTupleからProductに変換します。/summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ToProduct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13, T14>> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Rest.Item1, tuple.Rest.Item2, tuple.Rest.Item3, tuple.Rest.Item4, tuple.Rest.Item5, tuple.Rest.Item6, tuple.Rest.Item7);
        }

        /// <summary>要素が14個のProductからTupleに変換します。/summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13, T14>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13, T14>>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7,new Tuple<T8, T9, T10, T11, T12, T13, T14>(prod.D8, prod.D9, prod.D10, prod.D11, prod.D12, prod.D13, prod.D14));
        }
        /// <summary>要素が15個のTupleからProductに変換します。/summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ToProduct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13, T14,Tuple<T15>>> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Rest.Item1, tuple.Rest.Item2, tuple.Rest.Item3, tuple.Rest.Item4, tuple.Rest.Item5, tuple.Rest.Item6, tuple.Rest.Item7, tuple.Rest.Rest.Item1);
        }

        /// <summary>要素が15個のProductからTupleに変換します。/summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13, T14,Tuple<T15>>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13, T14,Tuple<T15>>>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7,new Tuple<T8, T9, T10, T11, T12, T13, T14,Tuple<T15>>(prod.D8, prod.D9, prod.D10, prod.D11, prod.D12, prod.D13, prod.D14,new Tuple<T15>(prod.D15)));
        }
        /// <summary>要素が16個のTupleからProductに変換します。/summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> ToProduct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13, T14,Tuple<T15, T16>>> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Rest.Item1, tuple.Rest.Item2, tuple.Rest.Item3, tuple.Rest.Item4, tuple.Rest.Item5, tuple.Rest.Item6, tuple.Rest.Item7, tuple.Rest.Rest.Item1, tuple.Rest.Rest.Item2);
        }

        /// <summary>要素が16個のProductからTupleに変換します。/summary>
        public static Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13, T14,Tuple<T15, T16>>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13, T14,Tuple<T15, T16>>>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7,new Tuple<T8, T9, T10, T11, T12, T13, T14,Tuple<T15, T16>>(prod.D8, prod.D9, prod.D10, prod.D11, prod.D12, prod.D13, prod.D14,new Tuple<T15, T16>(prod.D15, prod.D16)));
        }
    }
}