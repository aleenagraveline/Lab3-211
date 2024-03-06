using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fruit : MonoBehaviour
{
    [SerializeField] protected Player p;
    [SerializeField] protected SpawnFruits spawner;

    void Awake()
    {
        p = GameObject.FindGameObjectsWithTag("PlayerObject")[0].GetComponent<Player>();
        spawner = GameObject.FindGameObjectsWithTag("Spawner")[0].GetComponent<SpawnFruits>();
    }

    void Update()
    {
        if (transform.position.y < -5)
        {
            fallOffScreen();
            Destroy(gameObject);
        }

        if(p.health < 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject == p.gameObject)
        {
            scorePoints();
            Destroy(gameObject);
        }
    }

    protected abstract void scorePoints();

    protected abstract void fallOffScreen();

    protected void setHighScore()
    {
        if (p.score > p.highScore)
        {
            p.highScore = p.score;

            switch (spawner.difficulty)
            {
                case SpawnFruits.Difficulty.Beginner:
                    if (p.highScore >= 20)
                    {
                        spawner.speedUp("Easy");
                    }
                    break;

                case SpawnFruits.Difficulty.Easy:
                    if(p.highScore >= 40)
                    {
                        spawner.speedUp("Medium");
                    }
                    break;

                case SpawnFruits.Difficulty.Medium: 
                    if(p.highScore >= 60)
                    {
                        spawner.speedUp("Hard");
                    }
                    break;

                case SpawnFruits.Difficulty.Hard:
                    if(p.highScore >= 80)
                    {
                        spawner.speedUp("Extreme");
                    }
                    break;

                case SpawnFruits.Difficulty.Extreme:
                    if(p.highScore >= 100)
                    {
                        spawner.speedUp("Expert");
                    }
                    break;
            }
        }
    }
}
