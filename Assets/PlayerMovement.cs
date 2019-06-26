using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] int movSpeed = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float forwardMovement = Input.GetAxis("Vertical");
        print(forwardMovement);
        transform.GetComponent<Rigidbody>().velocity = new Vector3(0, forwardMovement * Time.deltaTime * movSpeed,0);
    }
}
