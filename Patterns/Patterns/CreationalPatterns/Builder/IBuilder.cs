using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.CreationalPatterns.Builder
{
    interface IBuilder
    {
        void Reset();
        void AddSalami();
        void AddCheese();
        void AddKetchup();
        void AddMayonnaise();
        void AddChilli();
        void AddPepper();
        void AddPineapple();
        void AddBacon();
    }
}
