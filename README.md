# Introduction
This project will be implementing a game mechanic in virtual reality, creating something inovative.

## Initial Research
Going into this research I have an initial idea I am interested in looking into. Making a marionette in the virtual world that will be controlled by a player.

### Marionette
I started by looking to see if anyone had used marionettes in vr games yet. I wasn't able to find any in a game, but i did stumble apon a blog. 

https://medium.com/shopify-vr/marionettes-in-vr-6b596620c3ca

Bringing this idea over into unity could be interesting, in the blog he uses a plugin for unreal to create the ropes between the puppet and the controller. There is an asset avaliable on the unity store to simulate rope, but for the price I don't believe it would be worth it for my needs. 
As an alternate I have found some video tutortials that guide you through creating a basic rope in unity.

https://www.youtube.com/watch?v=Cecp4a7FsTU

Another section of this blog shows the positioning of the static character, this reminds me of the classic artist wooden human models used for referencing the body in specific positions.
This could be something that is implemented into vr art creation tools to provide reference for the artist.
Another idea for this was given to me by Al was to make this into a game where the player has to pose the body of the marionette to match poses given by the game.

### New Controller
Valve are working on a new controller that gives the ability to track grip input from each finger on the hand, along with being strapped to the hand so you are able to let go with every finger.

Having this ability could would work really well with posing a model. But this not being widely available yet restricts the idea of implementing it and restricting the games market. 

![Controller Layout](https://cdn.arstechnica.net/wp-content/uploads/2017/06/knuckles2.png)

### Concluding thoughts
I have spent a bit of time thinking over how the marionette or the poseable model could be built into interesting games.

For the marionette I believe a fun way to use this mechanic would be to create a game that requires you to control the marionette puppet through the average day of a human, the fun would come from the awkwardness of controlling a marionette through normally easy to do tasks. There are a few glaring issues that would need to be considered. The first being that a marionette can useually be picked up and moved across any distance without being made to walk, this would either need to be considered in the game layout, or have a restriction on how the player uses the puppet. However restricting how the player can control the puppet could take away a good amount of fun. The second issue is that with the puppet control likely being difficult to beginners having tasks that are too complex could be overly frustating, this might limit the ability to simulate everyday tasks in the game.

For the poseable model I have taken a real liking to the idea of having to pose the model into specific poses that will allow it to get through a gap in an approaching wall. The fun in this game comes from posing the model into poses, some being whimsical that a normal human probably couldn't do. The scale of this idea is smaller than the marrionette game allowing for greater polishing. I've been pointed towards an old game show called "hole in the wall" which does exactly what I was considering but using the players body in real life instead of a model in virtual reality. Issues that I have considered with this idea is that the accuracy in which you are able to quickly pose the model will need to be very good. The fact that you have a time limit in which to pose the model could put some people off from the game, to combat this I could create an untimed mode where you purely have to pose the model into requested poses.

# Game Proposal
I have decided to create the game where the poseable model is required to be set into given poses. The player will have the ability to change the models poses with both of thier hands. The main game will offer requested poses in the form of an oncoming wall with a gap in it that you must make the model fit through. If there is enough time I will make a relaxed version where you are given just a pose to match not requiring the player to worry about time set in place with an oncoming wall.

### Market Research
For market research I will be looking specifically for games using similar mechanics, mostly focused in VR but with the posibility of bringing information from other platforms if the mechanics are close enough to my product.

![Tiny Town VR](https://steamcdn-a.akamaihd.net/steam/apps/653930/header.jpg?t=1516678143)

Tiny Town VR is a casual world-building game in virtual reality with a price point of £10.99. I bring this game to light as it is based in VR and has poseable models.
The game itself isn't focused on this posing mechanic, and the game I create will give much more precision in the posing controls of the model.

![Waltz of the Wizard](https://steamcdn-a.akamaihd.net/steam/apps/436820/header.jpg?t=1539707517)

Waltz of the Wizard is a virtual reality experience that lets you feel what it’s like to have magical powers and it's totally free! This game has many different aspects but the one I find interest in is one item that is a wooden artist mannequin. You are able to accurately move the different limbs of this model. Something similar to this would be good for my game.

![Hole in the Wall](http://123kinect.com/wp-content/uploads/2011/08/hole-in-the-wall-kinect.jpg)

Hole in the Wall is a Xbox Kinect game based on the tv show that challenges you to become a human puzzle piece as you contort to fit through wacky shapes that are cut out into themed walls hurtling towards you. This game shows exactly the sort of mechanic that would be used in my game, but requiring players to move their own body instead. Reviews of this are lackluster often complaining that they could not fit the holes given to them. My game will not suffer from this issue as the model used for posing is given to the user and all poses will be tested in development to make sure they fit.

# Design
To facilitate the design of this project I am going to set some key requirements the project must meet to fullfill a successful prototype.
I will then break these down into user stories.

## Key Requirements
* Player is able to look about and move around the model in VR
* Player can touch and push the model with virtual hands tied to the VR controllers
* Walls with holes big enough to fit the player will continually approach the player/model with differences in where the hole is
* Player is able to see the remaining health of the model

## User Stories

As the Player I want to be able to move the model around with my virtual hands

As the Player I want to be able to lose the game

As the player I want to be able to see the holes and walls coming towards me

As the player I want to be able to easily setup and play the game in VR

As the player I want to be able to view the model remaining health

## Design Details
After giving the above thought as to what the game will need I will now state my plans on how to implement these requirements.

Having looked a bit into the ease of implementation for VR and considering my current knowledge of avaliable game engines I will be creating the project in Unity. Premade assests are avaliable for smoothly bringing a Unity project into a VR environment. These are called SteamVR Plugin and I will be using these free assests to link the game with the VR headset and the controllers.

I will take a premade human model that has already been rigged and then apply ragdoll physics to that model in Unity, with the previous knowledge of doing a similar thing for our current group project game I believe this should go well.

I will create a wall with a gap in it and use this multiple times with different rotations to provide the differences in where the hole is. I have chosen to use only one wall with hole as my 3D modeling isn't great and I believe it may be difficult for me to make. To save on resources I will have a set number of walls created at run time and then reposition them back to the start once they have past the player, giving them a new rotation.

The walls will have a script to move them forwards at a set speed, and the model will send information about its collisions with the walls to a player script that will manage the damage input and keep track of health.

Lastly I will attach a health bar to one of the players hands, this health bar will be linked to the players health and decrease in size as the health lowers. Having it attached to the hand should mean that it is always easily veiwable for the player.
