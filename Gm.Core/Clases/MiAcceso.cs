﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class MiAcceso
    {
        public int ID { get; set; }
        public int IDParent { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
    }
}
