using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.CreationalPatterns.FactoryMethod
{
    class EntryPoint
    {
        public static void TestPattern()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Factory method\n");
            Console.ResetColor();

            Test(new SwordsmanCreator());
            Test(new ArcherCreator());
        }

        static void Test(IEnemyCreator enemyCreator)
        {
            enemyCreator.CreateEnemy(50, 100).AttackPlayer();
        }

    }
}
