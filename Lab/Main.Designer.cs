namespace Lab
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.numericAnswer = new System.Windows.Forms.NumericUpDown();
            this.questionInput = new System.Windows.Forms.TextBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAnswer.Location = new System.Drawing.Point(152, 424);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(104, 34);
            this.buttonAnswer.TabIndex = 9;
            this.buttonAnswer.Text = "Ответить";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // numericAnswer
            // 
            this.numericAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericAnswer.Location = new System.Drawing.Point(293, 370);
            this.numericAnswer.Name = "numericAnswer";
            this.numericAnswer.Size = new System.Drawing.Size(101, 26);
            this.numericAnswer.TabIndex = 8;
            this.numericAnswer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // questionInput
            // 
            this.questionInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionInput.Location = new System.Drawing.Point(12, 27);
            this.questionInput.Multiline = true;
            this.questionInput.Name = "questionInput";
            this.questionInput.ReadOnly = true;
            this.questionInput.Size = new System.Drawing.Size(382, 322);
            this.questionInput.TabIndex = 7;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.Location = new System.Drawing.Point(289, 4);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(83, 20);
            this.labelQuestion.TabIndex = 4;
            this.labelQuestion.Text = "Вопрос №";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnswer.Location = new System.Drawing.Point(8, 372);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(274, 20);
            this.labelAnswer.TabIndex = 5;
            this.labelAnswer.Text = "Укажите номер ошибочной строки:";
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayer.Location = new System.Drawing.Point(8, 4);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(72, 20);
            this.labelPlayer.TabIndex = 6;
            this.labelPlayer.Text = "Игрок №";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(166, 4);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(51, 20);
            this.labelResult.TabIndex = 10;
            this.labelResult.Text = "label1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 470);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.numericAnswer);
            this.Controls.Add(this.questionInput);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.labelPlayer);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.NumericUpDown numericAnswer;
        private System.Windows.Forms.TextBox questionInput;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelResult;
    }
}

