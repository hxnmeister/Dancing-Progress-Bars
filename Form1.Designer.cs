namespace DancingProgressBars
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumberOfBarsUpDown = new System.Windows.Forms.NumericUpDown();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.DescribeToCounterLabel = new System.Windows.Forms.Label();
            this.ControlGroupBox = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfBarsUpDown)).BeginInit();
            this.ControlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberOfBarsUpDown
            // 
            this.NumberOfBarsUpDown.Location = new System.Drawing.Point(11, 47);
            this.NumberOfBarsUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumberOfBarsUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NumberOfBarsUpDown.Name = "NumberOfBarsUpDown";
            this.NumberOfBarsUpDown.Size = new System.Drawing.Size(111, 23);
            this.NumberOfBarsUpDown.TabIndex = 0;
            this.NumberOfBarsUpDown.ValueChanged += new System.EventHandler(this.NumberOfBarsUpDown_ValueChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Enabled = false;
            this.SubmitButton.Location = new System.Drawing.Point(142, 59);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(74, 31);
            this.SubmitButton.TabIndex = 1;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // DescribeToCounterLabel
            // 
            this.DescribeToCounterLabel.AutoSize = true;
            this.DescribeToCounterLabel.Location = new System.Drawing.Point(8, 27);
            this.DescribeToCounterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescribeToCounterLabel.Name = "DescribeToCounterLabel";
            this.DescribeToCounterLabel.Size = new System.Drawing.Size(114, 16);
            this.DescribeToCounterLabel.TabIndex = 2;
            this.DescribeToCounterLabel.Text = "Amount of bars:";
            // 
            // ControlGroupBox
            // 
            this.ControlGroupBox.Controls.Add(this.ResetButton);
            this.ControlGroupBox.Controls.Add(this.DescribeToCounterLabel);
            this.ControlGroupBox.Controls.Add(this.SubmitButton);
            this.ControlGroupBox.Controls.Add(this.NumberOfBarsUpDown);
            this.ControlGroupBox.Location = new System.Drawing.Point(13, 13);
            this.ControlGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ControlGroupBox.Name = "ControlGroupBox";
            this.ControlGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ControlGroupBox.Size = new System.Drawing.Size(224, 104);
            this.ControlGroupBox.TabIndex = 3;
            this.ControlGroupBox.TabStop = false;
            this.ControlGroupBox.Text = "Input";
            // 
            // ResetButton
            // 
            this.ResetButton.Enabled = false;
            this.ResetButton.Location = new System.Drawing.Point(142, 20);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(74, 31);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 128);
            this.Controls.Add(this.ControlGroupBox);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dancing Progress Bars";
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfBarsUpDown)).EndInit();
            this.ControlGroupBox.ResumeLayout(false);
            this.ControlGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumberOfBarsUpDown;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label DescribeToCounterLabel;
        private System.Windows.Forms.GroupBox ControlGroupBox;
        private System.Windows.Forms.Button ResetButton;
    }
}

