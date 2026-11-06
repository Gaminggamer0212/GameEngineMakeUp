using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] InputAction playerControlls;
    [SerializeField] float playerSpeed = 10f;
    [SerializeField] private AudioClip eatSound;
    Rigidbody2D rb;
    Collider2D collider;
    Vector2 moveDirection;
    
    
    private void OnEnable()
    {
        playerControlls.Enable();
    }

    private void OnDisable()
    {
        playerControlls.Disable();
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = playerControlls.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        //moveDirection.y = 0;
        rb.linearVelocity = playerSpeed *  moveDirection;
    }

    public void Eat()
    {
        AudioManager.Instance.PlaySound(eatSound);
        GameManager.Instance.AddScore(10);
    }
}
