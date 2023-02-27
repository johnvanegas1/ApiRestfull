﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Interfaces
{
    public interface IPersonaRepository
    {
        void Add(Persona cliente);
        IEnumerable<Persona> GetAll();
    }
}
