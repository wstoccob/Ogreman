using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Ogreman.Scenes;

public interface IScene
{
    public void Load() { }
    
    public void Update(GameTime gameTime) { }
    
    public void Draw(SpriteBatch spriteBatch) { }
    
}