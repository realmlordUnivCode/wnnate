using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicEnemyBehavior : MonoBehaviour
{


    public Transform isPLAYERDETECTOR;

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
    private void Start()
    {



    }
    // Update is called once per frame
    private void Update()
    {

     if(IFrames >= 1)
        {



            IFrames--;
        }

        CheckIfWalled();


        gameObject.transform.position = new Vector2(gameObject.transform.position.x - 0.01f, gameObject.transform.position.y);


        transform.eulerAngles = new Vector3(0, 0, 0);

    }

    void CheckIfWalled()
    {
        Collider2D collider = Physics2D.OverlapCircle(isWallChecker.position, checkGroundRadius, groundLayer);
        if (collider != null)
        {
            IsLeft = true;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
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

