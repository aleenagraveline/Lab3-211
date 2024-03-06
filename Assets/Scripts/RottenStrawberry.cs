using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RottenStrawberry : Fruit
{
    protected override void scorePoints()
    {
        p.health -= 4;
        p.score -= 2;
    }

    protected override void fallOffScreen()
    {

    }
}
