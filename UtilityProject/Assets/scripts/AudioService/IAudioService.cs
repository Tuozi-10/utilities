using Service;

namespace AudioService
{
    public interface IAudioService : IService
    {
        void PlaySound(int id);
    }
}