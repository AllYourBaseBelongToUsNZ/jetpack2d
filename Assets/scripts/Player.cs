using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 10f;
	public Vector2 MaxVelocity = new Vector2(3,5);
	public bool standing;
	public float jetSpeed =15f;
	public float airSpeedMultiplier =.3f;
	private Animator animator;
	public Player_Controller controller;
	
	// Use this for initialization
	void Start () {
		
		controller = GetComponent<Player_Controller> ();
			
	}

	// Update is called once per frame
	void Update () {

		var forceX = 0f;
		var forceY = 0f;

		var ABSVelX = Mathf.Abs (rigidbody2D.velocity.x);
		var ABSVelY = Mathf.Abs (rigidbody2D.velocity.y);


		if (controller.moving.x != 0) {
				
						if (ABSVelX < MaxVelocity.x) {


								forceX = standing ? speed * controller.moving.x : (speed * controller.moving.x * airSpeedMultiplier);
								transform.localScale = new Vector3 (forceX > 0 ? 1 : -1, 1, 1);

						}

						//trigger the animation state in the animator
						animator.SetInteger ("AnimState", 1);

				} else {
				//trigget the idle animation state in the animator
				animator.SetInteger ("AnimState", 0);

				}

		if (controller.moving.y > 0){

			if(ABSVelY < MaxVelocity.y)

				forceY = jetSpeed * controller.moving.y;


		}

		rigidbody2D.AddForce (new Vector2 (forceX, forceY));
	
	}
}
