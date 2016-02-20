﻿using System;

//Define a class Laptop that holds the following information about a laptop device:
//model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life in hours and price.
//The model and price are mandatory.All other values are optional.
//Define two separate classes: a class Laptop holding an instance of class Battery.
//Define several constructors that take different sets of arguments(full laptop + battery information or only part of it). 
//Use proper variable types.
//Add a method in the Laptop class that displays information about the given instance
//Tip: override the ToString() method
//Put validation in all property setters and constructors.String values cannot be empty, and numeric data cannot be negative
//.Throw exceptions when improper data is entered.

class Battery
{
    private string batteryType;
    private int batteryLife;

    public Battery(string batteryType, int batteryLife)
    {
        this.BatteryType = batteryType;
        this.BatteryLife = batteryLife;
    }

    public string BatteryType
    {
        get
        {
            return this.batteryType;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("String cannot be empty!");
            }
            this.batteryType = value;
        }
    }

    public int BatteryLife
    {
        get
        {
            return this.batteryLife;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Number must be possitive!");
            }
            this.batteryLife = value;
        }
    }

}
