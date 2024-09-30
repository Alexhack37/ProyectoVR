using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoBala : MonoBehaviour
{

    public float tiempoDesaparicion=4;
    public void Awake()
    {
        if (Player.Play)
        {
            Destroy(gameObject, tiempoDesaparicion);
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "tarjet")
        {
            //Debug.Log("Trieger");
            //Destroy(other.gameObject);
            EnemySpawner.enemigosDerrotados++;
            other.gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "tarjet")
        {
            //Debug.Log("collider");
            //Destroy(collision.gameObject);
            EnemySpawner.enemigosDerrotados++;
            collision.gameObject.SetActive(false);
        }
    }
}
