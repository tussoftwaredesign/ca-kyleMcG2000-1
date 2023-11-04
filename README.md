# ca-kyleMcG2000-1
ca-kyleMcG2000-1 created by GitHub Classroom
Student number A00299484


In this Report I will discuss my VR application project that I made using Unity and included the following.
- The project setup
-LocoMotion
-Grabbable Objects
-Sockets.

I will discuss the aim of the game and the ups and downs I had making it. There will also be screenshots of the game itself to back up the use of the four features previously listed above.

The Project Setup:

The theme I went with for my game was an abandoned graveyard in a spooky forest. I chose this as Halloween was right around the corner and what better way to bring in than with a horrifying graveyard.

<img width="488" alt="Screenshot 2023-11-04 185628" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/5d144265-84ae-44e9-9775-e058383fa155">

 
This is an overview of the entire world that I created. The trees were painted onto the world using a terrain (the checkered pattern floor) and paintbrush tool to make the forest with ease. At first, I had difficulty with this as it was my first time using this feature and I didn’t know what I was doing. Eventually I got the hang of it and set the spooky factor into play. The dark outline you see just past the trees is a hill game object painted completely black to give a feel of a dark sky. I also used a skybox to turn the sky a bit darker to match. The mud floor for the game consists of a green floor game object painted brown and it is also given a mesh collider to help stop the grabbable objects from falling through it. I’ll talk more about the grabbable objects when we get to that section.


<img width="358" alt="Screenshot 2023-11-04 185648" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/35c94236-c3cc-4945-8c67-0de40f1e7a47">

 
In this second image it shows a closer view of the graveyard. The aim of the game is to find six pumpkins which I scattered throughout the map. You must then return each pumpkin back to the coffins where you first started the game, only then can you escape. Later I will show the pumpkin inside the coffin as part of the Sockets section.

Locomotion:

To play the game, you need to be able to move and that’s what I added with the help of continuous movement. On my XR rig I attached two scripts called continuous move provider and continuous turn provider. These allow for a smooth flow when moving and turning.

<img width="220" alt="Screenshot 2023-11-04 193807" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/b5ea1209-34c2-408d-abb6-389d13b56deb">
