using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ErstesProjekt
{
   public class InputComponent: GameComponent
    {
        public Vector2 Direction
        {
            get;
            private set;
        }
        public InputComponent(Game1 game) : base(game)
        {
           
        }

        public override void Update(GameTime gameTime)
        {
           
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                Direction += new Vector2(-1F, 0F);

            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {

                Direction += new Vector2(0F, 1F);

            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {

                Direction += new Vector2(0F, -1F);

            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {

                Direction += new Vector2(1F, 0F);

            }
            base.Update(gameTime);
        }
    }
}
