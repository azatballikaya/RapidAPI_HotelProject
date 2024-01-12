﻿using HotelProject.DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;
        DbSet<T> _object;

        public GenericRepository(Context context)
        {
            _context = context;
            _object=_context.Set<T>();
        }

        public void Delete(T p)
        {
            _context.Remove(p);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
           return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
           return _context.Set<T>().ToList();
        }

        public void Insert(T p)
        {
            _context.Add(p);
            _context.SaveChanges();
        }

        public void Update(T p)
        {
            _context.Set<T>().Update(p);
            _context.SaveChanges();
        }
    }
}