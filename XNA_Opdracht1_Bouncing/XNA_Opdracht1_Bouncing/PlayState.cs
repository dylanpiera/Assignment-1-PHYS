using Microsoft.Xna.Framework;
using System;

namespace Opdracht1_Bouncing {
    class PlayState : GameObjectList {
        public PlayState()
            : base() {
            ///////////
            // Example:
            // randomize the starting position and velocity
            Vector2 position = new Vector2(GameEnvironment.Random.Next(100, GameEnvironment.Screen.X - 100),
                GameEnvironment.Random.Next(100, GameEnvironment.Screen.Y - 100));
            Vector2 velocity = new Vector2(GameEnvironment.Random.Next(-150, 150),
                GameEnvironment.Random.Next(-150, 150));
            // Instantiate a new ball
            Ball ball = new Ball("PinkSoftColorBall", position, velocity, 30f);
            // Add the instance of the baal to this GameObjectList
            this.Add(ball);
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