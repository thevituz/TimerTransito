namespace SemaforoTimer
{
    partial class SemaforoTimer
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
            this.btnLigar = new System.Windows.Forms.Button();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pbBase = new System.Windows.Forms.PictureBox();
            this.pbVermelho = new System.Windows.Forms.PictureBox();
            this.pbAmarelo = new System.Windows.Forms.PictureBox();
            this.pbVerde = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLigar
            // 
            this.btnLigar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigar.Location = new System.Drawing.Point(20, 400);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(100, 40);
            this.btnLigar.TabIndex = 1;
            this.btnLigar.Text = "LIGAR";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // btnDesligar
            // 
            this.btnDesligar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesligar.Location = new System.Drawing.Point(140, 400);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(100, 40);
            this.btnDesligar.TabIndex = 2;
            this.btnDesligar.Text = "DESLIGAR";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(260, 400);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 40);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pbBase
            // 
            this.pbBase.Image = global::TimerTransito.Properties.Resources.semaforo;
            this.pbBase.Location = new System.Drawing.Point(100, 50);
            this.pbBase.Name = "pbBase";
            this.pbBase.Size = new System.Drawing.Size(150, 300);
            this.pbBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBase.TabIndex = 0;
            this.pbBase.TabStop = false;
            // 
            // pbVermelho
            // 
            this.pbVermelho.Location = new System.Drawing.Point(154, 71);
            this.pbVermelho.Name = "pbVermelho";
            this.pbVermelho.Size = new System.Drawing.Size(40, 51);
            this.pbVermelho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVermelho.TabIndex = 4;
            this.pbVermelho.TabStop = false;
            // 
            // pbAmarelo
            // 
            this.pbAmarelo.Location = new System.Drawing.Point(154, 147);
            this.pbAmarelo.Name = "pbAmarelo";
            this.pbAmarelo.Size = new System.Drawing.Size(40, 52);
            this.pbAmarelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAmarelo.TabIndex = 5;
            this.pbAmarelo.TabStop = false;
            // 
            // pbVerde
            // 
            this.pbVerde.Location = new System.Drawing.Point(154, 224);
            this.pbVerde.Name = "pbVerde";
            this.pbVerde.Size = new System.Drawing.Size(40, 52);
            this.pbVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVerde.TabIndex = 6;
            this.pbVerde.TabStop = false;
            // 
            // SemaforoTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 483);
            this.Controls.Add(this.pbVerde);
            this.Controls.Add(this.pbAmarelo);
            this.Controls.Add(this.pbVermelho);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDesligar);
            this.Controls.Add(this.btnLigar);
            this.Controls.Add(this.pbBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SemaforoTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Semáforo";
            ((System.ComponentModel.ISupportInitialize)(this.pbBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBase;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pbVermelho;
        private System.Windows.Forms.PictureBox pbAmarelo;
        private System.Windows.Forms.PictureBox pbVerde;
    }
}

