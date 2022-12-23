
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrdView
            // 
            this.dataGrdView.AllowUserToAddRows = false;
            this.dataGrdView.AllowUserToDeleteRows = false;
            this.dataGrdView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrdView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdView.Location = new System.Drawing.Point(12, 155);
            this.dataGrdView.Name = "dataGrdView";
            this.dataGrdView.ReadOnly = true;
            this.dataGrdView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGrdView.RowTemplate.Height = 29;
            this.dataGrdView.Size = new System.Drawing.Size(1196, 586);
            this.dataGrdView.TabIndex = 0;
            // 
            // chooseFIle
            // 
            this.chooseFIle.Location = new System.Drawing.Point(54, 44);
            this.chooseFIle.Name = "chooseFIle";
            this.chooseFIle.Size = new System.Drawing.Size(152, 56);
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
            "Color",
            "Type"});
            this.cbb_styleCode.Location = new System.Drawing.Point(320, 33);
            this.cbb_styleCode.Name = "cbb_styleCode";
            this.cbb_styleCode.Size = new System.Drawing.Size(193, 28);
            this.cbb_styleCode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Columns:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search:";
            // 
            // tb_styleCode
            // 
            this.tb_styleCode.Location = new System.Drawing.Point(320, 80);
            this.tb_styleCode.Name = "tb_styleCode";
            this.tb_styleCode.Size = new System.Drawing.Size(193, 27);
            this.tb_styleCode.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.tb_styleCode);
            this.panel1.Controls.Add(this.chooseFIle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbb_styleCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(231, 12);
            this.panel1.MinimumSize = new System.Drawing.Size(750, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 140);
            this.panel1.TabIndex = 8;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(548, 44);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(143, 56);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrdView);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "Caculate";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrdView;
        private System.Windows.Forms.Button chooseFIle;
        private System.Windows.Forms.ComboBox cbb_styleCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_styleCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_search;
    }
}

