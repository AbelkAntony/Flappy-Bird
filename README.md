# Flappy-Bird
 
Flappy Bird is an arcade-style game in which the player controls the bird Faby, which moves persistently to the right. The player is tasked with navigating Faby through pairs of pipes that have equally sized gaps placed at random heights.

In this game I use animation to Bird , also I use animations to ground also. I create pipes for both sides and make the pipes as a child object , So I can access the both pipes position by its parent object. When the Bird cross the pipe points will be added and display on the top of the game. If the Bird collide with the pipes or collide with ground the game will end . We have an option to restart the game again . I add capsule collider to Bird and box collider 2D to pipes also box collider 2D to ground so I can detect the collision . In this game I use SceneManager to reset the scene of the game to restart
