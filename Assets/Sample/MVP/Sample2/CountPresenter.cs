using Cysharp.Threading.Tasks;
using UnityEngine;
using  UnityEngine.UI;
using  UniRx;

namespace mvp2
{
    public class CountPresenter : MonoBehaviour
    {
        [SerializeField] private Slider _slider;
        [SerializeField] private Text _text;

        [SerializeField] private SampleModel _model;
        // Start is called before the first frame update
        void Start()
        {
            _model.Count.Subscribe(v =>
            {
                _slider.value = ((float)v / _model.MaxCount);
                _text.text = $"{v}%";
            }).AddTo(this);

            _slider.OnValueChangedAsObservable()
                .Subscribe(x =>
                {
                    var value = (int)(100 * x);
                    _model.SetCount(value);
                }).AddTo(this);
        }
    }
}