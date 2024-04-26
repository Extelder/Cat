using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private int _nextScene;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<PlayerHealth>(out PlayerHealth _player))
        {
            SceneManager.LoadScene(_nextScene);
        }
    }
}
