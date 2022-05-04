using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using TMPro;

public class RoomName : MonoBehaviourPunCallbacks
{
    public TextMeshProUGUI roomName;
    
    private void Start()
    {
        roomName.text = "Room Name: " + PhotonNetwork.CurrentRoom.Name;
    }
    
}