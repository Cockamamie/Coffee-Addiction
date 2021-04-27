using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;

    private const float Speed = 30;

    //[FormerlySerializedAs("camera")] public Camera cam;

    private Vector2 movement;
    //private Vector2 mousePosition;
    private void MovementInput()
    {
        var dx = Input.GetAxisRaw("Horizontal");
        var dy = Input.GetAxisRaw("Vertical");
        movement = new Vector2(dx, dy).normalized;
    }
    private void FixedUpdate()
    {
        rb.velocity = movement * Speed;
        /*var lookingDirectory = mousePosition - rb.position;
        var angle = Mathf.Atan2(lookingDirectory.y, lookingDirectory.x) * Mathf.Rad2Deg - 90;
        rb.rotation = angle;*/
    }

    // Update is called once per frame
    private void Update()
    {
        MovementInput();
        //mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
    }
}
