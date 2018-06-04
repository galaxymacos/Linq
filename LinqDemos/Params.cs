using System.Collections;
using System.Collections.Generic;

namespace LinqDemos
{
    public class Params : IEnumerable<int>
    {
        private readonly int a;
        private readonly int b;
        private readonly int c;

        public Params(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        // want to use for-each to 
        public IEnumerator<int> GetEnumerator()
        {
            yield return a;
            yield return b;
            yield return c;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}