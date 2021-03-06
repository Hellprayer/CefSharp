﻿using System.IO;

namespace CefSharp
{
    public interface IRequestResponse
    {
        // TODO: Improve these comments.

        /// cancel the request, return nothing
        void Cancel();

        /// the current request
        IRequest Request { get; }

        /// respond with redirection to the provided URL
        void Redirect(string url);

        /// respond with data from Stream
        void RespondWith(Stream stream, string mimeType);
    }
}
