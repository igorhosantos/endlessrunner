﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character {

    public abstract EnemyAction FactoryMethod();
}
