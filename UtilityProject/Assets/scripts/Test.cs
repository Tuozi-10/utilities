using AudioService;
using Core.Scripts.Utils;
using GameService;
using Service;

public class Test : MonoSingleton<Test>
{
    // Start is called before the first frame update
    void Start()
    {
        Logs.Log("Hello world");
        var compositor = new Compositor();
        compositor.AssignService<IGameService>(new GameService.GameService());
        compositor.AssignService<IAudioService>(new AudioService.AudioService());
        compositor.StartComposition();
    }
    
}
