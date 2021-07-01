﻿// <copyright file="IMessage.cs" company="Okta, Inc">
// Copyright (c) 2020 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

using Okta.Sdk.Abstractions;

namespace Okta.Idx.Sdk
{
    /// <summary>
    /// An interface to represent a sigle Idx message.
    /// </summary>
    public interface IMessage : IResource
    {
        string Text { get; }

        IIdxI18n I18n { get; }
    }
}
