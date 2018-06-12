using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentPlan
{
    public enum InstalmentMethod : short
    {
        VariablePrincipal =  3,
        AdditionalPayment = 5,
        EqualPrincipal = 4, // eşit anapara
        VariableAmount = 2,
        IncreasingInstalment = 6,
        DecreasingInstalment = 7,
        EqualAmount = 1, 


    }
}
