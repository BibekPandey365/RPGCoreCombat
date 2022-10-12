using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform target;

    void Start()
    {
        
    }

    void LateUpdate()
    {
        transform.position = target.position;
    }
}
