using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageLoop : MonoBehaviour
{
    [SerializeField] private Vector2 movementVelocity;

    private Vector2 offset;
    private Material material;

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
    }
    private void Update()
    {
        offset = movementVelocity * Time.deltaTime;
        material.mainTextureOffset += offset;
    }

}
