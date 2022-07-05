using UnityEngine;
using UnityEngine.UI;
using  DG.Tweening;

namespace mvp3
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Text _text;
        [SerializeField] private Slider _slider;

        public void SetName(string name)
        {
            _text.text = name;
        }

        public void SetHealth(float value)
        {
            DOTween.To(() => _slider.value,
                n => _slider.value = n,
                value,
                1.0f);
        }
    }
}