using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thruster : MonoBehaviour
{
    public GameObject thrustTarget;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Quaternion yawStickRot = thrusterStick.transform.rotation;            
            float magnitude = 50.0f;
            Vector3 relativePosition = thrustTarget.transform.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(relativePosition);
            Vector3 direction = rotation * Vector3.forward;

            gameObject.GetComponent<Rigidbody>().AddForce(direction * magnitude, ForceMode.Impulse);
        }
    }
}
