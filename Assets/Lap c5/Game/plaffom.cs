using UnityEngine;

public class OneWayPlatform3D : MonoBehaviour
{
    private Collider platformCollider;

    void Start()
    {
        platformCollider = GetComponent<Collider>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;

        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

        if (rb != null && rb.velocity.y > 0)
        {
            Physics.IgnoreCollision(collision.collider, platformCollider, true);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;

        Physics.IgnoreCollision(collision.collider, platformCollider, false);
    }
}
