using System;

namespace Extensions
{
    //Option<T> = Variant<T, Unit>
    public sealed class Option<T> 
    {
        private Variant<T, Unit> variant;
        private Option(Variant<T, Unit> variant)
        {
            this.variant = variant;
        }

        public static Option<T> Some(T value)
        {
            return new Option<T>(Variant<T, Unit>.C1(value));
        }
        public static Option<T> None()
        {
            return new Option<T>(Variant<T, Unit>.C2(Unit.New()));  
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
