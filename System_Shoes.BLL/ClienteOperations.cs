﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System_Shoes.DAL;
using System_Shoes.Entities;

namespace System_Shoes.BLL
{
    public class ClienteOperations
    {
        #region Singleton
        private static volatile ClienteOperations instance = null;
        private static readonly object padlock = new object();
        private SystemShoesContext context = new SystemShoesContext();

        private ClienteOperations() { }

        public static ClienteOperations Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new ClienteOperations();
            return instance;
        }
        #endregion

        public int Add(Cliente cliente)
        {
            context.Add(cliente);
            return context.SaveChanges();
        }

        public int Delete(int idCliente)
        {
            Cliente cliente = context.Clientes.Where(c => c.idCliente == idCliente).FirstOrDefault();
            cliente.activo = false;
            return context.SaveChanges();
        }

        public List<Cliente> GetAll()
        {
            return context.Clientes.Where(c => c.activo == true).ToList();
        }

        public Cliente GetById(int idCliente)
        {
            return context.Find<Cliente>(idCliente);
        }

        public int Update(Cliente cliente)
        {
            context.Update(cliente);
            return context.SaveChanges();
        }
    }
}