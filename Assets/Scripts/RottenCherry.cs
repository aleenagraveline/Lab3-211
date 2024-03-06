using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RottenCherry : Fruit
{
    protected override void scorePoints()
    {
        p.health -= 20;
        p.score -= 10;
    }

    protected override void fallOffScreen()
    {

    }
}
