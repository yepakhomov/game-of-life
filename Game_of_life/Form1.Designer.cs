
namespace Game_of_life
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.randButton = new System.Windows.Forms.Button();
            this.startPauseButton = new System.Windows.Forms.Button();
            this.stepButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(236, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "The game of life";
            // 
            // randButton
            // 
            this.randButton.Location = new System.Drawing.Point(47, 51);
            this.randButton.Name = "randButton";
            this.randButton.Size = new System.Drawing.Size(75, 23);
            this.randButton.TabIndex = 1;
            this.randButton.Text = "Random";
            this.randButton.UseVisualStyleBackColor = true;
            this.randButton.Click += new System.EventHandler(this.randButton_Click);
            // 
            // startPauseButton
            // 
            this.startPauseButton.Location = new System.Drawing.Point(226, 51);
            this.startPauseButton.Name = "startPauseButton";
            this.startPauseButton.Size = new System.Drawing.Size(75, 23);
            this.startPauseButton.TabIndex = 2;
            this.startPauseButton.Text = "Start";
            this.startPauseButton.UseVisualStyleBackColor = true;
            this.startPauseButton.Click += new System.EventHandler(this.startPauseButton_Click);
            // 
            // stepButton
            // 
            this.stepButton.Location = new System.Drawing.Point(417, 51);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(75, 23);
            this.stepButton.TabIndex = 3;
            this.stepButton.Text = "1 step frwd";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Click += new System.EventHandler(this.stepButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(47, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 600);
            this.panel1.TabIndex = 4;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(571, 50);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 693);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.startPauseButton);
            this.Controls.Add(this.randButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button randButton;
        private System.Windows.Forms.Button startPauseButton;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearButton;
    }
}

