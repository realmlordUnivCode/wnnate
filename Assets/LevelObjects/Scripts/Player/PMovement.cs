using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMovement : MonoBehaviour
{
    private Rigidbody2D RB;
    public Transform groundCheck;
 float speed = 0.25f;
   float h;
    public float gCRadius;
    public LayerMask gLayer;
    public float jSpeed = 4;
 bool grounded = false;
    public AudioClip PJump;
    
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        groundChecking();
        h = Input.GetAxisRaw("Horizontal");
        gameObject.transform.position = new Vector2(gameObject.transform.position.x + (h * speed), gameObject.transform.position.y);
        if (Input.GetKeyDown("space") && grounded || Input.GetAxisRaw("Vertical") == 1 && grounded) 
        {
            AudioSource.PlayClipAtPoint(PJump, gameObject.transform.position);
            RB.velocity = new Vector2(RB.velocity.x, jSpeed);

        }
    }
    void groundChecking()
    {
        Collider2D collider = Physics2D.OverlapCircle(groundCheck.position, gCRadius, gLayer);

        if (collider != null)
        {

            grounded = true;
        }
        else
        {

            grounded = false;
        }
        
    }

}
   