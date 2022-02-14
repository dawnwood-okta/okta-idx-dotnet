﻿// <copyright file="EnrollOktaVerifyAuthenticatorOptions.cs" company="Okta, Inc">
// Copyright (c) 2020 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

namespace Okta.Idx.Sdk
{
    /// <summary>
    /// Options to entroll in Okta Verify.
    /// </summary>
    public class EnrollOktaVerifyAuthenticatorOptions : SelectEnrollAuthenticatorOptions
    {
        /// <summary>
        /// Gets or sets the enrollment channel.
        /// </summary>
        public string Channel { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
