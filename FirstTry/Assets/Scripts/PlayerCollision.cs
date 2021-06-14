using UnityEngine;



public class PlayerCollision : MonoBehaviour
{
    public Moving movement;
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GmManager>().End();
            
        }

    }
}
