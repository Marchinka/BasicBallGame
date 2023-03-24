using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag != "Hit") {
            hits++;
            Debug.Log($"You have hit a {other.gameObject.name} You have hit {hits} obstacles.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
