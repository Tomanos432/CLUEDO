using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class GameBoard : MonoBehaviour
{
    public GameObject TileContainer, PlayerContainer, RoomContainer, SuggestMenu;
    public Player player;
    public Tile tile;
    [SerializeField] private int Playercount;
    [SerializeField] private Color tilehighlight, doorhighlight;
    int[,] tileposition = {{0, 6},{0, 19},{1, 6},{1, 7},{1, 13},{1, 19},{1, 20},{2, 6},{2, 7},{2, 13},{2, 19},{2, 20},{3, 6},{3, 7},{3, 13},{3, 19},{3, 20},{4, 6},{4, 7},{4, 13},{4, 19},{4, 20},{5, 5},{5, 6},{5, 7},{5, 13},{5, 19},{5, 20},{6, 2},{6, 3},{6, 4},{6, 5},{6, 6},{6, 7},{6, 8},{6, 9},{6, 10},{6, 11},{6, 12},{6, 13},{6, 14},{6, 18},{6, 19},{6, 20},{7, 1},{7, 2},{7, 3},{7, 4},{7, 5},{7, 6},{7, 7},{7, 8},{7, 9},{7, 10},{7, 11},{7, 12},{7, 13},{7, 14},{7, 15},{7, 16},{7, 17},{7, 18},{7, 19},{7, 20},{7, 21},{7, 22},{7, 23},{7, 24},{8, 1},{8, 8},{8, 9},{8, 10},{8, 11},{8, 12},{8, 13},{8, 14},{8, 15},{8, 16},{8, 17},{8, 18},{8, 19},{8, 20},{8, 21},{8, 22},{8, 23},{9, 0},{9, 1},{9, 8},{9, 9},{9, 17},{10, 8},{10, 9},{10, 17},{11, 8},{11, 9},{11, 17},{12, 8},{12, 9},{12, 17},{13, 8},{13, 9},{13, 17},{14, 0},{14, 1},{14, 8},{14, 9},{14, 10},{14, 11},{14, 12},{14, 13},{14, 14},{14, 15},{14, 16},{14, 17},{15, 1},{15, 8},{15, 9},{15, 10},{15, 11},{15, 12},{15, 13},{15, 14},{15, 15},{15, 16},{15, 17},{15, 18},{15, 19},{15, 20},{15, 21},{15, 22},{15, 23},{16, 1},{16, 2},{16, 3},{16, 4},{16, 5},{16, 6},{16, 7},{16, 8},{16, 9},{16, 16},{16, 17},{16, 18},{16, 19},{16, 20},{16, 21},{16, 22},{16, 23},{16, 24},{17, 2},{17, 3},{17, 4},{17, 5},{17, 6},{17, 7},{17, 8},{17, 9},{17, 16},{17, 17},{17, 18},{18, 7},{18, 8},{18, 9},{18, 16},{18, 17},{18, 18},{19, 7},{19, 8},{19, 16},{19, 17},{19, 18},{20, 7},{20, 8},{20, 16},{20, 17},{20, 18},{21, 7},{21, 8},{21, 16},{21, 17},{21, 18},{22, 7},{22, 8},{22, 16},{22, 17},{22, 18},{23, 7},{23, 17}};
    int[,] playerposition = {{16, 24}, {23, 17}, {14, 0}, {9, 0}, {0, 6}, {0, 19}};
    System.Random rand = new System.Random();
    Tile[,] tiles = new Tile[26, 27];
    Player[] players = new Player[6];
    int playerturn, roll;
    System.Random rnd = new System.Random();
    void Start()
    {
        Camera.main.orthographicSize = (24/2)+5;
        Camera.main.transform.position = new Vector3(((float) (25 / 2) - .5f), ((float) (25 / 2) - .5f), -12);
        for (int n = 0; n < 188; n++)
        {
            Tile TileClone = Instantiate(tile, new Vector2(tileposition[n,0], tileposition[n,1]), Quaternion.identity);
            TileClone.name = $"Tile {tileposition[n,0]} {tileposition[n,1]}";
            TileClone.transform.parent = TileContainer.transform;
            tiles[tileposition[n,0]+1,tileposition[n,1]+1] = TileClone;
            TileClone.OnClick += MovePlayerToTile;
        }
        for (int n = 0; n < Playercount; n++)
        {
            Player PlayerClone = Instantiate(player, new Vector2(playerposition[n,0], playerposition[n,1]), Quaternion.identity);
            tiles[playerposition[n,0]+1, playerposition[n,1]+1].occupied = true;
            PlayerClone.transform.parent = PlayerContainer.transform;
            PlayerClone.name = $"Player {n+1}";
            players[n] = PlayerClone;
        }
        playerturn = 0;
        roll = 5;
    }
    bool enter = false, passturn = false;
    private void Update() {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            InitiateTurn(playerturn);
        }
        if (Input.GetKeyUp(KeyCode.Return) || Input.GetKeyUp(KeyCode.KeypadEnter))
        {
            enter = true;
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            passturn = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            secretpassage();
        }
    }
    void InitiateTurn(int playerturn)
    {
        CheckMoves(new Vector2(players[playerturn].transform.position.x+1, players[playerturn].transform.position.y+1), 1);
    }
    void CheckMoves(Vector2 checkpos, int steps)
    {
        if (players[playerturn].transform.parent != PlayerContainer.transform)
        {
            switch (players[playerturn].transform.parent.transform.GetSiblingIndex())
            {
                case 0: if (tiles[6+1, 20+1].occupied == false)tiles[6+1, 20+1].myrenderer.color = doorhighlight; break;
                case 1: if (tiles[8+1, 20+1].occupied == false)tiles[8+1, 20+1].myrenderer.color = doorhighlight;
                        if (tiles[11+1, 17+1].occupied == false)tiles[11+1, 17+1].myrenderer.color = doorhighlight;
                        if (tiles[12+1, 17+1].occupied == false)tiles[12+1, 17+1].myrenderer.color = doorhighlight; break;
                case 2: if (tiles[17+1, 18+1].occupied == false)tiles[17+1, 18+1].myrenderer.color = doorhighlight; break;
                case 3: if (tiles[7+1, 16+1].occupied == false)tiles[7+1, 16+1].myrenderer.color = doorhighlight;
                        if (tiles[3+1, 13+1].occupied == false)tiles[3+1, 13+1].myrenderer.color = doorhighlight; break;
                case 4: if (tiles[1+1, 13+1].occupied == false)tiles[1+1, 13+1].myrenderer.color = doorhighlight;
                        if (tiles[6+1, 9+1].occupied == false)tiles[6+1, 9+1].myrenderer.color = doorhighlight; break;
                case 5: if (tiles[17+1, 16+1].occupied == false)tiles[17+1, 16+1].myrenderer.color = doorhighlight;
                        if (tiles[15+1, 12+1].occupied == false)tiles[15+1, 12+1].myrenderer.color = doorhighlight; break;
                case 6: if (tiles[5+1, 5+1].occupied == false)tiles[5+1, 5+1].myrenderer.color = doorhighlight; break;
                case 7: if (tiles[7+1, 5+1].occupied == false)tiles[7+1, 5+1].myrenderer.color = doorhighlight;
                        if (tiles[9+1, 8+1].occupied == false)tiles[9+1, 8+1].myrenderer.color = doorhighlight;
                        if (tiles[14+1, 8+1].occupied == false)tiles[14+1, 8+1].myrenderer.color = doorhighlight;
                        if (tiles[16+1, 5+1].occupied == false)tiles[16+1, 5+1].myrenderer.color = doorhighlight; break;
                case 8: if (tiles[19+1, 7+1].occupied == false)tiles[19+1, 7+1].myrenderer.color = doorhighlight; break;
            }

        }
        else
        {
            int h = 0, v = 0;
            for (int direction = 0; direction < 4; direction++)
            {
                switch (direction)
                {
                    case 0: h = -1; v = 0; break;
                    case 1: h = 0; v = 1; break;
                    case 2: h = 1; v = 0; break;
                    case 3: h = 0; v = -1; break;
                }
                Tile checktile = tiles[(int)checkpos.x+h, (int)checkpos.y+v];
                if (checktile != null && checktile.occupied == false && ((checktile.Distance - steps >= 2) || steps == 1 || checktile.Distance == 0))
                {   
                    checktile.myrenderer.color = (checktile.myrenderer.color == tile.doorway || checktile.myrenderer.color == doorhighlight) ? doorhighlight : tilehighlight;
                    if (checktile.myrenderer.color == tilehighlight) checktile.myrenderer.color = tile.move;
                    checktile.Distance = steps;
                    if (steps != roll)
                    {
                        CheckMoves(new Vector2(checkpos.x+h , checkpos.y+v), steps + 1);
                    }
                    else
                    {
                        checktile.myrenderer.color = (checktile.myrenderer.color == tile.doorway || checktile.myrenderer.color == doorhighlight) ? doorhighlight : tilehighlight;
                    }
                }
            }
        }
        
    }
    IEnumerator MovePlayerToTile(Vector2 pos) 
    {
        bool startinroom = false;
        int room = 0;
        Tile tile = tiles[(int)pos.x+1, (int)pos.y+1];
        if ((tile.myrenderer.color == doorhighlight || tile.myrenderer.color == tilehighlight) && !passturn)
        {
            if (players[playerturn].transform.parent == PlayerContainer.transform) 
            {
                SuggestMenu.SetActive(false);
                tiles[(int)players[playerturn].transform.position.x+1, (int)players[playerturn].transform.position.y+1].occupied = false;
            }
            else
            {
                SuggestMenu.SetActive(true);
                players[playerturn].transform.parent = PlayerContainer.transform;
                startinroom = true;
            }
            tile.occupied = true;
            players[playerturn].transform.position = new Vector2(pos.x, pos.y);

            if (tile.myrenderer.color == doorhighlight)
            {
                switch ((tile.transform.position.x, tile.transform.position.y))
                {
                    //study 
                    case (6, 20): room = 0; break;
                    //hall
                    case (8, 20):
                    case (11, 17):
                    case (12, 17): room = 1;break;
                    //lounge
                    case (17, 18): room = 2;break;
                    //library
                    case (7, 16):
                    case (3, 13): room = 3;break;
                    //billiard room
                    case (1, 13):
                    case (6, 9): room = 4;break;
                    //dining room
                    case (17, 16):
                    case (15, 12): room = 5;break;
                    //conservatory
                    case (5, 5): room = 6;break;
                    //ball room
                    case (7, 5):
                    case (9, 8):
                    case (14, 8):
                    case (16, 5): room = 7;break;
                    //kitchen
                    case (19, 7): room = 8;break;
                }
                if (startinroom)
                {
                    passturn = true;
                    playerturn--;
                }
                else
                {
                    yield return new WaitUntil(() => (enter || passturn));
                    if (enter)
                    {
                        tiles[(int)players[playerturn].transform.position.x+1, (int)players[playerturn].transform.position.y+1].occupied = false;
                        players[playerturn].transform.parent = RoomContainer.transform.GetChild(room).transform;
                        for (int i = 0; i < RoomContainer.transform.GetChild(room).childCount; i++)
                        {
                            float angle = i * Mathf.PI*2f / RoomContainer.transform.GetChild(room).childCount;
                            RoomContainer.transform.GetChild(room).GetChild(i).transform.position = new Vector2(Mathf.Cos(angle)+RoomContainer.transform.GetChild(room).transform.position.x, Mathf.Sin(angle)+RoomContainer.transform.GetChild(room).transform.position.y);   
                        }
                        passturn = true;
                    }
                }
            }
            foreach (var item in tiles)
            {
                if (item != null)
                {
                    item.myrenderer.color = (item.myrenderer.color == doorhighlight || item.myrenderer.color == item.doorway) ? item.doorway : item.tile;
                    item.Distance = 0;
                }
            }
            yield return new WaitUntil(() => (passturn));
        }
        if(passturn) playerturn++;
        if (playerturn == Playercount) playerturn = 0;
        enter = false;
        passturn = false;
        startinroom = false;
        roll = rnd.Next(2,13);
        InitiateTurn(playerturn);
    }
    void secretpassage()
    {
        if (passturn == false && players[playerturn].transform.parent != PlayerContainer.transform)
        {
            switch (players[playerturn].transform.parent.transform.GetSiblingIndex())
            {
                case 0: players[playerturn].transform.parent = RoomContainer.transform.GetChild(8).transform; break;
                case 2: players[playerturn].transform.parent = RoomContainer.transform.GetChild(6).transform; break;
                case 6: players[playerturn].transform.parent = RoomContainer.transform.GetChild(2).transform; break;
                case 8: players[playerturn].transform.parent = RoomContainer.transform.GetChild(0).transform; break;
                default: goto skip;
            }
            for (int i = 0; i < RoomContainer.transform.GetChild(players[playerturn].transform.parent.transform.GetSiblingIndex()).childCount; i++)
            {
                float angle = i * Mathf.PI*2f / RoomContainer.transform.GetChild(players[playerturn].transform.parent.transform.GetSiblingIndex()).childCount;
                RoomContainer.transform.GetChild(players[playerturn].transform.parent.transform.GetSiblingIndex()).GetChild(i).transform.position = new Vector2(Mathf.Cos(angle)+RoomContainer.transform.GetChild(players[playerturn].transform.parent.transform.GetSiblingIndex()).transform.position.x, Mathf.Sin(angle)+RoomContainer.transform.GetChild(players[playerturn].transform.parent.transform.GetSiblingIndex()).transform.position.y);   
            }
            foreach (var item in tiles)
            {
                if (item != null)
                {
                    item.myrenderer.color = (item.myrenderer.color == doorhighlight || item.myrenderer.color == item.doorway) ? item.doorway : item.tile;
                    item.Distance = 0;
                }
            }
            passturn = true;
            StartCoroutine(MovePlayerToTile(new Vector2(5, 7)));
        }
        skip:;
    }
}