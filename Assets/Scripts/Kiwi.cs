using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiwi : Fruit
{
    protected override void scorePoints()
    {
        p.score += 5;
        setHighScore();
    }

    protected override void fallOffScreen()
    {
        p.health -= 5;
    }
}
