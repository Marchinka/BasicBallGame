using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faller : MonoBehaviour
{
    [SerializeField] float timeToWait = 5f;
    Rigidbody rigidBody;
    MeshRenderer meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= this.timeToWait) 
        {
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
