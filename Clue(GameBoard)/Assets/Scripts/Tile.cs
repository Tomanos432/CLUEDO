using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private SpriteRenderer myrenderer;
    [SerializeField] private Color tile, doorway, mustard, scarlet, green, peacock, white, plum;
    [SerializeField] private GameObject highlight;
    public Player pawn;

    private void Start() {
        switch ((transform.position.x, transform.position.y))
        {
            case (1, 13): goto door;
            case (3, 13): goto door;
            case (5, 5): goto door;
            case (6, 9): goto door;
            case (6, 20): goto door;
            case (7, 5): goto door;
            case (7, 16): goto door;
            case (8, 20): goto door;
            case (9, 8): goto door;
            case (11, 17): goto door;
            case (12, 17): goto door;
            case (14, 8): goto door;
            case (15, 12): goto door;
            case (16, 5): goto door;
            case (17, 16): goto door;
            case (17, 18): goto door;
            case (19, 7): door: myrenderer.color = doorway; break;
            case (0, 6): myrenderer.color =  peacock; break;
            case (0, 19): myrenderer.color =  plum; break;
            case (9, 0): myrenderer.color =  green; break;
            case (14, 0): myrenderer.color =  white; break;
            case (16, 24): myrenderer.color =  scarlet; break;
            case (23, 17): myrenderer.color =  mustard; break;
            default: myrenderer.color = tile; break;
        }
    }
    void OnMouseEnter()
    {
        highlight.SetActive(true);
    }
    void OnMouseExit()
    {
        highlight.SetActive(false);
    }
    void OnMouseDown()
    {
        pawn.MovePlayerToTile(transform.position);
    }
}

//var x = (float)System.Math.Round(Camera.main.ScreenToWorldPoint(Input.mousePosition).x);
//var y = (float)System.Math.Round(Camera.main.ScreenToWorldPoint(Input.mousePosition).y);