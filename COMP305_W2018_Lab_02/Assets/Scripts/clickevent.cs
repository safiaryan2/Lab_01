using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickevent : MonoBehaviour {


    public GameObject GreenPlayer;
    public Sprite greenPlayer;


    private SpriteRenderer sRend;
    void Start()
    {
        sRend = GreenPlayer.GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        sRend.sprite = greenPlayer;
    }
}
