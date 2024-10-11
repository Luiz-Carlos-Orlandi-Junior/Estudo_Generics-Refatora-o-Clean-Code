using Consultorio.Interfaces;
using System;
using System.Collections.Generic;

namespace Consultorio.Classes
{
    public class Consulta<TFinalidade, THorario, TLocal> : IConsulta
    {
        private TFinalidade _finalidade;
        private THorario _horario;
        private TLocal _local;

        // Propriedade de Finalidade
        public TFinalidade Finalidade
        {
            get => _finalidade;
            set
            {
                // Validação de exemplo
                if (EqualityComparer<TFinalidade>.Default.Equals(value, default))
                    throw new ArgumentException("A finalidade não pode ser vazia.");
                _finalidade = value;
            }
        }

        // Propriedade de Horário
        public THorario Horario
        {
            get => _horario;
            set => _horario = value; // Aqui poderia haver uma validação adicional.
        }

        // Propriedade de Local
        public TLocal Local
        {
            get => _local;
            set => _local = value; // Similar a Horario, poderia ter validações.
        }

        // Método para exibir informações da consulta
        public void MostrarConsulta()
        {
            Console.WriteLine($"Finalidade: {_finalidade}");
            Console.WriteLine($"Horário: {_horario}");
            Console.WriteLine($"Local: {_local}");
        }
    }
}
