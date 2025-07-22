using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;

    void OnCollisionEnter2D(Collision2D collision)
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package")
        {
            Debug.Log("Package has been picked up!");
            hasPackage = true;
        }
        if (collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package has been delivered!");
        }
    }
}
