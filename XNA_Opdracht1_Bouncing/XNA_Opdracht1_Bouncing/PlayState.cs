using Microsoft.Xna.Framework;
using System;

namespace Opdracht1_Bouncing {
    internal class PlayState : GameObjectList {
        public PlayState() {
            ///////////
            // Example:
            // randomize the starting position and velocity
            var position = new Vector2(GameEnvironment.Random.Next(100, GameEnvironment.Screen.X - 100),
                GameEnvironment.Random.Next(100, GameEnvironment.Screen.Y - 100));
            var velocity = new Vector2(GameEnvironment.Random.Next(-150, 150),
                GameEnvironment.Random.Next(-150, 150));
            // Instantiate a new ball
            var ball = new Ball("PinkSoftColorBall", position, velocity, 30f);
            // Add the instance of the baal to this GameObjectList
            Add(ball);
            ///////////

            // step 1: Initialize three balls on the correct position
            // step 2: Give them the correct velocity

            // step 10: randomize the position and starting velocity
        }

        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
        }
    }
}