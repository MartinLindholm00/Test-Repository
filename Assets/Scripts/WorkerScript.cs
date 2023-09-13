using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class WorkerScript : MonoBehaviour
{
    //private bool onOrOff = false;

    private int timer = 1;

    private LogicScript logic;

    private int level = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        logic = GameObject.FindGameObjectWithTag("LogicTag").GetComponent<LogicScript>();

        for (int i = 0; i < 100; i ++) 
        {
            //Invoke(logic.AddScore(level), 1);
            
        }

    }
}
