// WidgetOptions.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI {

    /// <summary>
    /// Options used to initialize or customize Widget.
    /// </summary>
    [ScriptImport]
    [ScriptIgnoreNamespace]
    [ScriptName("Object")]
    public  class WidgetOptions {

        public WidgetOptions() {
        }

        public WidgetOptions(params object[] nameValuePairs) {
        }

        /// <summary>
        /// This event is triggered when the widget is created.
        /// </summary>
        [ScriptField]
        public jQueryEventHandler Create {
             get {
                return null;
             }
             set {
             }
        }

        /// <summary>
        /// Disables the widget if set to true.
        /// </summary>
        [ScriptField]
        public bool Disabled {
            get {
                return false;
            }
            set {
            }
        }
    }
}
