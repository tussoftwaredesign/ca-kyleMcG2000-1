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

In this Report I will talk about the second continuous assessment portion of my VR project. I had the option to start a new game or continue from the previous game, so I decided to expand on my previous game. In this continuation I Implemented the following.

-	Audio 
-	Action Events
-	Direct and Ray interactors
-	And User Interface

Audio:
To enhance the experience of the game for players I added audio to the map. I added the spooky audio to give a creepy feel to the map, I added a second audio source of wolves howling at random intervals throughout the game to try scare the player as well. To do this I created an empty game object and added an audio source component. I then sourced the audio I wished to use off Itch.io and added it to each component.

<img width="223" alt="Screenshot 2023-12-25 134413" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/fc9572a9-446d-4036-9a80-3b021ed223cd">
<img width="329" alt="Screenshot 2023-12-25 134350" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/9f7ec798-1e9b-4b89-af15-1813827837da">


Action Events:
I added a couple of different action events to the game. The first one is the opening of the doors to the house. I did this by adding a box collider and the XR simple interactable component. In the interactable events tab on the select entered option, I selected the door as the object to be disabled once the door handle is interacted with and once the player interacts with this object, the doors setActive state will be set to false. The second Action event I added was a TV remote that turns on the TV to play a video. On the screen of the tv I added the video player component and the play video script. I then sourced the video I wished to use from YouTube and converted it to a .mp4 file. I then added the video to the play video script as shown below. To turn on the tv you must use the remote. I added an XR grab interactable component to the remote. In the interactable events tab on the Activate option the first tab plays the remotes sound to say it’s been pressed, the second tab changes the light on the remote to show its been pressed and the final tab turns on the TV. The deactivated tab changes the remotes colour back to its original state. I feel these action events added fun elements and interesting elements to the game.

<img width="205" alt="Screenshot 2023-12-25 140837" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/e9d78fe3-c922-4255-bf0e-f250d2cd77ed">
<img width="182" alt="Screenshot 2023-12-25 140848" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/4828b0e6-4dbd-4ed5-b204-a016399a014f">
<img width="198" alt="Screenshot 2023-12-25 141956" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/b3af4fc5-7761-4ab6-a512-2e1eb0234531">
<img width="210" alt="Screenshot 2023-12-25 142540" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/a04486cb-6174-4939-9ec6-129f26fea700">
<img width="205" alt="Screenshot 2023-12-25 142556" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/e40a7c8d-2b87-47ac-948b-296b09fdbba2">

Direct and Ray Interactors:

I made use of the rays by allowing them to only have optional use in the game. They are only used to interact with the buttons on the Interface canvas. You can select the rays by using the primary button on each controller as shown below.

<img width="198" alt="Screenshot 2023-12-25 144614" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/f991588e-1966-4b35-b73c-77cad73c72da">

User Interface:

To give the players a feel for what they have to do in the game I added 2 canvas’ to the map telling the players what to do to play the game. I created these first by adding a child object to the canvas and added the textMeshPro – text component to the child object to add the text to the canvas. I did the same for the two canvas’ in the house and the reset background as well. To reset the game, I used the reset background canvas and a reset button attached to it. On the button component in the OnClick tab, once selected the scene will be reloaded. The cancel button will keep you in the same scene.

<img width="206" alt="Screenshot 2023-12-25 145608" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/e729cf6e-939b-4feb-b35d-369ee2bd28ae">
<img width="210" alt="Screenshot 2023-12-25 145620" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/638b8016-149f-4e94-a4e4-feacddb2588c">
<img width="211" alt="Screenshot 2023-12-25 150228" src="https://github.com/tussoftwaredesign/ca-kyleMcG2000-1/assets/123557094/02e08b5f-bf44-4bbb-9c9f-394fd986cad5">

Extra add-ons from the previous game:

To complete the game, I added Keys around the interior of the house, I added multiple keys but only one of them works, once you set foot in the house you’ll find a riddle that will help find the location of escape. There’s also a ladder that the player will need to use in order to escape as well. The key works in a similar manner to opening the window as the player did with the door. The correct key collides with the window and destroys it. The player then brings the ladder and adds it to the socket in front of the window to complete the game.


Conclusion:

In conclusion I’m really happy with the way the game turned out, I fixed the previously mentioned issue with the gate not deactivating. To do this I simply had to deactivate the attach component on each coffin so that once each pumpkin is inserted into their correct coffins the attach point will active and the gate will then destroy. I also added to the eeriness of the game by turning of the directional light in the game to make it dark. I found this paired with the audio made the game complete. I also added a lamp that the player should always carry around with them to navigate the map. I felt this gave a bit more of a challenge to the game as this meant the player has to carry the lamp in one hand whilst only being able to carry back one pumpkin at a time to each coffin.

I would definitely use the knowledge I’ve obtained from this module to further sharpen my VR skills and create more projects like this in the future.  I also want to work on colliders more as I feel I still need more improvement with them. I managed to fix some wall collisions but I also noticed that a majority of colliders still didn’t work like others. I’m looking forward to learning on how to fix this issue and make the game even better. Thanks for reading.














