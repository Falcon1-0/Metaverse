# Metaverse
Codes and data related to all the things we have done in our metaverse Project. Collaborators: Kushal Mohite, Tanvi Dhonukshe

## Abstract
This project envisions a healthcare metaverse platform that revolutionizes patient engagement and accessibility. Built with Unity and featuring customizable avatars from Ready Player Me. Patients can engage in consultations with healthcare providers, shedding geographical limitations. Beyond consultations, the platform empowers users to explore treatment options through interactive simulations, promoting informed decision-making, the platform also fosters a comprehensive and immersive virtual environment.

At the heart of this virtual space lies a powerful medical information search engine powered by an open-source AI module. This intelligent engine simplifies access to a vast ocean of healthcare knowledge, fostering a deeper understanding of individual well-being. To further empower patients, the platform leverages AI to provide personalized doctor recommendations. This ensures patients connect with the most suitable healthcare professionals for their specific needs.

The platform doesn't stop at individual consultations. The metaverse's interactive nature fosters social interaction among patients. Avatars become a tool for building communities and support networks, fostering a sense of connection and shared experiences. This holistic approach to healthcare goes beyond traditional medical care, promoting a patient-centric environment that empowers individuals to take charge of their health journey.


## Tools used:
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
* *Back to mode :* This script is used to redirect our scene from Heathcare or Multiplayer mode back to the page where we can select either of the mode again.
* *ConnectToServer :* This script is used to connect our player to the photon server for multiplayer system.
* *CreateAndJoinRoom :* This script is used for creating or joining a room in multiplayer system on photon server.
* *Modes :* This script contains action for Modes scene buttons to enter either of the mode.
* *PlayFabManager :* This script is u to store and fetch data from the PlayFab database
* *StaticData :* This script is used to temporarily store data so that is can transfer room code data from CreateAndJoinRoom C# file to PhotonSetupManager C# file.
* *PhotonSetupManager :* This script file is used to connect our application to Photon Server and create or join a particular room for multiplayer communication.


## Adding C# to Game Object
* To add C# script to Game Object
  * Create empty game object in the project hierarchy
  * Create the C# script you want to add
  * Drag and drop the created script file to the inspector of the created empty game object
### ![Adding Script to Game Object](https://github.com/Falcon1-0/Metaverse/blob/main/Assets/Adding%20script%20to%20object.png)

## Video Tutorials
* [How to create Metaverse](https://www.youtube.com/watch?v=nCDGjLRecrs)
* [How to add Customize Avatar](https://www.youtube.com/watch?v=x64CV_fVOt8)
* [How to add ConvAI](https://www.youtube.com/watch?v=Vhr7IvfITgU)
* [PlayFab Integration](https://www.youtube.com/watch?v=QS_sl7jNyVc&list=PL1aAeF6bPTB4oP-Tejys3n8P8iXlj7uj-&index=6)
* [How to add Photon Unity Networking for multiplayer](https://www.youtube.com/watch?v=93SkbMpWCGo)
* [Adding PUN Voice 2 for Audio communication in multiplayer](https://www.youtube.com/watch?v=yjUltw6eypQ)

## Game Files
* [Game Link](https://drive.google.com/drive/folders/1f3RMM40FhRnoffgvGPMDCtb4YhSo3S5m?usp=sharing)
