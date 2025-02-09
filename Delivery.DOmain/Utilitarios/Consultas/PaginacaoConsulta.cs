﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Domain.Utilitarios.Consultas
{
    public class PaginacaoConsulta<T> where T : class
    {
        public long Total { get; set; }
        public IEnumerable<T> Registros { get; set; }
    }
}
