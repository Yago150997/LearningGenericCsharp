﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HigherPriceProduct.Entities
{
    class CalculationService
    {
        

        
        
        public int Max(List<int> list)
        {
            int max = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }

            return max;
        }
    }
}