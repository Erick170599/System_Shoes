using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System_Shoes.DAL;
using System_Shoes.Entities;

namespace System_Shoes.BLL
{
    public class VentaOperations
    {
        #region Singleton
        private static volatile VentaOperations instance = null;
        private static readonly object padlock = new object();
        private SystemShoesContext context = new SystemShoesContext();

        private VentaOperations() { }

        public static VentaOperations Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new VentaOperations();
            return instance;
        }
        #endregion

        public Venta Add(Venta venta)
        {
            Folio folio = context.Folios.Where(f => f.descripcion == "Remisión").SingleOrDefault();
            folio.valor++;
            context.Update(folio);
            venta.folio = folio.valor;
            venta = context.Add(venta).Entity;
            context.SaveChanges();
            return venta;
        }

        public List<Venta> GetAll()
        {
            return context.Ventas.Where(v => v.status == "A").Include(v => v.ventasDetalle).ToList();
        }
    }
}
