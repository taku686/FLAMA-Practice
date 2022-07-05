using UnityEngine;
using  UniRx;
using  UnityEngine.UI;
using  DG.Tweening;

namespace mvp
{
    public class AnimationSlider : MonoBehaviour
    {
        [SerializeField] Slider _slider;

        public void SetValue(float value)
        {
            DOTween.To(() => _slider.value,
                n => _slider.value = n,
                value,
                duration: 1.0f);
            Debug.Log(value);
        }
    }
}