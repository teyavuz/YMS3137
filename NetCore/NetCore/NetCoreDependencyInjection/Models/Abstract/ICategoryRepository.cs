﻿using NetCoreDependencyInjection.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreDependencyInjection.Models.Abstract
{
    public interface ICategoryRepository
    {
        List<Category> Categories();
    }
}
