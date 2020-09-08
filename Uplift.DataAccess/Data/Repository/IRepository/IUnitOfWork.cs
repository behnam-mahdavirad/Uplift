using System;
using System.Collections.Generic;
using System.Text;

namespace Uplift.DataAccess.Repository.IRepository
{
    interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        void Save();
    }
}
