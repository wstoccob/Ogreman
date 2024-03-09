using System.Collections.Generic;
using Microsoft.Xna.Framework.Content;

namespace Ogreman.Scenes;

public class SceneManager
{
    private readonly Stack<IScene> scenes;
    public SceneManager()
    {
        scenes = new();
    }
    
    public void AddScene(IScene scene)
    {
        scenes.Push(scene);
    }

    public IScene GetActiveScene()
    {
        return scenes.Peek();
    }

    public IScene RemoveScene()
    {
        return scenes.Pop();
    }
}