using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tk1
{
    public partial class FormMain : Form
    {
        private TableAdjacentClasses tac;
        CodeAlgorithmFactory codeAlgorithmFactory;
        public FormMain()
        {
            InitializeComponent();
            codeAlgorithmFactory = CodeAlgorithmFactory.Instance;
        }

        private void bt_getCode_Click(object sender, EventArgs e)
        {
            Code code = codeAlgorithmFactory.GetCodeAlgorithm(cb_chooseCode.Text);
            rtb_codeword.Text = code.GetCodeWord(rtb_message.Text);
        }

        private void bt_decode_Click(object sender, EventArgs e)
        {
            Code code = codeAlgorithmFactory.GetCodeAlgorithm(cb_chooseCode.Text);
            label3.Text = code.Decode(rtb_codeword.Text);
        }

        private void bt_makeGrid_Click(object sender, EventArgs e)
        {
            dgv_adjacentClass.Rows.Clear();
            int rowsNumber = Int32.Parse(tb_row.Text);
            dgv_adjacentClass.ColumnCount = Int32.Parse(tb_column.Text);
            for(int i = 0; i < dgv_adjacentClass.ColumnCount; ++i)
                dgv_adjacentClass.Columns[i].Width = 60;
            for (int i = 0; i < rowsNumber; ++i )
                dgv_adjacentClass.Rows.Add();
        }

        private void bt_fill_Click(object sender, EventArgs e)
        {
            List<string> errorVector = new List<string>();
            List<string> codeWords = new List<string>();
            for (int i = 0; i < dgv_adjacentClass.RowCount; ++i)
                errorVector.Add(dgv_adjacentClass[0, i].Value.ToString());
            for (int i = 0; i < dgv_adjacentClass.ColumnCount; ++i)
                codeWords.Add(dgv_adjacentClass[i,0].Value.ToString());
            tac = new TableAdjacentClasses(codeWords, errorVector);
            for (int j = 1; j < dgv_adjacentClass.ColumnCount; ++j)
                for (int i = 1; i < dgv_adjacentClass.RowCount; ++i)
                    dgv_adjacentClass[j,i].Value = tac.Table[i, j];
        }

        private void bt_adjClassesDecode_Click(object sender, EventArgs e)
        {
            if(tac != null)
                lb_adjClassesCodeword.Text = "Codeword : " + tac.Decode(tb_incomingMessage.Text);
        }

        private void bt_do_Click(object sender, EventArgs e)
        {
            /*string codeword = tb_codeWordForLast.Text;
            codeword += evenParity.GetEven(codeword);
            rtb_allError.Text = "";
            BinaryArythmetic binaryArythmetic = new BinaryArythmetic();
            int maxNumber = (int)Math.Pow(2, codeword.Length);
            for (int i = 0; i < maxNumber; ++i)
            {
                string number = Convert.ToString(i,2);
                rtb_allError.Text += binaryArythmetic.AddBinaryNumber(codeword, number) + '\n';
            }*/
        }

        private void bt_decodeError_Click(object sender, EventArgs e)
        {
            /*string[] codewords = rtb_allError.Text.Split('\n');
            rtb_checkError.Text = "";
            foreach (string str in codewords)
                rtb_checkError.Text += evenParity.Decode(str) + '\n';*/
        }

        
    }
}
