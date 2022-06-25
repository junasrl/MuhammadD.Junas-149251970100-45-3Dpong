using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerPreview : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Winner;
    public ScoreManager manager;

    private void Update()
    {
        Winner.text = "The Winner is " + manager.winner + "!";
    }
}
