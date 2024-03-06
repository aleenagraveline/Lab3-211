using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] public float speed = 7.0f;
    [SerializeField] public int score = 0;
    [SerializeField] public int highScore = 0;
    [SerializeField] public int health = 100;
    [SerializeField] private SpawnFruits spawner;
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text gameOverText;
    [SerializeField] private TMP_Text healthText;
    [SerializeField] private Button startButton;
    [SerializeField] private TMP_Text startButtonText;
    [SerializeField] private TMP_Text instructions;

    void Start()
    {
        Pause(true);
    }

    void Update()
    {
        float movement = Input.GetAxis("Horizontal");

        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;

        if(transform.position.x <= -9)
        {
            transform.position = new Vector3(9, transform.position.y, transform.position.z);
        }
        else if(transform.position.x >= 9)
        {
            transform.position = new Vector3(-9, transform.position.y, transform.position.z);
        }

        scoreText.SetText("Score: " + score);

        if (health < 0)
        {
            Pause(true);
            gameOverText.SetText("GAME OVER.\nHighest Score: " + highScore);
            gameOverText.gameObject.SetActive(true);
            healthText.SetText("Health: 0");
            startButtonText.SetText("RESTART");
            startButton.gameObject.SetActive(true);
        }
        else
        {
            healthText.SetText("Health: " + health);
        }
    }

    private void Pause(bool paused)
    {
        if(paused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void StartGame()
    {
        spawner.SetInitialValues();
        speed = 7.0f;
        score = 0;
        highScore = 0;
        health = 100;
        startButton.gameObject.SetActive(false);
        instructions.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
        Pause(false);
    }
}
