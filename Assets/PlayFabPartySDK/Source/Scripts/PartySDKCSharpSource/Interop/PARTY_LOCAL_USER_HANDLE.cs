﻿using System;
using System.Runtime.InteropServices;

namespace PartyCSharpSDK.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct PARTY_LOCAL_USER_HANDLE
    {
        private readonly IntPtr handle;
    }
}
