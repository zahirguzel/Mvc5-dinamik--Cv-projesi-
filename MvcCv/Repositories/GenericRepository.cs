using MvcCv.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Web;

namespace MvcCv.Repositories
{
    public class GenericRepository<T> where T : class,new() // t class olmalı ve new lenmeli 
    {
        DbCvEntities db = new DbCvEntities(); 

        public List<T> List() 
        {
            return db.Set<T>().ToList();
        
        }

        public void TAdd(T p) 
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }
        public void TRemove(T p) 
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }
        public T TGet(int id) 
        {
            return db.Set<T>().Find(id);
        }
        public void TUpdate(T p) 
        {
            db.SaveChanges();
        }
        public T Find(Expression<Func<T,bool>> where) //"Bana bir şart (kural) ver, ben de veritabanına gidip o şarta uyan İLK kaydı bulup sana getireyim."
        {
            return db.Set<T>().FirstOrDefault(where);
        
        }
        public void TDelete(T p) 
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }

       
    }
}