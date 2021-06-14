using UnityEngine;
using UnityEngine.SceneManagement;

public class GmManager : MonoBehaviour
{
    bool over = false;
    public float restartDelay = 1f;
   
   public GameObject completeLevelUI;
   public void CompleteLvl()
   {
       completeLevelUI.SetActive(true);
   }
   public void End() 
   {
       if(over == false)
       {
           over = true;
           Debug.Log("Game over");
           Invoke("RestartGame", restartDelay);
       }
   }
   void RestartGame()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);


   }
}
