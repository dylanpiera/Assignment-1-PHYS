using Microsoft.Xna.Framework;
using System;
using System.Linq;

namespace Opdracht1_Bouncing {
    internal class PlayState : GameObjectList {

        GameObjectList balls;

        Ball red_ball, pink_ball, purple_ball;

        public PlayState() {
            ///////////
            // Example:
            // randomize the starting position and velocity
            var position = new Vector2(GameEnvironment.Random.Next(100, GameEnvironment.Screen.X - 100),
                GameEnvironment.Random.Next(100, GameEnvironment.Screen.Y - 100));
            var velocity = new Vector2(GameEnvironment.Random.Next(-150, 150),
                GameEnvironment.Random.Next(-150, 150));
            // Instantiate a new ball
            //            var ball = new Ball("PinkSoftColorBall", position, velocity, 30f);
            // Add the instance of the baal to this GameObjectList
            //            Add(ball);
            ///////////

            // step 1: Initialize three balls on the correct position
            balls = new GameObjectList();
            this.Add(balls);

            red_ball = new Ball("spr_ball_red", new Vector2(BouncingGameWorld.Screen.X/4, BouncingGameWorld.Screen.Y/2 ), Vector2.Zero, 30f);
            pink_ball = new Ball("PinkSoftColorBall", new Vector2(0, BouncingGameWorld.Screen.Y), Vector2.Zero, 30f);
            purple_ball = new Ball("PurpleSoftColorBall", new Vector2(BouncingGameWorld.Screen.X/2, 0), Vector2.Zero, 30f);

            // step 2: Give them the correct velocity

            red_ball.Velocity = Vector2.Zero;
            pink_ball.Velocity = new Vector2(300, -300);
            purple_ball.Velocity = new Vector2(0, 300);



            // step 10: randomize the position and starting velocity


            balls.Add(red_ball);
            balls.Add(pink_ball);
            balls.Add(purple_ball);
        }

        public override void Update(GameTime gameTime) {

            red_ball.Velocity = new Vector2(red_ball.Velocity.X + 1, red_ball.Velocity.Y);

            pink_ball.Velocity = new Vector2(pink_ball.Velocity.X, pink_ball.Velocity.Y + 5f);

            purple_ball.Velocity = new Vector2(purple_ball.Velocity.X, purple_ball.Velocity.Y + 5f);
            if (purple_ball.Position.Y > BouncingGameWorld.Screen.Y)
            {
                purple_ball.Velocity = new Vector2(purple_ball.Velocity.X, purple_ball.Velocity.Y * 0.66f);
            }
            

            balls.Objects.ForEach(x =>
            {
                if(x.Position.X < 0 || x.Position.X > BouncingGameWorld.Screen.X)
                {
                    x.Velocity = new Vector2(x.Velocity.X * -1, x.Velocity.Y);
                }
                if (x.Position.Y < 0 || x.Position.Y > BouncingGameWorld.Screen.Y)
                {
                    x.Velocity = new Vector2(x.Velocity.X, x.Velocity.Y * -1);
                }
            });

            base.Update(gameTime);
        }
    }
}