namespace Casino
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btGirar = new System.Windows.Forms.Button();
            this.tmrGiro = new System.Windows.Forms.Timer(this.components);
            this.chbVitorias = new System.Windows.Forms.CheckBox();
            this.lbxUltimos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Gold;
            this.lbl1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(89, 40);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(95, 89);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "0";
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Gold;
            this.lbl2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(280, 40);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(95, 89);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "0";
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Gold;
            this.lbl3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(465, 40);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(95, 89);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "0";
            // 
            // btGirar
            // 
            this.btGirar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btGirar.AutoSize = true;
            this.btGirar.BackColor = System.Drawing.Color.DarkRed;
            this.btGirar.Font = new System.Drawing.Font("Copperplate Gothic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGirar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btGirar.Location = new System.Drawing.Point(88, 175);
            this.btGirar.Name = "btGirar";
            this.btGirar.Size = new System.Drawing.Size(465, 80);
            this.btGirar.TabIndex = 3;
            this.btGirar.Text = "Girar";
            this.btGirar.UseVisualStyleBackColor = false;
            this.btGirar.Click += new System.EventHandler(this.btGirar_Click);
            // 
            // tmrGiro
            // 
            this.tmrGiro.Tick += new System.EventHandler(this.tmrGiro_Tick);
            // 
            // chbVitorias
            // 
            this.chbVitorias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbVitorias.AutoSize = true;
            this.chbVitorias.BackColor = System.Drawing.Color.Olive;
            this.chbVitorias.Font = new System.Drawing.Font("Copperplate Gothic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbVitorias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chbVitorias.Location = new System.Drawing.Point(88, 295);
            this.chbVitorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbVitorias.Name = "chbVitorias";
            this.chbVitorias.Size = new System.Drawing.Size(182, 39);
            this.chbVitorias.TabIndex = 4;
            this.chbVitorias.Text = "Vitórias";
            this.chbVitorias.UseVisualStyleBackColor = false;
            this.chbVitorias.CheckedChanged += new System.EventHandler(this.chbVitorias_CheckedChanged);
            // 
            // lbxUltimos
            // 
            this.lbxUltimos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbxUltimos.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbxUltimos.Font = new System.Drawing.Font("Copperplate Gothic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxUltimos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbxUltimos.FormattingEnabled = true;
            this.lbxUltimos.ItemHeight = 29;
            this.lbxUltimos.Location = new System.Drawing.Point(88, 374);
            this.lbxUltimos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxUltimos.Name = "lbxUltimos";
            this.lbxUltimos.Size = new System.Drawing.Size(466, 149);
            this.lbxUltimos.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Casino.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 673);
            this.Controls.Add(this.lbxUltimos);
            this.Controls.Add(this.chbVitorias);
            this.Controls.Add(this.btGirar);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "CASSINOOOOO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btGirar;
        private System.Windows.Forms.Timer tmrGiro;
        private System.Windows.Forms.CheckBox chbVitorias;
        private System.Windows.Forms.ListBox lbxUltimos;
    }
}

