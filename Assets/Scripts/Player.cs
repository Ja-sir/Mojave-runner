using Unity.VisualScripting.FullSerializer;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]

public class Player : MonoBehaviour
{



    // TODO: Reference to Rigidbody2D component should have class scope.
    Rigidbody2D rb;
    // TODO: A float variable to control how high to jump / how much upwards
    // force to add.
    public float jumpforce = 10f;

    public bool isFalling = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // TODO: Use GetComponent to get a reference to attached Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isFalling)
        {

        // TODO: On the frame the player presses down the space bar, add an instant upwards
        // force to the rigidbody.
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
        rb.AddForce(Vector3.up *  jumpforce, ForceMode2D.Impulse);
        }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        print("On Collision Enter");
        if (other.gameObject.CompareTag("Ground"))
        {
            isFalling = false;
        }
    }

private void OnCollisionExit2D(Collision2D other)
    { if (other.gameObject.CompareTag("Ground"))
        {
            isFalling = true;
        }
    print("On Collision Enter");
}


}


