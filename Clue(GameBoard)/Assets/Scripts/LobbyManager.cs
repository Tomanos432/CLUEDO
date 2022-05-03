using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using TMPro;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    public TextMeshProUGUI roomName;
    public TextMeshProUGUI P1Name;
    public TextMeshProUGUI P2Name;
    public TextMeshProUGUI P3Name;
    public TextMeshProUGUI P4Name;
    public TextMeshProUGUI P5Name;
    public TextMeshProUGUI P6Name;
    

    private void Start()
    {
        roomName.text = "Room Name: " + PhotonNetwork.CurrentRoom.Name;
    }
    
}
