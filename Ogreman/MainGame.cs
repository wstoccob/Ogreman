using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Ogreman.Objects;
using Ogreman.Scenes;

namespace Ogreman;

public class MainGame : Game
{
    private const int TargetWidth = 640;
    private const int TargetHeight = 360;

    private const int WindowWidth = 1280;
    private const int WindowHeight = 720;
    
    private readonly GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private Canvas _canvas;

    private SceneManager _sceneManager;

    public MainGame()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
        _sceneManager = new SceneManager();
    }

    protected override void Initialize()
    {
        SetResolution(_graphics, WindowWidth, WindowHeight);
        
        _canvas = new Canvas(_graphics.GraphicsDevice, TargetWidth, TargetHeight);
        _sceneManager.AddScene(new StartScene(Content, _sceneManager));
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        _sceneManager.GetActiveScene().Load();

    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();
        
        _sceneManager.GetActiveScene().Update(gameTime);
        
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        _canvas.Activate();
        
        _spriteBatch.Begin(samplerState: SamplerState.PointClamp);
        
        _sceneManager.GetActiveScene().Draw(_spriteBatch);
        
        _spriteBatch.End();
        
        _canvas.Render(_spriteBatch);
        
        base.Draw(gameTime);
    }

    private void SetResolution(GraphicsDeviceManager graphics, int width, int height)
    {
        graphics.PreferredBackBufferWidth = width;
        graphics.PreferredBackBufferHeight = height;
        graphics.ApplyChanges();
    }

    private Texture2D LoadTexture2D(string assetName)
    {
        return Content.Load<Texture2D>(assetName);
    }
}
