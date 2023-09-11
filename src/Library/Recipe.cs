//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public ArrayList GetSteps { get => steps; }


        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        // La responsabilidad de obtener el costo total del producto final es de la receta ya que es quien conoce la infomrmación necesaria 
        // para poder calcular el total.
        public double GetProductionCost(ArrayList steps)
        {
            double totalCost = 0;
            foreach (Step step in steps)
            {
                totalCost += step.TotalCost;
            }
            return totalCost;
        }

/*
        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            Console.WriteLine($"El costo total de la receta es {this.GetProductionCost}");
        }
        */
    }
}