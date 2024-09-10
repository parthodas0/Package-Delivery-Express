using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject carToFollow;
    // Camera's position should be the same as the car's position
    void LateUpdate()
    {
        transform.position = carToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
