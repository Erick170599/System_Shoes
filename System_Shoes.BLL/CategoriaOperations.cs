using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System_Shoes.DAL;
using System_Shoes.Entities;

namespace System_Shoes.BLL
{
    public class CategoriaOperations
    {
        #region Singleton
        private static volatile CategoriaOperations instance = null;
        private static readonly object padlock = new object();
        private SystemShoesContext context = new SystemShoesContext();

        private CategoriaOperations() { }

        public static CategoriaOperations Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new CategoriaOperations();
            return instance;
        }
        #endregion

        public int Add(Categoria categoria)
        {
            context.Add(categoria);
            return context.SaveChanges();
        }

        public int Delete(int idCategoria)
        {
            Categoria categoria = context.Categorias.Where(c => c.idCategoria == idCategoria).FirstOrDefault();
            categoria.activo = false;
            return context.SaveChanges();
        }

        public List<Categoria> GetAll()
        {
            return context.Categorias.Where(c => c.activo == true).ToList();
        }

        public Categoria GetById(int idCategoria)
        {
            return context.Find<Categoria>(idCategoria);
        }

        public int Update(Categoria categoria)
        {
            context.Update(categoria);
            return context.SaveChanges();
        }
    }
}
