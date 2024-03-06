using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watermelon : Fruit
{
    protected override void scorePoints()
    {
        p.score++;
        setHighScore();
    }

    protected override void fallOffScreen()
    {
        p.health -= 1;
    }
}
