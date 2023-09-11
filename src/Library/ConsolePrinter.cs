using System;
namespace Full_GRASP_And_SOLID.Library
{
    // Esta clase fue creada como consecuencia de seguir SRP ya que la receta no debería tener la responsabilidad de imprimirse.
    // Este principio dice que una clase debería tener una unica razón para cambiar, y el que se le otorgue la responsabilidad
    // de imprimir la receta a Recipe no lo sigue; hoy la receta se imprime en la consola, pero el día de mañana podríamos
    // crear una interfaz donde imprimirla y esta clase no debería verse afectada por esto.
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.GetSteps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            Console.WriteLine($"El costo total de la receta es {recipe.GetProductionCost}");
        }
    }
}