using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Hockey.Tournament.RNHockeyTournament
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNHockeyTournamentModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNHockeyTournamentModule"/>.
        /// </summary>
        internal RNHockeyTournamentModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNHockeyTournament";
            }
        }
    }
}
