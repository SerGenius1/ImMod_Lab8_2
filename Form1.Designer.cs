namespace Lab_8._2
{
    partial class Form1
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
            this.input = new System.Windows.Forms.TextBox();
            this.bt_Predict = new System.Windows.Forms.Button();
            this.label_Answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input.Location = new System.Drawing.Point(64, 57);
            this.input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.input.MaxLength = 200;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(611, 34);
            this.input.TabIndex = 1;
            this.input.Text = "Введите вопрос";
            // 
            // bt_Predict
            // 
            this.bt_Predict.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Predict.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Predict.Location = new System.Drawing.Point(279, 118);
            this.bt_Predict.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Predict.Name = "bt_Predict";
            this.bt_Predict.Size = new System.Drawing.Size(184, 44);
            this.bt_Predict.TabIndex = 2;
            this.bt_Predict.Text = "Предсказать";
            this.bt_Predict.UseVisualStyleBackColor = true;
            this.bt_Predict.Click += new System.EventHandler(this.bt_Predict_Click);
            // 
            // label_Answer
            // 
            this.label_Answer.AutoSize = true;
            this.label_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Answer.Location = new System.Drawing.Point(223, 283);
            this.label_Answer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(0, 29);
            this.label_Answer.TabIndex = 3;
            this.label_Answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 490);
            this.Controls.Add(this.label_Answer);
            this.Controls.Add(this.bt_Predict);
            this.Controls.Add(this.input);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "The ball of predictions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button bt_Predict;
        private System.Windows.Forms.Label label_Answer;
    }
}

