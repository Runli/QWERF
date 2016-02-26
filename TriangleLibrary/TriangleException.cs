using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriangleLibrary {
    public class TriangleException : Exception {
        private   string p;
        public TriangleException() : base() { }
        public TriangleException(string p) {
            // TODO: Complete member initialization
            this.p = p;
        }
    }
}
