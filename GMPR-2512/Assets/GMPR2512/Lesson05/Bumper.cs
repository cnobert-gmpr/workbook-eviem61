using UnityEngine;

namespace GMPR2512Lesson05
{
public class bumper : MonoBehaviour
{
    [SerializeField] private float _bumperForce = 150f;
    void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.collider.CompareTag("Ball"))
       {
           Debug.Log($"A game object with tag {collision.collider.tag} just hit me!");
           if(collision.rigidbody != null)
                {
                    
                
              // Step 1: Get the normal of the first contact point
                    Vector2 normal = Vector2.zero;
                    if (collision.contactCount > 0)
                    {
                        ContactPoint2D contact = collision.GetContact(0);
                        normal = contact.normal;  // points *outward* from the bumper surface
                    }
                    // Step 2: If for some reason we didn't get a contact normal, fall back
                    if (normal == Vector2.zero)
                    {
                        Vector2 direction = (collision.rigidbody.position - (Vector2)transform.position).normalized;
                        normal = direction;
                    }
                    // Step 3: Calculate an impulse along the normal
                    Vector2 impulse = normal * _bumperForce;
                    // Step 4: Apply as an instantaneous force (ignores mass scaling)


              collision.rigidbody.AddForce(impulse, ForceMode2D.Impulse);
           }
       }
    }
    }
}

