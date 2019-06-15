using System;
using Microsoft.AspNetCore.Http;

namespace PONTODIGITAL.Models
{
    public class Cadastro
    {
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public string Telefone {get;set;}
        // public IFormFile Foto {get;set;}
        public DateTime DataNascimento {get;set;}
        public string Tipo{get;set;}
        public int Id {get;set;}
    
    // public Cadastro (string nome, string email, string senha, DateTime dataNascimento) {
    //         this.Nome = nome;
    //         this.Email = email;
    //         this.Senha = senha;
    //         this.DataNascimento = dataNascimento;
    //     }
    }
}