using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RottenKiwi : Fruit
{
    protected override void scorePoints()
    {
        p.health -= 10;
        p.score -= 5;
    }

    protected override void fallOffScreen()
    {

    }
}
