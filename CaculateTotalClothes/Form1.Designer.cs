
namespace CaculateTotalClothes
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
            this.dataGrdView = new System.Windows.Forms.DataGridView();
            this.chooseFIle = new System.Windows.Forms.Button();
            this.cbb_styleCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_styleCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrdView
            // 
            this.dataGrdView.AllowUserToAddRows = false;
            this.dataGrdView.AllowUserToDeleteRows = false;
            this.dataGrdView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdView.Location = new System.Drawing.Point(12, 79);
            this.dataGrdView.Name = "dataGrdView";
            this.dataGrdView.ReadOnly = true;
            this.dataGrdView.RowHeadersWidth = 51;
            this.dataGrdView.RowTemplate.Height = 29;
            this.dataGrdView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrdView.Size = new System.Drawing.Size(1645, 698);
            this.dataGrdView.TabIndex = 0;
            this.dataGrdView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrdView_CellContentClick);
            // 
            // chooseFIle
            // 
            this.chooseFIle.Location = new System.Drawing.Point(12, 26);
            this.chooseFIle.Name = "chooseFIle";
            this.chooseFIle.Size = new System.Drawing.Size(273, 29);
            this.chooseFIle.TabIndex = 1;
            this.chooseFIle.Text = "Choose File ";
            this.chooseFIle.UseVisualStyleBackColor = true;
            this.chooseFIle.Click += new System.EventHandler(this.chooseFIle_Click);
            // 
            // cbb_styleCode
            // 
            this.cbb_styleCode.FormattingEnabled = true;
            this.cbb_styleCode.Items.AddRange(new object[] {
            "Buyer",
            "Style",
            "Color"});
            this.cbb_styleCode.Location = new System.Drawing.Point(439, 27);
            this.cbb_styleCode.Name = "cbb_styleCode";
            this.cbb_styleCode.Size = new System.Drawing.Size(193, 28);
            this.cbb_styleCode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Columns:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(728, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search:";
            // 
            // tb_styleCode
            // 
            this.tb_styleCode.Location = new System.Drawing.Point(799, 29);
            this.tb_styleCode.Name = "tb_styleCode";
            this.tb_styleCode.Size = new System.Drawing.Size(199, 27);
            this.tb_styleCode.TabIndex = 7;
            this.tb_styleCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_styleCode_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1669, 789);
            this.Controls.Add(this.tb_styleCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_styleCode);
            this.Controls.Add(this.chooseFIle);
            this.Controls.Add(this.dataGrdView);
            this.Name = "Form1";
            this.Text = "Caculate";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrdView;
        private System.Windows.Forms.Button chooseFIle;
        private System.Windows.Forms.ComboBox cbb_styleCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_styleCode;
    }
}

