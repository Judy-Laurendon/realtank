using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript1 : MonoBehaviour
{
    [SerializeField] private Image timerFond;

    public float timeLeft;

    public bool isGameOver;

    public bool winOrNot;

    public float maximumTime;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = maximumTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timerFond.fillAmount = timeLeft / maximumTime;
        if (timeLeft <= 0)
        {
            isGameOver = true;
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
