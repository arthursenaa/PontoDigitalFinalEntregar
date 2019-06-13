using System;
using System.Collections.Generic;
using System.IO;
using PONTODIGITAL.Models;
using static PONTODIGITAL.Repositorios.BaseRepositorio;

namespace PONTODIGITAL.Repositorios {
    public class FaqRepositorio : BaseRepositorios
    {
        private const string PATH = "Database/Comentario.csv";

        private const string PATH_FAQ = "Database/Comentario.csv";

        private List<Faq> coment = new List<Faq> ();

        public FaqRepositorio () {
            if (!File.Exists (PATH_FAQ)) {
                File.Create (PATH_FAQ).Close ();
            }

            var ultimoIndice = File.ReadAllText (PATH_FAQ);
            uint indice = 0;
            uint.TryParse (ultimoIndice, out indice);
        }
        public bool Inserir (Faq coment) {

            string linha = PrepararRegistroCSV (coment);
            File.AppendAllText (PATH, linha);

            return true;
        }
        private string PrepararRegistroCSV (Faq coment) {
            return $"Comentario = {coment}\n";
        }

        public List<Faq> ListarComentarios () {
            List<Faq> listarComent = new List<Faq> ();
            string[] linhas = File.ReadAllLines ("comentarios.csv");

            foreach (var item in linhas) {
                if (string.IsNullOrEmpty (item)) {
                    //Sair Do Foreach
                    continue;
                }
                string[] linha = item.Split (";");

                Faq coment = new Faq();
                    coment.Comentario = linha[0];
                listarComent.Add (coment);
            }
            return listarComent;
        }
    }
}