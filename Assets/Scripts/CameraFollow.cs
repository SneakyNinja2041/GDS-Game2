using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothing = 5f;
    public bool followYAxis = true;
    public Vector3 offset = new Vector3(0f, 0f, 0f);

    private void FixedUpdate()
    {
        Vector3 targetPosition = target.position + offset;
        if (!followYAxis)
        {
            targetPosition.y = transform.position.y
;        }
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.fixedDeltaTime);

    }

}
