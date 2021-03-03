# 5. Virtual Reality in Unity
<img src="Docs/Holos%20Logo.png" alt="Holos Logo" width="400"/>

<br/> 

## Time for Some VR Fun!
Congrats on making it this far and hope you enjoyed making your own dancing avatar! Now we can dive into the part you are mostly excited about: Virtual Reality! The good news is: Unity has a very nice and easy VR integration for developers like you and me. Follow this tutorial and create your first VR experience! 

<br>

### 1. Start a new Unity project
By now you should have an idea on how to create a new Unity project. Just in case if you forgot, check out [the tutorial here.](IntroductionToUnity.md). Open Unity Hub, select "New", and create a 3D project. I'm going name mine "VRDemo".

<img src="Docs/create_vrdemo_project.png" alt="Unity3D" width="400"/>

<br>

### 2. Challenge: Develop the scene a bit more!
Drawing from your knowledge of creating a scene from the last mini-challenge, let's make a scene that is more interesting! Feel free to get creative with it.

So here is my super simple scene consisted of a box and a tree made of a sphere and a cylinder.

<img src="Docs/simple_first_scene.png" alt="Unity3D" width="400"/>.

### 3. Enable VR in Unity
Depending on the device you have available, choose one of the three options below (*tip: HMD means Head Mounted Display, or your VR headset*).

1. [PC-Powered HMD](#PC-Powered-HMD)
2. [Oculus Quest](#Oculus-Quest) 
3. [Without HMD](#Without-a-HMD)

<br>

## PC-Powered HMD


### 1. Enable VR in Unity
Next, follow this [offical guide](https://learn.unity.com/tutorial/enabling-vr-1#5fd69c9cedbc2a1685e10ed5) provided by Unity to enable VR in your project. Once you're done, if you put on your VR headset, you should be able to rotate your head and see the scene. Something like this: 

<img src="Docs/first_vr_scene.gif" alt="Unity3D" width="400"/>.

<br>

### 2. Seeing your scene in VR
Once your scene is done, put on your headset and witness the wonders you created! 

<img src="Docs/modified_first_vr_scene.gif" alt="Unity3D" width="400"/>.

<br>

## Oculus Quest

### *Coming Soon!* 

<br>

## Without a HMD
No headset no problem! Here is how you can simulate VR in Unity even without a HMD.

### 1. Install XR Pluging Management
Open Project Setting in the dropdown menu (`Edit->Project Setting`).
<img src="Docs/projecct_setting.png" alt="Unity3D" width="400"/>.

And a window pops up and on the left you should see a "XR Plugin Management" tab, and click "Install XR Plugin Management"
<img src="Docs/xr_management.png" alt="Unity3D" width="400"/>

<br>

### 2. Enable Mock HMD
After you install XR Plugin Mangement, you should see a list of plug-in providers and enable `Unity Mock HMD`.
<img src="Docs/installed_xr_management.png" alt="Unity3D" width="400"/>

<br>

### 3. Seeing your scene in VR
Once you enable Mock HMD, go back to the scene you just created and click play. You should see something like this:

<img src="Docs/mock_hmd_view.png" alt="Unity3D" width="400"/>

Why are there two identical views? That is what each eye would see if you have your HMD! You can even change the view on the top right corner from "Both eyes" to either left or right eye.

<br>

### 4. Adding Interactions 

Congrats on making your first VR experience! You may notice that you can't really move in this view. I highly recommend checking out [this tutorial on enabling interaction in Mock HMD](https://www.youtube.com/watch?v=UlqdHrfXppo), espeically the latter half of the video. Have fun!