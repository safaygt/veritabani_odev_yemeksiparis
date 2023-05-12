namespace veritabani_odev
{
    partial class Kullanıcı_Panel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_müsteriler = new System.Windows.Forms.LinkLabel();
            this.lbl_restoranlar = new System.Windows.Forms.LinkLabel();
            this.lbl_encokpara = new System.Windows.Forms.LinkLabel();
            this.txt_restorangetir = new System.Windows.Forms.TextBox();
            this.btn_restorangetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(884, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_müsteriler
            // 
            this.lbl_müsteriler.AutoSize = true;
            this.lbl_müsteriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_müsteriler.Location = new System.Drawing.Point(553, 161);
            this.lbl_müsteriler.Name = "lbl_müsteriler";
            this.lbl_müsteriler.Size = new System.Drawing.Size(115, 20);
            this.lbl_müsteriler.TabIndex = 1;
            this.lbl_müsteriler.TabStop = true;
            this.lbl_müsteriler.Text = "Müşterilerimiz";
            this.lbl_müsteriler.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_müsteriler_LinkClicked);
            // 
            // lbl_restoranlar
            // 
            this.lbl_restoranlar.AutoSize = true;
            this.lbl_restoranlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_restoranlar.Location = new System.Drawing.Point(818, 161);
            this.lbl_restoranlar.Name = "lbl_restoranlar";
            this.lbl_restoranlar.Size = new System.Drawing.Size(96, 20);
            this.lbl_restoranlar.TabIndex = 1;
            this.lbl_restoranlar.TabStop = true;
            this.lbl_restoranlar.Text = "Restoranlar";
            this.lbl_restoranlar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_restoranlar_LinkClicked);
            // 
            // lbl_encokpara
            // 
            this.lbl_encokpara.AutoSize = true;
            this.lbl_encokpara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_encokpara.Location = new System.Drawing.Point(58, 161);
            this.lbl_encokpara.Name = "lbl_encokpara";
            this.lbl_encokpara.Size = new System.Drawing.Size(336, 20);
            this.lbl_encokpara.TabIndex = 1;
            this.lbl_encokpara.TabStop = true;
            this.lbl_encokpara.Text = "Tek Seferde En Çok Para Harcayan Müşteri";
            this.lbl_encokpara.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_encokpara_LinkClicked);
            // 
            // txt_restorangetir
            // 
            this.txt_restorangetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_restorangetir.Location = new System.Drawing.Point(160, 46);
            this.txt_restorangetir.Multiline = true;
            this.txt_restorangetir.Name = "txt_restorangetir";
            this.txt_restorangetir.Size = new System.Drawing.Size(365, 39);
            this.txt_restorangetir.TabIndex = 2;
            // 
            // btn_restorangetir
            // 
            this.btn_restorangetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_restorangetir.Location = new System.Drawing.Point(592, 46);
            this.btn_restorangetir.Name = "btn_restorangetir";
            this.btn_restorangetir.Size = new System.Drawing.Size(181, 39);
            this.btn_restorangetir.TabIndex = 3;
            this.btn_restorangetir.Text = "ARA";
            this.btn_restorangetir.UseVisualStyleBackColor = true;
            this.btn_restorangetir.Click += new System.EventHandler(this.btn_restorangetir_Click);
            // 
            // Kullanıcı_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 583);
            this.Controls.Add(this.btn_restorangetir);
            this.Controls.Add(this.txt_restorangetir);
            this.Controls.Add(this.lbl_restoranlar);
            this.Controls.Add(this.lbl_encokpara);
            this.Controls.Add(this.lbl_müsteriler);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kullanıcı_Panel";
            this.Text = "Kullanıcı Panel";
            this.Load += new System.EventHandler(this.Kullanıcı_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel lbl_müsteriler;
        private System.Windows.Forms.LinkLabel lbl_restoranlar;
        private System.Windows.Forms.LinkLabel lbl_encokpara;
        private System.Windows.Forms.TextBox txt_restorangetir;
        private System.Windows.Forms.Button btn_restorangetir;
    }
}