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
            this.button1 = new System.Windows.Forms.Button();
            this.name = new gestionnaireVisuel.typingArea();
            this.mark = new gestionnaireVisuel.typingArea();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(323, 31);
            this.name.TabIndex = 8;
            this.name.Load += new System.EventHandler(this.typingArea1_Load);
            // 
            // mark
            // 
            this.mark.Location = new System.Drawing.Point(12, 59);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(323, 31);
            this.mark.TabIndex = 9;
            this.mark.Load += new System.EventHandler(this.typingArea2_Load);
            // 
            // typingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 154);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Name = "typingWindow";
            this.Text = "typpingWindow";
            this.Load += new System.EventHandler(this.typingWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private typingArea name;
        private typingArea mark;
    }
}