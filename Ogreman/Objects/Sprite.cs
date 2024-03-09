using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Ogreman.Objects;

public class Sprite
{
    private Texture2D _texture;
    private Vector2 Position;

    private Rectangle _rectangle => new((int)Position.X, (int)Position.Y, _texture.Width, _texture.Height);

    public Sprite(Texture2D texture, Vector2 position)
    {
        _texture = texture;
        Position = position;
    }

    public void Render(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(_texture, Position, Color.White);
    }
}