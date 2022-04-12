using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour
{
    [SerializeField] private int Playercount;
    public Tile TileOriginal;
    public Player PlayerOriginal;
    public GameObject TileContainer, PlayerContainer;
    private List<Player> players = new List<Player>();
    int[,] tileposition = {{0, 6},{0, 19},{1, 6},{1, 7},{1, 13},{1, 19},{1, 20},{2, 6},{2, 7},{2, 13},{2, 19},{2, 20},{3, 6},{3, 7},{3, 13},{3, 19},{3, 20},{4, 6},{4, 7},{4, 13},{4, 19},{4, 20},{5, 5},{5, 6},{5, 7},{5, 13},{5, 19},{5, 20},{6, 2},{6, 3},{6, 4},{6, 5},{6, 6},{6, 7},{6, 8},{6, 9},{6, 10},{6, 11},{6, 12},{6, 13},{6, 14},{6, 18},{6, 19},{6, 20},{7, 1},{7, 2},{7, 3},{7, 4},{7, 5},{7, 6},{7, 7},{7, 8},{7, 9},{7, 10},{7, 11},{7, 12},{7, 13},{7, 14},{7, 15},{7, 16},{7, 17},{7, 18},{7, 19},{7, 20},{7, 21},{7, 22},{7, 23},{7, 24},{8, 1},{8, 8},{8, 9},{8, 10},{8, 11},{8, 12},{8, 13},{8, 14},{8, 15},{8, 16},{8, 17},{8, 18},{8, 19},{8, 20},{8, 21},{8, 22},{8, 23},{9, 0},{9, 1},{9, 8},{9, 9},{9, 17},{10, 8},{10, 9},{10, 17},{11, 8},{11, 9},{11, 17},{12, 8},{12, 9},{12, 17},{13, 8},{13, 9},{13, 17},{14, 0},{14, 1},{14, 8},{14, 9},{14, 10},{14, 11},{14, 12},{14, 13},{14, 14},{14, 15},{14, 16},{14, 17},{15, 1},{15, 8},{15, 9},{15, 10},{15, 11},{15, 12},{15, 13},{15, 14},{15, 15},{15, 16},{15, 17},{15, 18},{15, 19},{15, 20},{15, 21},{15, 22},{15, 23},{16, 1},{16, 2},{16, 3},{16, 4},{16, 5},{16, 6},{16, 7},{16, 8},{16, 9},{16, 16},{16, 17},{16, 18},{16, 19},{16, 20},{16, 21},{16, 22},{16, 23},{16, 24},{17, 2},{17, 3},{17, 4},{17, 5},{17, 6},{17, 7},{17, 8},{17, 9},{17, 16},{17, 17},{17, 18},{18, 7},{18, 8},{18, 9},{18, 16},{18, 17},{18, 18},{19, 7},{19, 8},{19, 16},{19, 17},{19, 18},{20, 7},{20, 8},{20, 16},{20, 17},{20, 18},{21, 7},{21, 8},{21, 16},{21, 17},{21, 18},{22, 7},{22, 8},{22, 16},{22, 17},{22, 18},{23, 7},{23, 17}};
    int[,] playerposition = {{0, 6}, {0, 19}, {9, 0}, {14, 0}, {16, 24}, {23, 17}};
    void Start()
    {
        Camera.main.orthographicSize = (25/2)+2;
        Camera.main.transform.position = new Vector3(((float) (25 / 2) - .5f), ((float) (25 / 2) - .5f), -12);
        for (int n = 0; n < 188; n++)
        {
            Tile TileClone = Instantiate(TileOriginal, new Vector2(tileposition[n,0], tileposition[n,1]), Quaternion.identity);
            TileClone.transform.parent = TileContainer.transform;
            TileClone.name = $"Tile {tileposition[n,0]} {tileposition[n,1]}";
        }
        for (int n = 0; n < Playercount; n++)
        {
            Player PlayerClone = Instantiate(PlayerOriginal, new Vector2(playerposition[n,0], playerposition[n,1]), Quaternion.identity);
            PlayerClone.transform.parent = PlayerContainer.transform;
            PlayerClone.name = $"Player {n+1}";
            players.Add(PlayerClone);
        }
        foreach(var Player in players)
     {
         Debug.Log(Player.ToString() + "\n");
     }
    }
}