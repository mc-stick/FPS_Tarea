using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform cam;
    float vm;
    float hm;
    float yr;
    public float hs; 
    public float vs;

    public CharacterController control;
    public float speed = 12f;
    float x;
    float z;
    Vector3 move;

    AudioSource aud;
    public AudioClip song;

    //public GameObject invocar;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   
        aud= GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Look();
        movement();



        if (Input.GetMouseButtonDown(0))
        {

            //GameObject enem = Instantiate(invocar);
            //enem.transform.position = new Vector3(0.08f, 0.7895802f, -0.1f);
            aud.PlayOneShot(song);
        }
    }

    void Look()
    {
        hm = Input.GetAxis("Mouse X") * hs * Time.deltaTime;
        vm= Input.GetAxis("Mouse Y") * vs * Time.deltaTime;

        yr -= vm;
        yr = Mathf.Clamp(yr, -90f, 90f);
        transform.Rotate(0f, hm, 0f);
        cam.localRotation = Quaternion.Euler(yr , 0f, 0f);  

    }

    void movement()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        move = transform.right * x + transform.forward * z;
        control.Move(speed * move * Time.deltaTime);

    }
}
