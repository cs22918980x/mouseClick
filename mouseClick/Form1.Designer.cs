namespace mouseClick
{
    partial class mouseClick
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.timeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.sequence1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.sequenceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sequence1)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.timeLabel.Location = new System.Drawing.Point(172, 99);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(318, 30);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "You have clicked 0 time";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(64, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 106);
            this.button1.TabIndex = 1;
            this.button1.Text = "click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(281, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 106);
            this.button2.TabIndex = 2;
            this.button2.TabStop = false;
            this.button2.Text = "reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(471, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 106);
            this.button3.TabIndex = 3;
            this.button3.Text = "check";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(64, 330);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 101);
            this.button4.TabIndex = 4;
            this.button4.Text = "time multiplication";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(281, 330);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 101);
            this.button5.TabIndex = 5;
            this.button5.Text = "9*9";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // sequence1
            // 
            this.sequence1.Font = new System.Drawing.Font("新細明體", 12F);
            this.sequence1.Location = new System.Drawing.Point(549, 328);
            this.sequence1.Name = "sequence1";
            this.sequence1.Size = new System.Drawing.Size(71, 31);
            this.sequence1.TabIndex = 6;
            this.sequence1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(467, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "sequence";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sequenceButton
            // 
            this.sequenceButton.Font = new System.Drawing.Font("新細明體", 13F);
            this.sequenceButton.Location = new System.Drawing.Point(471, 372);
            this.sequenceButton.Name = "sequenceButton";
            this.sequenceButton.Size = new System.Drawing.Size(149, 59);
            this.sequenceButton.TabIndex = 8;
            this.sequenceButton.Text = "check sequence";
            this.sequenceButton.UseVisualStyleBackColor = true;
            this.sequenceButton.Click += new System.EventHandler(this.sequenceButton_Click);
            // 
            // mouseClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 505);
            this.Controls.Add(this.sequenceButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sequence1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeLabel);
            this.Font = new System.Drawing.Font("新細明體", 9F);
            this.Name = "mouseClick";
            this.Text = "mouseClick";
            ((System.ComponentModel.ISupportInitialize)(this.sequence1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button button1;
        protected System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown sequence1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sequenceButton;
    }
}

