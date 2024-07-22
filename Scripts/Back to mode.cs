using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class Backtomode : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update    
    public void back()
    {
        StartCoroutine(Dis());
    }
    IEnumerator Dis()
    {
        PhotonNetwork.LeaveRoom();
        while(PhotonNetwork.InRoom)
        {
            yield return null;
        }
        PhotonNetwork.Disconnect();
        
        while (PhotonNetwork.IsConnected)
        {
            yield return null;
        }
        SceneManager.LoadScene("Loding");
    }
    public void leave()
    {
        PhotonNetwork.LeaveRoom();
    }
}
