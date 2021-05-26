﻿using System;
using PartyCSharpSDK.Interop;

namespace PartyCSharpSDK
{
    //typedef enum PARTY_STATE_CHANGE_RESULT
    //{
    //    PARTY_STATE_CHANGE_RESULT_SUCCEEDED,
    //    PARTY_STATE_CHANGE_RESULT_UNKNOWN_ERROR,
    //    PARTY_STATE_CHANGE_RESULT_CANCELED_BY_TITLE,
    //    PARTY_STATE_CHANGE_RESULT_INTERNET_CONNECTIVITY_ERROR,
    //    PARTY_STATE_CHANGE_RESULT_PARTY_SERVICE_ERROR,
    //    PARTY_STATE_CHANGE_RESULT_NO_SERVERS_AVAILABLE,
    //    PARTY_STATE_CHANGE_RESULT_USER_NOT_AUTHORIZED,
    //    PARTY_STATE_CHANGE_RESULT_USER_CREATE_NETWORK_THROTTLED,
    //    PARTY_STATE_CHANGE_RESULT_TITLE_NOT_ENABLED_FOR_PARTY,
    //    PARTY_STATE_CHANGE_RESULT_NETWORK_LIMIT_REACHED,
    //    PARTY_STATE_CHANGE_RESULT_NETWORK_NO_LONGER_EXISTS,
    //    PARTY_STATE_CHANGE_RESULT_NETWORK_NOT_JOINABLE,
    //    PARTY_STATE_CHANGE_RESULT_VERSION_MISMATCH,
    //    PARTY_STATE_CHANGE_RESULT_LEAVE_NETWORK_CALLED,
    //    PARTY_STATE_CHANGE_RESULT_FAILED_TO_BIND_TO_LOCAL_UDP_SOCKET,
    //}
    //PARTY_STATE_CHANGE_RESULT;
    public enum PARTY_STATE_CHANGE_RESULT : UInt32
    {
        PARTY_STATE_CHANGE_RESULT_SUCCEEDED,
        PARTY_STATE_CHANGE_RESULT_UNKNOWN_ERROR,
        PARTY_STATE_CHANGE_RESULT_CANCELED_BY_TITLE,
        PARTY_STATE_CHANGE_RESULT_INTERNET_CONNECTIVITY_ERROR,
        PARTY_STATE_CHANGE_RESULT_PARTY_SERVICE_ERROR,
        PARTY_STATE_CHANGE_RESULT_NO_SERVERS_AVAILABLE,
        PARTY_STATE_CHANGE_RESULT_USER_NOT_AUTHORIZED,
        PARTY_STATE_CHANGE_RESULT_USER_CREATE_NETWORK_THROTTLED,
        PARTY_STATE_CHANGE_RESULT_TITLE_NOT_ENABLED_FOR_PARTY,
        PARTY_STATE_CHANGE_RESULT_NETWORK_LIMIT_REACHED,
        PARTY_STATE_CHANGE_RESULT_NETWORK_NO_LONGER_EXISTS,
        PARTY_STATE_CHANGE_RESULT_NETWORK_NOT_JOINABLE,
        PARTY_STATE_CHANGE_RESULT_VERSION_MISMATCH,
        PARTY_STATE_CHANGE_RESULT_LEAVE_NETWORK_CALLED,
        PARTY_STATE_CHANGE_RESULT_FAILED_TO_BIND_TO_LOCAL_UDP_SOCKET,
    }
}