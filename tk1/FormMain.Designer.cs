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
            this.lb_decodeResult = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_adjacentClass = new System.Windows.Forms.DataGridView();
            this.tb_row = new System.Windows.Forms.TextBox();
            this.tb_column = new System.Windows.Forms.TextBox();
            this.bt_makeGrid = new System.Windows.Forms.Button();
            this.bt_fill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_incomingMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_adjClassesDecode = new System.Windows.Forms.Button();
            this.lb_adjClassesCodeword = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bt_do = new System.Windows.Forms.Button();
            this.tb_codeWordForLast = new System.Windows.Forms.TextBox();
            this.rtb_allError = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adjacentClass)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_message
            // 
            this.rtb_message.Location = new System.Drawing.Point(6, 31);
            this.rtb_message.Name = "rtb_message";
            this.rtb_message.Size = new System.Drawing.Size(154, 52);
            this.rtb_message.TabIndex = 0;
            this.rtb_message.Text = "";
            // 
            // rtb_codeword
            // 
            this.rtb_codeword.Location = new System.Drawing.Point(242, 31);
            this.rtb_codeword.Name = "rtb_codeword";
            this.rtb_codeword.Size = new System.Drawing.Size(141, 52);
            this.rtb_codeword.TabIndex = 1;
            this.rtb_codeword.Text = "";
            // 
            // bt_getCode
            // 
            this.bt_getCode.Location = new System.Drawing.Point(166, 47);
            this.bt_getCode.Name = "bt_getCode";
            this.bt_getCode.Size = new System.Drawing.Size(70, 36);
            this.bt_getCode.TabIndex = 2;
            this.bt_getCode.Text = "Get code word";
            this.bt_getCode.UseVisualStyleBackColor = true;
            this.bt_getCode.Click += new System.EventHandler(this.bt_getCode_Click);
            // 
            // bt_decode
            // 
            this.bt_decode.Location = new System.Drawing.Point(404, 47);
            this.bt_decode.Name = "bt_decode";
            this.bt_decode.Size = new System.Drawing.Size(88, 23);
            this.bt_decode.TabIndex = 3;
            this.bt_decode.Text = "Decode";
            this.bt_decode.UseVisualStyleBackColor = true;
            this.bt_decode.Click += new System.EventHandler(this.bt_decode_Click);
            // 
            // lb_decodeResult
            // 
            this.lb_decodeResult.AutoSize = true;
            this.lb_decodeResult.Location = new System.Drawing.Point(437, 39);
            this.lb_decodeResult.Name = "lb_decodeResult";
            this.lb_decodeResult.Size = new System.Drawing.Size(0, 13);
            this.lb_decodeResult.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 194);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtb_message);
            this.tabPage1.Controls.Add(this.bt_getCode);
            this.tabPage1.Controls.Add(this.bt_decode);
            this.tabPage1.Controls.Add(this.rtb_codeword);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(523, 168);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lb_adjClassesCodeword);
            this.tabPage2.Controls.Add(this.bt_adjClassesDecode);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tb_incomingMessage);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.bt_fill);
            this.tabPage2.Controls.Add(this.bt_makeGrid);
            this.tabPage2.Controls.Add(this.tb_column);
            this.tabPage2.Controls.Add(this.tb_row);
            this.tabPage2.Controls.Add(this.dgv_adjacentClass);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(523, 168);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.dgv_adjacentClass.Size = new System.Drawing.Size(218, 162);
            this.dgv_adjacentClass.TabIndex = 0;
            // 
            // tb_row
            // 
            this.tb_row.Location = new System.Drawing.Point(10, 13);
            this.tb_row.Name = "tb_row";
            this.tb_row.Size = new System.Drawing.Size(26, 20);
            this.tb_row.TabIndex = 1;
            // 
            // tb_column
            // 
            this.tb_column.Location = new System.Drawing.Point(59, 13);
            this.tb_column.Name = "tb_column";
            this.tb_column.Size = new System.Drawing.Size(26, 20);
            this.tb_column.TabIndex = 2;
            // 
            // bt_makeGrid
            // 
            this.bt_makeGrid.Location = new System.Drawing.Point(27, 40);
            this.bt_makeGrid.Name = "bt_makeGrid";
            this.bt_makeGrid.Size = new System.Drawing.Size(43, 22);
            this.bt_makeGrid.TabIndex = 3;
            this.bt_makeGrid.Text = "make";
            this.bt_makeGrid.UseVisualStyleBackColor = true;
            this.bt_makeGrid.Click += new System.EventHandler(this.bt_makeGrid_Click);
            // 
            // bt_fill
            // 
            this.bt_fill.Location = new System.Drawing.Point(27, 79);
            this.bt_fill.Name = "bt_fill";
            this.bt_fill.Size = new System.Drawing.Size(43, 22);
            this.bt_fill.TabIndex = 4;
            this.bt_fill.Text = "fill";
            this.bt_fill.UseVisualStyleBackColor = true;
            this.bt_fill.Click += new System.EventHandler(this.bt_fill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "x";
            // 
            // tb_incomingMessage
            // 
            this.tb_incomingMessage.Location = new System.Drawing.Point(327, 20);
            this.tb_incomingMessage.Name = "tb_incomingMessage";
            this.tb_incomingMessage.Size = new System.Drawing.Size(83, 20);
            this.tb_incomingMessage.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter incoming message";
            // 
            // bt_adjClassesDecode
            // 
            this.bt_adjClassesDecode.Location = new System.Drawing.Point(354, 46);
            this.bt_adjClassesDecode.Name = "bt_adjClassesDecode";
            this.bt_adjClassesDecode.Size = new System.Drawing.Size(70, 23);
            this.bt_adjClassesDecode.TabIndex = 8;
            this.bt_adjClassesDecode.Text = "Decode";
            this.bt_adjClassesDecode.UseVisualStyleBackColor = true;
            this.bt_adjClassesDecode.Click += new System.EventHandler(this.bt_adjClassesDecode_Click);
            // 
            // lb_adjClassesCodeword
            // 
            this.lb_adjClassesCodeword.AutoSize = true;
            this.lb_adjClassesCodeword.Location = new System.Drawing.Point(324, 79);
            this.lb_adjClassesCodeword.Name = "lb_adjClassesCodeword";
            this.lb_adjClassesCodeword.Size = new System.Drawing.Size(0, 13);
            this.lb_adjClassesCodeword.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtb_allError);
            this.tabPage3.Controls.Add(this.tb_codeWordForLast);
            this.tabPage3.Controls.Add(this.bt_do);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(523, 168);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bt_do
            // 
            this.bt_do.Location = new System.Drawing.Point(223, 82);
            this.bt_do.Name = "bt_do";
            this.bt_do.Size = new System.Drawing.Size(85, 23);
            this.bt_do.TabIndex = 0;
            this.bt_do.Text = "button1";
            this.bt_do.UseVisualStyleBackColor = true;
            this.bt_do.Click += new System.EventHandler(this.bt_do_Click);
            // 
            // tb_codeWordForLast
            // 
            this.tb_codeWordForLast.Location = new System.Drawing.Point(223, 43);
            this.tb_codeWordForLast.Name = "tb_codeWordForLast";
            this.tb_codeWordForLast.Size = new System.Drawing.Size(99, 20);
            this.tb_codeWordForLast.TabIndex = 1;
            // 
            // rtb_allError
            // 
            this.rtb_allError.Location = new System.Drawing.Point(349, 5);
            this.rtb_allError.Name = "rtb_allError";
            this.rtb_allError.Size = new System.Drawing.Size(154, 150);
            this.rtb_allError.TabIndex = 2;
            this.rtb_allError.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 220);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lb_decodeResult);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adjacentClass)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_message;
        private System.Windows.Forms.RichTextBox rtb_codeword;
        private System.Windows.Forms.Button bt_getCode;
        private System.Windows.Forms.Button bt_decode;
        private System.Windows.Forms.Label lb_decodeResult;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_fill;
        private System.Windows.Forms.Button bt_makeGrid;
        private System.Windows.Forms.TextBox tb_column;
        private System.Windows.Forms.TextBox tb_row;
        private System.Windows.Forms.DataGridView dgv_adjacentClass;
        private System.Windows.Forms.Label lb_adjClassesCodeword;
        private System.Windows.Forms.Button bt_adjClassesDecode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_incomingMessage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tb_codeWordForLast;
        private System.Windows.Forms.Button bt_do;
        private System.Windows.Forms.RichTextBox rtb_allError;
    }
}

