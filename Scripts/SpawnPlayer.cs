using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerPrefab;
    public float minX, minY, minZ, maxX, maxY, maxZ;
    
    void Start()
    {
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
        PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
    }
}
