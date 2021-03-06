﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    // accesing definitions and variables from TankControllerUniversal Script
    GameObject Tank;
    private TankControllerUniversal TankScript;
    public int AttackDamage;
    public Collider AgentCollider;

    // Start is called before the first frame update
    void Start()
    {   // assigning 
        Tank = GameObject.FindGameObjectWithTag("Tank");
        TankScript = Tank.GetComponentInChildren<TankControllerUniversal>();
        AgentCollider = Tank.GetComponentInChildren<BoxCollider>();
    }
    void OnCollisionEnter(Collision AgentCollider) 
    {   
        if (AgentCollider.gameObject.tag =="Tank")
        {
            TankScript.GiveDamage(AgentCollider, AttackDamage);
            
        }
        Destroy(this);
    }
}
