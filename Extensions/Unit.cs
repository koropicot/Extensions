using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extensions
{
    /// <summary>要素が唯一の型</summary>
    public class Unit
    {
        public static Unit New() { return new Unit(); }
        private Unit() { }
    }
}
