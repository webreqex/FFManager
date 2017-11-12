﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFManager.Models.Bases
{
    public interface RelationAccountBase<TService> : IServiceAccount<TService> where TService : IService
    {
    }
}