using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unloadproj : MonoBehaviour
{ health HealthScript;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D projectile)
    {
        //you may check the tag of the 'other' object here to make sure if its your instantiated object
        //if(other.gameObject.tag=="yourInstantiatedObjectTag")
        if (projectile.gameObject.tag == "projectile")
        {
            Debug.Log("correct");
            Destroy(projectile.gameObject);//dont forget to check the isTrigger of the quad or else the event will not trigger
        }
    }
}
