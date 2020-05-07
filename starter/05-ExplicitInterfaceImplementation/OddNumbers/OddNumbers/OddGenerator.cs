﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumbers
{
    public class OddGenerator : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            int i = 1;
            yield return i;
            while (true)
            {
                i += 2;
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
