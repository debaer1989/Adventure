﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
 

namespace ErstesProjekt
{
    
    /*Ziemliche Scheiße*/
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        
       
        public InputComponent Input
        {
            get;
            private set;
        }

        public SimulationComponent Simulation
        {
            get;
            private set;
        }
        public SceneComponent Scene
        {
            get;
            private set;
        }


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            Input = new InputComponent(this);
            Input.UpdateOrder = 0;
            Components.Add(Input);

            Simulation = new SimulationComponent(this);
            Simulation.UpdateOrder = 1;
            Components.Add(Simulation);

            Scene = new SceneComponent(this);
            Scene.UpdateOrder = 2;
            Components.Add(Scene);

        }
        
     
    }
}
