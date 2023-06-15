
# Game Basic Information #

## Summary ##
![image](https://github.com/s3lven/ECS189L-FinalProject/assets/57575778/b8b7de1f-9b05-4f7e-a7ed-e5397cf08196)

In "Papa's Bobaria," you step into the role of a skilled boba shop barista, tasked with creating delicious and customized drinks for a bustling crowd of customers. As the game begins, you find yourself in the heart of the kitchen, surrounded by various stations and equipment necessary to fulfill orders. Orders will appear at the top of the screen, presenting a combination of random ingredients, flavors, and toppings. You must swiftly navigate the kitchen, visiting stations such as the Topping Station, Powder/Syrups Station, and more.

With a 2-D top-down view, you move your character strategically, grabbing ingredients, combining them, and processing them when necessary. Time is of the essence as you strive to complete orders before they disappear from the list. Prepare to immerse yourself in a fast-paced, addictive boba-making experience that will put your multitasking skills to the test. Can you become the ultimate boba master in "Papa's Bobaria"?

## Gameplay Explanation ##

As a quick side note, when loading this game into Unity, please start from the Title screen.

After clicking the play button, players are immediately put into the game stage. Players have a set amount of time to fulfill orders one by one. Around the player are the stations that will help them gather the ingredients. There 8 stations are:
- Tea Station: When interacting with this station, a panel of three buttons appear. From left to right, these buttons correspond to the black tea, the green tea, and the oolong tea. After pressing the button, the player will need to wait until the window disappears before moving on.
- Syrup and Milk station: Upon interaction, an image of a machine is brought up with two buttons: the sugar and milk button. Players will have to visit the station on two separate interactions to get both sugar and milk.
- Toppings station: Upon interaction, the players must drag the image of either the boba topping or the lychee jelly topping onto the cup.
- Ice staton: Similar to the toppings station, the players must drag one of the ice sprites into the cup. The player must add two ice sprites before passing.
- Blend/Shake stations: These two stations require the player to press a button that will play a sound of either shaking or blending the drink. An audio cue will signal when its passed.
- Trash station: Similar to the other drag and drop games, the player will have to drag the shaker sprite onto the trash sprite. The players will only use this if they need to restart on their drink.
- Submit station: When finished with a drink, players will interact with this object to turn in their drink. If it is passed, the players will receive 10 points, else minus 10 points. In either case, a new drink will spawn and the player's current drink will be cleared.

The players are able to perform tasks at any order. If one of the games have already been interacted with, however, then the player will be locked out from the game and they will be forced to trash their drink.

At the end of the timer, the player will be brought to the end screen, where their stats will of how many successful and failed drinks and score are displayed.
# Main Roles #

Your goal is to relate the work of your role and sub-role in terms of the content of the course. Please look at the role sections below for specific instructions for each role.

Below is a template for you to highlight items of your work. These provide the evidence needed for your work to be evaluated. Try to have at least 4 such descriptions. They will be assessed on the quality of the underlying system and how they are linked to course content. 

*Short Description* - Long description of your work item that includes how it is relevant to topics discussed in class. [link to evidence in your repository](https://github.com/dr-jam/ECS189L/edit/project-description/ProjectDocumentTemplate.md)

Here is an example:  
*Procedural Terrain* - The background of the game consists of procedurally-generated terrain that is produced with Perlin noise. This terrain can be modified by the game at run-time via a call to its script methods. The intent is to allow the player to modify the terrain. This system is based on the component design pattern and the procedural content generation portions of the course. [The PCG terrain generation script](https://github.com/dr-jam/CameraControlExercise/blob/513b927e87fc686fe627bf7d4ff6ff841cf34e9f/Obscura/Assets/Scripts/TerrainGenerator.cs#L6).

You should replay any **bold text** with your relevant information. Liberally use the template when necessary and appropriate.

## User Interface - Thomas Chen & Rongshan Gao

(Rongshan Gao)
1. [Title screen](https://github.com/s3lven/ECS189L-FinalProject/blob/main/Assets/Scripts/TitleMenu.cs) - I built a simplistic, yet welcoming title screen for Papa's Bobaria using Unity's Canvas, Panels, Buttons, and TextMeshPro boxes. Using EventSystem to detect user mouse clicks, I implemented buttons to Play, view Controls, and Quit the game. I installed custom fonts and added some clipart for the title screen to provide a more lighthearted feel for players. The Play button loads the main game scene. The Controls button makes an initially invisible panel viewable, which provides the essential mechanics for Papa's Bobaria. Within the Controls panel is a Got It button, which hides the panel again and takes the user back to the Title screen. The Quit button exits the application.
2. [Pause screen](https://github.com/s3lven/ECS189L-FinalProject/blob/main/Assets/Scripts/PauseMenu.cs) - Within the main game, users can pause the game at any time by pressing ESCAPE, chosen due to its common use for this function. Upon making the Pause panel visible, TimeScale is set to 0 to stop the game script. The Resume button hides the panel and reverts TimeScale back to 1. The Restart button resets the main game scene, resetting all progress and allowing the player to make a fresh start. The Home button unloads the main game scene and loads the Title screen. All buttons and fonts used here are similar to ones used in the Title screen.
3. [End screen](https://github.com/s3lven/ECS189L-FinalProject/blob/main/Assets/Scripts/EndMenu.cs) - After the game ends, the user is taken to the End screen, which provides a summary of the player's stats (orders delivered, orders failed, and total score). In the End screen, the user can either Replay, which loads the game scene again, or go Home, taking the player back to Title screen.

These screens, while not directly affecting gameplay, provide the player with logical, seamless transitions between game states. In addition, they help set the tone/game feel with the fun fonts and art. Personally, I strongly dislike playing games with overly complicated UI; instead, I really admired the easy-to-digest UI from games like Overcooked and PlateUp. Thus, I attempted to make these screens as simplistic as possible to reduce screen clutter and information overload. This principle also extends to the Controls screen. Despite the short lengths of each screen's scripts, most of the work was done in Unity editor, consisting of working with Canvas, Panels, etc. Since we didn't heavily focus on these aspects during this course, designing and implementing these screens was a fun learning challenge.

(Thomas Chen)
	

## Movement/Physics - Eriz Sartiga & Rongshan Gao
(Eriz Sartiga, Rongshan Gao)
The movement of this game is simple; the player moves using WASD in a 2D top-down plane. The physics in Papa's Bobaria is also straightforward - the player collides with stations and walls, and cannot move through them. 

**Describe the basics of movement and physics in your game. Is it the standard physics model? What did you change or modify? Did you make your movement scripts that do not use the physics system?**

## Animation and Visuals - Jason Dao & Kwantip

**Describe how your work intersects with game feel, graphic design, and world-building. Include your visual style guide if one exists.**

(Jason Dao:)
1.  Asset Creation - Throughout development, I took on the role of an asset creator responsible for designing and producing visual assets that contribute to the aesthetic of the game world. This involved creating sprites for characters, objects, and environments. By applying the principles of graphic design and adhering to the visual style guide of the game, my team and I ensured that the assets we created were cohesive, visually appealing, and aligned with the artistic vision of the game. With the retro art style, we wanted to evoke a sense of nostalgia and charm. My work intersects with the course content as I learned the basics of Unity and its graphic capabilities, practiced graphic design, and learned essential Unity concepts that I applied to create visually engaging assets. (all of the artwork for the game is created by our animation and visuals team)

	Here are some examples of assets I created for this project:
- [Skeuomorphic Ice machine minigame backdrop](https://github.com/s3lven/ECS189L-FinalProject/blob/main/Assets/Sprites/Stage/iecMachine.png)
- [Toppings minigame backdrop](https://github.com/s3lven/ECS189L-FinalProject/blob/main/Assets/Sprites/Stage/Toppings%20Table.png)
- [Hands minigame backdrop](https://github.com/s3lven/ECS189L-FinalProject/blob/main/Assets/Sprites/Stage/Trash%20Hands.png)
- Game icon, used for press 
  <img src="https://img.itch.zone/aW1nLzEyNDY3NDgzLnBuZw==/347x500/r7Xvl%2F.png" data-canonical-src="https://img.itch.zone/aW1nLzEyNDY3NDgzLnBuZw==/347x500/r7Xvl%2F.png" width="100" />




2.  Minigames - I contributed to the minigames associated with each 'station'. These minigames reward players for making decisions and make the game more interactive. I helped to design and implement various mechanics through click-based interactions, drag-and-drop mechanics. This contribution aligns with the intermediate scripting tutorials, game feel, and the entry point into scripting in Unity, as we utilized these concepts to create interactive and immersive minigames.
- [Toppings drag and drop minigame](https://github.com/s3lven/ECS189L-FinalProject/blob/main/Assets/Scripts/Stations/ToppingsMinigame.cs)
    
3.  Sprite Animation and Interactivity - I also implemented sprite animation and interactivity, which added some responsiveness to the drag-and-drop minigames. I implemented object interactions utilizing Unity's animation system and scripting in C#. By making these objects responsive to player input, I enhanced the game's immersion and player engagement. This contribution aligns with the scripting tutorials and lessons covered in the course, as well as the concepts of the game feel and animation principles discussed during class.
- [Sprites change on hover](https://github.com/s3lven/ECS189L-FinalProject/blob/main/Assets/Scripts/hoverSprite.cs)
- [Another instance](https://github.com/s3lven/ECS189L-FinalProject/blob/main/Assets/Scripts/HoverEffect.cs)
    
4.  UI Design - I participated in designing the user interface (UI) of the game. This involved creating intuitive and engaging UI elements such as menus, buttons, and icons. By creating assets and considering principles of user experience (UX) design and graphic design, we ensured that the UI was user-friendly, aesthetically pleasing, and consistent with the game's visual style. This connects with the topics of UI/UX design, graphical user interfaces, and the entry point into scripting in Unity, as we applied these principles to create an effective and visually appealing UI.
- (please play the game to view my UI contributions as my work is shown through Unity Scene)
- [Hourglass sprite for timer UI](https://github.com/s3lven/ECS189L-FinalProject/blob/1e420275ef5ffc45cd4184e52b36b4fe1534169f/Assets/Sprites/UI/timerhourglass.png)
- [Ice cube sprite for UI](https://github.com/s3lven/ECS189L-FinalProject/blob/main/Assets/Sprites/Stage/dropIce.png)

-----------------------------------------------
(Kwantip Tachasooksaree:)
Even though my role was originally input, I ended up helping out with sprite creations. My main contribution is creating the sprites for the map including the player, interactable objects, and the map itself. I also worked closely with Jason to create some of the minigame UI. For instance, the sugar and milk station and blender station. I attempted to animate the blender minigame where when the player first click the blender, a static image of the blender will appear. When player click the fan button at the bottom to blend, the blender sprite is supposed to alternate between the animated blender sprites that I made. However, I was not able to figure out how to get the animation to fully function. The following are some of the examples of things I made:
- [Map](https://github.com/s3lven/ECS189L-FinalProject/blob/main/Assets/Sprites/Stage/Map.png)
- [Sugar and milk station] (https://github.com/s3lven/ECS189L-FinalProject/blob/main/Assets/Sprites/Stage/Sugar%20and%20Milk%20Station.png)
- [Player](https://github.com/s3lven/ECS189L-FinalProject/blob/main/Assets/Sprites/Stage/Player.png)
...


## Input -- Eriz Sartiga

While my original role was Game Logic, I have extended myself to Input in the interest of time.

I used Unity's relatively new Input System to assign keybindings. In short, 2d movement is controlled with WASD and players can use the Left-Click on their mouse to interact with objects. The scripts check to see if the player is near the station and the highlight is on before they can interact with the object to mimic realism. Lastly, box colliders are used on the player, the walls, and other game objects to ensure familiarity and game feel.

## Game Logic - Eriz Sartiga

1. Controllers - I wrote Controller scripts that managed the state of different elements in the game, from the current order, to the drink that is currently being made by the player, to the player's movement and interactions. I had hoped to implement more Pub/Sub patterns within the code; however, due to lack of time, I could not refactor the code in time to do so. However, I did ensure that functions that are related to one specific gameplay element are kept on their own script. In short, [OrderController](https://github.com/s3lven/ECS189L-FinalProject/blob/d8b2fa52fa434d0ad33883294dc9f94c57840eb7/Assets/Scripts/OrderController.cs#LL7C33-L7C33) was in charge of keeping track of what minigames needed to be completed and would check based on string encodings and enumerations. [DrinkController](https://github.com/s3lven/ECS189L-FinalProject/blob/d8b2fa52fa434d0ad33883294dc9f94c57840eb7/Assets/Scripts/DrinkController.cs#L6)was in charge of keeping track of what is in the current drink and would create the string encoding that will be compared in OrderController.

2. Minigames - I wrote all of the scripts for the minigames. They boiled down to either "click-the-button" or "drag-and-drop" minigames. In short, I added OnClick events to the "click-the-button" games that would update variables in the DrinkController based on the associated station. For the "drag-and-drop" minigames, I used [OnDrag events](https://github.com/s3lven/ECS189L-FinalProject/blob/d8b2fa52fa434d0ad33883294dc9f94c57840eb7/Assets/Scripts/Stations/Topping/InventorySlot.cs#L16-L30) and Grid Layouts to ensure that items can be dragged from one slot to another. When put in the correct slot, it would eliminate the current prefab and generate a new one in its spawn spot to ensure replayability.

3. Interactable Objects - Although the scripts for these interactable objects could have been better written, I wrote them such that they would hold the UI element and runs the associated minigame. They also use colliders to highlight when the player is near a certain station and is able to interact with that station. 

# Sub-Roles

## Cross-Platform

We did not think about the game being played on other platforms besides PC. As such, the only characteristcs for this platform are the use of the mouse and keyboard.

## Audio - Thomas Chen

**List your assets including their sources and licenses.**
BackGround Music: https://www.youtube.com/watch?v=Uj93hicGDNc

https://pixabay.com/sound-effects/good-6081/

https://pixabay.com/sound-effects/success-bell-6776/

The tool I use to edit the audio to what we wanted to be: https://audio-joiner.com/

**Describe the implementation of your audio system.**

All the audio is done 
**Document the sound style.** 

## Gameplay Testing - Eriz Sartiga

As someone who has programmed the minigames, I have done extensive gameplay testing to try and account for edge cases in the minigames and overall interactions with the shop. To summarize:
- The box colliders are programmed such that constantly running into the counter exhibits a weird "glitchy" movement. This is likely due to the player's 3D capsule collider instead of a 2D box collider. There is the possibility of the player interacting with a station while they're in this glitch and begin to glide to the right
- There is a glitch on the toppings minigame where if the player quickly clicks on any of the topping without moving their mouse to any other slots (topping slots or cup slots), they accidentally add a topping into the grid layout. Thus, there is two elements in the layout and leads to unintended behavior.
- The gameplay loop works as intended but needs better design to inform players about the process of their drink (i.e. a checklsit showing of what minigames they have done).
- The music stops at the end of the game with no other sounds playing.

## Narrative Design

**Document how the narrative is present in the game via assets, gameplay systems, and gameplay.** 

## Press Kit and Trailer - Jason Dao & ...

Here is a link to the [press kit](https://jasondaok.itch.io/boba) and **trailer**. 

**Describe how you showcased your work. How did you choose what to show in the trailer? Why did you choose your screenshots?**

(Jason Dao was responsible for the press kit:)
For the press kit, I helped to write the game description, features, set up the website loosely following the doPresskit() guidelines but for itch.io instead. I wanted to highlight our games unique features and organized the relevant information accordingly. I selected the viewable screenshots because I wanted to capture the essence of the game and its elements. As a result, I included scenes of the colorful main map, the minigames, and the UI. We aimed to pique the interest of any players and tried to convey the experience that they would expect by playing Papa's Bobaria.

......


## Game Feel

**Document what you added to and how you tweaked your game to improve its game feel.**
