using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruits : MonoBehaviour
{
    [SerializeField] private List<GameObject> fruits;
    [SerializeField] private float spawnCountdown = 3f;
    [SerializeField] private float spawnCountdownLength = 3f;
    [SerializeField] private int fruitToSpawn;
    [SerializeField] private Player player;
    [SerializeField] public Difficulty difficulty = Difficulty.Beginner;

    void Update()
    {
        if (spawnCountdown <= 0)
        {
            fruitToSpawn = Random.Range(1, 60);
            if (fruitToSpawn >= 1 && fruitToSpawn <= 25)
            {
                fruitToSpawn = 0;
            }
            else if (fruitToSpawn >= 26 && fruitToSpawn <= 45)
            {
                fruitToSpawn = 2;
            }
            else if (fruitToSpawn >= 46 && fruitToSpawn <= 55)
            {
                fruitToSpawn = 4;
            }
            else
            {
                fruitToSpawn = 6;
            }

            if (Random.Range(1, 10) >= 8)
            {
                fruitToSpawn++;
            }
            
            Instantiate(fruits[fruitToSpawn], new Vector3(Random.Range(-7f, 7f), 7f, 0), Quaternion.identity);
            spawnCountdown = spawnCountdownLength;
        }

        spawnCountdown -= Time.deltaTime;
    }

    public void speedUp(string diff)
    {
        spawnCountdownLength -= 0.5f;
        player.speed += 5; 

        if(diff.Equals("Easy"))
        {
            difficulty = Difficulty.Easy;
        }
        else if(diff.Equals("Medium"))
        {
            difficulty = Difficulty.Medium;
        }
        else if(diff.Equals("Hard"))
        {
            difficulty = Difficulty.Hard;
        }
        else if(diff.Equals("Extreme"))
        {
            difficulty = Difficulty.Extreme;
        }
        else
        {
            difficulty = Difficulty.Expert;
        }
    }

    public void SetInitialValues()
    {
        spawnCountdown = 3.0f;
        spawnCountdownLength = 3.0f;
        difficulty = Difficulty.Beginner;
    }

    public enum Difficulty { Beginner, Easy, Medium, Hard, Extreme, Expert }
}

