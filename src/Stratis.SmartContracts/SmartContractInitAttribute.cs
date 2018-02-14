﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Stratis.SmartContracts
{
    /// <summary>
    /// This attribute specifies the method that should be called when a contract is first created.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class SmartContractInitAttribute : Attribute
    {
    }
}