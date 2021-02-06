﻿using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace GenericScale
{
    class EqualityScale<T>
    {

        private T left;
        private T right;

        public EqualityScale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public bool AreEqual()
        {

            return this.left.Equals(this.right);
        
        }
    }
}
