using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Ogreman;

public class Canvas
{
    private RenderTarget2D _target;
    private Rectangle _destinationRectangle;
    private GraphicsDevice _graphicsDevice;

    public Canvas(GraphicsDevice graphicsDevice, int width, int height)
    {
        _graphicsDevice = graphicsDevice;
        _target = new RenderTarget2D(_graphicsDevice, width, height);
    }

    public void SetDestinationRectangle()
    {
        var screen = _graphicsDevice.PresentationParameters.Bounds;
        var scaleX = (float)screen.Width / _target.Width;
        var scaleY = (float)screen.Height / _target.Height;
        var scale = Math.Min(scaleX, scaleY);

        var newWidth = (int)(_target.Width * scale);
        var newHeight = (int)(_target.Height * scale);

        var posX = (screen.Width - newWidth) / 2;
        var posY = (screen.Height - newHeight) / 2;

        _destinationRectangle = new Rectangle(posX, posY, newWidth, newHeight);
    }

    public void Activate()
    {
        _graphicsDevice.SetRenderTarget(_target);
        _graphicsDevice.Clear(Color.DarkGray);
    }

    public void Render(SpriteBatch spriteBatch)
    {
        _graphicsDevice.SetRenderTarget(null);
        _graphicsDevice.Clear(Color.Black);
        spriteBatch.Begin();
        spriteBatch.Draw(_target, _destinationRectangle, Color.White);
        spriteBatch.End();
    }
}