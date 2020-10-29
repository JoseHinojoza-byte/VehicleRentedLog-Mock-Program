namespace A3_Hinojoza
{
    partial class Assignment3
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
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.lblMakeandModel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnLowestMileage = new System.Windows.Forms.Button();
            this.btnAvgFordMileage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(138, 78);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(204, 78);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(44, 13);
            this.lblMileage.TabIndex = 1;
            this.lblMileage.Text = "Mileage";
            // 
            // lblMakeandModel
            // 
            this.lblMakeandModel.AutoSize = true;
            this.lblMakeandModel.BackColor = System.Drawing.SystemColors.Control;
            this.lblMakeandModel.Location = new System.Drawing.Point(12, 78);
            this.lblMakeandModel.Name = "lblMakeandModel";
            this.lblMakeandModel.Size = new System.Drawing.Size(87, 13);
            this.lblMakeandModel.TabIndex = 2;
            this.lblMakeandModel.Text = "Make and Model";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(336, 321);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 13);
            this.name.TabIndex = 3;
            this.name.Text = "Jose";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnLowestMileage
            // 
            this.btnLowestMileage.Location = new System.Drawing.Point(376, 103);
            this.btnLowestMileage.Name = "btnLowestMileage";
            this.btnLowestMileage.Size = new System.Drawing.Size(100, 23);
            this.btnLowestMileage.TabIndex = 6;
            this.btnLowestMileage.Text = "Lowest Mileage";
            this.btnLowestMileage.UseVisualStyleBackColor = true;
            this.btnLowestMileage.Click += new System.EventHandler(this.btnLowestMileage_Click);
            // 
            // btnAvgFordMileage
            // 
            this.btnAvgFordMileage.Location = new System.Drawing.Point(376, 147);
            this.btnAvgFordMileage.Name = "btnAvgFordMileage";
            this.btnAvgFordMileage.Size = new System.Drawing.Size(100, 42);
            this.btnAvgFordMileage.TabIndex = 7;
            this.btnAvgFordMileage.Text = "Average Ford Mileage";
            this.btnAvgFordMileage.UseVisualStyleBackColor = true;
            this.btnAvgFordMileage.Click += new System.EventHandler(this.btnAvgFordMileage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::A3_Hinojoza.Properties.Resources.itsTony;
            this.pictureBox1.Location = new System.Drawing.Point(176, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Assignment3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 386);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAvgFordMileage);
            this.Controls.Add(this.btnLowestMileage);
            this.Controls.Add(this.name);
            this.Controls.Add(this.lblMakeandModel);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.lblYear);
            this.Name = "Assignment3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label lblMakeandModel;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnLowestMileage;
        private System.Windows.Forms.Button btnAvgFordMileage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

