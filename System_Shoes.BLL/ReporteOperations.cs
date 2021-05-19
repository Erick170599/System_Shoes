using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System_Shoes.DAL;
using System_Shoes.Entities;

namespace System_Shoes.BLL
{
    public class ReporteOperations
    {
        #region Singleton
        private static volatile ReporteOperations instance = null;
        private static readonly object padlock = new object();
        private SystemShoesContext context = new SystemShoesContext();

        private ReporteOperations() { }

        public static ReporteOperations Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new ReporteOperations();
            return instance;
        }
        #endregion

        public int Add(Reporte reporte)
        {
            context.Add(reporte);
            return context.SaveChanges();
        }

        public int Delete(int idReporte)
        {
            Reporte reporte = context.Reportes.Where(c => c.idReporte == idReporte).FirstOrDefault();
            reporte.activo = false;
            return context.SaveChanges();
        }

        public List<Reporte> GetAll()
        {
            return context.Reportes.Where(c => c.activo == true).ToList();
        }

        public Reporte GetById(int idReporte)
        {
            return context.Find<Reporte>(idReporte);
        }

        public int Update(Reporte reporte)
        {
            context.Update(reporte);
            return context.SaveChanges();
        }

        public Reporte GetByName(string nombre)
        {
            return context.Reportes.Where(p => p.nombre == nombre).SingleOrDefault();
        }
    }
}