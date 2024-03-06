using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RottenWatermelon : Fruit
{
    protected override void scorePoints()
    {
        p.health -= 2;
        p.score--;
    }

    protected override void fallOffScreen()
    {

    }
}
