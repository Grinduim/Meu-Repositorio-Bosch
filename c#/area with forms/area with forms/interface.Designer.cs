
namespace area_with_forms
{
    partial class @interface
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
            this.ButtonTriangulo = new System.Windows.Forms.Button();
            this.ButtonCirc = new System.Windows.Forms.Button();
            this.ButtonRet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonTriangulo
            // 
            this.ButtonTriangulo.Location = new System.Drawing.Point(93, 125);
            this.ButtonTriangulo.Name = "ButtonTriangulo";
            this.ButtonTriangulo.Size = new System.Drawing.Size(105, 43);
            this.ButtonTriangulo.TabIndex = 0;
            this.ButtonTriangulo.Text = "Triagulo";
            this.ButtonTriangulo.UseVisualStyleBackColor = true;
            this.ButtonTriangulo.Click += new System.EventHandler(this.ButtonTriangulo_Click);
            // 
            // ButtonCirc
            // 
            this.ButtonCirc.Location = new System.Drawing.Point(260, 125);
            this.ButtonCirc.Name = "ButtonCirc";
            this.ButtonCirc.Size = new System.Drawing.Size(103, 43);
            this.ButtonCirc.TabIndex = 1;
            this.ButtonCirc.Text = "Circunferencia";
            this.ButtonCirc.UseVisualStyleBackColor = true;
            // 
            // ButtonRet
            // 
            this.ButtonRet.Location = new System.Drawing.Point(438, 125);
            this.ButtonRet.Name = "ButtonRet";
            this.ButtonRet.Size = new System.Drawing.Size(100, 43);
            this.ButtonRet.TabIndex = 2;
            this.ButtonRet.Text = "Retangulo";
            this.ButtonRet.UseVisualStyleBackColor = true;
            this.ButtonRet.Click += new System.EventHandler(this.button2_Click);
            // 
            // @interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonRet);
            this.Controls.Add(this.ButtonCirc);
            this.Controls.Add(this.ButtonTriangulo);
            this.Name = "@interface";
            this.Text = "@interface";
            this.Load += new System.EventHandler(this.@interface_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonTriangulo;
        private System.Windows.Forms.Button ButtonCirc;
        private System.Windows.Forms.Button ButtonRet;
    }
}