﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr5
{
    interface IRateAndCopy
    {
        double Score
        {
            get;
        }
        object DeepCopy();
    }
}
