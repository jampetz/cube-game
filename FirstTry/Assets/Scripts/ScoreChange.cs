using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TextCore;

public class ScoreChange : MonoBehaviour
{
    public Transform player;
    public Text textdata;
    // Update is called once per frame
    void Update()
    {
        textdata.text = player.position.z.ToString("0");
    }
}
