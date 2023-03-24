using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnCollision : MonoBehaviour
{
    Material collisionMaterial;

    // Start is called before the first frame update
    void Start()
    {
        collisionMaterial = Resources.Load("Hit Material", typeof(Material)) as Material;
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            GetComponent<MeshRenderer>().material = collisionMaterial;
            gameObject.tag = "Hit";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
