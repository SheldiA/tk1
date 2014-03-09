namespace tk1
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb_message = new System.Windows.Forms.RichTextBox();
            this.rtb_codeword = new System.Windows.Forms.RichTextBox();
            this.bt_getCode = new System.Windows.Forms.Button();
            this.bt_decode = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lb_n = new System.Windows.Forms.Label();
            this.tb_n = new System.Windows.Forms.TextBox();
            this.cb_chooseCode = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lb_adjClassesCodeword = new System.Windows.Forms.Label();
            this.bt_adjClassesDecode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_incomingMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_fill = new System.Windows.Forms.Button();
            this.tb_adjacent_k = new System.Windows.Forms.TextBox();
            this.tb_adjacent_n = new System.Windows.Forms.TextBox();
            this.dgv_adjacentClass = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtb_checkError = new System.Windows.Forms.RichTextBox();
            this.bt_decodeError = new System.Windows.Forms.Button();
            this.rtb_allError = new System.Windows.Forms.RichTextBox();
            this.bt_do = new System.Windows.Forms.Button();
            this.rtb_decode = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adjacentClass)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_message
            // 
            this.rtb_message.Location = new System.Drawing.Point(2, 116);
            this.rtb_message.Name = "rtb_message";
            this.rtb_message.Size = new System.Drawing.Size(121, 35);
            this.rtb_message.TabIndex = 0;
            this.rtb_message.Text = "";
            // 
            // rtb_codeword
            // 
            this.rtb_codeword.Location = new System.Drawing.Point(91, 40);
            this.rtb_codeword.Name = "rtb_codeword";
            this.rtb_codeword.Size = new System.Drawing.Size(141, 52);
            this.rtb_codeword.TabIndex = 1;
            this.rtb_codeword.Text = "";
            // 
            // bt_getCode
            // 
            this.bt_getCode.Location = new System.Drawing.Point(6, 44);
            this.bt_getCode.Name = "bt_getCode";
            this.bt_getCode.Size = new System.Drawing.Size(79, 40);
            this.bt_getCode.TabIndex = 2;
            this.bt_getCode.Text = "Get code word";
            this.bt_getCode.UseVisualStyleBackColor = true;
            this.bt_getCode.Click += new System.EventHandler(this.bt_getCode_Click);
            // 
            // bt_decode
            // 
            this.bt_decode.Location = new System.Drawing.Point(238, 44);
            this.bt_decode.Name = "bt_decode";
            this.bt_decode.Size = new System.Drawing.Size(56, 43);
            this.bt_decode.TabIndex = 3;
            this.bt_decode.Text = "Decode";
            this.bt_decode.UseVisualStyleBackColor = true;
            this.bt_decode.Click += new System.EventHandler(this.bt_decode_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(137, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 194);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtb_decode);
            this.tabPage1.Controls.Add(this.bt_getCode);
            this.tabPage1.Controls.Add(this.bt_decode);
            this.tabPage1.Controls.Add(this.rtb_codeword);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 168);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "EvenParity";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lb_n
            // 
            this.lb_n.AutoSize = true;
            this.lb_n.Location = new System.Drawing.Point(-1, 31);
            this.lb_n.Name = "lb_n";
            this.lb_n.Size = new System.Drawing.Size(43, 13);
            this.lb_n.TabIndex = 7;
            this.lb_n.Text = "Param: ";
            // 
            // tb_n
            // 
            this.tb_n.Location = new System.Drawing.Point(48, 28);
            this.tb_n.Name = "tb_n";
            this.tb_n.Size = new System.Drawing.Size(32, 20);
            this.tb_n.TabIndex = 6;
            // 
            // cb_chooseCode
            // 
            this.cb_chooseCode.FormattingEnabled = true;
            this.cb_chooseCode.Items.AddRange(new object[] {
            "Repetition code",
            "Even parity code",
            "Rectangular code",
            "Triangular code"});
            this.cb_chooseCode.Location = new System.Drawing.Point(2, 76);
            this.cb_chooseCode.Name = "cb_chooseCode";
            this.cb_chooseCode.Size = new System.Drawing.Size(121, 21);
            this.cb_chooseCode.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lb_adjClassesCodeword);
            this.tabPage2.Controls.Add(this.bt_adjClassesDecode);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tb_incomingMessage);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.bt_fill);
            this.tabPage2.Controls.Add(this.tb_adjacent_k);
            this.tabPage2.Controls.Add(this.tb_adjacent_n);
            this.tabPage2.Controls.Add(this.dgv_adjacentClass);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 168);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AdjacentClasses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lb_adjClassesCodeword
            // 
            this.lb_adjClassesCodeword.AutoSize = true;
            this.lb_adjClassesCodeword.Location = new System.Drawing.Point(362, 84);
            this.lb_adjClassesCodeword.Name = "lb_adjClassesCodeword";
            this.lb_adjClassesCodeword.Size = new System.Drawing.Size(0, 13);
            this.lb_adjClassesCodeword.TabIndex = 9;
            // 
            // bt_adjClassesDecode
            // 
            this.bt_adjClassesDecode.Location = new System.Drawing.Point(365, 45);
            this.bt_adjClassesDecode.Name = "bt_adjClassesDecode";
            this.bt_adjClassesDecode.Size = new System.Drawing.Size(70, 23);
            this.bt_adjClassesDecode.TabIndex = 8;
            this.bt_adjClassesDecode.Text = "Decode";
            this.bt_adjClassesDecode.UseVisualStyleBackColor = true;
            this.bt_adjClassesDecode.Click += new System.EventHandler(this.bt_adjClassesDecode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter incoming message";
            // 
            // tb_incomingMessage
            // 
            this.tb_incomingMessage.Location = new System.Drawing.Point(365, 21);
            this.tb_incomingMessage.Name = "tb_incomingMessage";
            this.tb_incomingMessage.Size = new System.Drawing.Size(83, 20);
            this.tb_incomingMessage.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "n: ";
            // 
            // bt_fill
            // 
            this.bt_fill.Location = new System.Drawing.Point(19, 79);
            this.bt_fill.Name = "bt_fill";
            this.bt_fill.Size = new System.Drawing.Size(43, 22);
            this.bt_fill.TabIndex = 4;
            this.bt_fill.Text = "fill";
            this.bt_fill.UseVisualStyleBackColor = true;
            this.bt_fill.Click += new System.EventHandler(this.bt_fill_Click);
            // 
            // tb_adjacent_k
            // 
            this.tb_adjacent_k.Location = new System.Drawing.Point(43, 47);
            this.tb_adjacent_k.Name = "tb_adjacent_k";
            this.tb_adjacent_k.Size = new System.Drawing.Size(26, 20);
            this.tb_adjacent_k.TabIndex = 2;
            // 
            // tb_adjacent_n
            // 
            this.tb_adjacent_n.Location = new System.Drawing.Point(43, 6);
            this.tb_adjacent_n.Name = "tb_adjacent_n";
            this.tb_adjacent_n.Size = new System.Drawing.Size(26, 20);
            this.tb_adjacent_n.TabIndex = 1;
            // 
            // dgv_adjacentClass
            // 
            this.dgv_adjacentClass.AllowUserToAddRows = false;
            this.dgv_adjacentClass.AllowUserToDeleteRows = false;
            this.dgv_adjacentClass.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_adjacentClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_adjacentClass.ColumnHeadersVisible = false;
            this.dgv_adjacentClass.GridColor = System.Drawing.Color.Black;
            this.dgv_adjacentClass.Location = new System.Drawing.Point(91, 5);
            this.dgv_adjacentClass.Name = "dgv_adjacentClass";
            this.dgv_adjacentClass.RowHeadersVisible = false;
            this.dgv_adjacentClass.RowHeadersWidth = 30;
            this.dgv_adjacentClass.Size = new System.Drawing.Size(247, 162);
            this.dgv_adjacentClass.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtb_checkError);
            this.tabPage3.Controls.Add(this.bt_decodeError);
            this.tabPage3.Controls.Add(this.rtb_allError);
            this.tabPage3.Controls.Add(this.bt_do);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(472, 168);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "AllErrors";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtb_checkError
            // 
            this.rtb_checkError.Location = new System.Drawing.Point(305, 5);
            this.rtb_checkError.Name = "rtb_checkError";
            this.rtb_checkError.Size = new System.Drawing.Size(154, 150);
            this.rtb_checkError.TabIndex = 4;
            this.rtb_checkError.Text = "";
            // 
            // bt_decodeError
            // 
            this.bt_decodeError.Location = new System.Drawing.Point(238, 40);
            this.bt_decodeError.Name = "bt_decodeError";
            this.bt_decodeError.Size = new System.Drawing.Size(61, 49);
            this.bt_decodeError.TabIndex = 3;
            this.bt_decodeError.Text = "Decode";
            this.bt_decodeError.UseVisualStyleBackColor = true;
            this.bt_decodeError.Click += new System.EventHandler(this.bt_decodeError_Click);
            // 
            // rtb_allError
            // 
            this.rtb_allError.Location = new System.Drawing.Point(78, 5);
            this.rtb_allError.Name = "rtb_allError";
            this.rtb_allError.Size = new System.Drawing.Size(154, 150);
            this.rtb_allError.TabIndex = 2;
            this.rtb_allError.Text = "";
            // 
            // bt_do
            // 
            this.bt_do.Location = new System.Drawing.Point(3, 42);
            this.bt_do.Name = "bt_do";
            this.bt_do.Size = new System.Drawing.Size(69, 47);
            this.bt_do.TabIndex = 0;
            this.bt_do.Text = "Generate errors";
            this.bt_do.UseVisualStyleBackColor = true;
            this.bt_do.Click += new System.EventHandler(this.bt_do_Click);
            // 
            // rtb_decode
            // 
            this.rtb_decode.Location = new System.Drawing.Point(300, 40);
            this.rtb_decode.Name = "rtb_decode";
            this.rtb_decode.Size = new System.Drawing.Size(131, 52);
            this.rtb_decode.TabIndex = 8;
            this.rtb_decode.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "k: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Choose code: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Enter text: ";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 220);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.rtb_message);
            this.Controls.Add(this.cb_chooseCode);
            this.Controls.Add(this.tb_n);
            this.Controls.Add(this.lb_n);
            this.Name = "FormMain";
            this.Text = "TK2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adjacentClass)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_message;
        private System.Windows.Forms.RichTextBox rtb_codeword;
        private System.Windows.Forms.Button bt_getCode;
        private System.Windows.Forms.Button bt_decode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_fill;
        private System.Windows.Forms.TextBox tb_adjacent_k;
        private System.Windows.Forms.TextBox tb_adjacent_n;
        private System.Windows.Forms.DataGridView dgv_adjacentClass;
        private System.Windows.Forms.Label lb_adjClassesCodeword;
        private System.Windows.Forms.Button bt_adjClassesDecode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_incomingMessage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button bt_do;
        private System.Windows.Forms.RichTextBox rtb_allError;
        private System.Windows.Forms.RichTextBox rtb_checkError;
        private System.Windows.Forms.Button bt_decodeError;
        private System.Windows.Forms.ComboBox cb_chooseCode;
        private System.Windows.Forms.Label lb_n;
        private System.Windows.Forms.TextBox tb_n;
        private System.Windows.Forms.RichTextBox rtb_decode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

