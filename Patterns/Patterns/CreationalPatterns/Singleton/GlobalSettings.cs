using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.CreationalPatterns.Singleton
{
    class GlobalSettings
    {
        private static GlobalSettings Instance;
        private GlobalSettings() { }

        public static GlobalSettings GetInstance() => Instance ?? (Instance = new GlobalSettings());

        public bool IsSoundsOn = true;
        public bool IsDarkModeOn = true;
    }
}
