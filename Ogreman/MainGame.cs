using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Ogreman.Objects;

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

    private Sprite _backgroundPicture;

    public MainGame()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        SetResolution(_graphics, WindowWidth, WindowHeight);
        
        _canvas = new Canvas(_graphics.GraphicsDevice, TargetWidth, TargetHeight);
        _backgroundPicture = new Sprite(LoadTexture2D("backgroundPicture"), new Vector2(0, 0));
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();
        
        
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        _canvas.Activate();
        
        _spriteBatch.Begin(samplerState: SamplerState.PointClamp);
        
        _backgroundPicture.Render(_spriteBatch);
        
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
