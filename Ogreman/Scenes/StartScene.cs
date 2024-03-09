using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Ogreman.Objects;
using Ogreman.Scenes.Base;

namespace Ogreman.Scenes;

public class StartScene : IScene
{
    private readonly ContentManager _contentManager;
    private Sprite startSceneBackground;
    private SceneManager _sceneManager;
    public StartScene(ContentManager contentManager, SceneManager sceneManager)
    {
        _contentManager = contentManager;
        _sceneManager = sceneManager;
    }

    public void Load()
    {
        startSceneBackground = new Sprite(_contentManager.Load<Texture2D>("backgroundPicture"), 
            new Vector2(0, 0));
    }

    public void Update(GameTime gameTime)
    {
        if (Keyboard.GetState().IsKeyDown(Keys.Space))
        {
            _sceneManager.AddScene(new GameScene(_contentManager, _sceneManager));
        }
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        startSceneBackground.Render(spriteBatch);
    }
}