﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace SteamLib
{
    class ConfigServerDSClient : DSClient
    {
        public IPEndPoint[] GetContentServerList( IPEndPoint endPoint )
        {
            return this.GetServerList( endPoint, EServerType.ConfigServer, null );
        }
    }
}