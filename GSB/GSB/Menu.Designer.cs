namespace GSB
{
    partial class Menu
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
            this.Valider = new System.Windows.Forms.Button();
            this.IdentifiantLab = new System.Windows.Forms.Label();
            this.identifiantTxt = new System.Windows.Forms.TextBox();
            this.PasswdLab = new System.Windows.Forms.Label();
            this.msgLab = new System.Windows.Forms.Label();
            this.passwdTxt = new System.Windows.Forms.TextBox();
            this.ConnexionLab = new System.Windows.Forms.Label();
            this.bsuser = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsuser)).BeginInit();
            this.SuspendLayout();
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(36, 254);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(162, 23);
            this.Valider.TabIndex = 0;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // IdentifiantLab
            // 
            this.IdentifiantLab.AutoSize = true;
            this.IdentifiantLab.Location = new System.Drawing.Point(33, 113);
            this.IdentifiantLab.Name = "IdentifiantLab";
            this.IdentifiantLab.Size = new System.Drawing.Size(53, 13);
            this.IdentifiantLab.TabIndex = 1;
            this.IdentifiantLab.Text = "Identifiant";
            // 
            // identifiantTxt
            // 
            this.identifiantTxt.Location = new System.Drawing.Point(98, 110);
            this.identifiantTxt.Name = "identifiantTxt";
            this.identifiantTxt.Size = new System.Drawing.Size(100, 20);
            this.identifiantTxt.TabIndex = 2;
            // 
            // PasswdLab
            // 
            this.PasswdLab.AutoSize = true;
            this.PasswdLab.Location = new System.Drawing.Point(33, 158);
            this.PasswdLab.Name = "PasswdLab";
            this.PasswdLab.Size = new System.Drawing.Size(53, 13);
            this.PasswdLab.TabIndex = 3;
            this.PasswdLab.Text = "Password";
            // 
            // msgLab
            // 
            this.msgLab.AutoSize = true;
            this.msgLab.Location = new System.Drawing.Point(33, 222);
            this.msgLab.Name = "msgLab";
            this.msgLab.Size = new System.Drawing.Size(35, 13);
            this.msgLab.TabIndex = 4;
            this.msgLab.Text = "label3";
            this.msgLab.Visible = false;
            // 
            // passwdTxt
            // 
            this.passwdTxt.Location = new System.Drawing.Point(98, 158);
            this.passwdTxt.Name = "passwdTxt";
            this.passwdTxt.Size = new System.Drawing.Size(100, 20);
            this.passwdTxt.TabIndex = 5;
            // 
            // ConnexionLab
            // 
            this.ConnexionLab.AutoSize = true;
            this.ConnexionLab.Location = new System.Drawing.Point(95, 73);
            this.ConnexionLab.Name = "ConnexionLab";
            this.ConnexionLab.Size = new System.Drawing.Size(57, 13);
            this.ConnexionLab.TabIndex = 6;
            this.ConnexionLab.Text = "Connexion";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 518);
            this.Controls.Add(this.ConnexionLab);
            this.Controls.Add(this.passwdTxt);
            this.Controls.Add(this.msgLab);
            this.Controls.Add(this.PasswdLab);
            this.Controls.Add(this.identifiantTxt);
            this.Controls.Add(this.IdentifiantLab);
            this.Controls.Add(this.Valider);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.bsuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Label IdentifiantLab;
        private System.Windows.Forms.TextBox identifiantTxt;
        private System.Windows.Forms.Label PasswdLab;
        private System.Windows.Forms.Label msgLab;
        private System.Windows.Forms.TextBox passwdTxt;
        private System.Windows.Forms.Label ConnexionLab;
        private System.Windows.Forms.BindingSource bsuser;
    }
}