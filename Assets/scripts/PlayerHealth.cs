using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Image _healthBar;


    private void FixedUpdate()
    {
        if(_healthBar.fillAmount < 1f && _healthBar.fillAmount > 0f)
        {
            _healthBar.fillAmount += 0.01f * Time.deltaTime;
        }
    }
    public void TakeDamage(float _damage)
    {
        _healthBar.fillAmount -= _damage;
        if(_healthBar.fillAmount <= 0)
        {
            Destroy(gameObject);
            Time.timeScale = 0f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<Trap>(out Trap _trap))
        {
            Destroy(_trap.gameObject);
            TakeDamage(0.1f);
        }
        if(collision.gameObject.TryGetComponent<Chicken>(out Chicken _chicken))
        {
            TakeDamage(0.1f);
        }
        if (collision.gameObject.TryGetComponent<Lava>(out Lava _lava))
        {
            TakeDamage(1f); 
        }
    }
}
