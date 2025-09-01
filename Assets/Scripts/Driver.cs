using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float turnSpeed = 0.1f;
    [SerializeField] float moveSpeed = 0.1f;
    [SerializeField] float slowSpeed;
    [SerializeField] float boostSpeed;

    void Start()
    {
        
    }

    void Update()
    {

        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -turnAmount);
        transform.Translate(0, moveAmount, 0);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bump")
        {
            moveSpeed = slowSpeed;
        }
        else if (collision.gameObject.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }
}
