using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    Slider HB;
    health HealthScript;
    // Start is called before the first frame update


    void Start()
    {
        HealthScript = GameObject.FindGameObjectWithTag("Player").GetComponent<health>() as health;


    }

    // Update is called once per frame
    void Update()
    {


    }
}
