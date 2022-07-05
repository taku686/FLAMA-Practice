using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;


public class PlayerCore : MonoBehaviour
{
    private Vector3 _shotPosSetOff = new Vector3(0, 0, 3.0f);
    private PlayerShotManagement _shotManagement;
    private int _count = 0;

    public Vector3 ShotPosSetOff { get => _shotPosSetOff; }
    
    // Start is called before the first frame update
    void Start()
    {
        /*_shotManagement = GameObject.FindGameObjectWithTag("Manager").GetComponent<PlayerShotManagement>();
        _shotManagement.Initialize();
        this.UpdateAsObservable()
            .Where(_ => Input.GetKey(KeyCode.Space))
            .ThrottleFirstFrame(30)
            .Subscribe(_ =>
            {
                _shotManagement.Shot(this);
            });
        this.UpdateAsObservable()
            .Where(_ => Input.GetKey(KeyCode.A))
            .ThrottleFirstFrame(60)
            .Subscribe(_ =>
            {
                ChangeShot();
            });*/
    }

   private void ChangeShot()
    {
        _count++;
        if (_count % 3 == 0)
        {
            _shotManagement.SetShot(ShotType.ShotTypes.NormalShot);
        }
        else if (_count % 3 == 1)
        {
            _shotManagement.SetShot(ShotType.ShotTypes.LaserShot);
        }
        else if (_count % 3 == 2)
        {
            _shotManagement.SetShot(ShotType.ShotTypes.DiffusionShot);
        }
    }
}
