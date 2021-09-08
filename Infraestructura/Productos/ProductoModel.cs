﻿using Domain.Entitys;
using Domain.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Productos
{
    public class ProductoModel
    {
        private Producto[] productos;

        #region CRUD
        public void Add(Producto p)
        {
            Add(p, ref productos);
        }

        public int Update(Producto p)
        {
            if(p == null)
            {
                throw new ArgumentException("El producto no puede ser null");
            }

            int index = GetIndexById(p.Id);
            if(index < 0)
            {
                throw new Exception($"El producto con id {p.Id} no se encuentra");
            }


            productos[index] = p;
            return index;
        }

        public bool Delete(Producto p)
        {
            if (p == null)
            {
                throw new ArgumentException("El producto no puede ser null");
            }

            int index = GetIndexById(p.Id);
            if (index < 0)
            {
                throw new Exception($"El producto con id {p.Id} no se encuentra");
            }

            if(index != productos.Length - 1)
            {
                productos[index] = productos[productos.Length - 1];
            }

            Producto[] tmp = new Producto[productos.Length - 1];
            Array.Copy(productos, tmp, tmp.Length);
            productos = tmp;

            return productos.Length == tmp.Length;
        }

        public Producto[] GetAll()
        {
            return productos;
        }


        #endregion

        #region Private Method

        private void Add(Producto p, ref Producto[] pds)
        {
            if (pds == null)
            {
                pds = new Producto[1];
                pds[pds.Length - 1] = p;
                return;
            }

            Producto[] tmp = new Producto[pds.Length + 1];
            Array.Copy(pds, tmp, pds.Length);
            pds = tmp;
        }

        private int GetIndexById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El id no puede ser igual o menor a 0");
            }

            int index = int.MinValue, i = 0;

            foreach(Producto p in productos)
            {
                if(p.Id == id)
                {
                    index = i;
                    break;
                }
                i++;
            }

            return index;
        }

        public Producto[] GetProductoByUnidadMedida(UnidadMedida um)
        {
            Producto[] tmp = null;

            if(productos == null)
            {
                return tmp;
            }

             foreach(Producto p in productos)
            {
                if(p.UnidadMedida == um)
                {
                    Add(p, ref tmp);
                }
            }

            return tmp;
        }

        public Producto[] GetProductosByVencimiento(DateTime dt)
        {
            Producto[] tmp = null;

            if (productos == null)
            {
                return tmp;
            }

            foreach (Producto p in productos)
            {
                if (p.FechaVencimiento.CompareTo(dt) <= 0)
                {
                    Add(p, ref tmp);
                }
            }

            return tmp;
        }

        public Producto[] GetProductosByRangoPrecio(decimal start, decimal end)
        {
            Producto[] tmp = null;

            if (productos == null)
            {
                return tmp;
            }

            foreach (Producto p in productos)
            {
                if (p.Precio >= start && p.Precio <= end)
                {
                    Add(p, ref tmp);
                }
            }

            return tmp;
        }

        public string ProductoAsJson()
        {
            return JsonConvert.SerializeObject(productos);
        }

        public Producto[] GetProductosOrderByPrice()
        {
            Array.Sort(productos, new Producto.ProductoPriceComparer() );
            return productos;
        }

        #endregion

        #region Queries
        public Producto GetProductoById(int id)
        {
            if(id <= 0)
            {
                throw new ArgumentException($"El Id: {id} no es valido");
            }

            int index = GetIndexById(id);
       

            return index <= 0 ? null : productos[index];
        }
        #endregion
    }
}
