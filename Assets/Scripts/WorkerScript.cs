using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class WorkerScript : MonoBehaviour
{
    private LogicScript logic;

    private int level = 1;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("LogicTag").GetComponent<LogicScript>();
     
        InvokeRepeating("working", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void working ()
    {
        logic.AddScore(level);
    }
}
