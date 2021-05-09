using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckController : MonoBehaviour
{
    public float SteeringVelocity;

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
           gameObject.transform.position += new Vector3(-SteeringVelocity, 0f, 0f) * Time.deltaTime;
       }
       if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
           gameObject.transform.position += new Vector3(SteeringVelocity, 0f, 0f) * Time.deltaTime;
       }
    }
}
