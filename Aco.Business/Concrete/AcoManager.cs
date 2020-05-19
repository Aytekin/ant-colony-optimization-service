﻿using Aco.Business.Abstract;
using Aco.Core.Ant;
using Aco.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aco.Business.Concrete
{
    public class AcoManager : IAcoService
    {
        public AcoRunner acoRunner = new AcoRunner();
        public AntResult Calculate(List<City> cities)
        {
            return acoRunner.Run(cities);
        }
    }
}
