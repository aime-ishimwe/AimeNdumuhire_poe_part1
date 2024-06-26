//Author: Aime Ndumuhire.
//Github: https://github.com/aime-ishimwe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimeNdumuhire_st10255663_POE
{
    internal class RecipeManager
    {
        //declarations
        private string[] ingredients;
        private double[] quantities;
        private string[] units;
        private string[] steps;
        private double scale;

        // Constructor to initialize arrays 
        public RecipeManager()
        {
            ingredients = new string[0];
            quantities = new double[0];
            units = new string[0];
            steps = new string[0];
            scale = 1.0;

        }

        // Method to enter recipe 
        public void EnterRecipeDetails()
        {
            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            Console.WriteLine();

            ingredients = new string[numIngredients];
            quantities = new double[numIngredients];
            units = new string[numIngredients];

            // Loop to input ingredient 
            for (int i = 0; i < numIngredients; i++)
            {

                Console.WriteLine($" Enter details for ingrediants{i + 1}:");

                Console.Write("Name: ");
                ingredients[i] = Console.ReadLine();

                Console.Write("Quantity:");
                quantities[i] = double.Parse(Console.ReadLine());

                Console.Write(" Unit of measurement: ");
                units[i] = Console.ReadLine();
                Console.WriteLine();


            }

            Console.Write("Enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());
            Console.WriteLine();
            steps = new string[numSteps];
            // Loop to input steps
            for (int i = 0; i < numSteps; i++)
            {

                Console.Write($"Enter step {i + 1}: ");
                steps[i] = Console.ReadLine();
                Console.WriteLine();
            }
        }
        // Method to display recipe details
        public void DisplayRecipe()
        {

            Console.WriteLine("Recipe:");
            Console.WriteLine();
            for (int i = 0; i < ingredients.Length; i++)
            {
                double scaledQuantity = quantities[i] * scale;
                Console.WriteLine($"{i + 1}. {"Quantity: " + scaledQuantity} {"Units: " + units[i]} of {ingredients[i]}");
            }
            Console.WriteLine();

            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"Step {i + 1}: {steps[i]}");
            }
            Console.WriteLine();
        }
        // Method to scale recipe quantities
        public void ScaleRecipe()
        {
            Console.Write("Enter the scaling factor (0.5, 2, or 3): ");
            double factor = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if (factor == 0.5 || factor == 2 || factor == 3)
            {
                scale = factor;
                Console.WriteLine("Recipe scaled successfully.");
            }
            else
            {
                Console.WriteLine("Invalid scaling factor. Recipe scaling failed.");
            }

            Console.WriteLine();
        }
        // Method to reset ingredient quantities to original values
        public void ResetQuantities()
        {
            scale = 1.0;
            Console.WriteLine("Quantities reset to original values.");
            Console.WriteLine();
        }
        // Method to clear recipe data
        public void ClearData()
        {
            ingredients = new string[0];
            quantities = new double[0];
            units = new string[0];
            steps = new string[0];
            scale = 1.0;

            Console.WriteLine("All data cleared.");
            Console.WriteLine();
        }
    }




}
