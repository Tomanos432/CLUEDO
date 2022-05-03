using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField createInput;
    public InputField joinInput;
    //public InputField usernameIn;

    public void CreateRoom()
    {
        //PhotonNetwork.NickName = usernameIn.text;
        PhotonNetwork.CreateRoom(createInput.text);
    }

    public void JoinRoom()
    {
        //PhotonNetwork.NickName = usernameIn.text;
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public override void OnJoinedRoom()
    {
        StreamChatBehaviour.instance.GetOrCreateChannel(PhotonNetwork.CurrentRoom.Name);
        PhotonNetwork.LoadLevel("SampleScene");
    }
    
}
