using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;


public class Goal_script : MonoBehaviour
{ public bool hCircleTriggered;
    public Vector2 reverseLocation;
     health HealthScript;
    public Transform HCircle;
    public LayerMask playerLayer;
    public Vector2 spawnPos;
    public bool reversed;
    Collision2D collisionThing;
    float TransFrames;
    public AudioClip ReverseAudio;
    public AudioClip goal;
    // Start is called before the first frame update
    void Start()
    {
        HealthScript = GameObject.FindObjectOfType(typeof(health)) as health;
        reverseLocation = HealthScript.spawnPosition;
        reversed = false;
        hCircleTriggered = false;
        spawnPos = gameObject.transform.position;


    }

    // Update is called once per frame
    void Update()
    {
      if(TransFrames >= 1)
        {
            TransFrames--;



        }
    }


    private void OnTriggerEnter2D(Collider2D col) { 
    
        if (col.gameObject.tag == "Player")
        {
            if (reversed == false)
            {
                AudioSource.PlayClipAtPoint(ReverseAudio,gameObject.transform.position);


                hCircleTriggered = true;
                reversed = true;
                gameObject.transform.position = reverseLocation;
                TransFrames = 1;
            }



            if (reversed == true && TransFrames ==0)
            {

                AudioSource.PlayClipAtPoint(goal, gameObject.transform.position);

               StartCoroutine(loadNextScene(col));




                

            }
        }
    }

    public IEnumerator loadNextScene(Collider2D col)
    {


      
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Additive);
        while (!asyncLoad.isDone)
        {

            yield return null;
        }
        SceneManager.MoveGameObjectToScene(col.gameObject, SceneManager.GetSceneByBuildIndex(SceneManager.GetActiveScene().buildIndex + 1));
 
  HealthScript.proceed();

        reversed = false;
        SceneManager.UnloadScene(gameObject.scene);
     
      

    }
    public void reset(){



        gameObject.transform.position = spawnPos;        }
}
                    
                    
                   










   
