﻿using System;
using System.Runtime.InteropServices;

namespace PartyCSharpSDK.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct PARTY_INVITATION_HANDLE
    {
        private readonly IntPtr handle;
    }
}
