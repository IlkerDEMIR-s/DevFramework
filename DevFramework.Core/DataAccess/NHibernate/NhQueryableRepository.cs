﻿using DevFramework.Core.DataAccess.NHihabernate;
using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.DataAccess.NHibernate
{
    public class NhQueryableRepository<T>: IQueryableRepository<T> where T : class, IEntity, new()
    {
        private NHibernateHelper _nHibernateHelper;
        private IQueryable<T> _entities;
        public NhQueryableRepository(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }
        public IQueryable<T> Table => this._entities;

        public IQueryable<T> Entities
        {
            get { return _entities ?? (_entities = _nHibernateHelper.OpenSession().Query<T>()); }
        }
    }
}
