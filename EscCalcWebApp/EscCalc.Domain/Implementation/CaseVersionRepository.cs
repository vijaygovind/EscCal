using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EscCalc.Domain.Abstract;
using EscCalc.Domain.Entities.Models;
using EscCalc.Domain.Implementation;
using EscCalc.Domain.Entities;

namespace EscCalc.Domain.Implementation
{
    public class CaseVersionRepository : Repository<TxnCaseVersion>
    {
        public CaseVersionRepository(ESCCALCEntities context) : base(context)
        {
        }
        
        public IEnumerable<TxnCaseVersion> GetCaseVersion(int pageIndex, int pageSize)
        {
            // Get Listing of all cases
            return EscCalcContext.TxnCaseVersions.OrderByDescending(c => c.CaseId).ToList();
        }

        public TxnCaseVersion GetCaseVersionById(int CaseVersionId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TxnCaseVersion> GetMyCases(int UserId, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

                     
        public new IEnumerable<TxnCaseVersion> Find(Expression<Func<TxnCaseVersion, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public new void Add(TxnCaseVersion entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TxnCaseVersion> AddCaseVersions(TxnCaseVersion entity)
        {
            throw new NotImplementedException();
        }

        public ESCCALCEntities EscCalcContext
        {
            get { return Context as ESCCALCEntities; }
        }

    }
}
