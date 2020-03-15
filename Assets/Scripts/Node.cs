﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public bool isOccupied;
    public int xPos;
    public int yPos;

    public Node(int xPos, int yPos, bool isOccupied)
    {
        this.xPos = xPos;
        this.yPos = yPos;
        this.isOccupied = isOccupied;
    }
}