﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Barbearia
{
    class SalaoDeBeleza
    {
        private List<Cliente> clientes;
        private List<Barbeiro> barbeiros;

        public SalaoDeBeleza()
        {
            clientes = new List<Cliente>();
            barbeiros = new List<Barbeiro>();
        }

        public void AdicionarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public void AdicionarBarbeiro(Barbeiro barbeiro)
        {
            barbeiros.Add(barbeiro);
        }

        public void AtenderClientes()
        {
            foreach (Cliente cliente in clientes)
            {
                foreach (Barbeiro barbeiro in barbeiros)
                {
                    if (barbeiro.Especialidade == cliente.ServicoDesejado)
                    {
                        barbeiro.RealizarServico(cliente);
                    }
                }
            }
        }
    }
}