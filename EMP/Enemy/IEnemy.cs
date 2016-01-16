using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace EMP
{
    interface IEnemy
    {
        Texture2D Texture { get; set; }
        Vector2 Position { get; set; }

        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
