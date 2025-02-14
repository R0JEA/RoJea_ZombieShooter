using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraF : MonoBehaviour
{
    public Transform target;
    public float SmSpeed;
    public Vector3 offset;
    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
