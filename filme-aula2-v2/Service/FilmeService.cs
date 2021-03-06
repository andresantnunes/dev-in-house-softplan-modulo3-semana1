using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using filme.Entity;
using filme.Helper;

namespace filme.Service
{
    public class FilmeService : IFilmeService
    {
        private FilmeContext _context;

        public FilmeService(FilmeContext context)
        {
            _context = context;
        }

        public List<Filme> listarFilmes(){
            return _context.Filmes.ToList();
        }

        public Filme encontrarFilme(int id){
            return _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        }

        public void salvarFilme(Filme filme)
        {
            // id += 1;
            // filme.Id = id;
            filme.DataLancamento = DateTime.Now;
            _context.Filmes.Add(filme);
        }
    }
}