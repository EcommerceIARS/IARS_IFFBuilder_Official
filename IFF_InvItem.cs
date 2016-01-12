using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IARS_IFFBuilder
{
    class IFF_InvItem : IFFBuilderType
    {

        private string Name;
        private string Qty;
        private string InvItemType;
        private string Description;
        private string Income_Account;
        private string Asset_Account;
        private string COGS_Account;
        private string Price;
        private string cost;
        private bool Taxable;
        private string Prefered_Vender;

        public IFF_InvItem(string sName, string Type): base(sName, Type)
        {

        }
        public IFF_InvItem(string sName):base(sName,"")
        {

        }

        
    }
}
