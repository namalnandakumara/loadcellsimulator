namespace viewname
{
    partial class viewForm
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
            this.tBoxView = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tBoxView
            // 
            this.tBoxView.Location = new System.Drawing.Point(1, 2);
            this.tBoxView.Multiline = true;
            this.tBoxView.Name = "tBoxView";
            this.tBoxView.Size = new System.Drawing.Size(524, 448);
            this.tBoxView.TabIndex = 0;
            this.tBoxView.TextChanged += new System.EventHandler(this.tBoxView_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.tBoxView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxView;
    }
}

