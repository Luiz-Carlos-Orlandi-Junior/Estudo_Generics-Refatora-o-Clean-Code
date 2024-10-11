using System;
using Consultorio.Interfaces;

namespace Consultorio.Classes
{
    // Implementação da classe Receita com Generics
    public class Receita<TMedicamento, TDosagem, TData> : IReceita
    {
        private TMedicamento _medicamento;
        private TDosagem _dosagem;
        private TData _data;

        // Construtor para inicializar a receita
        public Receita(TMedicamento medicamento, TDosagem dosagem, TData data)
        {
            _medicamento = medicamento;
            _dosagem = dosagem;
            _data = data;
        }

        public TMedicamento Medicamento
        {
            get { return _medicamento; }
            set { _medicamento = value; }
        }

        public TDosagem Dosagem
        {
            get { return _dosagem; }
            set { _dosagem = value; }
        }

        public TData Data
        {
            get { return _data; }
            set { _data = value; }
        }

        // Implementação do método MostrarReceita
        public void MostrarReceita()
        {
            Console.WriteLine($"Medicamento: {_medicamento}, Dosagem: {_dosagem}, Data: {_data}");
        }
    }
}
