using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShoot : MonoBehaviour
{
    public GameObject missilePrefab; 
    public float delay = 1.0f;
    [Range(0f, 10000f)]
    public float force;
    public Transform shootSpawn;

    private float timeShot = 0f; 

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && Time.time >= timeShot)
        {
            Shoot();
            timeShot = Time.time + delay; 
        }
    }

    private void Shoot()
    {
       GameObject clone = Instantiate(missilePrefab, transform.GetChild(0).position,transform.GetChild(0).rotation);
        clone.GetComponent<Rigidbody>().velocity = transform.GetChild(0).up * force;
        Destroy(clone, 5);




    }
}
