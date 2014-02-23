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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_adjacentClass)).BeginInit();
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
    }
}

