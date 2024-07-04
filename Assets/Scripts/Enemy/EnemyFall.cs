using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFall : MonoBehaviour
{
    public float fallSpeed;
    private void Update()
    {
        transform.position += Vector3.down * fallSpeed * Time.deltaTime;
    }
}
