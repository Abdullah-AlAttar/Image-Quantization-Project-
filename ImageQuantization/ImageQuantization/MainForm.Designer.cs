namespace ImageQuantization
{
    partial class MainForm
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ClustersNumber = new System.Windows.Forms.TextBox();
            this.WhiteDistButton = new System.Windows.Forms.Button();
            this.MstQtButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.distColorsBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.distinctColorsBox2 = new System.Windows.Forms.TextBox();
            this.ReduceColorsBox = new System.Windows.Forms.CheckBox();
            this.MstBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(526, 833);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(169, 35);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 792);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original Image";
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.Location = new System.Drawing.Point(629, 920);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(66, 27);
            this.txtHeight.TabIndex = 8;
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(629, 885);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.ReadOnly = true;
            this.txtWidth.Size = new System.Drawing.Size(66, 27);
            this.txtWidth.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(522, 891);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(522, 926);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Height";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(766, 808);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Number of clusters";
            // 
            // ClustersNumber
            // 
            this.ClustersNumber.BackColor = System.Drawing.SystemColors.Menu;
            this.ClustersNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClustersNumber.Location = new System.Drawing.Point(770, 839);
            this.ClustersNumber.Name = "ClustersNumber";
            this.ClustersNumber.Size = new System.Drawing.Size(169, 27);
            this.ClustersNumber.TabIndex = 18;
            // 
            // WhiteDistButton
            // 
            this.WhiteDistButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhiteDistButton.Location = new System.Drawing.Point(1195, 808);
            this.WhiteDistButton.Name = "WhiteDistButton";
            this.WhiteDistButton.Size = new System.Drawing.Size(148, 77);
            this.WhiteDistButton.TabIndex = 19;
            this.WhiteDistButton.Text = "White Distance Quantiztion";
            this.WhiteDistButton.UseVisualStyleBackColor = true;
            this.WhiteDistButton.Click += new System.EventHandler(this.WhiteDistButton_Click);
            // 
            // MstQtButton
            // 
            this.MstQtButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MstQtButton.Location = new System.Drawing.Point(987, 808);
            this.MstQtButton.Name = "MstQtButton";
            this.MstQtButton.Size = new System.Drawing.Size(163, 77);
            this.MstQtButton.TabIndex = 20;
            this.MstQtButton.Text = "Mst Quantiztion";
            this.MstQtButton.UseVisualStyleBackColor = true;
            this.MstQtButton.Click += new System.EventHandler(this.MstQtButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 841);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Distinct colors";
            // 
            // distColorsBox1
            // 
            this.distColorsBox1.Location = new System.Drawing.Point(321, 844);
            this.distColorsBox1.Name = "distColorsBox1";
            this.distColorsBox1.ReadOnly = true;
            this.distColorsBox1.Size = new System.Drawing.Size(100, 24);
            this.distColorsBox1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 891);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Approximated Distinct Colors";
            // 
            // distinctColorsBox2
            // 
            this.distinctColorsBox2.Location = new System.Drawing.Point(321, 892);
            this.distinctColorsBox2.Name = "distinctColorsBox2";
            this.distinctColorsBox2.ReadOnly = true;
            this.distinctColorsBox2.Size = new System.Drawing.Size(100, 24);
            this.distinctColorsBox2.TabIndex = 24;
            // 
            // ReduceColorsBox
            // 
            this.ReduceColorsBox.AutoSize = true;
            this.ReduceColorsBox.Location = new System.Drawing.Point(785, 909);
            this.ReduceColorsBox.Name = "ReduceColorsBox";
            this.ReduceColorsBox.Size = new System.Drawing.Size(118, 21);
            this.ReduceColorsBox.TabIndex = 25;
            this.ReduceColorsBox.Text = "Reduce Colors";
            this.ReduceColorsBox.UseVisualStyleBackColor = true;
            // 
            // MstBox
            // 
            this.MstBox.Location = new System.Drawing.Point(1068, 917);
            this.MstBox.Name = "MstBox";
            this.MstBox.ReadOnly = true;
            this.MstBox.Size = new System.Drawing.Size(163, 24);
            this.MstBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(984, 920);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Mst Value : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(757, 732);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(775, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(853, 732);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1675, 1045);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MstBox);
            this.Controls.Add(this.ReduceColorsBox);
            this.Controls.Add(this.distinctColorsBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.distColorsBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MstQtButton);
            this.Controls.Add(this.WhiteDistButton);
            this.Controls.Add(this.ClustersNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Image Quantization...";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ClustersNumber;
        private System.Windows.Forms.Button WhiteDistButton;
        private System.Windows.Forms.Button MstQtButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox distColorsBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox distinctColorsBox2;
        private System.Windows.Forms.CheckBox ReduceColorsBox;
        private System.Windows.Forms.TextBox MstBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

