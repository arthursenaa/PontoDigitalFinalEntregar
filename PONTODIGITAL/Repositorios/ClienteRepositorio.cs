using System;
using System.Collections.Generic;
using System.IO;
using PONTODIGITAL.Models;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using static PONTODIGITAL.Repositorios.BaseRepositorio;

namespace PONTODIGITAL.Repositorio {
    public class ClienteRepositorio : BaseRepositorios{
        public static uint CONT = 0;

        private const string PATH = "Database/Cliente.csv";
        private const string PATH_INDEX = "Database/Cliente_Id.csv";

        // private const string PATH_FAQ = "Database/Comentario.csv";

        private List<Cadastro> clientes = new List<Cadastro> ();
        public ClienteRepositorio () {
            if (!File.Exists (PATH_INDEX)) {
                File.Create (PATH_INDEX).Close ();
            }

            var ultimoIndice = File.ReadAllText (PATH_INDEX);
            uint indice = 0;
            uint.TryParse (ultimoIndice, out indice);
            CONT = indice;
        }
        public bool Inserir (Cadastro cliente) {
            CONT++;
            File.WriteAllText (PATH_INDEX, CONT.ToString ());

            string linha = PrepararRegistroCSV (cliente);
            File.AppendAllText (PATH, linha);

            return true;
        }
        private string PrepararRegistroCSV (Cadastro cliente) {
            return $"id={CONT};nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};telefone={cliente.Telefone};data_nascimento={cliente.DataNascimento};tipo=Comum;\n";
        }

        public bool Atualizar (Cadastro cliente) {
            var clientesRecuperados = ObterRegistrosCSV (PATH);
            var clienteString = PrepararRegistroCSV (cliente);
            var linhaCliente = -1;
            var resultado = false;

            for (int i = 0; i < clientesRecuperados.Length; i++) {
                if (clienteString.Equals (clientesRecuperados[i])) {
                    linhaCliente = i;
                    resultado = true;
                }
            }
            if (linhaCliente >= 0) {
                clientesRecuperados[linhaCliente] = clienteString;
                File.WriteAllLines (PATH, clientesRecuperados);
            }

            return resultado;

        }

        public bool Apagar (ulong id) {

            var clientesRecuperados = ObterRegistrosCSV (PATH);
            var linhaCliente = -1;
            var resultado = false;

            for (int i = 0; i < clientesRecuperados.Length; i++) {
                if (id.Equals (clientesRecuperados[i])) {
                    linhaCliente = i;
                    resultado = true;
                }
            }

            if (linhaCliente >= 0) {
                clientesRecuperados[linhaCliente] = "";
                try {
                    File.WriteAllLines (PATH, clientesRecuperados);

                } catch (DirectoryNotFoundException dnfe) {
                    System.Console.WriteLine ("Diretório não encontrado. Favor verificar.");
                } catch (PathTooLongException ptle) {
                    System.Console.WriteLine ("Nome do arquivo é muito grande.");
                }
            }

            return resultado;
        }

        public Cadastro ObterPor (string email) {
            if (email != null) {

                foreach (var item in ObterRegistrosCSV (PATH)) {
                    if (email.Equals (ExtrairCampo (email, item))) {
                        return ConverterEmObjeto (item);
                    }
                }
            }
            return null;
        }
        
        public List<Cadastro> ListarTodos () {
            var linhas = ObterRegistrosCSV (PATH);
            foreach (var item in linhas) {

                Cadastro cliente = ConverterEmObjeto (item);

                this.clientes.Add (cliente);
            }
            return this.clientes;
        }

        private Cadastro ConverterEmObjeto (string registro) {

            Cadastro cliente = new Cadastro();
            System.Console.WriteLine ("REGISTRO:" + registro);
            cliente.Id = int.Parse (ExtrairCampo ("id", registro));
            cliente.Nome = ExtrairCampo ("nome", registro);
            cliente.Email = ExtrairCampo ("email", registro);
            cliente.Senha = ExtrairCampo ("senha", registro);
            cliente.Telefone = ExtrairCampo ("telefone", registro);
            cliente.DataNascimento = DateTime.Parse (ExtrairCampo ("data_nascimento", registro));
            cliente.Tipo = ExtrairCampo("tipo", registro);

            return cliente;
        }

        public Cadastro BuscarEmailESenha (string email, string senha){
            var cliente = ListarTodos();
            foreach(var item in cliente)
            {
                if(item!= null){
                    if(email.Equals(item.Email) && senha.Equals(item.Senha)){
                        return item;
                    }
                }
            }
            return null;
        }

        // public List<Cadastro> Listar () {
        //     List<Cadastro> listaDeUsuarios = new List<Cadastro> ();
        //     string[] linhas = File.ReadAllLines ("Cliente.csv");
        //     Cadastro usuario;

        //     foreach (var item in linhas) {
        //         if (string.IsNullOrEmpty (item)) {
        //             //Sair Do Foreach
        //             continue;
        //         }
        //         string[] linha = item.Split (";");

        //         usuario = new Cadastro (
        //             // Id: int.Parse (linha[0]),
        //             nome: linha[0],
        //             email: linha[1],
        //             senha: linha[2],
        //             dataNascimento: DateTime.Parse (linha[3])
        //         );
        //         listaDeUsuarios.Add (usuario);
        //     }
        //     return listaDeUsuarios;
        // }
    }
}