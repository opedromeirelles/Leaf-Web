﻿using System.ComponentModel.DataAnnotations;

namespace Leaf.Models.Domain
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O login é obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha { get; set; }

        public int Status { get; set; }

        // Relação com Departamento
        [Required(ErrorMessage = "Selecione um departamento")]
        public int IdDpto { get; set; }

        public Departamento? Departamento { get; set; }


    }


}
