using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
// using Microsoft.CodeAnalysis;
// using Microsoft.CodeAnalysis.CSharp;
// using Microsoft.CodeAnalysis.Emit;

// current version - 1.0.1

// changes:
// - add csproj

internal class Program
{
    private static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Usage: ./chease.exe filename.chease");
            return;
        }
    }
}