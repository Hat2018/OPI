using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public sealed class Singleton
{
    
    private Singleton() { }
    private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
    
        public static Singleton Source { get { return lazy.Value; } }
}
    
