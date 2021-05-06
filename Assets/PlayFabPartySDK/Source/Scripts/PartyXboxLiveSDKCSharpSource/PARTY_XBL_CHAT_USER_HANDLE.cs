﻿using System;
using PartyCSharpSDK;

namespace PartyXBLCSharpSDK
{
    public class PARTY_XBL_CHAT_USER_HANDLE
    {
        internal PARTY_XBL_CHAT_USER_HANDLE(Interop.PARTY_XBL_CHAT_USER_HANDLE interopHandle)
        {
            this.InteropHandle = interopHandle;
        }

        internal static UInt32 WrapAndReturnError(UInt32 error, Interop.PARTY_XBL_CHAT_USER_HANDLE interopHandle, out PARTY_XBL_CHAT_USER_HANDLE handle)
        {
            if (PartyError.SUCCEEDED(error))
            {
                handle = new PARTY_XBL_CHAT_USER_HANDLE(interopHandle);
            }
            else
            {
                handle = default(PARTY_XBL_CHAT_USER_HANDLE);
            }
            return error;
        }

        internal void ClearInteropHandle()
        {
            this.InteropHandle = new Interop.PARTY_XBL_CHAT_USER_HANDLE();
        }

        internal Interop.PARTY_XBL_CHAT_USER_HANDLE InteropHandle { get; set; }
    }
}
