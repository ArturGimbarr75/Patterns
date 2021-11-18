using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.CreationalPatterns.FactoryMethod
{
    class Enemy
    {
        string EnemyType { get => GetType().Name; }
        public float Health { get; set; }
        public float Energy { get; set; }
        public void AttackPlayer()
        {
            Console.WriteLine($"{EnemyType} damage: { (float)(Energy * Health / 100.0) }");
        }
    }

    class Archer : Enemy { }

    class Swordsman : Enemy { }
}
