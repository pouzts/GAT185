using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    [SerializeField] float timer = 10.0f;

    void Start()
    {
        Destroy(gameObject, timer);
    }
}
