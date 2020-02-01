using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhisicsSimmulation : MonoBehaviour
{

    public int maxIteration = 1000;

    [ContextMenu("Run Simulation")]
    public void RunSimmulation()
    {

        Physics.autoSimulation = false;
        for (int i =0; i < maxIteration; i++)
        {
            Physics.Simulate(Time.fixedDeltaTime);
        }
        Physics.autoSimulation = true;
        
    }
}
