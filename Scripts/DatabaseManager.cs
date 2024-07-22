using Firebase.Database;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class DatatoSave
{
    public string username;
    public string password;
}
public class DatabaseManager : MonoBehaviour
{
    public DatatoSave dts;
    private string userID;
    private DatabaseReference dbref;

    private void Awake()
    {
        dbref = FirebaseDatabase.DefaultInstance.RootReference;
    }

    public void saveData()
    {
        string json = JsonUtility.ToJson(dts);
        dbref.Child("users").Child(userID).SetRawJsonValueAsync(json);
    }

    public void loadData()
    {

    }
}
