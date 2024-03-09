using System.Collections.Generic;

namespace Ogreman.Scenes.Base;

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