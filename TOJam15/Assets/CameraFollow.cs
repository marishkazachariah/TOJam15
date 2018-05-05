using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    //public Transform target;            // The position that that camera will be following.
    public float smoothing = 5f;        // The speed with which the camera will be following.

    //Vector3 offset;                     // The initial offset from the target.
    private Vector3 viewPos;
    private Transform foodObject;
    void Start()
    {
        // Calculate the initial offset.
        //offset = transform.position - target.position;
        foodObject = GameObject.FindGameObjectWithTag("food").GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        //// Create a postion the camera is aiming for based on the offset from the target.
        //Vector3 targetCamPos = target.position + offset;

        //// Smoothly interpolate between the camera's current position and it's target position.
        //transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
    public void Update()
    {

        viewPos = Camera.main.WorldToViewportPoint(foodObject.position);

        if ((0f <= viewPos.x && viewPos.x <= 1F) && (0f <= viewPos.y && viewPos.y <= 1F) && (Camera.main.transform.position.z < this.transform.position.z))
        {
            print("target is in the camera! ----- ");
        }
        else if ((0f > viewPos.x))
        {
            print("target is on the left side!");
        }
        else if ((viewPos.x > 1F))
        {
            print("target is on the right side!");
        }
        else
        {
            print("target is NOT in the camera!");
        }
        if (viewPos.x > 0.5F)
            print("target is on the right side!");
        else
            print("target is on the left side!");
    }         
}
