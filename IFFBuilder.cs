using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IARS_IFFBuilder;
using Microsoft.Office.Interop.Excel;

namespace IARS_IFFBuilder
{
    class IFFBuilder
    {
        private List<IFFBuilderType> myListTypes = new List<IFFBuilderType>();

        private Microsoft.Office.Interop.Excel.Application curExcelApp;
        private Workbook buildIFFFile;
        private Microsoft.Office.Interop.Excel.Worksheet curWorksheet;

        public IFFBuilder()
        {
            curExcelApp = new Microsoft.Office.Interop.Excel.Application();

            // curExcelApp.Visible = true;

            //Build Form Values and Text
            

            //Make Excel accessable for builing a file
            //TODO: move to IFFBuilder Class
            buildIFFFile = curExcelApp.Workbooks.Add(System.Reflection.Missing.Value);

            curWorksheet = (Worksheet)buildIFFFile.Worksheets[1];

            string sVar = "IFF File " + DateTime.Now.ToString().Replace("/", "-").Replace(":", ".");

            curWorksheet.Name = sVar;
            curExcelApp.Visible = false;
        }

        public void BuildFile(string sBuildType, string sBuildPath)
        {
            switch (sBuildType)
            {
                case "InvListBuild":

                    break;
                case "a":

                    break;
                default:
                    break;
            }
        }
        private void BuildInvList() { }

        public IFFBuilderType createType(string sType, string sValue)
        {
            IFFBuilderType curType = new IFFBuilderType(sType, sValue);
            myListTypes.Add(curType);
            return curType ;
        }
    }
}
