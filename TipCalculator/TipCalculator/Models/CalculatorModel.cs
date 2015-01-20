//Creator: Jason R Hodges
//Description: This is a tip calculator that allows you to:
//  -Split a tip between multiple people
//  -Adjust the percent amount that you would like to tip
//  -Choose to either include tax and deductions in the tip calculation or exclude them
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TipCalculator.Models
{
    public class CalculatorModel
    {
        public CalculatorModel()
        {
            NumGuest = 1;
            Quality = 3;
            BillTotal = 0.00D;
            BillDeduct = 0.00D;
            Taxes = 0.00D;
            MinTip = 0.00D;
            MaxTip = 40.00D;
            TipRate = 20.00D;
            TotalTip = 0.00;
            PerPerson = 0.00D;
            TotalCost = 0.00D;
            IncludeTax = true;
            IncludeDeduct = true;

        }

        [DisplayFormat(DataFormatString = "{0:0.00}")]
        [Required]
        public int NumGuest { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}")]
        [Required]
        public double Quality { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}")]
        [Required]
        public double BillTotal { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}")]
        [Required]
        public double BillDeduct { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}")]
        [Required]
        public double Taxes { get; set; }

        [Required]
        public double MinTip { get; set; }

        [Required]
        public double MaxTip { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}")]
        public double TipRate { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}")]
        public double TotalTip { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}")]
        public double PerPerson { get; set; }

        [DisplayFormat(DataFormatString = "{0:0.00}")]
        public double TotalCost { get; set; }

        public bool IncludeTax { get; set; }
        public bool IncludeDeduct { get; set; }

        /// <summary>
        /// This method is used to calculate the total cost with
        /// Taxes Included and Deductions Included in the tip
        /// </summary>
        public void CalcTotal1()
        {
            TotalTip = (BillTotal + Taxes) * (TipRate * .01);

            PerPerson = TotalTip / NumGuest;

            TotalCost = (BillTotal + Taxes + TotalTip) - BillDeduct;

        }

        /// <summary>
        /// This method is used to calculate the total cost with
        /// Taxes Included and Deductions Excluded in the tip
        /// </summary>
        public void CalcTotal2()
        {
            TotalTip = ((BillTotal - BillDeduct) + Taxes) * (TipRate * .01);

            PerPerson = TotalTip / NumGuest;

            TotalCost = (BillTotal + Taxes + TotalTip) - BillDeduct;

        }

        /// <summary>
        /// This method is used to calculate the total cost with
        /// Taxes Excluded and Deductions Included in the tip
        /// </summary>
        public void CalcTotal3()
        {
            TotalTip = BillTotal * (TipRate * .01);

            PerPerson = TotalTip / NumGuest;

            TotalCost = (BillTotal + Taxes + TotalTip) - BillDeduct;

        }

        /// <summary>
        /// This method is used to calculate the total cost with
        /// Taxes Excluded and Deductions Excluded in the tip
        /// </summary>
        public void CalcTotal4()
        {
            TotalTip = (BillTotal - BillDeduct) * (TipRate * .01);

            PerPerson = TotalTip / NumGuest;

            TotalCost = (BillTotal + Taxes + TotalTip) - BillDeduct;

        }


    }
}