using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChaseState : state
{
    public Flashlight flashlight;
    
    public Transform Objetivo;
    //public float Velocidad;
    //public NavMeshAgent IA;

    public Atackstate  Atackstate;
    public bool isinattackrange;
    public override state RunCurrentState()
   {
    if(isinattackrange)
    {
        return Atackstate;
    }
    else
    {
        return this;
    }
    
   }

    void Update()
    {
        
    }
}
