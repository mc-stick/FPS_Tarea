using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class Actions : MonoBehaviour, IDamage
{
    public Transform posGun;
    public Transform cam;

    public GameObject prefab;
    public LayerMask ignoreLayer;

    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DoDamage(int valor)
    {
        Debug.Log("daño recibido " + valor);
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.DrawRay(cam.position, cam.forward * 100f, Color.gray);
        Debug.DrawRay(posGun.position, cam.forward * 100f, Color.blue );

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 direction = cam.TransformDirection(new Vector3(Random.Range(-0.05f, 0.05f), Random.Range(-0.05f, 0.05f), 1));
            Debug.DrawRay(cam.position, direction * 100f, Color.green, 5f);

            GameObject bulletObj = Instantiate(prefab); 
            bulletObj.transform.position = posGun.position;

            if(Physics.Raycast(cam.position, direction, out hit, Mathf.Infinity, ~ignoreLayer))
            {
                bulletObj.transform.LookAt(hit.point);
            }
            else
            {
                Vector3 dir = cam.position + direction * 10f;
                bulletObj.transform.LookAt(dir);
            }

            
        }
    }
}
