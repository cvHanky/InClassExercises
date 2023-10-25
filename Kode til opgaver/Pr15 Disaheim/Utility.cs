﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr15_Disaheim
{
    public class Utility
    {
        public Double GetValueOfBook(Book book)
        {
            Double result = book.Price;
            return result;
        }

        public Double GetValueOfAmulet(Amulet amulet)
        {
            Double result;
            switch (amulet.Quality)
            {
                case Level.low:
                    result = 12.5;
                    break;
                case Level.medium:
                    result = 20;
                    break;
                case Level.high:
                    result = 27.5;
                    break;
                default:
                    result = 0;
                    throw new Exception("Amulet does not have a quality.");
            }
            return result;
        }
    }
}
