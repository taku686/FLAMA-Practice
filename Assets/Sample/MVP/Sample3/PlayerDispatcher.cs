using Cysharp.Threading.Tasks;
using UnityEngine;
using  UniRx;

namespace mvp3
{
    public class PlayerDispatcher : MonoBehaviour
    {
        [SerializeField] private PlayerManager _playerManager;

        [SerializeField] private PlayerPresenter _playerPresenter;

        [SerializeField] private PlayerView _viewPrefab;
        
        // Start is called before the first frame update
        void Start()
        {
            foreach (var player in _playerManager.Players)
            {
                Dispatch(player);
            }

            _playerManager.Players.ObserveAdd().Subscribe(x => Dispatch(x.Value)).AddTo(this);
        }

        private void Dispatch(Player player)
        {
            var view = Instantiate(_viewPrefab, player.transform, true);
            view.transform.localPosition = Vector3.up * 1.5f;
            
            // Presenterに組み合わせて通知
            _playerPresenter.OnCreatePlayer(player, view);
        }
    }
}