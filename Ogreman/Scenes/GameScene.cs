using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Ogreman.Objects;

namespace Ogreman.Scenes;

public class GameScene : IScene
{
    private readonly ContentManager _contentManager;
    private readonly SceneManager _sceneManager;
    public GameScene(ContentManager contentManager, SceneManager sceneManager)
    {
        _contentManager = contentManager;
        _sceneManager = sceneManager;
    }

    public void Load()
    {
        
    }

    public void Update(GameTime gameTime)
    {
        
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        
    }
}