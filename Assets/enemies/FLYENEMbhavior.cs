using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FLYENEMbhavior : MonoBehaviour
{
     health HealthScript;

    public Transform isPLAYERDETECTOR;
    private Rigidbody2D RB;
    float IFrames;
    public LayerMask m_LayerMask;
    bool IsLeft = false;
    bool isGrounded = false;

    public Transform isWallChecker;
    public float checkGroundRadius;
    public float checkWallRadius;
    public int damage = 10;
    public LayerMask groundLayer;
    // Start is called before the first frame update
    void Start()
    {
        HealthScript = GameObject.FindObjectOfType(typeof(health)) as health;

        RB = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {


        GCHECK();
   

        CheckIfWalled();


        if (isGrounded)
        {




        }

        void CheckIfWalled()
        {
            Collider2D collider = Physics2D.OverlapCircle(isWallChecker.position, checkGroundRadius, groundLayer);
            if (collider != null)
            {
                IsLeft = true;
            }

        }
       

        void GCHECK()
        {
            Collider2D collider = Physics2D.OverlapCircle(isWallChecker.position, checkGroundRadius, groundLayer);
            if (collider != null)
            {
                RB.velocity = new Vector2(RB.velocity.x, 7);
            }

        }
    } private void OnCollisionEnter2D(Collision2D collision)
        {



            if (collision.gameObject.tag == "Player")
            {





                if (IFrames == 0)
                {
                    collision.gameObject.GetComponent<health>().Damaged(damage);
                    IFrames = 60;
                }
                if (IFrames >= 1)
                {


                }


            }


        }
}

