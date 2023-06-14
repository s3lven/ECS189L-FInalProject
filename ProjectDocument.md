
# Game Basic Information #

## Summary ##
![image](https://github.com/s3lven/ECS189L-FinalProject/assets/57575778/b8b7de1f-9b05-4f7e-a7ed-e5397cf08196)

In "Papa's Bobaria," you step into the role of a skilled boba shop barista, tasked with creating delicious and customized drinks for a bustling crowd of customers. As the game begins, you find yourself in the heart of the kitchen, surrounded by various stations and equipment necessary to fulfill orders. Orders will appear at the top of the screen, presenting a combination of random ingredients, flavors, and toppings. You must swiftly navigate the kitchen, visiting stations such as the Topping Station, Powder/Syrups Station, and more.

With a 2-D top-down view, you move your character strategically, grabbing ingredients, combining them, and processing them when necessary. Time is of the essence as you strive to complete orders before they disappear from the list. Prepare to immerse yourself in a fast-paced, addictive boba-making experience that will put your multitasking skills to the test. Can you become the ultimate boba master in "Papa's Bobaria"?

## Gameplay Explanation ##

**In this section, explain how the game should be played. Treat this as a manual within a game. It is encouraged to explain the button mappings and the most optimal gameplay strategy.**


**If you did work that should be factored in to your grade that does not fit easily into the proscribed roles, add it here! Please include links to resources and descriptions of game-related material that does not fit into roles here.**

# Main Roles #

Your goal is to relate the work of your role and sub-role in terms of the content of the course. Please look at the role sections below for specific instructions for each role.

Below is a template for you to highlight items of your work. These provide the evidence needed for your work to be evaluated. Try to have at least 4 such descriptions. They will be assessed on the quality of the underlying system and how they are linked to course content. 

*Short Description* - Long description of your work item that includes how it is relevant to topics discussed in class. [link to evidence in your repository](https://github.com/dr-jam/ECS189L/edit/project-description/ProjectDocumentTemplate.md)

Here is an example:  
*Procedural Terrain* - The background of the game consists of procedurally-generated terrain that is produced with Perlin noise. This terrain can be modified by the game at run-time via a call to its script methods. The intent is to allow the player to modify the terrain. This system is based on the component design pattern and the procedural content generation portions of the course. [The PCG terrain generation script](https://github.com/dr-jam/CameraControlExercise/blob/513b927e87fc686fe627bf7d4ff6ff841cf34e9f/Obscura/Assets/Scripts/TerrainGenerator.cs#L6).

You should replay any **bold text** with your relevant information. Liberally use the template when necessary and appropriate.

## Producer

**Describe the steps you took in your role as producer. Typical items include group scheduling mechanism, links to meeting notes, descriptions of team logistics problems with their resolution, project organization tools (e.g., timelines, depedency/task tracking, Gantt charts, etc.), and repository management methodology.**

## User Interface

**Describe your user interface and how it relates to gameplay. This can be done via the template.**

## Movement/Physics

**Describe the basics of movement and physics in your game. Is it the standard physics model? What did you change or modify? Did you make your movement scripts that do not use the physics system?**

## Animation and Visuals - Jason Dao & ...

**Describe how your work intersects with game feel, graphic design, and world-building. Include your visual style guide if one exists.**

(Jason Dao:)
1.  Asset Creation - Throughout development, I took on the role of an asset creator responsible for designing and producing visual assets that contribute to the aesthetic of the game world. This involved creating sprites for characters, objects, and environments. By applying the principles of graphic design and adhering to the visual style guide of the game, my team and I ensured that the assets we created were cohesive, visually appealing, and aligned with the artistic vision of the game. With the retro art style, we wanted to evoke a sense of nostalgia and charm. My work intersects with the course content as I learned the basics of Unity and its graphic capabilities, practiced graphic design, and learned essential Unity concepts that I applied to create visually engaging assets. (all of the artwork for the game is created by our animation and visuals team)

	Here are some examples of assets I created for the game:
- [Skeuomorphic Ice machine minigame backdrop](https://github.com/s3lven/ECS189L-FinalProject/blob/main/Assets/Sprites/Stage/iecMachine.png)
- [Toppings minigame backdrop](https://github.com/s3lven/ECS189L-FinalProject/blob/main/Assets/Sprites/Stage/Toppings%20Table.png)
- [Hands minigame backdrop](https://github.com/s3lven/ECS189L-FinalProject/blob/main/Assets/Sprites/Stage/Trash%20Hands.png)

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

...





## Input

**Describe the default input configuration.**

**Add an entry for each platform or input style your project supports.**

## Game Logic

**Document what game states and game data you managed and what design patterns you used to complete your task.**

# Sub-Roles

## Cross-Platform

**Describe the platforms you targeted for your game release. For each, describe the process and unique actions taken for each platform. What obstacles did you overcome? What was easier than expected?**

## Audio

**List your assets including their sources and licenses.**

**Describe the implementation of your audio system.**

**Document the sound style.** 

## Gameplay Testing

**Add a link to the full results of your gameplay tests.**

**Summarize the key findings from your gameplay tests.**

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
