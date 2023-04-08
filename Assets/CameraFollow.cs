using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    // Start is called before the first frame update
    float offset;
    void Start()
    {
        offset = target.position.x - transform.position.x;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float newX = target.position.x - offset;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}
