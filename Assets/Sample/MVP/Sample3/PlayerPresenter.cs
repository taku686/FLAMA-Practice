using UnityEngine;
using UniRx;
namespace mvp3
{
    public class PlayerPresenter : MonoBehaviour
    {
        public void OnCreatePlayer(Player player, PlayerView view)
        {
            view.SetName(player.name);
            player.Health.Subscribe(x =>
            {
                view.SetHealth((float)x / player.MaxHealth);
            }).AddTo(this);
        }
    }
}