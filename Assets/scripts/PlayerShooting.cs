using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private Image _ammoBar;
    [SerializeField] private Transform _muzzle;
    [SerializeField] private GameObject _bullet;

    void FixedUpdate()
    {
        if(_ammoBar.fillAmount < 1f)
        {
            _ammoBar.fillAmount += 0.05f * Time.deltaTime;
        }

    }

    public void Shoot()
    {
        if(_ammoBar.fillAmount >= 0.1f)
        {
          _ammoBar.fillAmount -= 0.1f;
            Instantiate(_bullet, _muzzle.position, Quaternion.Euler(transform.localScale.x, _bullet.transform.rotation.y, _bullet.transform.rotation.z));
        }
    }
}
