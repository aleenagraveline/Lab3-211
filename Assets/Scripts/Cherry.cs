using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cherry : Fruit
{
    protected override void scorePoints()
    {
        p.score += 10;
        setHighScore();
    }

    protected override void fallOffScreen()
    {
        p.health -= 10;
    }
}
