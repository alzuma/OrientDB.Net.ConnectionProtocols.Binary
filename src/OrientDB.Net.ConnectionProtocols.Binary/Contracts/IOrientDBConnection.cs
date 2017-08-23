﻿using OrientDB.Net.Core.Abstractions;

namespace OrientDB.Net.ConnectionProtocols.Binary.Contracts
{
    internal interface IOrientDBConnection
    {
        IOrientDBCommand CreateCommand();
        IOrientDBTransaction CreateTransaction();
    }
}