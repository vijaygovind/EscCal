using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EscCalc.Domain.Entities.Models;
using EscCalc.Domain.Entities;

namespace EscCalc.Domain.Abstract
{
    public interface ICaseVersionRepository<TEntity> : IRepository<TxnCaseVersion> where TEntity : class
    {
        IEnumerable<TxnCaseVersion> GetCaseVersion(int pageIndex, int pageSize);

        IEnumerable<TxnCaseVersion> GetMyCases(int UserId, int pageIndex, int pageSize);
        IEnumerable<TxnCaseVersion> AddCaseVersions(TEntity entity);

    }
}
