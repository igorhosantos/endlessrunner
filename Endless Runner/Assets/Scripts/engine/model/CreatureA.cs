﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureA : Enemy
{
    public override EnemyAction FactoryMethod()
    {
        return new EnemyAction(1);
    }

}