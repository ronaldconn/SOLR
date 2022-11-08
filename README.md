# SOLR

![cover](https://user-images.githubusercontent.com/97855104/200453500-dd0e0823-1e27-4056-b28b-3d75d033d9a0.png)

**Unity Based VR Experience**

## How to open up the project on Unity Editor
This game was developed using **Unity Editor 2020.3.32f1**, I suggest you to download this version because different ones (especially older) might give problems.

Once you've downloaded the repository and extracted it into a folder, open up the folder SOLR using the Unity Hub. If the version of the Unity Editor you're using to open the project is the correct one, no error should appear.

https://user-images.githubusercontent.com/97855104/200410947-8bbbfe7f-0bf0-4422-ac47-7e81d509a15b.mp4

## Aesthetics and immersion design

This is a simple vr experience coded to learn the inner-workings of the unity gui and engine. All the movements and interactions are coded from scratch.

This experience has an [controller input checker coded](https://github.com/ronaldconn/SOLR/blob/main/Assets/Scripts/DetectVR.cs) that looks to see if a VR headset is plugged in. If a headset is plugged in, the experience will run in VR, should the user not have a headset the program then switches to a custom coded computer based input system ([mouse](https://github.com/ronaldconn/SOLR/blob/main/Assets/Scripts/MouseLook.cs) and [keyboard](https://github.com/ronaldconn/SOLR/blob/main/Assets/PlayerMovement.cs)). The switcher program, user movement and interactions and environment interaction were all coded from scratch. The c# files are viewable in the root directory and asset folders.

In addition to world navigation, I coded [player](https://github.com/ronaldconn/SOLR/blob/main/Assets/Scripts/PlayerInteractionController.cs) and [object](https://github.com/ronaldconn/SOLR/blob/main/Assets/Scripts/Interactable.cs) interaction from scratch. And as for game/world logic, the raycast system was utilized to check and see if an object(solar panel) was facing the correct direction towards another object (the sun). Thankfully, this was pretty straightforward and didn't require much math since I utilized collision detection to see if a raycast had hit another object.

Once all the panels face the sun, the game is won! A jumotron like textmesh displays the results.


## 🛠 Skills

C#, Unity Engine, XR Interaction Toolkit(compatible with multiple vr headsets). Game design and development of the game mechanics from scratch using only the Unity engine and the basic XR Framework for Virtual Reality interactions, free Unity Store's assets (trees, textures, and skybox texture).

## 🔗 Links

[LinkedIn](https://www.linkedin.com/in/aaronclamp/)</br>
[Portfolio](https://aaronclamp.netlify.app/)</br>
[Github](https://github.com/ronaldconn/)
 
# Lessons Learned

The biggest take away from creating this experience in Unity was that by creating serialized fields in gameobjects, I could easily bind other objects, components or variables to said objects. This allowed the game scripts to be easibly accessible and organized, and maked tracking small bugs a breeze. This is a huge advantage over other manual transmission like graphic and grame engines. With limited Unity libraries one can create elaborate interactions, and if one does bring in off-the-shelf code, in world experiences could be created faster than ever!

# Future optimizations

- Add tracking system that displays how many panels are facing the sun rather than the green light system
- Add user dashboard displaying stats
- Create another game based on circuit board diagrams to run wires from the panels to a hub/controller
- Write an algorithm that uses the shadow and light variables in game to determine and implement a percent based system rather than a boolean. Thus the object of the game would not just be to demonstrate that panels face the sun but that each panel has an efficay rating based on total light hitting the panel.
