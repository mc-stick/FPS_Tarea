using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ai_Enemy : MonoBehaviour, IDamage
{

    public Transform objetivo;
    public float velocidad;
    public NavMeshAgent IA;


    AudioSource aud;
    public AudioClip song;  

    public void DoDamage(int valor)
    {   
        //aud.PlayOneShot(song);
       Debug.Log("daño recibido "+ valor);
        
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        aud = GetComponent<AudioSource>();
    }



    // Update is called once per frame
    void Update()
    {
        IA.speed = velocidad;
         //   IA.SetDestination(objetivo.position);

    }

        
}
