using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] ForceMode forceMode;
    [SerializeField] float timer;

    [SerializeField] GameObject destroyPrefab;

    public void Start()
	{
        rb.AddRelativeForce(Vector3.forward * speed, forceMode);
        if (timer != 0) StartCoroutine(DestroyTimer());
	}

    IEnumerator DestroyTimer()
    {
        yield return new WaitForSeconds(timer);
        if (destroyPrefab != null) Instantiate(destroyPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (timer != 0) return;

        if (destroyPrefab != null) Instantiate(destroyPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
