using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform player;
    // Update is called once per frame
    void Update()
    {
        Debug.Log(player.position.z);
    }
}
