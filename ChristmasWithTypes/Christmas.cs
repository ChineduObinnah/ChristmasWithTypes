﻿using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int? TreeHeight { get; set; } //TODO Make the Height property nullable

        //TODO Make the property, "Day", type enum
        public enum Day { Monday, Tuesday, Wendesday, Thursday, Friday, Saturday, Sunday/*Fill out the days of the week*/ };

    }
}
