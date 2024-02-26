using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageTriangulo : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("da�o");
            collision.transform.GetComponent<PlayerRespawn>().PlayerDamaged();
        }
    }

}
