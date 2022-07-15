// -----------------------------------------------
//     Author: Ramon Bollen
//      File: StringCalculator.CalculateString.cs
// Created on: 20220715
// -----------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator;

/// <summary>
///     Step 1,2,3,4 of the Kata
/// </summary>
public static class CalculateString
{
    //Explicitly not doing any validation on the int.Parse
    public static int Add(string numbers) => string.IsNullOrWhiteSpace(numbers) ? 0 : SplitToArray(numbers).Sum(int.Parse);

    private static string[] SplitToArray(string text)
    {
        List<char> separators = new() {'\n', '\u002C'};

        if (text[0] == '/' && text[1] == '/')
        {
            separators.Add(text[2]);
            text = text.Remove(0, 3);
        }

        return text.Split(separators.ToArray(), StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
    }
}