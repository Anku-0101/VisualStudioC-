using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialTest st = new SerialTest();
            st.SerializeNow();
            st.DeserializeNow();
        }
    }
}
