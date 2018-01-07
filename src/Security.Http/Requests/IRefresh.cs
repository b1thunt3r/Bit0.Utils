﻿using System;

namespace Bit0.Utils.Security.Http.Requests
{
    /// <summary>
    /// Refresh token request
    /// </summary>
    public interface IRefresh
    {
        /// <summary>
        /// Refresh Token
        /// </summary>
        String Token { get; set; }
    }
}