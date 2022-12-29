using src.IOC.Service;

namespace GameService
{
    public interface IGameService : IService
    {
        void GenerateBurger();
    }
}