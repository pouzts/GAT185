using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(0,10)][Tooltip("Speed of Player")] public float speed = 5.0f;
    [SerializeField] AudioSource audioSource;

   /* private void Awake()
    {
        print("awake");
    }

    private void Start()
    {
        Debug.Log("Start");
        print("start");
    }*/

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        transform.position += direction * speed * Time.deltaTime;
        //transform.rotation *= Quaternion.Euler(5, 0, 0);
        //transform.localScale = new Vector3(2,2,2);

        // Input
        if (Input.GetButtonDown("Fire1"))
        {
            audioSource?.Play();
            GetComponent<Renderer>().material.color = Color.yellow;
            //transform.rotation *= Quaternion.Euler(5, 0, 0);
        }
    }
}
