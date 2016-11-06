using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public GameObject shot;
	public Transform shotSpawn;

    private GameController gameController;



    public float fireRate = 0.5F;
	
	private float nextFire = 0.0F;//asdkjahdasjda


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

    }


    void Update()
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire && gameController.numberOfFood>0 && !gameController.levelComplete())
		{
			nextFire = Time.time + fireRate;
			GameObject clone = Instantiate(shot, shotSpawn.position, shotSpawn.rotation) as GameObject;
      
			GetComponent<AudioSource>().Play();
            gameController.DecFood();
            gameController.IncFoodOnScreen();
		}



	}
}
