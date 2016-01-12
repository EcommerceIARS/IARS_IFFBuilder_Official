using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace IARS_IFFBuilder
{
    public partial class IFFBuilderAPP : Form
    {
        
        private OpenFileDialog File_Window;
        private IFFBuilder myIFFBuilder;
        private IFFBuilderType myIffType;

        public IFFBuilderAPP()
        {

            InitializeComponent();

            myIFFBuilder = new IFFBuilder();

            buIFFInvList.Name = "Build IFF Inventory List";
            cbIFFBuilderType.Items.Add(myIFFBuilder.createType("Inventory Builder", "InvListBuild"));
            // curExcelApp.Workbooks.Add(buildIFFFile);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            File_open_Window.ShowDialog();

        }

        private void File_Window_FileOK(object sender, EventArgs e)
        {
            
        }

       

        private void File_open_Window_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = File_open_Window.InitialDirectory.ToString();
        }

        private void buIFFInvList_Click(object sender, EventArgs e)
        {
            myIffType = (IFFBuilderType)cbIFFBuilderType.SelectedItem;
            myIFFBuilder = new IFFBuilder();
            myIFFBuilder.BuildFile(myIffType.sValue, textBox1.Text);
            
        }
    }
}
