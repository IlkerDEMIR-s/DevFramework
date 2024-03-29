﻿using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess.NHihabernate
{
    public abstract class NHibernateHelper : IDisposable
    {
        private static ISessionFactory _sessionFactory; // Factory design pattern

        public virtual ISessionFactory SessionFactory
        {
            get
            {
                return _sessionFactory ??(_sessionFactory = InitializeFactory()); 
            }
        }

        protected abstract ISessionFactory InitializeFactory(); // SQL or oracle 
        //it will vary depending on the environment implementing it

        public virtual ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this); // Garbage collector
        }
    }
}
