using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform followTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = new Vector3(followTransform.position.x, 0, 0);
    }
}
