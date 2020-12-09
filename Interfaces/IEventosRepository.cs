﻿using Nyous.Api.NoSql.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nyous.Api.NoSql.Interfaces
{
    public interface IEventosRepository
    {
        List<EventoDomain> Listar();
        void Adicionar(EventoDomain evento);
        void Atualizar(string id, EventoDomain evento);
        void Remover(string id);
    }
}
