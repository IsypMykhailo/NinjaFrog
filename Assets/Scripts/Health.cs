using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public void TakeHit()
    {
        //health -= damage;        
        numOfHearts -= 1;
        for(int i = 0; i < hearts.Length; i++)
        {
            if((i+1) > numOfHearts)
            {
                hearts[i].sprite = emptyHeart;
            }
        }
        if(numOfHearts <= 0)
        {
            Destroy(gameObject);
            RestartLevel();
        }
        //gameObject.transform.position.Set(-8.24F, 1.38F, 0);
        //Destroy(gameObject);
        /*if (health > numOfHearts)
        {
            health = numOfHearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < Mathf.RoundToInt(health))
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }*/

        /*if (health <= 0)
        {
            
        }*/
    }

    private void FixedUpdate()
    {
        
    }

    public void SetHealth()
    {
        numOfHearts += 1;
        if(numOfHearts > hearts.Length)
        {
            numOfHearts = hearts.Length;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if ((i+1) <= numOfHearts)
            {
                hearts[i].sprite = fullHeart;
            }
        }
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
