using System;

namespace Extensions
{
    public static class ProductEx
    {
        public static Product Produce<TSource>(
            this TSource source)
        {
            return Product.Creat();
        }
        public static Product<T1> Produce<TSource, T1>(
            this TSource source, Func<TSource, T1> f1)
        {
            return Product.Creat(f1(source));
        }
        public static Product<T1, T2> Produce<TSource, T1, T2>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2)
        {
            return Product.Creat(f1(source), f2(source));
        }
        public static Product<T1, T2, T3> Produce<TSource, T1, T2, T3>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3)
        {
            return Product.Creat(f1(source), f2(source), f3(source));
        }
        public static Product<T1, T2, T3, T4> Produce<TSource, T1, T2, T3, T4>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source));
        }
        public static Product<T1, T2, T3, T4, T5> Produce<TSource, T1, T2, T3, T4, T5>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source));
        }
        public static Product<T1, T2, T3, T4, T5, T6> Produce<TSource, T1, T2, T3, T4, T5, T6>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source));
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7> Produce<TSource, T1, T2, T3, T4, T5, T6, T7>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source));
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8> Produce<TSource, T1, T2, T3, T4, T5, T6, T7, T8>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7, Func<TSource, T8> f8)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source), f8(source));
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9> Produce<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7, Func<TSource, T8> f8, Func<TSource, T9> f9)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source), f8(source), f9(source));
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Produce<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7, Func<TSource, T8> f8, Func<TSource, T9> f9, Func<TSource, T10> f10)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source), f8(source), f9(source), f10(source));
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Produce<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7, Func<TSource, T8> f8, Func<TSource, T9> f9, Func<TSource, T10> f10, Func<TSource, T11> f11)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source), f8(source), f9(source), f10(source), f11(source));
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Produce<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7, Func<TSource, T8> f8, Func<TSource, T9> f9, Func<TSource, T10> f10, Func<TSource, T11> f11, Func<TSource, T12> f12)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source), f8(source), f9(source), f10(source), f11(source), f12(source));
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Produce<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7, Func<TSource, T8> f8, Func<TSource, T9> f9, Func<TSource, T10> f10, Func<TSource, T11> f11, Func<TSource, T12> f12, Func<TSource, T13> f13)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source), f8(source), f9(source), f10(source), f11(source), f12(source), f13(source));
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Produce<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7, Func<TSource, T8> f8, Func<TSource, T9> f9, Func<TSource, T10> f10, Func<TSource, T11> f11, Func<TSource, T12> f12, Func<TSource, T13> f13, Func<TSource, T14> f14)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source), f8(source), f9(source), f10(source), f11(source), f12(source), f13(source), f14(source));
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Produce<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7, Func<TSource, T8> f8, Func<TSource, T9> f9, Func<TSource, T10> f10, Func<TSource, T11> f11, Func<TSource, T12> f12, Func<TSource, T13> f13, Func<TSource, T14> f14, Func<TSource, T15> f15)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source), f8(source), f9(source), f10(source), f11(source), f12(source), f13(source), f14(source), f15(source));
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Produce<TSource, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this TSource source, Func<TSource, T1> f1, Func<TSource, T2> f2, Func<TSource, T3> f3, Func<TSource, T4> f4, Func<TSource, T5> f5, Func<TSource, T6> f6, Func<TSource, T7> f7, Func<TSource, T8> f8, Func<TSource, T9> f9, Func<TSource, T10> f10, Func<TSource, T11> f11, Func<TSource, T12> f12, Func<TSource, T13> f13, Func<TSource, T14> f14, Func<TSource, T15> f15, Func<TSource, T16> f16)
        {
            return Product.Creat(f1(source), f2(source), f3(source), f4(source), f5(source), f6(source), f7(source), f8(source), f9(source), f10(source), f11(source), f12(source), f13(source), f14(source), f15(source), f16(source));
        }

        public static Product<T1> ToProduct<T1>(
            this Tuple<T1> tuple)
        {
            return Product.Creat(tuple.Item1);
        }

        public static Tuple<T1> ToTuple<T1>(
            this Product<T1> prod)
        {
            return new Tuple<T1>(prod.D1);
        }
        public static Product<T1, T2> ToProduct<T1, T2>(
            this Tuple<T1, T2> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2);
        }

        public static Tuple<T1, T2> ToTuple<T1, T2>(
            this Product<T1, T2> prod)
        {
            return new Tuple<T1, T2>(prod.D1, prod.D2);
        }
        public static Product<T1, T2, T3> ToProduct<T1, T2, T3>(
            this Tuple<T1, T2, T3> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3);
        }

        public static Tuple<T1, T2, T3> ToTuple<T1, T2, T3>(
            this Product<T1, T2, T3> prod)
        {
            return new Tuple<T1, T2, T3>(prod.D1, prod.D2, prod.D3);
        }
        public static Product<T1, T2, T3, T4> ToProduct<T1, T2, T3, T4>(
            this Tuple<T1, T2, T3, T4> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4);
        }

        public static Tuple<T1, T2, T3, T4> ToTuple<T1, T2, T3, T4>(
            this Product<T1, T2, T3, T4> prod)
        {
            return new Tuple<T1, T2, T3, T4>(prod.D1, prod.D2, prod.D3, prod.D4);
        }
        public static Product<T1, T2, T3, T4, T5> ToProduct<T1, T2, T3, T4, T5>(
            this Tuple<T1, T2, T3, T4, T5> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5);
        }

        public static Tuple<T1, T2, T3, T4, T5> ToTuple<T1, T2, T3, T4, T5>(
            this Product<T1, T2, T3, T4, T5> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5);
        }
        public static Product<T1, T2, T3, T4, T5, T6> ToProduct<T1, T2, T3, T4, T5, T6>(
            this Tuple<T1, T2, T3, T4, T5, T6> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6);
        }

        public static Tuple<T1, T2, T3, T4, T5, T6> ToTuple<T1, T2, T3, T4, T5, T6>(
            this Product<T1, T2, T3, T4, T5, T6> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6);
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7> ToProduct<T1, T2, T3, T4, T5, T6, T7>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7);
        }

        public static Tuple<T1, T2, T3, T4, T5, T6, T7> ToTuple<T1, T2, T3, T4, T5, T6, T7>(
            this Product<T1, T2, T3, T4, T5, T6, T7> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7);
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8> ToProduct<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8>> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Rest.Item1);
        }

        public static Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8>(
            this Product<T1, T2, T3, T4, T5, T6, T7, T8> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8>>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7,new Tuple<T8>(prod.D8));
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9> ToProduct<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9>> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Rest.Item1, tuple.Rest.Item2);
        }

        public static Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            this Product<T1, T2, T3, T4, T5, T6, T7, T8, T9> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9>>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7,new Tuple<T8, T9>(prod.D8, prod.D9));
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ToProduct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10>> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Rest.Item1, tuple.Rest.Item2, tuple.Rest.Item3);
        }

        public static Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            this Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10>>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7,new Tuple<T8, T9, T10>(prod.D8, prod.D9, prod.D10));
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ToProduct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11>> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Rest.Item1, tuple.Rest.Item2, tuple.Rest.Item3, tuple.Rest.Item4);
        }

        public static Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            this Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11>>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7,new Tuple<T8, T9, T10, T11>(prod.D8, prod.D9, prod.D10, prod.D11));
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ToProduct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12>> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Rest.Item1, tuple.Rest.Item2, tuple.Rest.Item3, tuple.Rest.Item4, tuple.Rest.Item5);
        }

        public static Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            this Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12>>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7,new Tuple<T8, T9, T10, T11, T12>(prod.D8, prod.D9, prod.D10, prod.D11, prod.D12));
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ToProduct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13>> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Rest.Item1, tuple.Rest.Item2, tuple.Rest.Item3, tuple.Rest.Item4, tuple.Rest.Item5, tuple.Rest.Item6);
        }

        public static Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            this Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13>>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7,new Tuple<T8, T9, T10, T11, T12, T13>(prod.D8, prod.D9, prod.D10, prod.D11, prod.D12, prod.D13));
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ToProduct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13, T14>> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Rest.Item1, tuple.Rest.Item2, tuple.Rest.Item3, tuple.Rest.Item4, tuple.Rest.Item5, tuple.Rest.Item6, tuple.Rest.Item7);
        }

        public static Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13, T14>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            this Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13, T14>>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7,new Tuple<T8, T9, T10, T11, T12, T13, T14>(prod.D8, prod.D9, prod.D10, prod.D11, prod.D12, prod.D13, prod.D14));
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ToProduct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13, T14,Tuple<T15>>> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Rest.Item1, tuple.Rest.Item2, tuple.Rest.Item3, tuple.Rest.Item4, tuple.Rest.Item5, tuple.Rest.Item6, tuple.Rest.Item7, tuple.Rest.Rest.Item1);
        }

        public static Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13, T14,Tuple<T15>>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            this Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13, T14,Tuple<T15>>>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7,new Tuple<T8, T9, T10, T11, T12, T13, T14,Tuple<T15>>(prod.D8, prod.D9, prod.D10, prod.D11, prod.D12, prod.D13, prod.D14,new Tuple<T15>(prod.D15)));
        }
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> ToProduct<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13, T14,Tuple<T15, T16>>> tuple)
        {
            return Product.Creat(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6, tuple.Item7, tuple.Rest.Item1, tuple.Rest.Item2, tuple.Rest.Item3, tuple.Rest.Item4, tuple.Rest.Item5, tuple.Rest.Item6, tuple.Rest.Item7, tuple.Rest.Rest.Item1, tuple.Rest.Rest.Item2);
        }

        public static Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13, T14,Tuple<T15, T16>>> ToTuple<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            this Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> prod)
        {
            return new Tuple<T1, T2, T3, T4, T5, T6, T7,Tuple<T8, T9, T10, T11, T12, T13, T14,Tuple<T15, T16>>>(prod.D1, prod.D2, prod.D3, prod.D4, prod.D5, prod.D6, prod.D7,new Tuple<T8, T9, T10, T11, T12, T13, T14,Tuple<T15, T16>>(prod.D8, prod.D9, prod.D10, prod.D11, prod.D12, prod.D13, prod.D14,new Tuple<T15, T16>(prod.D15, prod.D16)));
        }
    }
}