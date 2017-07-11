using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name:Dennis Kanzira
 * Date:July 11 2017
 * Description: This is the SuperHuman class that extends the Human abstract class
 * version: 0.2 - Added _initialize method
 * 
*/
namespace Comp123_lesson2b
{
    /// <summary>
    /// This is the Super Human class
    /// </summary>
    public class SuperHuman : Human
    {
        //PRIVATE INSTANCE VARIABLES(FIELDS)
        private List<Power> _powers;
        //PUBLIC PROPERITIES

        //CONSTRUCTORS -----------------------------------------------------
        /// <summary>
        /// This is the main constructor for SuperHuman Class
        /// It takes one parameter - name(string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHuman(string name)
            :base(name)
        {
            this._intialize();
        }

        //PRIVATE METHODS
        /// <summary>
        /// This method initializes, instantiates ans ass
        /// </summary>
        private void _intialize()
        {
            this._powers = new List<Power>();//Creates an empty list
        }

        //PUBLIC METHODS
    }
}