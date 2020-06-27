namespace Minecraft_Book_Maker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.inputTextbox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.goRightPageButton = new System.Windows.Forms.Button();
            this.goLeftPageButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextbox
            // 
            this.inputTextbox.Location = new System.Drawing.Point(4, 5);
            this.inputTextbox.Multiline = true;
            this.inputTextbox.Name = "inputTextbox";
            this.inputTextbox.Size = new System.Drawing.Size(269, 375);
            this.inputTextbox.TabIndex = 0;
            this.inputTextbox.TextChanged += new System.EventHandler(this.ConvertButtonClick);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputLabel.ForeColor = System.Drawing.Color.Black;
            this.outputLabel.Location = new System.Drawing.Point(377, 5);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(205, 318);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // goRightPageButton
            // 
            this.goRightPageButton.BackColor = System.Drawing.Color.Transparent;
            this.goRightPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.goRightPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goRightPageButton.ForeColor = System.Drawing.Color.Transparent;
            this.goRightPageButton.Image = global::Minecraft_Book_Maker.Properties.Resources.rightButton;
            this.goRightPageButton.Location = new System.Drawing.Point(483, 326);
            this.goRightPageButton.Name = "goRightPageButton";
            this.goRightPageButton.Size = new System.Drawing.Size(100, 58);
            this.goRightPageButton.TabIndex = 4;
            this.goRightPageButton.UseVisualStyleBackColor = false;
            this.goRightPageButton.Click += new System.EventHandler(this.goRightPageButton_Click);
            // 
            // goLeftPageButton
            // 
            this.goLeftPageButton.BackColor = System.Drawing.Color.Transparent;
            this.goLeftPageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.goLeftPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goLeftPageButton.ForeColor = System.Drawing.Color.Transparent;
            this.goLeftPageButton.Image = global::Minecraft_Book_Maker.Properties.Resources.leftButton;
            this.goLeftPageButton.Location = new System.Drawing.Point(377, 326);
            this.goLeftPageButton.Name = "goLeftPageButton";
            this.goLeftPageButton.Size = new System.Drawing.Size(100, 58);
            this.goLeftPageButton.TabIndex = 3;
            this.goLeftPageButton.UseVisualStyleBackColor = false;
            this.goLeftPageButton.Click += new System.EventHandler(this.goLeftPageButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Minecraft_Book_Maker.Properties.Resources._5b739c22c64474_92630279153430326681213802;
            this.pictureBox1.Location = new System.Drawing.Point(279, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 386);
            this.Controls.Add(this.goRightPageButton);
            this.Controls.Add(this.goLeftPageButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inputTextbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(603, 425);
            this.MinimumSize = new System.Drawing.Size(603, 425);
            this.Name = "MainForm";
            this.Text = "Minecraft Text Conventer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button goLeftPageButton;
        private System.Windows.Forms.Button goRightPageButton;
    }
}

