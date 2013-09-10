using System;
using System.Collections.Generic;
using System.Linq;

namespace Extensions
{
    //ConsList<T> = Variant<Product,Product<T,ConsList<T>>>
    public sealed class ConsList<T> : IEnumerable<T>
    {
        private Variant<Product, Product<T, ConsList<T>>> variant;
        private ConsList(Variant<Product, Product<T, ConsList<T>>> variant) 
        {
            this.variant = variant;
        }

        internal static ConsList<T> Nil()
        {
            return new ConsList<T>(Variant<Product, Product<T, ConsList<T>>>.C1(Product.Create())); ;
        }
        internal static ConsList<T> Cons(T head, ConsList<T> tail)
        {
            return new ConsList<T>(Variant<Product, Product<T, ConsList<T>>>.C2(Product.Create(head, tail)));
        }
        public TResult Match<TResult>(Func<TResult> Nil, Func<T, ConsList<T>, TResult> Cons)
        {
            return variant.Match(Nil.Tuplize(), Cons.Tuplize());
        }
    
        public IEnumerator<T> GetEnumerator()
        {
            return 
                Ex.Unfold(this,cl => cl.Match(
                    Nil: () => Option.None<Product<T, ConsList<T>>>(),
                    Cons: (h, t) => Option.Some(Product.Create(h, t))))
                .GetEnumerator();
        }  
        
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public static class ConsList
    {
        public static ConsList<T> Cons<T>(T head, ConsList<T> tail)
        {
            return ConsList<T>.Cons(head, tail);
        }
        public static ConsList<T> Nil<T>()
        {
            return ConsList<T>.Nil();
        }

        public static TResult Fold<T, TResult>(this ConsList<T> list, Func<TResult> nil, Func<T, TResult, TResult> cons)
        {
            return list.Match(nil, (t, l) => cons(t, l.Fold(nil, cons)));
        }
        public static ConsList<T> ToConsList<T>(this IEnumerable<T> seq)
        {
            return seq.Any() ? ConsList<T>.Cons(seq.First(), seq.Skip(1).ToConsList()) : ConsList<T>.Nil();
        }
    }
}
