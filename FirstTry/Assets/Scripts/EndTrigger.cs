using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GmManager gameManager;

    public void OnTriggerEnter()
    {
        gameManager.CompleteLvl();
    }


}
