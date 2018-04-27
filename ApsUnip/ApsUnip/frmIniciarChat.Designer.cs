namespace ApsUnip
{
    partial class frmIniciarChat
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
            this.txtIpServidor = new System.Windows.Forms.TextBox();
            this.lblIpServidor = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIpServidor
            // 
            this.txtIpServidor.Location = new System.Drawing.Point(143, 36);
            this.txtIpServidor.Name = "txtIpServidor";
            this.txtIpServidor.Size = new System.Drawing.Size(283, 22);
            this.txtIpServidor.TabIndex = 0;
            // 
            // lblIpServidor
            // 
            this.lblIpServidor.AutoSize = true;
            this.lblIpServidor.Location = new System.Drawing.Point(38, 36);
            this.lblIpServidor.Name = "lblIpServidor";
            this.lblIpServidor.Size = new System.Drawing.Size(99, 17);
            this.lblIpServidor.TabIndex = 1;
            this.lblIpServidor.Text = "IP do servidor:";
            this.lblIpServidor.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(58, 230);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(125, 81);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair do chat";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmIniciarChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 323);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblIpServidor);
            this.Controls.Add(this.txtIpServidor);
            this.Name = "frmIniciarChat";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmIniciarChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIpServidor;
        private System.Windows.Forms.Label lblIpServidor;
        private System.Windows.Forms.Button btnSair;
    }
}