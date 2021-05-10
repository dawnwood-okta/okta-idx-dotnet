﻿// <copyright file="AuthenticationResponse.cs" company="Okta, Inc">
// Copyright (c) 2020 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

using System.Collections.Generic;

namespace Okta.Idx.Sdk
{
    /// <summary>
    /// This class represents the authentication response.
    /// </summary>
    public class AuthenticationResponse : Resource, IAuthenticationResponse
    {
        /// <summary>
        /// Gets or sets the Token Info.
        /// </summary>
        public ITokenResponse TokenInfo { get; set; }

        /// <summary>
        /// Gets or sets the authentication status.
        /// </summary>
        public AuthenticationStatus AuthenticationStatus { get; set; }

        /// <summary>
        /// Gets or sets the IDX context.
        /// </summary>
        public IIdxContext IdxContext { get; set; }

        /// <summary>
        /// Gets or sets the authenticators.
        /// </summary>
        public IList<IAuthenticator> Authenticators { get; set; }

        ///// <summary>
        ///// Gets or sets the authenticator enrollments.
        ///// </summary>
        //public IList<IAuthenticatorEnrollment> AuthenticatorEnrollments { get; set; }

        /// <summary>
        /// Gets or sets the current authenticator enrollment.
        /// </summary>
        public IAuthenticator CurrentAuthenticatorEnrollment { get; set; }
    }
}
