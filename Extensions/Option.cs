using System;

namespace Extensions
{
    //Option<T> = Variant<T, Product>
    public sealed class Option<T> 
    {
        private Variant<T, Product> variant;
        private Option(Variant<T, Product> variant)
        {
            this.variant = variant;
        }

        public static Option<T> Some(T value)
        {
            return new Option<T>(Variant<T, Product>.C1(value));
        }
        public static Option<T> None()
        {
            return new Option<T>(Variant<T, Product>.C2(Product.Creat()));  
        }
        public TResult Match<TResult>(Func<T, TResult> Some, Func<TResult> None)
        {
            return variant.Match(Some,None.Tuplize());
        }
    }

    public static class Option
    {
        public static Option<T> Some<T>(T value) 
        { 
            return Option<T>.Some(value);
        }
        public static Option<T> None<T>() 
        {
            return Option<T>.None(); 
        }
    }
}
