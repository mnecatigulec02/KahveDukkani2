﻿using KahveDukkani2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveDukkani2.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
