﻿using CodeIT.Airlines.Models.Locais.Interfaces;

namespace CodeIT.Airlines.Models.Carros.Interfaces
{
    public interface ICarro : ILocal
    {
        ILocal LocalAtual { get; }
        string Modelo { get; }
        void DirigirAte(ILocal local);
    }
}
