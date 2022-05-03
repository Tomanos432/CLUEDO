using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    public InputField usernameIn;
    public TextMeshProUGUI buttonText;
    
    public void OnClickConnect()
    {
        PhotonNetwork.NickName = usernameIn.text;
        buttonText.text = "Loading...";
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        StreamChatBehaviour.instance.GetOrCreateClient(usernameIn.text);
        //PhotonNetwork.JoinLobby();
        SceneManager.LoadScene("Lobby");
    }

    //public override void OnJoinedLobby()
    //{
      //SceneManager.LoadScene("Lobby");  
    //}
    
}
