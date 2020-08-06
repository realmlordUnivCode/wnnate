using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class onPlayClicker : MonoBehaviour
{
    public Button m_playButton;
    // Start is called before the first frame update
    void Start()
    {
        m_playButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {


    }
   void TaskOnClick (){
        Debug.Log("bitch y u no work");
SceneManager.LoadSceneAsync(gameObject.scene.buildIndex +1);
        SceneManager.UnloadSceneAsync(gameObject.scene);
    }
}
