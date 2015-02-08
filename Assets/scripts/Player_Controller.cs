using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour {

	public Vector2 moving = new Vector2();

	
	// Update is called once per frame
	void Update () {

		moving.x = moving.y = 0;

		if (Input.GetKey ("d")) {

			moving.x =1;

		} else if (Input.GetKey ("a")) {

			moving.x =-1;	

		}



		 if (Input.GetKey ("w")) {

			moving.y = 1;	

		} else if (Input.GetKey ("s")) {

			moving.y = -1;


		}
	
	}
}
