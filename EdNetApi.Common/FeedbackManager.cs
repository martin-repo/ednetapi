﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeedbackManager.cs" company="Martin Amareld">
//   Copyright(c) 2017 Martin Amareld. All rights reserved. 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace EdNetApi.Common
{
    using System;
    using System.Threading.Tasks;

    using SharpRaven;
    using SharpRaven.Data;

    public static class FeedbackManager
    {
        private static RavenClient ravenClient;

        public static void Initialize(bool allowAnonymousErrorFeedback)
        {
            if (allowAnonymousErrorFeedback && ravenClient == null)
            {
                ravenClient = new RavenClient(
                    "https://30fdef43059c4140b548b963fccc339a:1cf2e03a994940b5afa228f41f25ed6f@sentry.io/206498");
            }
        }

        public static void SendFeedback(Func<string> messageFunc)
        {
            try
            {
                //ravenClient?.Capture(new SentryEvent(messageFunc()));
            }
            catch
            {
                // Feedback not possible
            }
        }
    }
}