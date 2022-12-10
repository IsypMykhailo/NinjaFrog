using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
   // public int collisionDamage = 1;
    public string collisionTag;
    private float timer = 1;
    private bool godMode = true;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        Animator anim = coll.gameObject.GetComponent<Animator>();
        if (coll.gameObject.tag == collisionTag)
        {
            anim.SetTrigger("hitTrigger");
            /*anim.SetBool("isHitting", true);
            Health health = coll.gameObject.GetComponent<Health>();            
            health.TakeHit(collisionDamage); */ 
        }
        
    }

    private void OnCollisionStay2D(Collision2D coll)
    {
        Animator anim = coll.gameObject.GetComponent<Animator>();
        anim.SetBool("isHitting", true);
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            //godMode = false;
            Health health = coll.gameObject.GetComponent<Health>();
            health.TakeHit();
            timer = 1;
        }
        /*else
        {
            godMode = true;
        }*/

        /*if (!godMode)
        {
            Health health = coll.gameObject.GetComponent<Health>();
            health.TakeHit(collisionDamage);
            godMode = true;
            timer = 1;
        }  */      
    }

    private void OnCollisionExit2D(Collision2D coll)
    {
        Animator anim = coll.gameObject.GetComponent<Animator>();
        anim.SetBool("isHitting", false);
    }
}
