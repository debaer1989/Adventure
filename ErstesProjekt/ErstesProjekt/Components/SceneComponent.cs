using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ErstesProjekt
{
     public class SceneComponent : DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        //Texture2D star;
        private Texture2D pixel;
        private Game1 game;
        public SceneComponent (Game1 game) : base(game)
        {
            this.game = game;
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            //star = Game.Content.Load<Texture2D>("starGold");
            pixel = new Texture2D(GraphicsDevice, 1, 1);
            pixel.SetData<Color>(new Color[] { Color.White });
            base.LoadContent();
        }

        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);


            spriteBatch.Begin();
            // TODO: Add your drawing code here
            //spriteBatch.Draw(star, game.Simulation.Position, Color.White);

            //Erstellt die Umrandung des Spielfeldes Oben und Unten
            spriteBatch.Draw(pixel, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, 10), Color.Red);
            spriteBatch.Draw(pixel, new Rectangle(0, GraphicsDevice.Viewport.Height-10, GraphicsDevice.Viewport.Width, 10), Color.Red);

            //Erstellt die Umrandung des Spielfeldes Rechts und Links
            spriteBatch.Draw(pixel, new Rectangle(0, 0, 10, GraphicsDevice.Viewport.Height), Color.Red);
            spriteBatch.Draw(pixel, new Rectangle(GraphicsDevice.Viewport.Width - 10, 0, 10, GraphicsDevice.Viewport.Height), Color.Red);

            //Malt Rechteckt als Schläger
            spriteBatch.Draw(pixel, new Rectangle((int)game.Simulation.Position.X, (int)game.Simulation.Position.Y, 10, 100), Color.White);
            spriteBatch.Draw(pixel, new Rectangle(GraphicsDevice.Viewport.Width -30, 10, 10, 100), Color.White);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
