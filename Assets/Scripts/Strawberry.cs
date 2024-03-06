using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strawberry : Fruit
{
    protected override void scorePoints()
    {
        p.score += 2;
        setHighScore();
    }

    protected override void fallOffScreen()
    {
        p.health -= 2;
    }
}
