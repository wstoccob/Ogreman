﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Ogreman.Objects;

public class Object
{
    private Texture2D _texture;
    private Vector2 Position;

    public Object(Texture2D texture, Vector2 position)
    {
        _texture = texture;
        Position = position;
    }

    public void Render(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(_texture, Position, Color.White);
    }
}