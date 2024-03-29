﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Domain.Models
{
    /// <summary>
    /// Domain model to store information about all transactions.
    /// </summary>
    public class AssetTransaction : DomainObject
    {
        public Account Account { get; set; }
        public bool IsPurchase { get; set; }
        public Asset Asset { get; set; }
        public int Shares { get; set; }
        public DateTime DateProcessed { get; set; }
    }
}
