using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowCharChng : MonoBehaviour {


    public GameObject GreenPlayer;   
    public Sprite yellowPlayer;

    private SpriteRenderer sRend;

    // initiaisation

    void Start()
    {
        sRend = GreenPlayer.GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        sRend.sprite = yellowPlayer;
    }
}
