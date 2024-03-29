﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System_Shoes.DAL;
using System_Shoes.Entities;

namespace System_Shoes.BLL
{
    public class ColorOperations
    {
        #region Singleton
        private static volatile ColorOperations instance = null;
        private static readonly object padlock = new object();
        private SystemShoesContext context = new SystemShoesContext();

        private ColorOperations() { }

        public static ColorOperations Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new ColorOperations();
            return instance;
        }
        #endregion

        public int Add(Color color)
        {
            context.Add(color);
            return context.SaveChanges();
        }

        public int Delete(int idColor)
        {
            Color color = context.Colores.Where(c => c.idColor == idColor).FirstOrDefault();
            color.activo = false;
            return context.SaveChanges();
        }

        public List<Color> GetAll()
        {
            return context.Colores.Where(c => c.activo == true).ToList();
        }

        public Color GetById(int idColor)
        {
            return context.Find<Color>(idColor);
        }

        public int Update(Color color)
        {
            context.Update(color);
            return context.SaveChanges();
        }
    }
}