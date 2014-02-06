namespace gestionnaireVisuel
{
    partial class typingWindow
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
            this.insertButton = new System.Windows.Forms.Button();
            this.mark = new gestionnaireVisuel.typingArea();
            this.name = new gestionnaireVisuel.typingArea();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(247, 108);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 7;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // mark
            // 
            this.mark.Location = new System.Drawing.Point(12, 59);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(323, 31);
            this.mark.TabIndex = 9;
            this.mark.Load += new System.EventHandler(this.typingArea2_Load);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(323, 31);
            this.name.TabIndex = 8;
            this.name.Load += new System.EventHandler(this.typingArea1_Load);
            // 
            // typingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 154);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.name);
            this.Controls.Add(this.insertButton);
            this.Name = "typingWindow";
            this.Text = "typpingWindow";
            this.Load += new System.EventHandler(this.typingWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insertButton;
        private typingArea name;
        private typingArea mark;
    }
}