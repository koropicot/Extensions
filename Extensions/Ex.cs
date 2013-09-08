using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extensions
{
    public static class Ex
    {
        /// <summary>IEnumerableに対するForEachです。</summary>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            source.Select(t => { action(t); return 0; }).ToArray();
        }

        /// <summary>IEnumerableに対するカウンタ付きForEachです。</summary>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T, int> action)
        {
            source.Select((t, i) => { action(t, i); return 0; }).ToArray();
        }

        /// <summary>Actionと引数の順番を入れ替え、引数を返すことでメソッドチェーンに組み込みやすくします。</summary>
        public static T Act<T>(this T arg, Action<T> action)
        {
            action(arg);
            return arg;
        }

        /// <summary>Funcと引数の順番を入れ替え、メソッドチェーンに組み込みやすくします。</summary>
        public static TResult Apply<T, TResult>(this T arg, Func<T, TResult> func)
        {
            return func(arg);
        }

        /// <summary>初期値と前の状態から次の要素と状態を生成する関数によってシーケンスを生成します。</summary>
        public static IEnumerable<T> Unfold<T, TState>(TState seed, Func<TState, Option<Tuple<T, TState>>> func)
        {
            var state = seed;
            var loop = false;
            do
            {
                var ret = func(state).Match(
                    Some: a => { loop = true; state = a.Item2; return a.Item1; },
                    None: () => { loop = false; return default(T); });
                if (loop)
                    yield return ret;
            } while (loop);
        }

        /// <summary>シーケンスの末尾に要素を追加します。</summary>
        public static IEnumerable<T> AddTail<T>(this T head, IEnumerable<T> tail)
        {
            yield return head;
            foreach (var x in tail)
                yield return x;
        }

        /// <summary>ストリームを畳み込みながら途中結果を列挙します。</summary>
        public static IEnumerable<TState> Scan<TSource, TState>
            (this IEnumerable<TSource> source, TState seed, Func<TState, TSource, TState> func)
        {
            var state = seed;
            return source.Select(item => state = func(state, item));
        }

        /// <summary>関数をメモ化します。</summary>
        public static Func<T, TResult> Memoize<T, TResult>(this Func<T, TResult> func)
        {
            var memo = new Dictionary<T, TResult>();
            return t =>
            {
                TResult result;
                if (memo.TryGetValue(t, out result))
                    return result;
                else
                {
                    memo[t] = func(t);
                    return memo[t];
                }
            };
        }

        /// <summary>Dictionaryから値を取り出します。値がない場合指定の関数の戻り値を返します。</summary>
        public static TValue GetValueOr<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key, Func<TValue> notContainsValue)
        {
            TValue o;
            return dict.TryGetValue(key, out o)
                ? o
                : notContainsValue();
        }

        /// <summary>シーケンスをisSplit関数がTrueを返す要素で分割します。</summary>
        public static IEnumerable<IEnumerable<T>> Split<T>(this IEnumerable<T> source, Func<T, bool> isSplit)
        {
            var rest = source;
            while (rest.Any())
            {
                yield return rest.TakeWhile(t => !isSplit(t));
                rest = rest.SkipWhile(t => !isSplit(t)).Skip(1);
            }
        }

        /// <summary>２つのシーケンスが一致する長さを取得します。</summary>
        public static int MatchLength<T>(this IEnumerable<T> first, IEnumerable<T> second)
            where T : IEquatable<T>
        {
           return first.Zip(second, (f, s) => new { f, s }).TakeWhile(a => a.f.Equals(a.s)).Count();
        }

        /// <summary>文字列を改行を考慮してインデントします。</summary>
        public static string Indent(this string source, int indent)
        {
            return source.Split('\n')
                .Select(line => Enumerable.Repeat(' ', indent).Apply(string.Concat) + line)
                .Apply(lines=>string.Join("\n",lines));
        }
    }
}