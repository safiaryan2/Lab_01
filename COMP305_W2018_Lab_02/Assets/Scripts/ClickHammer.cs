using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHammer : MonoBehaviour {


	public GameObject GreenPlayer;
   // public GameObject GreenButton;
    //public GameObject YellowButton;

    //public Sprite firstImage;
	public Sprite bluePlayer;
    //public Sprite thirdImage;

	private SpriteRenderer sRend;
    private Rigidbody2D rBody;
    

	// initiaisation

	void Start()
	{
		// Player.velocity = new Vector2 (5, 0);
		rBody = GreenPlayer.GetComponent<Rigidbody2D> ();
		sRend = GreenPlayer.GetComponent<SpriteRenderer> ();
     
		 rBody.velocity = new Vector2 (0, 0);

        //if (gameObject.tag== "blueButton")
        //{
        //    Debug.Log("greeb button Start !!!!");
        //}
    }

   
    void Update()
	{
	}
	void OnMouseDown () {

        sRend.sprite =bluePlayer;


        //if (sRend.sprite == firstImage)
        //{
        //    Debug.Log("hello 1");
        //    sRend.sprite = secondImage;
        //}
        //else
        //{
        //    sRend.sprite = firstImage;
        //}
            //    else if (sRend.sprite == secondImage)
            //{
            //          Debug.Log("hello2");
            //          sRend.sprite = thirdImage;
            //}
            //else
            //{
            //    Debug.Log("hello3");
            //    sRend.sprite = firstImage;
            //}
            // Debug.Log (gObject.name);

        }
}
