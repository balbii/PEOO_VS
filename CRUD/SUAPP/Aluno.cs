﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUAPP
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public int Email { get; set; }
        public int IdTurma { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Nome} - {Matricula} - {Email} - {IdTurma}";
        }
    }
}
