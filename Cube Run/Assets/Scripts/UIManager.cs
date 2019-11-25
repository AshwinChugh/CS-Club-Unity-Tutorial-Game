using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject MainPlayer;
    public Text ScoreText;
    // Update is called once per frame
    void Update()
    {
        ScoreText.text = MainPlayer.transform.position.z.ToString("0");
    }

    public void OnPlayButtonClicked()
    {
        //code here
    }

    public void OnQuitGameButtonClicked()
    {
        //code here
    }
}
