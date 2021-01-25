/*  5.02 Formatting String Output - Justification.cs
    Author: Kleverzon Vasquez
    Student ID: 16367
    Date: 1/25/21
    Lesson: 5.02 A Formatting A Pokemon
    */

using System;

class MainClass {

  public static void Main (string[] args) {
    String trainer = "Jodie";
    String name = "Snivy";
    int maxHP = 75;

    Console.WriteLine($"{trainer, -10} {name, -15} {maxHP, 7}");

  }
}