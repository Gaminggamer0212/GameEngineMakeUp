# INFR 3110 Make Up Assignment
---
### Name : Anson
### Student Number : 100748012
---
# Object Oriented Programming
---
### Description
<!-- Briefly describe the classes, their relationships, and how object-oriented
programming principles are demonstrated in your implementation. -->
Inheritance and polymorphism are done using the food class and their respective spawners. There is a generic food class where every other types of food like orange and apple are inheriting from. (just noticed i called it food instead of fruit)
## UML Diagram
<!-- Attach your UML diagram here -->
---
# Singleton Pattern
---
### Purpose
<!-- Explain why the Singleton pattern is appropriate for this particular system.
-->
For sound it is to prevent multiple sources from playing at the same time. Same for game manager, you want to prevent multiple keeping track of score
### Implementation
<!--Describe how the Singleton pattern is implemented in your project. -->
I have created an AudioManager to play sounds. And GameManager is mostly used to keep track of score and spawn enemies.
---
# Factory Pattern
---
### Purpose
<!-- Explain why the Factory pattern is appropriate for this particular system. -->
It is appropriate because it you only have to reference fruit when you have multiple types of fruit
### Implementation
<!-- Describe how the Factory pattern is implemented in your project. -->
It is used to instantiate different types of fruit on the scene.
---
# References
---
<!-- Identify sources used to create any gameplay logic or programming pattern
implementations. -->
The singleton base was from the lecture/async slides, but it was a direct copy from the mid-terms. Factory design is also very similar from the slides.