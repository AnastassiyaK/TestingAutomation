using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_test.Tests
{
    class StringForAdding : IEnumerable
    {
            public IEnumerator GetEnumerator()
            {
                yield return new string[] { "Аленка", "Арахисовая"};
                //yield return new object[] { "Аленка", "Арахисовая"};

            }

    }
}
