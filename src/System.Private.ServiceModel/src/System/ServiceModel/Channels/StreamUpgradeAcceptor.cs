// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.IO;

namespace System.ServiceModel.Channels
{
    public abstract class StreamUpgradeAcceptor
    {
        protected StreamUpgradeAcceptor()
        {
        }

        public abstract bool CanUpgrade(string contentType);

        public virtual Stream AcceptUpgrade(Stream stream)
        {
            return EndAcceptUpgrade(BeginAcceptUpgrade(stream, null, null));
        }

        public abstract IAsyncResult BeginAcceptUpgrade(Stream stream, AsyncCallback callback, object state);
        public abstract Stream EndAcceptUpgrade(IAsyncResult result);
    }
}
