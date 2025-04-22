using hotel_2.Controllers;
using hotel_2.Views;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
       Display display = new Display();
        display.ShowMenu();
    }
}