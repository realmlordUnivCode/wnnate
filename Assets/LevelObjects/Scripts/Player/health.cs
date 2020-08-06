using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class health : MonoBehaviour
{   public Vector2 spawnPosition;
    public bool potatoes;
    public Slider HealthBar;
    public float Health;
    public Transform deathDetector;
    public int deathRadius;
    public LayerMask KillTiles;
    public Vector2 positionProjectile;
    public Projectile send;
    public AudioClip PDie;
    public AudioClip PHurt;
    // Start is called before the first frame update
    public Goal_script reverse;
    void Start()
    {

        reverse = FindObjectOfType<Goal_script>() as Goal_script;
        Health = 100;
    
        spawnPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

       

        if (Health <= 0)
        {
            AudioSource.PlayClipAtPoint(PDie, gameObject.transform.position);
            gameObject.transform.position = new Vector2(spawnPosition.x,spawnPosition.y);
            Health = 100;
            HealthBar.value = Health;
        }
  deathBarrier();

    }
    public void Damaged(int damage)
    {  

        Health -= damage;
        if (Health > 0)
        {
            AudioSource.PlayClipAtPoint(PHurt, gameObject.transform.position, 1.0f);


        }
            HealthBar.value = Health;
        
    }
   public void deathBarrier()
    {
        Collider2D collider = Physics2D.OverlapCircle(deathDetector.position, 0.05f, KillTiles);

        if (collider != null)
        {

            Health = 0;
            reverse.reversed = false;
            reverse.reset();


        }
        
    }
 public void proceed()
        {
        reverse = FindObjectOfType<Goal_script>() as Goal_script;



    }

}
