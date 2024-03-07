using System;
using System.Collections.Generic;
using System.Text;

namespace _3_4
{
    interface IElChoice<T>
    {
        T UserEl();

        T RndEl();
    }
}
