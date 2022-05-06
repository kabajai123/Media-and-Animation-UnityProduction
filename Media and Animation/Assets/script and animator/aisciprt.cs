using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class aisciprt : MonoBehaviour
{
    private bool hitbox = false;
    private bool walkback = false;
    private bool turnright = false;
    private bool run = true;

    private void Update()
    {
        if (run == true)
        {
            gameObject.GetComponent<Animator>().Play("walk");

        }

        if (walkback == true)
        {
            gameObject.GetComponent<Animator>().Play("walkback");

        }

        if (turnright == true)
        {
            gameObject.GetComponent<Animator>().Play("rightTurn");
        }

        if (hitbox == true)
        {
            StartCoroutine(wallhere());

        }
    }
    IEnumerator wallhere()
    {

        hitbox = false;
        walkback = true;
        yield return new WaitForSeconds(2);
        walkback = false;
        turnright = true;
        yield return new WaitForSeconds(3);
        turnright = false;
        run = true;


    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<wall>())
        {
            run = false;
            hitbox = true;
        }
    }
}
