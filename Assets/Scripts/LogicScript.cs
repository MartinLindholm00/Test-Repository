using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public Text NumberText;
    private int Score;
    public GameObject Worker_1;
    public Light CokkieLight;
    public CookieScript CokkieScript;



    void Start()
    {
        CokkieScript = GameObject.FindGameObjectWithTag("CookieTag").GetComponent<CookieScript>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void AddScore(int addedScore)
    {
        Score = Score + addedScore;
        NumberText.text = Score.ToString();
        Debug.Log(Score.ToString());
    }

    public void worker_1() 
    {
        Worker_1.SetActive(true);
    }

    public void LightSwitch(bool Switch)
    {
        CokkieLight.GetComponent<Light>().enabled = Switch;
    }
}
