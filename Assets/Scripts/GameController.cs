using UnityEngine;
using System.Collections;
using System;

public class GameController : MonoBehaviour {

    public int numberOfFood;
    private int hits;

    public int hitsNeeded;

    public GUIText foodText;
    public GUIText hitsText;
    public GUIText gameOverText;

    private int foodOnScreen;

    private bool gameOver;
    private bool levelCompleted;
    private bool restart;

    // Use this for initialization
    //prolece je stiglo svima je do jaja hehe maj je 
    void Start () {
        restart = false;
        foodOnScreen = 0;
        gameOver = false;
        levelCompleted = false;
        hits = 0;
        foodText.text = "Food: " + numberOfFood;
        hitsText.text = "Score: " + hits + " / " + hitsNeeded;
        gameOverText.text = "";

	}
	
	// Update is called once per frame
	void Update () {

        if (numberOfFood == 0 && foodOnScreen == 0 && !levelCompleted) {
            GameOver();
        }

        if (gameOver)
        {



            if (Input.touchCount > 0 || Input.GetMouseButton(0))
            {

                Application.LoadLevel(Application.loadedLevel);

            }

        }
    }


    public void DecFood()
    {
        numberOfFood--;
        foodText.text = "Food: " + numberOfFood;

    }

    public void IncScore() {
        if(hits+1 > hitsNeeded)
        {
            return;
        }

        hits++;

        if (hits == hitsNeeded) {
            
            LevelCompleted();
         
        }
       
        hitsText.text = "Score: " + hits + " / " + hitsNeeded;
    }

    internal bool levelComplete()
    {
        if (hitsNeeded == hits)
        {
            return true;
        }
        else {
            return false;
        }
    }

    private void GameOver()
    {
        gameOverText.text = "Game Over";
        gameOver = true;
    }

    private void LevelCompleted()
    {
        levelCompleted = true;
        gameOverText.text = "Level Complete";
    }

    public void IncFoodOnScreen() {
        foodOnScreen++;
        Debug.Log("Food: " + foodOnScreen);
    }
    public void DecFoodOnScreen()
    {
        foodOnScreen--;
    }



}
