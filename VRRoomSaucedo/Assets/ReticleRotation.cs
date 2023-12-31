using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleRotation : MonoBehaviour
{
    private float spinSpeed = 10f;
    private float scaleSpeed = 0.1f;
    private float maxScale = 1.5f;
    private float minScale = 1f;

    private bool isScalingUp = true;

    private void Update()
    {
        // Rotate the reticle around the y-axis
        transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);

        // Scale the reticle up and down
        if (isScalingUp)
        {
            transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
            if (transform.localScale.x >= maxScale)
            {
                isScalingUp = false;
            }
        }
        else
        {
            transform.localScale -= Vector3.one * scaleSpeed * Time.deltaTime;
            if (transform.localScale.x <= minScale)
            {
                isScalingUp = true;
            }
        }
    }
}
