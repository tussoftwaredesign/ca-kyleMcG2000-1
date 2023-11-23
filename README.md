# ca-kyleMcG2000-1
ca-kyleMcG2000-1 created by GitHub Classroom
Student number A00299484


In this Report I will discuss my VR application project that I made using Unity and included the following.

-The project setup

-LocoMotion

-Grabbable Objects

-Sockets

I will discuss the aim of the game and the ups and downs I had making it. There will also be screenshots of the game itself to back up the use of the four features previously listed above.

The Project Setup:

The theme I went with for my game was an abandoned graveyard in a spooky forest. I chose this as Halloween was right around the corner and what better way to bring in than with a horrifying graveyard.


<img width="488" alt="Screenshot 2023-11-04 185628" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/5fbd311c-5470-4f89-a36f-56839ba94e15">

 
This is an overview of the entire world that I created. The trees were painted onto the world using a terrain (the checkered pattern floor) and paintbrush tool to make the forest with ease. At first, I had difficulty with this as it was my first time using this feature and I didn’t know what I was doing. Eventually I got the hang of it and set the spooky factor into play. The dark outline you see just past the trees is a hill game object painted completely black to give a feel of a dark sky. I also used a skybox to turn the sky a bit darker to match. The mud floor for the game consists of a green floor game object painted brown and it is also given a mesh collider to help stop the grabbable objects from falling through it. I’ll talk more about the grabbable objects when we get to that section.


<img width="358" alt="Screenshot 2023-11-04 185648" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/b831155f-1f4d-4749-92a3-4ac39ec7f198">


 
In this second image it shows a closer view of the graveyard. The aim of the game is to find six pumpkins which I scattered throughout the map. You must then return each pumpkin back to the coffins where you first started the game, only then can you escape. Later I will show the pumpkin inside the coffin as part of the Sockets section.

Locomotion:

To play the game, you need to be able to move and that’s what I added with the help of continuous movement. On my XR rig I attached two scripts called continuous move provider and continuous turn provider. These allow for a smooth flow when moving and turning.

<img width="220" alt="Screenshot 2023-11-04 193807" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/aba8164e-d77c-4f2b-a5ef-a34f003ef240">


Grabbable objects:

My game relies on grabbable objects to be able to complete it. The aim of the game like I previously mentioned is to pick up pumpkins and place them in the coffins. I had the most trouble with this feature, mainly on the pumpkins as when I first picked them up my player would start to float or when I dropped them my player would spin. Eventually I fixed it after messing around with the rigid body and the XR grab interactable script. On the previously mentioned script I also have an interaction layer mask called pumpkin just so the pumpkin only interacts with the socket on the coffin which I will discuss more in the next section. I also added throwable candy objects with a grab interactable to help the player a certain point in the game.

<img width="215" alt="Screenshot 2023-11-06 100117" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/0aa55d3d-c08b-47e7-99a7-1a668939ffe3">

<img width="948" alt="Screenshot 2023-11-04 185507" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/ca6b0b30-07a6-4cc3-a734-aa0dc41fe00b">

<img width="304" alt="Screenshot 2023-11-06 100528" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/fe488ffa-f674-4326-82c9-db8c94c95f13">


Sockets:

The final portion of this report is the sockets. The sockets are also a key component of the game as they are also needed to help complete the game. The coffins have a socket point set on each of them that only interacts with the pumpkins. I also have a light source on the pumpkins that gives this cool feature that makes the pumpkins light up when they are inserted into the coffins, giving a feel that the pumpkins have come to life when placed. I didn’t have much trouble with the sockets as I had previously worked on something similar which made this feature possible.


<img width="668" alt="Screenshot 2023-11-04 185557" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/73fa4f6e-36f2-4986-890c-12072284b913">


Reflection:

I had a lot of fun making this project, there was good times and bad times with making it. The first issue that was a major problem was when I imported my first set of assets and they were all pink, I found out later that the Universal rendering pipeline (URP) was the main cause of this problem and once it was unequipped, I had zero trouble with the rest of my assets. The second issue I had and still have is with my XR rig phasing through all my objects instead of colliding with them, it’s something I’m still trying to resolve and hope to have resolved for the second game. Making this game has thought me a lot about VR and the process of making a 3D VR game in unity.  I have found this area to be a whole lot of fun to work with and wish to expand my knowledge and creativity within VR to hopefully make my second game even better than this one.



