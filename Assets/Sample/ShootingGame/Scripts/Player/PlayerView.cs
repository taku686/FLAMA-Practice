using UnityEngine;
using UnityEngine.UI;
using  DG.Tweening;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Text _hpText;
    [SerializeField] private Text _bulletTypeText;
    public Text BulletTypeText => _bulletTypeText;
    

    public void SetSliderValue(float value)
    {
        DOTween.To(() => _slider.value,
            n=>_slider.value = n,
            value,
            0.5f);
    }

    public void SetHpText(int value)
    {
        _hpText.text = value.ToString();
    }
}
