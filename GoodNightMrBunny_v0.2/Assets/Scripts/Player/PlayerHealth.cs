using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerHealth : AMonster
{
    protected override void Awake()
    {
        base.Awake();
    }

    public override void ChangeHealth(float value, bool IsDamage)
    {
        base.ChangeHealth(value, IsDamage);
    }

    public override void Die()
    {
        //Die();
    }
}
