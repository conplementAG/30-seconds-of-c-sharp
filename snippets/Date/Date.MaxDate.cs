﻿using System;
using System.Linq;

namespace JonasSchubert.Snippets.Date
{
    /// <summary>
    /// Partial class for date snippets
    /// </summary>
    public static partial class Date
    {
        /// <summary>
        /// Returns the maximum of the given dates.
        /// </summary>
        public static DateTime MaxDate(params DateTime[] dateTimeList)
        {
            if (dateTimeList == null || !dateTimeList.Any())
            {
                throw new ArgumentException("The dateTimeList may not be empty!", nameof(dateTimeList));
            }

            if (!dateTimeList.All(x => dateTimeList.First().Kind == x.Kind))
            {
                throw new ArgumentException("All params have to have the same timezone!", nameof(dateTimeList));
            }

            return dateTimeList.Max();
        }
    }
}
