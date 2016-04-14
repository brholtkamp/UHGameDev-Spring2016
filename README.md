UH Game Development Tutorial - April 2016
=========================================

Topics To Cover
---------------

* What is a Game?

    * Extremely hard to define
    * "all games share four defining traits: a goal, rules, a feedback system, and voluntary participation." - Jane McGonigal

* What is Game Development?

    * Simple Answer: To process to build a game

    * Real Answer: A huge collaborative effort under taken by (potentially many) talented people involving many disciplines to create a polished and fun experience for a player to enjoy

    * Incomplete List of Required Skills in Game Development:

        * Team Management (Producer)
        * Marketing / Distribution (Publisher)
        * Customer Validation (Market Research)
        * Quality Control (Testers)
        * _Programming_ (Programmers)
        * Graphic Design (Artists)
        * Animation (Animators)
        * Textures (Artists)
        * Sound Engineering (Sound Engineers / Musicians)
        * _Game Design_ / Level Design (Designers)
        * Gameplay Testing (Testers / Designers)

* Game Engines

    * What is a Game Engine?

    A piece of software designed to assist with the creation and development of video games

    * What comes with a Game Engine?

        * The Game Logic
            * Main Game Loop
            * Menus
            * Scripting
            * Object Instantiation / Pooling
            * Garbage Collection
        * Graphics / Rendering
            * Cameras
            * Shaders
            * Textures
            * Materials
            * Lighting
            * Animations
        * Controls
            * Keyboard / Mouse
            * Controllers
            * Networked inputs
        * Audio
            * BGM
            * SFX
            * 3D Audio Effects
        * Physics
            * Colliders / Bounding Boxes
            * Raycasts
            * Physics Materials
            * Gravity
            * Fluid Dynamics
            * _Explosions!_
        * AI
            * Navigation (Navmeshes)
            * Triggers
            * Areas of Influence
        * Scene Management
            * Level Building
            * Level Loading
            * Scene Serialization
        * VR/AR Support
            * Head-tracking support
            * Motion controls
            * HUD Menus

    * What are some Game Engines?

        * [_Unity3D_](https://www.unity3d.com)
            * Super popular
            * Plenty of tutorials and resources
            * Scripted in C#, JavaScript, or Boo
        * [_Unreal_](https://www.unrealengine.com)
            * Super popular
            * Plenty of tutorials and resources
            * Scripted in Blueprints and/or C++
        * [CryEngine](https://www.cryengine.com)
            * Highly performant
            * Typically the bleeding edge of technology
            * Scripted in C#, C++, and Lua
        * [OGRE](https://www.ogre3d.com)
            * Extremely minimal
            * Highly customizable
            * Scripted in C++

* Case Study: Flappy Bird

    ![Flappy Bird](https://upload.wikimedia.org/wikipedia/en/5/52/Flappy_Bird_gameplay.png "Example of Flappy Bird Gameplay")

    * 2013 Mobile Hit
    * Game Definition
        * Goal
            * Survive as long as possible
            * Get a high score
        * Rules
            * You can't hit the floor
            * You can't hit the pipes
            * You're always falling
        * Feedback System
            * Your inputs direct the bird
            * If directed well, you can get a higher score
        * Voluntary Participation
            * We have a short attention span
            * We get bored easily

* Unity3D

    * Terminology
        * GameObject

            An object in the game that's governed by a script

        * Transform

            An object that exists within the "world" of the game

        * Component

            An additional piece of functionality that has been added to a game object

    * Interface

        * Hierarchy
            * Parents and Children
        * Scene
            * World Space vs Local Space
        * Game
        * Inspector
            * Layers
            * Tags
            * Transform
            * Components
        * Project
        * Console
        * Controls
            * Scene Management
                * Play
                * Pause
                * Next Frame
            * Hand Movement
            * Transform Movement
            * Transform Rotation
            * Transform Scaling

Building Flappy Bird
====================

Phase 1
-------

1. Set the Scene
    1. Create a scene
    1. Introduce the camera
        1. Set the aspect ratio
    1. Add in a background
        1. Import the image
        1. Create an empty game object
        1. Add a sprite renderer
        1. Apply the sprite
        1. Tweak the scaling (2, 1.5, 1)
1. Add in the Character
    1. Create the character
        1. Import the image
        1. Create an empty game object
        1. Add the sprite renderer
        1. Apply the sprite
    1. That's a big bird!
        1. Adjust the camera (Orthographic 9)
        1. Adjust the bird scaling (0.25, 0.25, 1.0f)
    1. Time for gravity
        1. Add a Rigidbody2D to the bird
        1. Falls kinda slow?  Increase it's mass (5, 500, 1000000)?
            1. What falls faster?  1lb of lead or 1lb of wood?
        1. Time to increase gravity scaling (2)
    1. Time to learn how to jump
        1. Add a BirdController.cs script
        1. Add an Update loop for input
        1. Add a FixedUpdate for input to change the velocity
        1. Set the force to be 5
        1. Tweak until it feels good (600)
1. We've made a "flappy" bird!

References
----------
[Tappy Plane Tutorial](https://github.com/anwell/TappyPlane)
[Background Art](http://opengameart.org/content/seamless-cave-background)
[Bird Sprite](http://opengameart.org/content/fat-bird-sprite-sheets-for-gamedev)
[Pipe Sprites](http://opengameart.org/content/2d-object-pack)
