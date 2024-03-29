﻿using CodeIT.Airlines.Models.Entidades.Enums;
using CodeIT.Airlines.Models.Entidades.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;

namespace CodeIT.Airlines.Models.Locais.Interfaces
{
    public interface ILocal
    {
        string Nome { get; }
        int? Capacidade { get; }
        IEnumerable<IPessoa> Pessoas { get; }
        void RegistrarEntrada(params IPessoa[] pessoas);
        void RegistrarSaida(params IPessoa[] pessoas);

        IPessoa PessoaPorTipo(TripulacaoTipo tripulacaoTipo);

        event Action<ILocal> LocalChanged;
    }
}
