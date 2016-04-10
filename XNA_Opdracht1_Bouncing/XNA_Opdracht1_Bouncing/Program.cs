using System;
using Opdracht1_Bouncing;

namespace XNA_Opdracht1_Bouncing {
#if WINDOWS || XBOX
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static void Main(string[] args)
        {
            using (var game = new BouncingGameWorld())
            {
                game.Run();
            }
        }
    }
#endif
}

