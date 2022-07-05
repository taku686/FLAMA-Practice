using Cysharp.Threading.Tasks;
using UnityEngine;
using  UniRx;

namespace mvp
{
    public class PlayerHealthPresenter : MonoBehaviour
    {
        [SerializeField] private Player _player;

        [SerializeField] private AnimationSlider _animationSlider;
        
        // Start is called before the first frame update
        void Start()
        {
            _player.Health
                .Subscribe(x =>
                {
                    // Viewに反映
                    _animationSlider.SetValue((float)x / _player._maxHealth);
                }).AddTo(this);
        }
    }
}