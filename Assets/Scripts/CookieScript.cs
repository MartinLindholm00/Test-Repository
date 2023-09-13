using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CookieScript : MonoBehaviour
{
    private int numberClicks;

    private LogicScript Logic;
    private WorkerScript worker_1;

    public float turnspeed = 50f;

    private bool Light = true;


    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("LogicTag").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (numberClicks == 10)
        {
            Logic.worker_1();

            worker_1 = GameObject.FindGameObjectWithTag("Worker_1Tag").GetComponent<WorkerScript>();
        } // Add the worker_1 to the game

        if (Input.GetKeyDown(KeyCode.Space))
        {
            numberClicks++;
            Logic.AddScore(1);
            Logic.LightSwitch(Light);
            LightOnOff();
        }

        transform.Rotate(Vector3.right, turnspeed * Time.deltaTime);
    }

    public void LightOnOff()
    {
        if (Light == true) 
        {
            Logic.LightSwitch(true);
            Light = false;
        }
        else
        {
            Logic.LightSwitch(false);
            Light = true;
        }
    }
}
