﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameView : MonoBehaviour
{
    private RunView board;

    void Awake()
    {
        board = transform.Find("Board").gameObject.AddComponent<RunView>();
    }


 
}