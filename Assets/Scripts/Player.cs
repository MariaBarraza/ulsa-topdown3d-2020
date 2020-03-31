using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;

    void Update()
    {
        transform.Translate(Axis * moveSpeed * Time.deltaTime);
    }

    Vector3 Axis
    {
        get => new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
    }
}
