using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Player : MonoBehaviour
{
    [SerializeField] private SpriteRenderer myrenderer;
    [SerializeField] private Color mustard, scarlet, green, peacock, white, plum;
    void Start()
    {
        switch ((transform.position.x, transform.position.y))
        {
            case (0, 6): myrenderer.color =  peacock; break;
            case (0, 19): myrenderer.color =  plum; break;
            case (9, 0): myrenderer.color =  green; break;
            case (14, 0): myrenderer.color =  white; break;
            case (16, 24): myrenderer.color =  scarlet; break;
            case (23, 17): myrenderer.color =  mustard; break;
        }
    }
    public void MovePlayerToTile(Vector2 pos) 
    {
        Debug.Log("current pos" + transform.position + "intended pos " + pos);
        transform.position = pos;
    }
}