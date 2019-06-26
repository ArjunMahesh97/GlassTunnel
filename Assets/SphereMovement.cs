using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    [SerializeField] int rotSpeed = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        transform.RotateAround(Vector3.zero, Vector3.forward, horizontalMovement * Time.deltaTime * -rotSpeed);
    }
}
