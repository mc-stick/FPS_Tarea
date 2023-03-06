using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 8f;
    public float l_duration = 2f;
    float l_timer;
    public int attack = 10;


    private void Start()
    {
        l_timer = l_duration;
        
    }

    // Update is called once per frame
    private void Update()
    {
     
        l_timer -= Time.deltaTime;
        if (l_timer <= 0)
        {
                gameObject.SetActive(false);
            
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }


    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("bullet choca con : " + other.name);

        IDamage damage = other.GetComponent<IDamage>();
        if (damage != null)
        {
            damage.DoDamage(attack);
        }
    }
}
