using System;

namespace Extensions
{
    /// <summary>
    /// 要素が0個の組です。
    /// また、各要素数の組を作成するための静的メソッドを提供します。
    /// </summary>
    public sealed class Product : IEquatable<Product>
    {
        #region Createメソッド
        /// <summary>0要素の組を生成します。</summary>
        public static Product Creat()
        {
            return new Product();
        }
        /// <summary>1要素の組を生成します。</summary>
        public static Product<T1> Creat<T1>(T1 v1)
        {
            return new Product<T1>(v1);
        }
        /// <summary>2要素の組を生成します。</summary>
        public static Product<T1, T2> Creat<T1, T2>(T1 v1, T2 v2)
        {
            return new Product<T1, T2>(v1, v2);
        }
        /// <summary>3要素の組を生成します。</summary>
        public static Product<T1, T2, T3> Creat<T1, T2, T3>(T1 v1, T2 v2, T3 v3)
        {
            return new Product<T1, T2, T3>(v1, v2, v3);
        }
        /// <summary>4要素の組を生成します。</summary>
        public static Product<T1, T2, T3, T4> Creat<T1, T2, T3, T4>(T1 v1, T2 v2, T3 v3, T4 v4)
        {
            return new Product<T1, T2, T3, T4>(v1, v2, v3, v4);
        }
        /// <summary>5要素の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5> Creat<T1, T2, T3, T4, T5>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5)
        {
            return new Product<T1, T2, T3, T4, T5>(v1, v2, v3, v4, v5);
        }
        /// <summary>6要素の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6> Creat<T1, T2, T3, T4, T5, T6>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6)
        {
            return new Product<T1, T2, T3, T4, T5, T6>(v1, v2, v3, v4, v5, v6);
        }
        /// <summary>7要素の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7> Creat<T1, T2, T3, T4, T5, T6, T7>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7)
        {
            return new Product<T1, T2, T3, T4, T5, T6, T7>(v1, v2, v3, v4, v5, v6, v7);
        }
        /// <summary>8要素の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8> Creat<T1, T2, T3, T4, T5, T6, T7, T8>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8)
        {
            return new Product<T1, T2, T3, T4, T5, T6, T7, T8>(v1, v2, v3, v4, v5, v6, v7, v8);
        }
        /// <summary>9要素の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9> Creat<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9)
        {
            return new Product<T1, T2, T3, T4, T5, T6, T7, T8, T9>(v1, v2, v3, v4, v5, v6, v7, v8, v9);
        }
        /// <summary>10要素の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Creat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10)
        {
            return new Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
        }
        /// <summary>11要素の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Creat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11)
        {
            return new Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11);
        }
        /// <summary>12要素の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Creat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12)
        {
            return new Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12);
        }
        /// <summary>13要素の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Creat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13)
        {
            return new Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13);
        }
        /// <summary>14要素の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Creat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13, T14 v14)
        {
            return new Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14);
        }
        /// <summary>15要素の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Creat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13, T14 v14, T15 v15)
        {
            return new Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15);
        }
        /// <summary>16要素の組を生成します。</summary>
        public static Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Creat<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13, T14 v14, T15 v15, T16 v16)
        {
            return new Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16);
        }
        #endregion

        public Product() { }

        public bool Equals(Product other)
        {
            return other == null ? false : true;
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Product);
        }
        public override int GetHashCode()
        {
            return 0;
        }
        public override string ToString()
        {
            return "()";
        }
    }

    /// <summary>要素が1個の組です。</summary>
    public sealed class Product<T1> : IEquatable<Product<T1>>
    {
        public Product(T1 v1)
        {
            D1 =  v1;
        }

        /// <summary>1要素目の値を取得します。</summary>
        public T1 D1 { get; private set; }

        public bool Equals(Product<T1> other)
        {
            return other == null ? false : D1.Equals(other.D1);
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Product<T1>);
        }
        public override int GetHashCode()
        {
            return D1.GetHashCode();
        }
        public override string ToString()
        {
            return "(" + string.Join(", ", new object[] { D1 }) + ")";
        }
    }

    /// <summary>要素が2個の組です。</summary>
    public sealed class Product<T1, T2> : IEquatable<Product<T1, T2>>
    {
        public Product(T1 v1, T2 v2)
        {
            D1 =  v1;
            D2 =  v2;
        }

        /// <summary>1要素目の値を取得します。</summary>
        public T1 D1 { get; private set; }
        /// <summary>2要素目の値を取得します。</summary>
        public T2 D2 { get; private set; }

        public bool Equals(Product<T1, T2> other)
        {
            return other == null ? false : D1.Equals(other.D1)
                && D2.Equals(other.D2);
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Product<T1, T2>);
        }
        public override int GetHashCode()
        {
            return D1.GetHashCode()
                ^ D2.GetHashCode();
        }
        public override string ToString()
        {
            return "(" + string.Join(", ", new object[] { D1, D2 }) + ")";
        }
    }

    /// <summary>要素が3個の組です。</summary>
    public sealed class Product<T1, T2, T3> : IEquatable<Product<T1, T2, T3>>
    {
        public Product(T1 v1, T2 v2, T3 v3)
        {
            D1 =  v1;
            D2 =  v2;
            D3 =  v3;
        }

        /// <summary>1要素目の値を取得します。</summary>
        public T1 D1 { get; private set; }
        /// <summary>2要素目の値を取得します。</summary>
        public T2 D2 { get; private set; }
        /// <summary>3要素目の値を取得します。</summary>
        public T3 D3 { get; private set; }

        public bool Equals(Product<T1, T2, T3> other)
        {
            return other == null ? false : D1.Equals(other.D1)
                && D2.Equals(other.D2)
                && D3.Equals(other.D3);
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Product<T1, T2, T3>);
        }
        public override int GetHashCode()
        {
            return D1.GetHashCode()
                ^ D2.GetHashCode()
                ^ D3.GetHashCode();
        }
        public override string ToString()
        {
            return "(" + string.Join(", ", new object[] { D1, D2, D3 }) + ")";
        }
    }

    /// <summary>要素が4個の組です。</summary>
    public sealed class Product<T1, T2, T3, T4> : IEquatable<Product<T1, T2, T3, T4>>
    {
        public Product(T1 v1, T2 v2, T3 v3, T4 v4)
        {
            D1 =  v1;
            D2 =  v2;
            D3 =  v3;
            D4 =  v4;
        }

        /// <summary>1要素目の値を取得します。</summary>
        public T1 D1 { get; private set; }
        /// <summary>2要素目の値を取得します。</summary>
        public T2 D2 { get; private set; }
        /// <summary>3要素目の値を取得します。</summary>
        public T3 D3 { get; private set; }
        /// <summary>4要素目の値を取得します。</summary>
        public T4 D4 { get; private set; }

        public bool Equals(Product<T1, T2, T3, T4> other)
        {
            return other == null ? false : D1.Equals(other.D1)
                && D2.Equals(other.D2)
                && D3.Equals(other.D3)
                && D4.Equals(other.D4);
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Product<T1, T2, T3, T4>);
        }
        public override int GetHashCode()
        {
            return D1.GetHashCode()
                ^ D2.GetHashCode()
                ^ D3.GetHashCode()
                ^ D4.GetHashCode();
        }
        public override string ToString()
        {
            return "(" + string.Join(", ", new object[] { D1, D2, D3, D4 }) + ")";
        }
    }

    /// <summary>要素が5個の組です。</summary>
    public sealed class Product<T1, T2, T3, T4, T5> : IEquatable<Product<T1, T2, T3, T4, T5>>
    {
        public Product(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5)
        {
            D1 =  v1;
            D2 =  v2;
            D3 =  v3;
            D4 =  v4;
            D5 =  v5;
        }

        /// <summary>1要素目の値を取得します。</summary>
        public T1 D1 { get; private set; }
        /// <summary>2要素目の値を取得します。</summary>
        public T2 D2 { get; private set; }
        /// <summary>3要素目の値を取得します。</summary>
        public T3 D3 { get; private set; }
        /// <summary>4要素目の値を取得します。</summary>
        public T4 D4 { get; private set; }
        /// <summary>5要素目の値を取得します。</summary>
        public T5 D5 { get; private set; }

        public bool Equals(Product<T1, T2, T3, T4, T5> other)
        {
            return other == null ? false : D1.Equals(other.D1)
                && D2.Equals(other.D2)
                && D3.Equals(other.D3)
                && D4.Equals(other.D4)
                && D5.Equals(other.D5);
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Product<T1, T2, T3, T4, T5>);
        }
        public override int GetHashCode()
        {
            return D1.GetHashCode()
                ^ D2.GetHashCode()
                ^ D3.GetHashCode()
                ^ D4.GetHashCode()
                ^ D5.GetHashCode();
        }
        public override string ToString()
        {
            return "(" + string.Join(", ", new object[] { D1, D2, D3, D4, D5 }) + ")";
        }
    }

    /// <summary>要素が6個の組です。</summary>
    public sealed class Product<T1, T2, T3, T4, T5, T6> : IEquatable<Product<T1, T2, T3, T4, T5, T6>>
    {
        public Product(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6)
        {
            D1 =  v1;
            D2 =  v2;
            D3 =  v3;
            D4 =  v4;
            D5 =  v5;
            D6 =  v6;
        }

        /// <summary>1要素目の値を取得します。</summary>
        public T1 D1 { get; private set; }
        /// <summary>2要素目の値を取得します。</summary>
        public T2 D2 { get; private set; }
        /// <summary>3要素目の値を取得します。</summary>
        public T3 D3 { get; private set; }
        /// <summary>4要素目の値を取得します。</summary>
        public T4 D4 { get; private set; }
        /// <summary>5要素目の値を取得します。</summary>
        public T5 D5 { get; private set; }
        /// <summary>6要素目の値を取得します。</summary>
        public T6 D6 { get; private set; }

        public bool Equals(Product<T1, T2, T3, T4, T5, T6> other)
        {
            return other == null ? false : D1.Equals(other.D1)
                && D2.Equals(other.D2)
                && D3.Equals(other.D3)
                && D4.Equals(other.D4)
                && D5.Equals(other.D5)
                && D6.Equals(other.D6);
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Product<T1, T2, T3, T4, T5, T6>);
        }
        public override int GetHashCode()
        {
            return D1.GetHashCode()
                ^ D2.GetHashCode()
                ^ D3.GetHashCode()
                ^ D4.GetHashCode()
                ^ D5.GetHashCode()
                ^ D6.GetHashCode();
        }
        public override string ToString()
        {
            return "(" + string.Join(", ", new object[] { D1, D2, D3, D4, D5, D6 }) + ")";
        }
    }

    /// <summary>要素が7個の組です。</summary>
    public sealed class Product<T1, T2, T3, T4, T5, T6, T7> : IEquatable<Product<T1, T2, T3, T4, T5, T6, T7>>
    {
        public Product(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7)
        {
            D1 =  v1;
            D2 =  v2;
            D3 =  v3;
            D4 =  v4;
            D5 =  v5;
            D6 =  v6;
            D7 =  v7;
        }

        /// <summary>1要素目の値を取得します。</summary>
        public T1 D1 { get; private set; }
        /// <summary>2要素目の値を取得します。</summary>
        public T2 D2 { get; private set; }
        /// <summary>3要素目の値を取得します。</summary>
        public T3 D3 { get; private set; }
        /// <summary>4要素目の値を取得します。</summary>
        public T4 D4 { get; private set; }
        /// <summary>5要素目の値を取得します。</summary>
        public T5 D5 { get; private set; }
        /// <summary>6要素目の値を取得します。</summary>
        public T6 D6 { get; private set; }
        /// <summary>7要素目の値を取得します。</summary>
        public T7 D7 { get; private set; }

        public bool Equals(Product<T1, T2, T3, T4, T5, T6, T7> other)
        {
            return other == null ? false : D1.Equals(other.D1)
                && D2.Equals(other.D2)
                && D3.Equals(other.D3)
                && D4.Equals(other.D4)
                && D5.Equals(other.D5)
                && D6.Equals(other.D6)
                && D7.Equals(other.D7);
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Product<T1, T2, T3, T4, T5, T6, T7>);
        }
        public override int GetHashCode()
        {
            return D1.GetHashCode()
                ^ D2.GetHashCode()
                ^ D3.GetHashCode()
                ^ D4.GetHashCode()
                ^ D5.GetHashCode()
                ^ D6.GetHashCode()
                ^ D7.GetHashCode();
        }
        public override string ToString()
        {
            return "(" + string.Join(", ", new object[] { D1, D2, D3, D4, D5, D6, D7 }) + ")";
        }
    }

    /// <summary>要素が8個の組です。</summary>
    public sealed class Product<T1, T2, T3, T4, T5, T6, T7, T8> : IEquatable<Product<T1, T2, T3, T4, T5, T6, T7, T8>>
    {
        public Product(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8)
        {
            D1 =  v1;
            D2 =  v2;
            D3 =  v3;
            D4 =  v4;
            D5 =  v5;
            D6 =  v6;
            D7 =  v7;
            D8 =  v8;
        }

        /// <summary>1要素目の値を取得します。</summary>
        public T1 D1 { get; private set; }
        /// <summary>2要素目の値を取得します。</summary>
        public T2 D2 { get; private set; }
        /// <summary>3要素目の値を取得します。</summary>
        public T3 D3 { get; private set; }
        /// <summary>4要素目の値を取得します。</summary>
        public T4 D4 { get; private set; }
        /// <summary>5要素目の値を取得します。</summary>
        public T5 D5 { get; private set; }
        /// <summary>6要素目の値を取得します。</summary>
        public T6 D6 { get; private set; }
        /// <summary>7要素目の値を取得します。</summary>
        public T7 D7 { get; private set; }
        /// <summary>8要素目の値を取得します。</summary>
        public T8 D8 { get; private set; }

        public bool Equals(Product<T1, T2, T3, T4, T5, T6, T7, T8> other)
        {
            return other == null ? false : D1.Equals(other.D1)
                && D2.Equals(other.D2)
                && D3.Equals(other.D3)
                && D4.Equals(other.D4)
                && D5.Equals(other.D5)
                && D6.Equals(other.D6)
                && D7.Equals(other.D7)
                && D8.Equals(other.D8);
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Product<T1, T2, T3, T4, T5, T6, T7, T8>);
        }
        public override int GetHashCode()
        {
            return D1.GetHashCode()
                ^ D2.GetHashCode()
                ^ D3.GetHashCode()
                ^ D4.GetHashCode()
                ^ D5.GetHashCode()
                ^ D6.GetHashCode()
                ^ D7.GetHashCode()
                ^ D8.GetHashCode();
        }
        public override string ToString()
        {
            return "(" + string.Join(", ", new object[] { D1, D2, D3, D4, D5, D6, D7, D8 }) + ")";
        }
    }

    /// <summary>要素が9個の組です。</summary>
    public sealed class Product<T1, T2, T3, T4, T5, T6, T7, T8, T9> : IEquatable<Product<T1, T2, T3, T4, T5, T6, T7, T8, T9>>
    {
        public Product(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9)
        {
            D1 =  v1;
            D2 =  v2;
            D3 =  v3;
            D4 =  v4;
            D5 =  v5;
            D6 =  v6;
            D7 =  v7;
            D8 =  v8;
            D9 =  v9;
        }

        /// <summary>1要素目の値を取得します。</summary>
        public T1 D1 { get; private set; }
        /// <summary>2要素目の値を取得します。</summary>
        public T2 D2 { get; private set; }
        /// <summary>3要素目の値を取得します。</summary>
        public T3 D3 { get; private set; }
        /// <summary>4要素目の値を取得します。</summary>
        public T4 D4 { get; private set; }
        /// <summary>5要素目の値を取得します。</summary>
        public T5 D5 { get; private set; }
        /// <summary>6要素目の値を取得します。</summary>
        public T6 D6 { get; private set; }
        /// <summary>7要素目の値を取得します。</summary>
        public T7 D7 { get; private set; }
        /// <summary>8要素目の値を取得します。</summary>
        public T8 D8 { get; private set; }
        /// <summary>9要素目の値を取得します。</summary>
        public T9 D9 { get; private set; }

        public bool Equals(Product<T1, T2, T3, T4, T5, T6, T7, T8, T9> other)
        {
            return other == null ? false : D1.Equals(other.D1)
                && D2.Equals(other.D2)
                && D3.Equals(other.D3)
                && D4.Equals(other.D4)
                && D5.Equals(other.D5)
                && D6.Equals(other.D6)
                && D7.Equals(other.D7)
                && D8.Equals(other.D8)
                && D9.Equals(other.D9);
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Product<T1, T2, T3, T4, T5, T6, T7, T8, T9>);
        }
        public override int GetHashCode()
        {
            return D1.GetHashCode()
                ^ D2.GetHashCode()
                ^ D3.GetHashCode()
                ^ D4.GetHashCode()
                ^ D5.GetHashCode()
                ^ D6.GetHashCode()
                ^ D7.GetHashCode()
                ^ D8.GetHashCode()
                ^ D9.GetHashCode();
        }
        public override string ToString()
        {
            return "(" + string.Join(", ", new object[] { D1, D2, D3, D4, D5, D6, D7, D8, D9 }) + ")";
        }
    }

    /// <summary>要素が10個の組です。</summary>
    public sealed class Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IEquatable<Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>
    {
        public Product(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10)
        {
            D1 =  v1;
            D2 =  v2;
            D3 =  v3;
            D4 =  v4;
            D5 =  v5;
            D6 =  v6;
            D7 =  v7;
            D8 =  v8;
            D9 =  v9;
            D10 =  v10;
        }

        /// <summary>1要素目の値を取得します。</summary>
        public T1 D1 { get; private set; }
        /// <summary>2要素目の値を取得します。</summary>
        public T2 D2 { get; private set; }
        /// <summary>3要素目の値を取得します。</summary>
        public T3 D3 { get; private set; }
        /// <summary>4要素目の値を取得します。</summary>
        public T4 D4 { get; private set; }
        /// <summary>5要素目の値を取得します。</summary>
        public T5 D5 { get; private set; }
        /// <summary>6要素目の値を取得します。</summary>
        public T6 D6 { get; private set; }
        /// <summary>7要素目の値を取得します。</summary>
        public T7 D7 { get; private set; }
        /// <summary>8要素目の値を取得します。</summary>
        public T8 D8 { get; private set; }
        /// <summary>9要素目の値を取得します。</summary>
        public T9 D9 { get; private set; }
        /// <summary>10要素目の値を取得します。</summary>
        public T10 D10 { get; private set; }

        public bool Equals(Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other)
        {
            return other == null ? false : D1.Equals(other.D1)
                && D2.Equals(other.D2)
                && D3.Equals(other.D3)
                && D4.Equals(other.D4)
                && D5.Equals(other.D5)
                && D6.Equals(other.D6)
                && D7.Equals(other.D7)
                && D8.Equals(other.D8)
                && D9.Equals(other.D9)
                && D10.Equals(other.D10);
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>);
        }
        public override int GetHashCode()
        {
            return D1.GetHashCode()
                ^ D2.GetHashCode()
                ^ D3.GetHashCode()
                ^ D4.GetHashCode()
                ^ D5.GetHashCode()
                ^ D6.GetHashCode()
                ^ D7.GetHashCode()
                ^ D8.GetHashCode()
                ^ D9.GetHashCode()
                ^ D10.GetHashCode();
        }
        public override string ToString()
        {
            return "(" + string.Join(", ", new object[] { D1, D2, D3, D4, D5, D6, D7, D8, D9, D10 }) + ")";
        }
    }

    /// <summary>要素が11個の組です。</summary>
    public sealed class Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IEquatable<Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>
    {
        public Product(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11)
        {
            D1 =  v1;
            D2 =  v2;
            D3 =  v3;
            D4 =  v4;
            D5 =  v5;
            D6 =  v6;
            D7 =  v7;
            D8 =  v8;
            D9 =  v9;
            D10 =  v10;
            D11 =  v11;
        }

        /// <summary>1要素目の値を取得します。</summary>
        public T1 D1 { get; private set; }
        /// <summary>2要素目の値を取得します。</summary>
        public T2 D2 { get; private set; }
        /// <summary>3要素目の値を取得します。</summary>
        public T3 D3 { get; private set; }
        /// <summary>4要素目の値を取得します。</summary>
        public T4 D4 { get; private set; }
        /// <summary>5要素目の値を取得します。</summary>
        public T5 D5 { get; private set; }
        /// <summary>6要素目の値を取得します。</summary>
        public T6 D6 { get; private set; }
        /// <summary>7要素目の値を取得します。</summary>
        public T7 D7 { get; private set; }
        /// <summary>8要素目の値を取得します。</summary>
        public T8 D8 { get; private set; }
        /// <summary>9要素目の値を取得します。</summary>
        public T9 D9 { get; private set; }
        /// <summary>10要素目の値を取得します。</summary>
        public T10 D10 { get; private set; }
        /// <summary>11要素目の値を取得します。</summary>
        public T11 D11 { get; private set; }

        public bool Equals(Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> other)
        {
            return other == null ? false : D1.Equals(other.D1)
                && D2.Equals(other.D2)
                && D3.Equals(other.D3)
                && D4.Equals(other.D4)
                && D5.Equals(other.D5)
                && D6.Equals(other.D6)
                && D7.Equals(other.D7)
                && D8.Equals(other.D8)
                && D9.Equals(other.D9)
                && D10.Equals(other.D10)
                && D11.Equals(other.D11);
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>);
        }
        public override int GetHashCode()
        {
            return D1.GetHashCode()
                ^ D2.GetHashCode()
                ^ D3.GetHashCode()
                ^ D4.GetHashCode()
                ^ D5.GetHashCode()
                ^ D6.GetHashCode()
                ^ D7.GetHashCode()
                ^ D8.GetHashCode()
                ^ D9.GetHashCode()
                ^ D10.GetHashCode()
                ^ D11.GetHashCode();
        }
        public override string ToString()
        {
            return "(" + string.Join(", ", new object[] { D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11 }) + ")";
        }
    }

    /// <summary>要素が12個の組です。</summary>
    public sealed class Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IEquatable<Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>
    {
        public Product(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12)
        {
            D1 =  v1;
            D2 =  v2;
            D3 =  v3;
            D4 =  v4;
            D5 =  v5;
            D6 =  v6;
            D7 =  v7;
            D8 =  v8;
            D9 =  v9;
            D10 =  v10;
            D11 =  v11;
            D12 =  v12;
        }

        /// <summary>1要素目の値を取得します。</summary>
        public T1 D1 { get; private set; }
        /// <summary>2要素目の値を取得します。</summary>
        public T2 D2 { get; private set; }
        /// <summary>3要素目の値を取得します。</summary>
        public T3 D3 { get; private set; }
        /// <summary>4要素目の値を取得します。</summary>
        public T4 D4 { get; private set; }
        /// <summary>5要素目の値を取得します。</summary>
        public T5 D5 { get; private set; }
        /// <summary>6要素目の値を取得します。</summary>
        public T6 D6 { get; private set; }
        /// <summary>7要素目の値を取得します。</summary>
        public T7 D7 { get; private set; }
        /// <summary>8要素目の値を取得します。</summary>
        public T8 D8 { get; private set; }
        /// <summary>9要素目の値を取得します。</summary>
        public T9 D9 { get; private set; }
        /// <summary>10要素目の値を取得します。</summary>
        public T10 D10 { get; private set; }
        /// <summary>11要素目の値を取得します。</summary>
        public T11 D11 { get; private set; }
        /// <summary>12要素目の値を取得します。</summary>
        public T12 D12 { get; private set; }

        public bool Equals(Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> other)
        {
            return other == null ? false : D1.Equals(other.D1)
                && D2.Equals(other.D2)
                && D3.Equals(other.D3)
                && D4.Equals(other.D4)
                && D5.Equals(other.D5)
                && D6.Equals(other.D6)
                && D7.Equals(other.D7)
                && D8.Equals(other.D8)
                && D9.Equals(other.D9)
                && D10.Equals(other.D10)
                && D11.Equals(other.D11)
                && D12.Equals(other.D12);
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>);
        }
        public override int GetHashCode()
        {
            return D1.GetHashCode()
                ^ D2.GetHashCode()
                ^ D3.GetHashCode()
                ^ D4.GetHashCode()
                ^ D5.GetHashCode()
                ^ D6.GetHashCode()
                ^ D7.GetHashCode()
                ^ D8.GetHashCode()
                ^ D9.GetHashCode()
                ^ D10.GetHashCode()
                ^ D11.GetHashCode()
                ^ D12.GetHashCode();
        }
        public override string ToString()
        {
            return "(" + string.Join(", ", new object[] { D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12 }) + ")";
        }
    }

    /// <summary>要素が13個の組です。</summary>
    public sealed class Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IEquatable<Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>
    {
        public Product(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13)
        {
            D1 =  v1;
            D2 =  v2;
            D3 =  v3;
            D4 =  v4;
            D5 =  v5;
            D6 =  v6;
            D7 =  v7;
            D8 =  v8;
            D9 =  v9;
            D10 =  v10;
            D11 =  v11;
            D12 =  v12;
            D13 =  v13;
        }

        /// <summary>1要素目の値を取得します。</summary>
        public T1 D1 { get; private set; }
        /// <summary>2要素目の値を取得します。</summary>
        public T2 D2 { get; private set; }
        /// <summary>3要素目の値を取得します。</summary>
        public T3 D3 { get; private set; }
        /// <summary>4要素目の値を取得します。</summary>
        public T4 D4 { get; private set; }
        /// <summary>5要素目の値を取得します。</summary>
        public T5 D5 { get; private set; }
        /// <summary>6要素目の値を取得します。</summary>
        public T6 D6 { get; private set; }
        /// <summary>7要素目の値を取得します。</summary>
        public T7 D7 { get; private set; }
        /// <summary>8要素目の値を取得します。</summary>
        public T8 D8 { get; private set; }
        /// <summary>9要素目の値を取得します。</summary>
        public T9 D9 { get; private set; }
        /// <summary>10要素目の値を取得します。</summary>
        public T10 D10 { get; private set; }
        /// <summary>11要素目の値を取得します。</summary>
        public T11 D11 { get; private set; }
        /// <summary>12要素目の値を取得します。</summary>
        public T12 D12 { get; private set; }
        /// <summary>13要素目の値を取得します。</summary>
        public T13 D13 { get; private set; }

        public bool Equals(Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> other)
        {
            return other == null ? false : D1.Equals(other.D1)
                && D2.Equals(other.D2)
                && D3.Equals(other.D3)
                && D4.Equals(other.D4)
                && D5.Equals(other.D5)
                && D6.Equals(other.D6)
                && D7.Equals(other.D7)
                && D8.Equals(other.D8)
                && D9.Equals(other.D9)
                && D10.Equals(other.D10)
                && D11.Equals(other.D11)
                && D12.Equals(other.D12)
                && D13.Equals(other.D13);
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>);
        }
        public override int GetHashCode()
        {
            return D1.GetHashCode()
                ^ D2.GetHashCode()
                ^ D3.GetHashCode()
                ^ D4.GetHashCode()
                ^ D5.GetHashCode()
                ^ D6.GetHashCode()
                ^ D7.GetHashCode()
                ^ D8.GetHashCode()
                ^ D9.GetHashCode()
                ^ D10.GetHashCode()
                ^ D11.GetHashCode()
                ^ D12.GetHashCode()
                ^ D13.GetHashCode();
        }
        public override string ToString()
        {
            return "(" + string.Join(", ", new object[] { D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13 }) + ")";
        }
    }

    /// <summary>要素が14個の組です。</summary>
    public sealed class Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IEquatable<Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>
    {
        public Product(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13, T14 v14)
        {
            D1 =  v1;
            D2 =  v2;
            D3 =  v3;
            D4 =  v4;
            D5 =  v5;
            D6 =  v6;
            D7 =  v7;
            D8 =  v8;
            D9 =  v9;
            D10 =  v10;
            D11 =  v11;
            D12 =  v12;
            D13 =  v13;
            D14 =  v14;
        }

        /// <summary>1要素目の値を取得します。</summary>
        public T1 D1 { get; private set; }
        /// <summary>2要素目の値を取得します。</summary>
        public T2 D2 { get; private set; }
        /// <summary>3要素目の値を取得します。</summary>
        public T3 D3 { get; private set; }
        /// <summary>4要素目の値を取得します。</summary>
        public T4 D4 { get; private set; }
        /// <summary>5要素目の値を取得します。</summary>
        public T5 D5 { get; private set; }
        /// <summary>6要素目の値を取得します。</summary>
        public T6 D6 { get; private set; }
        /// <summary>7要素目の値を取得します。</summary>
        public T7 D7 { get; private set; }
        /// <summary>8要素目の値を取得します。</summary>
        public T8 D8 { get; private set; }
        /// <summary>9要素目の値を取得します。</summary>
        public T9 D9 { get; private set; }
        /// <summary>10要素目の値を取得します。</summary>
        public T10 D10 { get; private set; }
        /// <summary>11要素目の値を取得します。</summary>
        public T11 D11 { get; private set; }
        /// <summary>12要素目の値を取得します。</summary>
        public T12 D12 { get; private set; }
        /// <summary>13要素目の値を取得します。</summary>
        public T13 D13 { get; private set; }
        /// <summary>14要素目の値を取得します。</summary>
        public T14 D14 { get; private set; }

        public bool Equals(Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> other)
        {
            return other == null ? false : D1.Equals(other.D1)
                && D2.Equals(other.D2)
                && D3.Equals(other.D3)
                && D4.Equals(other.D4)
                && D5.Equals(other.D5)
                && D6.Equals(other.D6)
                && D7.Equals(other.D7)
                && D8.Equals(other.D8)
                && D9.Equals(other.D9)
                && D10.Equals(other.D10)
                && D11.Equals(other.D11)
                && D12.Equals(other.D12)
                && D13.Equals(other.D13)
                && D14.Equals(other.D14);
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>);
        }
        public override int GetHashCode()
        {
            return D1.GetHashCode()
                ^ D2.GetHashCode()
                ^ D3.GetHashCode()
                ^ D4.GetHashCode()
                ^ D5.GetHashCode()
                ^ D6.GetHashCode()
                ^ D7.GetHashCode()
                ^ D8.GetHashCode()
                ^ D9.GetHashCode()
                ^ D10.GetHashCode()
                ^ D11.GetHashCode()
                ^ D12.GetHashCode()
                ^ D13.GetHashCode()
                ^ D14.GetHashCode();
        }
        public override string ToString()
        {
            return "(" + string.Join(", ", new object[] { D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14 }) + ")";
        }
    }

    /// <summary>要素が15個の組です。</summary>
    public sealed class Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IEquatable<Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>
    {
        public Product(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13, T14 v14, T15 v15)
        {
            D1 =  v1;
            D2 =  v2;
            D3 =  v3;
            D4 =  v4;
            D5 =  v5;
            D6 =  v6;
            D7 =  v7;
            D8 =  v8;
            D9 =  v9;
            D10 =  v10;
            D11 =  v11;
            D12 =  v12;
            D13 =  v13;
            D14 =  v14;
            D15 =  v15;
        }

        /// <summary>1要素目の値を取得します。</summary>
        public T1 D1 { get; private set; }
        /// <summary>2要素目の値を取得します。</summary>
        public T2 D2 { get; private set; }
        /// <summary>3要素目の値を取得します。</summary>
        public T3 D3 { get; private set; }
        /// <summary>4要素目の値を取得します。</summary>
        public T4 D4 { get; private set; }
        /// <summary>5要素目の値を取得します。</summary>
        public T5 D5 { get; private set; }
        /// <summary>6要素目の値を取得します。</summary>
        public T6 D6 { get; private set; }
        /// <summary>7要素目の値を取得します。</summary>
        public T7 D7 { get; private set; }
        /// <summary>8要素目の値を取得します。</summary>
        public T8 D8 { get; private set; }
        /// <summary>9要素目の値を取得します。</summary>
        public T9 D9 { get; private set; }
        /// <summary>10要素目の値を取得します。</summary>
        public T10 D10 { get; private set; }
        /// <summary>11要素目の値を取得します。</summary>
        public T11 D11 { get; private set; }
        /// <summary>12要素目の値を取得します。</summary>
        public T12 D12 { get; private set; }
        /// <summary>13要素目の値を取得します。</summary>
        public T13 D13 { get; private set; }
        /// <summary>14要素目の値を取得します。</summary>
        public T14 D14 { get; private set; }
        /// <summary>15要素目の値を取得します。</summary>
        public T15 D15 { get; private set; }

        public bool Equals(Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> other)
        {
            return other == null ? false : D1.Equals(other.D1)
                && D2.Equals(other.D2)
                && D3.Equals(other.D3)
                && D4.Equals(other.D4)
                && D5.Equals(other.D5)
                && D6.Equals(other.D6)
                && D7.Equals(other.D7)
                && D8.Equals(other.D8)
                && D9.Equals(other.D9)
                && D10.Equals(other.D10)
                && D11.Equals(other.D11)
                && D12.Equals(other.D12)
                && D13.Equals(other.D13)
                && D14.Equals(other.D14)
                && D15.Equals(other.D15);
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>);
        }
        public override int GetHashCode()
        {
            return D1.GetHashCode()
                ^ D2.GetHashCode()
                ^ D3.GetHashCode()
                ^ D4.GetHashCode()
                ^ D5.GetHashCode()
                ^ D6.GetHashCode()
                ^ D7.GetHashCode()
                ^ D8.GetHashCode()
                ^ D9.GetHashCode()
                ^ D10.GetHashCode()
                ^ D11.GetHashCode()
                ^ D12.GetHashCode()
                ^ D13.GetHashCode()
                ^ D14.GetHashCode()
                ^ D15.GetHashCode();
        }
        public override string ToString()
        {
            return "(" + string.Join(", ", new object[] { D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15 }) + ")";
        }
    }

    /// <summary>要素が16個の組です。</summary>
    public sealed class Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : IEquatable<Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>
    {
        public Product(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13, T14 v14, T15 v15, T16 v16)
        {
            D1 =  v1;
            D2 =  v2;
            D3 =  v3;
            D4 =  v4;
            D5 =  v5;
            D6 =  v6;
            D7 =  v7;
            D8 =  v8;
            D9 =  v9;
            D10 =  v10;
            D11 =  v11;
            D12 =  v12;
            D13 =  v13;
            D14 =  v14;
            D15 =  v15;
            D16 =  v16;
        }

        /// <summary>1要素目の値を取得します。</summary>
        public T1 D1 { get; private set; }
        /// <summary>2要素目の値を取得します。</summary>
        public T2 D2 { get; private set; }
        /// <summary>3要素目の値を取得します。</summary>
        public T3 D3 { get; private set; }
        /// <summary>4要素目の値を取得します。</summary>
        public T4 D4 { get; private set; }
        /// <summary>5要素目の値を取得します。</summary>
        public T5 D5 { get; private set; }
        /// <summary>6要素目の値を取得します。</summary>
        public T6 D6 { get; private set; }
        /// <summary>7要素目の値を取得します。</summary>
        public T7 D7 { get; private set; }
        /// <summary>8要素目の値を取得します。</summary>
        public T8 D8 { get; private set; }
        /// <summary>9要素目の値を取得します。</summary>
        public T9 D9 { get; private set; }
        /// <summary>10要素目の値を取得します。</summary>
        public T10 D10 { get; private set; }
        /// <summary>11要素目の値を取得します。</summary>
        public T11 D11 { get; private set; }
        /// <summary>12要素目の値を取得します。</summary>
        public T12 D12 { get; private set; }
        /// <summary>13要素目の値を取得します。</summary>
        public T13 D13 { get; private set; }
        /// <summary>14要素目の値を取得します。</summary>
        public T14 D14 { get; private set; }
        /// <summary>15要素目の値を取得します。</summary>
        public T15 D15 { get; private set; }
        /// <summary>16要素目の値を取得します。</summary>
        public T16 D16 { get; private set; }

        public bool Equals(Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> other)
        {
            return other == null ? false : D1.Equals(other.D1)
                && D2.Equals(other.D2)
                && D3.Equals(other.D3)
                && D4.Equals(other.D4)
                && D5.Equals(other.D5)
                && D6.Equals(other.D6)
                && D7.Equals(other.D7)
                && D8.Equals(other.D8)
                && D9.Equals(other.D9)
                && D10.Equals(other.D10)
                && D11.Equals(other.D11)
                && D12.Equals(other.D12)
                && D13.Equals(other.D13)
                && D14.Equals(other.D14)
                && D15.Equals(other.D15)
                && D16.Equals(other.D16);
        }
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Product<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>);
        }
        public override int GetHashCode()
        {
            return D1.GetHashCode()
                ^ D2.GetHashCode()
                ^ D3.GetHashCode()
                ^ D4.GetHashCode()
                ^ D5.GetHashCode()
                ^ D6.GetHashCode()
                ^ D7.GetHashCode()
                ^ D8.GetHashCode()
                ^ D9.GetHashCode()
                ^ D10.GetHashCode()
                ^ D11.GetHashCode()
                ^ D12.GetHashCode()
                ^ D13.GetHashCode()
                ^ D14.GetHashCode()
                ^ D15.GetHashCode()
                ^ D16.GetHashCode();
        }
        public override string ToString()
        {
            return "(" + string.Join(", ", new object[] { D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12, D13, D14, D15, D16 }) + ")";
        }
    }
}