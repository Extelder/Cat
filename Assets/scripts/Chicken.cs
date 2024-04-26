using UnityEngine;

public class Chicken : MonoBehaviour
{
    private int _health = 100;
    public void TakeDamage(int _damage)
    {
        _health -= _damage;
        if(_health <= 0)
        {
            Death();
        }
    }

    public void Death()
    {
        Destroy(gameObject);
    }
    public void FlipX(float x)
    {
        transform.localScale = new Vector3(x, transform.localScale.y, transform.localScale.z);
    }
   

}
