using System;

namespace Extensions
{
    //Either<TLeft,TRight> = Variant<TLeft,TRight>
    public sealed class Either<TLeft, TRight> {
        private Variant<TLeft, TRight> variant;
        private Either(Variant<TLeft, TRight> variant)
        {
            this.variant = variant;
        }

        public static Either<TLeft, TRight> Left(TLeft left)
        {
            return new Either<TLeft, TRight>(Variant<TLeft, TRight>.C1(left));
        }
        public static Either<TLeft, TRight> Right(TRight right)
        {
            return new Either<TLeft, TRight>(Variant<TLeft, TRight>.C2(right));
        }
        public TResult Match<TResult>(Func<TLeft, TResult> Left, Func<TRight, TResult> Right)
        {
            return variant.Match(Left, Right);
        }
    }

    public static class Either
    {
        public static Either<TLeft, TRight> Left<TLeft, TRight>(TLeft value)
        {
            return Either<TLeft, TRight>.Left(value);
        }
        public static Either<TLeft, TRight> Right<TLeft, TRight>(TRight value)
        {
            return Either<TLeft, TRight>.Right(value);
        }
    }

}
