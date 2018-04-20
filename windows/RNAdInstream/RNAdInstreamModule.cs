using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Ad.Instream.RNAdInstream
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNAdInstreamModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNAdInstreamModule"/>.
        /// </summary>
        internal RNAdInstreamModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNAdInstream";
            }
        }
    }
}
