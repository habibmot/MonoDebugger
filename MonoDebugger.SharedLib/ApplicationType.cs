﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MonoDebugger.SharedLib
{
    [DataContract]
    public enum ApplicationType
    {
        [EnumMember]
        Desktopapplication,
        [EnumMember]
        Webapplication
    }
}