using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset;
    
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = target.transform.position + offset;
    }
}
