using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * this.speed * Time.deltaTime;
        float deltaZ = Input.GetAxis("Vertical") * this.speed * Time.deltaTime;
        this.transform.Translate(deltaX, 0f, deltaZ);
    }
}
