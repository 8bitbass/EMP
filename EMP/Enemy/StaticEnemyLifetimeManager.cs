using System.Collections.Generic;

namespace EMP
{
    class StaticEnemyLifetimeManager
    {
        private List<BoringEnemy> activeEnemies;
        private List<BoringEnemy> inactiveEnemies;
        private static List<IEnemy> activeEnemies = new List<IEnemy>();
        private static List<IEnemy> inactiveEnemies = new List<IEnemy>();

        void Update()
        {
            
        }
    }
}
