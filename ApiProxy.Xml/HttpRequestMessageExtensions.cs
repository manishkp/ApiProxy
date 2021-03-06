﻿using System;
using System.Net.Http;

namespace DD.ApiProxy.Xml
{
    public static class HttpRequestMessageExtensions
    {
        public static bool IsContentMediaTypeXml(this HttpRequestMessage request)
        {
            return IsContentMediaType(request, "application/xml") || IsContentMediaType(request, "text/xml");
        }

        public static bool IsContentMediaType(this HttpRequestMessage request, string typestring)
        {
            return string.Equals(request?.Content?.Headers?.ContentType.MediaType, typestring, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}