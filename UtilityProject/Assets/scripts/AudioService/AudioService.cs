using src.Log;

namespace AudioService
{
    public class AudioService : IAudioService
    {
        public void PlaySound(int id)
        {
           Logs.Log($"Playing sound at id {id}");
            // TODO PLAY SOUND
        }

    }
}