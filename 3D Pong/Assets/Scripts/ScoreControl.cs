using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    public Text scorep1;
    public Text scorep2;
    public Text scorep3;
    public Text scorep4;

    public ScoreManager manager;

    private void Update()
    {
        scorep1.text = manager.p1score.ToString();
        scorep2.text = manager.p2score.ToString();
        scorep3.text = manager.p3score.ToString();
        scorep4.text = manager.p4score.ToString();

    }
}
