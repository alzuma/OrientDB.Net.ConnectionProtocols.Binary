﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrientDB.Net.ConnectionProtocols.Binary.Operations
{
    internal class VoidOperationResult
    {
        public bool IsSuccess { get; } = true;
    }
}
