namespace gestionnaireVisuel
{
    partial class typingArea
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.fieldName = new System.Windows.Forms.Label();
            this.myTypingField = new gestionnaireVisuel.myTextbox();
            this.SuspendLayout();
            // 
            // fieldName
            // 
            this.fieldName.AutoSize = true;
            this.fieldName.Location = new System.Drawing.Point(21, 6);
            this.fieldName.Name = "fieldName";
            this.fieldName.Size = new System.Drawing.Size(54, 13);
            this.fieldName.TabIndex = 0;
            this.fieldName.Text = "fieldName";
            this.fieldName.Click += new System.EventHandler(this.fieldName_Click);
            // 
            // myTypingField
            // 
            this.myTypingField.Location = new System.Drawing.Point(81, 3);
            this.myTypingField.Name = "myTypingField";
            this.myTypingField.Size = new System.Drawing.Size(224, 20);
            this.myTypingField.TabIndex = 1;
            this.myTypingField.TextChanged += new System.EventHandler(this.myTypingField_TextChanged);
            // 
            // typingArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myTypingField);
            this.Controls.Add(this.fieldName);
            this.Name = "typingArea";
            this.Size = new System.Drawing.Size(323, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fieldName;
        private myTextbox myTypingField;
    }
}
