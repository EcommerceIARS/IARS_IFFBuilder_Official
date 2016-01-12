using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IARS_IFFBuilder
{
    class  IFFBuilderType
    {
        public string sName { get; set; }
        public string sValue { get; set;}


        //some test change is applied here
        public string Test_Change;


        public IFFBuilderType(string type, string value)
        {
            sName = type;
            sValue = value;
        }

        public override string ToString()
        {
            return sName;
        }   
        
    }
}
