using System;

namespace RocksDbSharp
{
    public class NativePackage
    {
        public static string GetCodeBase()
#if NETSTANDARD2_0
            => AppContext.BaseDirectory;
#else
            => AppDomain.CurrentDomain.BaseDirectory;
#endif
    }
}
