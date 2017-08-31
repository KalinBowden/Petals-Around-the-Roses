using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetalsAroundTheRoseGame
{
    /// <summary>
    /// Class: Simulates the rolling of dice.
    /// </summary>
    class Dice
    {
        //Class level varibles.
        private int points;
        private int dieFace;

        /// <summary>
        /// Constructor: Default -no arguments-
        /// </summary>
        public Dice()
        {
            points = 0;
            dieFace = 0;
        }// End of Constructor.

        /// <summary>
        /// Constructor: Two arguments.
        /// </summary>
        /// <param name="rollPoint"></param>
        /// <param name="rollDieFace"></param>
        public Dice(int rollPoint, int rollDieFace)
        {
            points = rollPoint;
            dieFace = rollDieFace;
        }// End of Constructor.

        /// <summary>
        /// Public Property: point variable for die.
        /// </summary>
        public int Points
        {
          get
            {
                return points;
            }
            set
            {
                points = value;
            }
        }// End of Property.

        /// <summary>
        /// Public Property: dieFace varible for die.
        /// </summary>
        public int DieFace
        {
            get
            {
                return dieFace;
            }
            set
            {
                dieFace = value;
            }
        }// End of Property.

        /// <summary>
        /// Method: Overriden ToString() for the Dice class.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Die Face: " + dieFace + "\r\nDie Value: " + points;
        }// End of Overriden ToString() Method.

    }// End of Class.
}// End of solution.
