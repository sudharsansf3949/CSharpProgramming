﻿using System;
namespace Question1;
class program{
    public static void Main(string[] args)
    {
        int[] numbers=new int[10];
        numbers[0]=1;
        numbers[1]=1;
        numbers[2]=2;
        numbers[3]=3;
        numbers[4]=4;
        numbers[5]=5;
        numbers[6]=6;
        numbers[7]=7;
        numbers[8]=8;
        numbers[9]=9;
        for (int i =0;i<10;i++){
            System.Console.WriteLine(numbers[i]);
        }
    }
}