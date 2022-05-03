using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SendMessage : MonoBehaviour
{
    public TMP_InputField messageInputField;

    private void Awake()
    {
        StreamChatBehaviour.instance.SetContentObject();
    }
    
    public void OnClickSend()
    {
        StreamChatBehaviour.instance.SendChat(messageInputField.text);
    }
    
    
}
