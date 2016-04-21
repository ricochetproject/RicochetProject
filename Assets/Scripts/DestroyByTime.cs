using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour
{

    public float lifeTime;
    private GameController gameController;
    // Use this for initializati
    void Start()
    {

        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }

        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script!");
        }

        Destroy(gameObject, lifeTime);



        
    }

    public void OnDestroy()
    {
        gameController.DecFoodOnScreen();
    }
}
