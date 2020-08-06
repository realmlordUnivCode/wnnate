using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ehealth : MonoBehaviour
{     public float Health;
   public AudioClip EHurt;
   public AudioClip EDie;
    // Start is called before the first frame update
    void Start()
    {
   
   
   
    }

    // Update is called once per frame
    void Update()
    {
        if(Health <= 0)
        {   AudioSource.PlayClipAtPoint(EDie, gameObject.transform.position);
           

            Destroy(gameObject);

        }
    }
    public void damage( float projDamage)
    {
        if (Health > 10)
        {


            AudioSource.PlayClipAtPoint(EHurt, gameObject.transform.position);
        }
     
        Health -= projDamage;



    }
}
