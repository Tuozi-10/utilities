using AudioService;
using GameService;
using src.IOC;
using src.Log;
using src.Singletons;
using UnityEngine;

public class Test : MonoSingleton<Test>
{
    // Start is called before the first frame update
    void Start()
    {
        Logs.Log("Hello world");
        Logs.Log("Message", "Hello world", LogType.Error, Logs.LogColors.Red, Logs.LogColors.Blue);
        var compositor = new Compositor();
        compositor.AssignService<IGameService>(new GameService.GameService());
        compositor.AssignService<IAudioService>(new AudioService.AudioService());
        compositor.StartComposition();
    }
    
}
