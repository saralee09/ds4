﻿using Laboratorio88;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio8
{
    internal class ClaseConcreta1 : ClaseAbstracta
    {
        protected override string tomarValor()
        {
            return "ClaseConcreta1";
        }
        public override string prefixValor(string prefix)
        {
            return $"{prefix}ClaseConcreta1";
        }
    }
}