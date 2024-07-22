using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRoom : MonoBehaviourPunCallbacks
{
    public InputField CreateInput, JoinInput;

    public void createRoom()
    {
        string create = CreateInput.text;
        StaticData.valueCreate = create;
        PhotonNetwork.CreateRoom(create);
    }
    public void joinRoom()
    { 
        string join = JoinInput.text;
        StaticData.valueJoin = join;
        PhotonNetwork.JoinRoom(JoinInput.text);
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("AvatarControl");
    }
}
