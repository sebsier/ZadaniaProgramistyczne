using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniaProgramistyczne.Okablowanie
{
    public interface ITestable<T1>
    {
        string Test(T1 input);
        T1 WygenerujDaneWejsciowe();
    }
}
