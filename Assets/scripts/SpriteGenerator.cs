using UnityEngine;
using System.Collections;
//script for collectables AND crystals
public class SpriteGenerator : MonoBehaviour {

	//array of all sprites in the resources folder.
	public Sprite[] sprites;
	//name of the file used to pull the texture out of the resources folder.
	public string resourceName;
	//if the id of the sprite is set,overide the random function
	public int CurrentSprite = -1;

	// Use this for initialization
	void Start () {
		//check that resources do not have a null file name

		if (resourceName != "") {
			sprites = Resources.LoadAll<Sprite> (resourceName);

			//reference the sprite renderer and randomly pick a sprite from the sprites array

			if(CurrentSprite == -1)
				CurrentSprite = Random.Range(0,sprites.Length);
			//if the id is greater than the sprite id length,set it back to it's length -1.
			else if(CurrentSprite > sprites.Length)
				CurrentSprite = sprites.Length -1;

			GetComponent<SpriteRenderer>().sprite = sprites[CurrentSprite];

		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
