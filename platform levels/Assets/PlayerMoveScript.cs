using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{

    public float speed = 1;             //Floating point variable to store the player's movement speed.
    public float jumpHeight = 3;
    private bool allowMovement = true;

    void Start()
    {

    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void Update()
    {
        if(Input.GetKey(KeyCode.D) && allowMovement)
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed, Space.World);

        }
        if (Input.GetKey(KeyCode.A) && allowMovement)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed, Space.World);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);

        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "deathplane")
        {
            Debug.Log("gay");
            Destroy(gameObject);
        }
    }
}