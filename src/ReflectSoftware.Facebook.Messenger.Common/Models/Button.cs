﻿// ReflectSoftware.Facebook
// Copyright (c) 2016 ReflectSoftware Inc.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information. 

using Newtonsoft.Json;

namespace ReflectSoftware.Facebook.Messenger.Common.Models
{
    public abstract class Button
    {
        public Button(string type)
        {
            Type = type;
        }

        /// <summary>
        /// Value is web_url, postback, phone_number, element_share, payment
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }
    }
}
