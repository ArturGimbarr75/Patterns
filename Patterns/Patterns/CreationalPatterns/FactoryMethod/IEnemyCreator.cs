using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.CreationalPatterns.FactoryMethod
{
    interface IEnemyCreator
    {
        public Enemy CreateEnemy(float health, float energy);
    }

    class ArcherCreator : IEnemyCreator
    {
        public Enemy CreateEnemy(float health, float energy)
        {
            return new Archer()
            {
                Health = health,
                Energy = energy
            };
        }
    }

    class SwordsmanCreator : IEnemyCreator
    {
        public Enemy CreateEnemy(float health, float energy)
        {
            return new Swordsman()
            {
                Health = health,
                Energy = energy
            };
        }
    }

}
