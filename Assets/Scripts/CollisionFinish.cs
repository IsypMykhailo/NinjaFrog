using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionFinish : MonoBehaviour
{
    public string collisionTag;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        RestartLevel();
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
