using UnityEngine;

namespace GMPR2512Lesson05
{
public class bumper : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.collider.CompareTag("Ball"))
       {
           Debug.Log($"A game object with tag {collision.collider.tag} just hit me!");
       }
    }
    }
}

