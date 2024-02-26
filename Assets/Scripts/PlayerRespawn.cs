using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerRespawn : MonoBehaviour
{
    public void PlayerDamaged()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
