namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_Nev = new System.Windows.Forms.TextBox();
            this.rbFF = new System.Windows.Forms.RadioButton();
            this.dtpSzul = new System.Windows.Forms.DateTimePicker();
            this.NN = new System.Windows.Forms.RadioButton();
            this.button_newPerson = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(17, 321);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(31, 15);
            label1.TabIndex = 5;
            label1.Text = "Név:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(17, 347);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Nem:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(17, 378);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "Született:";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 25;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(776, 268);
            this.dgv.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Név";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nem";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Szül";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // tb_Nev
            // 
            this.tb_Nev.Location = new System.Drawing.Point(80, 318);
            this.tb_Nev.Name = "tb_Nev";
            this.tb_Nev.Size = new System.Drawing.Size(200, 23);
            this.tb_Nev.TabIndex = 1;
            // 
            // rbFF
            // 
            this.rbFF.AutoSize = true;
            this.rbFF.Checked = true;
            this.rbFF.Location = new System.Drawing.Point(80, 347);
            this.rbFF.Name = "rbFF";
            this.rbFF.Size = new System.Drawing.Size(48, 19);
            this.rbFF.TabIndex = 2;
            this.rbFF.TabStop = true;
            this.rbFF.Text = "Férfi";
            this.rbFF.UseVisualStyleBackColor = true;
            // 
            // dtpSzul
            // 
            this.dtpSzul.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSzul.Location = new System.Drawing.Point(80, 372);
            this.dtpSzul.Name = "dtpSzul";
            this.dtpSzul.Size = new System.Drawing.Size(200, 23);
            this.dtpSzul.TabIndex = 3;
            // 
            // NN
            // 
            this.NN.AutoSize = true;
            this.NN.Location = new System.Drawing.Point(186, 347);
            this.NN.Name = "NN";
            this.NN.Size = new System.Drawing.Size(41, 19);
            this.NN.TabIndex = 4;
            this.NN.Text = "Nő";
            this.NN.UseVisualStyleBackColor = true;
            // 
            // button_newPerson
            // 
            this.button_newPerson.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_newPerson.Location = new System.Drawing.Point(540, 318);
            this.button_newPerson.Name = "button_newPerson";
            this.button_newPerson.Size = new System.Drawing.Size(231, 33);
            this.button_newPerson.TabIndex = 8;
            this.button_newPerson.Text = "ÚJ SZEMÉLY HOZZÁADÁSA";
            this.button_newPerson.UseVisualStyleBackColor = true;
            this.button_newPerson.Click += new System.EventHandler(this.Button_newPerson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.button_newPerson);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.NN);
            this.Controls.Add(this.dtpSzul);
            this.Controls.Add(this.rbFF);
            this.Controls.Add(this.tb_Nev);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox tb_Nev;
        private RadioButton rbFF;
        private DateTimePicker dtpSzul;
        private RadioButton NN;
        private Button button_newPerson;
    }
}