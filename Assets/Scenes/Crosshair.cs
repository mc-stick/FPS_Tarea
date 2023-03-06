using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public float camDis = 10.0f;
    Ray ray;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        GameData.GetInstance().crossRay= ray;

        transform.position = ray.origin + ray.direction * camDis;

        Debug.DrawRay(ray.origin, ray.direction * 40, Color.yellow);
    }
}
