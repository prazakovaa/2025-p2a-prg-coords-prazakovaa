﻿// See https://aka.ms/new-console-template for more information
using System;
using Coords;

Coord c1 = new Coord(10, 10);
Coord c2 = new Coord(10, 10);

Console.WriteLine(c1 == c2); // False
Console.WriteLine(c2.Equals(c2)); // True
