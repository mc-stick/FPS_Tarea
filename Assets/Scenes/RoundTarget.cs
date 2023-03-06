using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundTarget : MonoBehaviour
{

    GameData data;
    AudioSource source; 
    // Start is called before the first frame update
    void Start()
    {
        data = GameData.GetInstance();
        source= gameObject.GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dirterget = (transform.position- data.crossRay.origin).normalized;
            float dot = Vector3.Dot(dirterget, data.crossRay.direction);

        if(dot >= 0.997f)
        {
            transform.localScale  = Vector3.one * 6;
            if(Input.GetMouseButton(0))
            {
                source.Play();
                transform.localScale = Vector3.one * 12;
                Destroy(gameObject, 0.1f);
            }
        }
        else
        {
            transform.localScale = Vector3.one *5; 
        }
    }
}
