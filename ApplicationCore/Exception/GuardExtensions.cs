using ApplicationCore.Entity.VulnModel;
using Ardalis.GuardClauses;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Exception
{
    public static class BasketGuards
    {
        public static void NullBasket(this IGuardClause guardClause, int vulnSeq, T_VULN vuln)
        {
            if (vuln == null)
                throw new BasketNotFoundException(vulnSeq);
        }
    }
}
