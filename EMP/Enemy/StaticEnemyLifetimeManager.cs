using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace EMP
{
    static class StaticEnemyLifetimeManager
    {
        private static List<IEnemy> activeEnemies = new List<IEnemy>();
        private static List<IEnemy> inactiveEnemies = new List<IEnemy>();

        public static void SpawnEnemy(Texture2D tex, Vector2 vec2)
        {
            BoringEnemy temp = new BoringEnemy();
            temp.Texture = tex;
            temp.Position = vec2;
            activeEnemies.Add(temp);
        }

        public static void Update()
        {
            foreach (var enemy in activeEnemies)
            {
                enemy.Update();
            }
        }

        public static void Draw(SpriteBatch spriteBatch)
        {
            foreach (var enemy in activeEnemies)
            {
                enemy.Draw(spriteBatch);
            }
        }
    }
}
