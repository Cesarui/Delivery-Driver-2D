using UnityEngine;

public class Collision : MonoBehaviour
{
    int timesCrossed = 0;
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        timesCrossed += 1;
        Debug.Log("What was that?");
        Debug.Log(timesCrossed);
    }
}
