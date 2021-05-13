using UnityEngine;
using static System.Math;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    private const float Speed = 30;
    private Animator playerAnimation;
    private Vector2 movement;
    private static readonly int MoveX = Animator.StringToHash("moveX");
    private static readonly int MoveY = Animator.StringToHash("moveY");
    private static readonly int LastX = Animator.StringToHash("lastX");
    private static readonly int LastY = Animator.StringToHash("lastY");
    private void Start()
    {
        playerAnimation = GetComponent<Animator>();
    }

    private void MovementInput()
    {
        var dx = Input.GetAxisRaw("Horizontal");
        var dy = Input.GetAxisRaw("Vertical");
        movement = new Vector2(dx, dy).normalized;
    }
    
    private void FixedUpdate()
    {
        rb.velocity = movement * Speed;
    }
    
    private void Update()
    {
        MovementInput();
            playerAnimation.SetFloat(MoveX, rb.velocity.x);
        playerAnimation.SetFloat(MoveY, rb.velocity.y);

        if (Abs(Input.GetAxisRaw("Horizontal")) == 1 || Abs(Input.GetAxisRaw("Vertical")) == 1)
        {
            playerAnimation.SetFloat(LastX, Input.GetAxisRaw("Horizontal"));
            playerAnimation.SetFloat(LastY, Input.GetAxisRaw("Vertical"));
        }
    }
}
