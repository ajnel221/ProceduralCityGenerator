## 170193_Adriaan_Johannes_Nel_Procedural_City_Generator_&_Vegetation_Spawner
------------------------------------------------------------------------------------------------
Download The .unitypackage here: https://drive.google.com/file/d/1X5UrlubYjoS09q_-HIEQGt84Vy-Uyon8/view?usp=sharing
------------------------------------------------------------------------------------------------
Check out a quick Demo Video Here: https://youtu.be/8iM9lRr7s1M
------------------------------------------------------------------------------------------------
# City

**To be able to use this generator, there are a few basic variables you need to understand in order to generate a viable City.**
1. ![1_1](https://i.ibb.co/PGksmLC/1.png)

 - Seed Text: Displays the current random seed.
 - Spawner Object: Attach the object that you would like to use as the City Spawner.
 - Game Object Array: All of the object you would like to use to generate the City. (Max 6 prefabs).

2. ![1_2](https://i.ibb.co/tXVG4b1/2.png)

 - Generate City: This will generate the city outside of play mode in the editor.
 - Delete City: This will delete the spawned items from the city, it has to be pressed more than once to delete all of the objects.
 - These apply for the ScriptableObject City buttons as well.
 - Map Height: This is basically the length of the map and will determine how many rows of objects there will be on a axis.
 - Map Width: This will determine how many columns there will be for objects on a different axis. 
 - These two values essential create a grid based system.
 - Building Space: This will control the space between objects.
 - Random Seed: If the toggle is enabled, a random city will be spawned every time the city is generated, if the toggle is disabled the city will be generated from a manual seed the user has specified.
 - The manual seed will spawn the city at the specified seed value.

3. ![1_3](https://i.ibb.co/jw4b6tW/3.png)

4. ![1_4](https://i.ibb.co/wgnH3pc/4.png)

 - By creating a ScriptableObject, the user can enter values of their choice into them and always have a specific city be generated based on those values instead of having a random city spawned each time, similar to the manual seed.
 - The ScriptableObject also has a random toggle, in case the user wishes to continue testing, but still have some variables saved.

5. ![1_5](https://i.ibb.co/BwbtfTd/5.png)

 - This array is simply used to rotate building objects. (First 3 Game Objects in the Array of objects to spawn.)
------------------------------------------------------------------------------------------------

## Vegetation
 1. ![2_1](https://i.ibb.co/3TFk6zt/6.png)
 - Grass Object: This is the item from which everything will be spawned.
 - Grass Prefab: This is where you would place the prefab of whichever grass you would like to use.
 - Trees To Spread: This is where you would place the prefab of whichever tree you would like to use.
 - Number of Trees to Spawn: This is the amount of trees you would like to spawn per spawner.
 - Number of Grass to Spawn: This is the amount of grass you would like to spawn per spawner.
 - X-Spread: The size of the spawnable area on the X-Axis.
 - Y-Spread: The size of the spawnable area on the Y-Axis.
 - Z-Spread: The size of the spawnable area on the Z-Axis.
------------------------------------------------------------------------------------------------

You can swap out the prefabs in use for whatever you like, just be sure to check the scaling of your models or adjust you variables according to your object scaling.

------------------------------------------------------------------------------------------------

The basic spawning and perlin noise methods were received from this tutorial:
[# Generating a Procedural City with Unity 5 Part 1](https://youtu.be/xkuniXI3SEE)

I didn't want to use the second part of the tutorial series, because then I would just have a copied system. I tried to incorporate rotation into the system, so that buildings are randomly rotated. I also added my own systems into this tutorial by creating the Manual Seed version of this along with the ScriptableObject system that works with the initial spawning system and as for a secondary spawning system, I also created the Vegetation Spawning from scratch to compliment this system.

------------------------------------------------------------------------------------------------
