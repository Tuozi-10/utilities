using AudioService;
using src.Addressables;
using src.IOC.Attributes;
using UnityEngine;
using static UnityEngine.AddressableAssets.Addressables;

namespace GameService
{
    public class GameService : IGameService
    {
        [DependsOnService] private IAudioService m_audioService;

        [ServiceInit]
        private void Initialize()
        {
           m_audioService.PlaySound(0);
        }

        public void GenerateBurger()
        {
            AddressableHelper.LoadAssetAsyncWithCompletionHandler<GameObject>("LeBurger", GenerateBurger);
        }

        private void GenerateBurger(GameObject gameObject)
        {
            var burger = Object.Instantiate(gameObject);
            Release(gameObject);
        }
        
    }
}