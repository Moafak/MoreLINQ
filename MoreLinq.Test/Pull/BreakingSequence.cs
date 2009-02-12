﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoreLinq.Test.Pull
{
    /// <summary>
    /// Enumerable sequence which throws InvalidOperationException as soon as its
    /// enumerator is requested. Used to check lazy evaluation.
    /// </summary>
    internal class BreakingSequence<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new InvalidOperationException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}