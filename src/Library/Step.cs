
//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        private double equipmentCost;
        private double totalCost;
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }


        private double EquipmentCost 
        { 
            get
            {
                return equipmentCost;
            }
            set 
            {
                equipmentCost = Time * Equipment.HourlyCost;
            }
        }

        public double TotalCost 
        {
            get {
                return totalCost;
            }
            private set 
            {
                totalCost = EquipmentCost + Input.UnitCost;
            }
        }

    }
}