namespace TestMines2017
{
    partial class TestEMN2017
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.code_action = new System.Windows.Forms.Label();
            this.code_action_text_box = new System.Windows.Forms.TextBox();
            this.btn_quote = new System.Windows.Forms.Button();
            this.label_resultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // code_action
            // 
            this.code_action.AutoSize = true;
            this.code_action.Location = new System.Drawing.Point(47, 54);
            this.code_action.Name = "code_action";
            this.code_action.Size = new System.Drawing.Size(166, 25);
            this.code_action.TabIndex = 0;
            this.code_action.Text = "Code de l\'action";
            // 
            // code_action_text_box
            // 
            this.code_action_text_box.Location = new System.Drawing.Point(237, 48);
            this.code_action_text_box.Name = "code_action_text_box";
            this.code_action_text_box.Size = new System.Drawing.Size(150, 31);
            this.code_action_text_box.TabIndex = 1;
            this.code_action_text_box.Text = "code_action";
            // 
            // btn_quote
            // 
            this.btn_quote.Location = new System.Drawing.Point(437, 42);
            this.btn_quote.Name = "btn_quote";
            this.btn_quote.Size = new System.Drawing.Size(141, 49);
            this.btn_quote.TabIndex = 2;
            this.btn_quote.Text = "Quote";
            this.btn_quote.UseVisualStyleBackColor = true;
            this.btn_quote.Click += new System.EventHandler(this.btn_quote_Click);
            // 
            // label_resultat
            // 
            this.label_resultat.AutoSize = true;
            this.label_resultat.Location = new System.Drawing.Point(122, 146);
            this.label_resultat.Name = "label_resultat";
            this.label_resultat.Size = new System.Drawing.Size(18, 25);
            this.label_resultat.TabIndex = 3;
            this.label_resultat.Text = ".";
            // 
            // TestEMN2017
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 589);
            this.Controls.Add(this.label_resultat);
            this.Controls.Add(this.btn_quote);
            this.Controls.Add(this.code_action_text_box);
            this.Controls.Add(this.code_action);
            this.Name = "TestEMN2017";
            this.Text = "TestEMN2017";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label code_action;
        private System.Windows.Forms.TextBox code_action_text_box;
        private System.Windows.Forms.Button btn_quote;
        private System.Windows.Forms.Label label_resultat;
    }
}

