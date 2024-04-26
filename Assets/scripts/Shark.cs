using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Attack());
    }


    private IEnumerator Attack()
    {
        transform.Translate(transform.position.x, 3f, transform.position.z);
        yield return new WaitForSeconds(1f);
        transform.rotation = new Quaternion(transform.rotation.x, 180f , transform.rotation.z, 0f);
        transform.Translate(transform.position.x, -3f, transform.position.z);
    }
}
