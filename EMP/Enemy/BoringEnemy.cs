using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace EMP
{
    class BoringEnemy : IEnemy
    {
        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }

        public void Update()
        {
            
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            // how to add scale to a texture when you don't need rotation
            spriteBatch.Draw(Texture, Position, null, Color.White, 10, new Vector2(Texture.Width /2, Texture.Height/2) /*rotation point*/, 0.1f/*scale*/, SpriteEffects.None, 0f);
        }
    }
}
