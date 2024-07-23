# Metaverse
Codes and data related to all the things we have done in our metaverse Project. Collaborators: Kushal Mohite, Tanvi Dhonukshe

## For the metverse project we have used:
* [Unity](https://docs.unity.com/) : Creating Metverse World
* [Photon Unity Network 2 (PUN2)](https://doc.photonengine.com/pun/current/getting-started/pun-intro) : Create Multiplayer system
* [PUN Voice 2](https://doc.photonengine.com/voice/current/getting-started/voice-for-pun) : Enabbling Audio communication within multiplayer world
* [ConvAI](https://docs.convai.com/api-docs) : Creating an AI for healthcare assistance
* [PlayFab](https://learn.microsoft.com/en-us/gaming/playfab/) : To store user login data
* [Ready Player Me](https://docs.readyplayer.me/ready-player-me) : For Avatar creation and personlize designing

## Programming languages used:
* [C#](https://docs.unity3d.com/Manual/ScriptingSection.html) :
  * Used for linking our file to the database
  * Sending and receiving data from database
  * Adding action to buttons and UI components
  * Setting properties to every object of the project

## To work with unity: 
* Download and install unity -> open Unity
* Create a new 3D project
* In the project pannel Right Click -> 3D Object -> Terrain
* Use various terrain features (Add ground layers, trees, grass, etc.) by downloading it from [Unity Asset Store](https://assetstore.unity.com/)
* Use level up and down feature of terrain to create mountain or rough land structure.

## Script file used
* Back to mode : This script is used to redirect our scene from Heathcare or Multiplayer mode back to the page where we can select either of the mode again.
* ConnectToServer : This script is used to connect our player to the photon server for multiplayer system.
* CreateAndJoinRoom : This script is used for creating or joining a room in multiplayer system on photon server.
* Modes : This script contains action for Modes scene buttons to enter either of the mode.
* PlayFabManager : This script is u to store and fetch data from the PlayFab database
* StaticData : This script is used to temporarily store data so that is can transfer room code data from CreateAndJoinRoom C# file to PhotonSetupManager C# file.
* PhotonSetupManager : This script file is used to connect our application to Photon Server and create or join a particular room for multiplayer communication.


## Adding C# to Game Object
* To add C# script to Game Object
  * Create empty game object in the project hierarchy
  * Create the C# script you want to add
  * Drag and drop the created script file to the inspector of the created empty game object
### ![Adding Script to Game Object](https://github.com/Falcon1-0/Metaverse/blob/main/Assets/Adding%20script%20to%20object.png)
