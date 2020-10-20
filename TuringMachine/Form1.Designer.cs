namespace TuringMachine
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
            this.ProgramText = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.BeginStatement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StartProgram = new System.Windows.Forms.Button();
            this.LoadProgram = new System.Windows.Forms.Button();
            this.DoStep = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StepsCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrState = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.delayBox = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.PauseCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProgramText
            // 
            this.ProgramText.Location = new System.Drawing.Point(12, 62);
            this.ProgramText.Multiline = true;
            this.ProgramText.Name = "ProgramText";
            this.ProgramText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProgramText.Size = new System.Drawing.Size(418, 376);
            this.ProgramText.TabIndex = 1;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(439, 88);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(176, 23);
            this.Confirm.TabIndex = 2;
            this.Confirm.Text = "Принять";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // BeginStatement
            // 
            this.BeginStatement.Location = new System.Drawing.Point(439, 62);
            this.BeginStatement.Name = "BeginStatement";
            this.BeginStatement.Size = new System.Drawing.Size(176, 20);
            this.BeginStatement.TabIndex = 3;
            this.BeginStatement.Text = "111#11111#11#111#1111";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите начальное состояние:";
            // 
            // StartProgram
            // 
            this.StartProgram.Location = new System.Drawing.Point(440, 185);
            this.StartProgram.Name = "StartProgram";
            this.StartProgram.Size = new System.Drawing.Size(176, 23);
            this.StartProgram.TabIndex = 5;
            this.StartProgram.Text = "Выполнить всю программу";
            this.StartProgram.UseVisualStyleBackColor = true;
            this.StartProgram.Click += new System.EventHandler(this.StartProgram_Click);
            // 
            // LoadProgram
            // 
            this.LoadProgram.Location = new System.Drawing.Point(440, 415);
            this.LoadProgram.Name = "LoadProgram";
            this.LoadProgram.Size = new System.Drawing.Size(175, 23);
            this.LoadProgram.TabIndex = 6;
            this.LoadProgram.Text = "Загрузить программу";
            this.LoadProgram.UseVisualStyleBackColor = true;
            this.LoadProgram.Click += new System.EventHandler(this.LoadProgram_Click);
            // 
            // DoStep
            // 
            this.DoStep.Location = new System.Drawing.Point(440, 214);
            this.DoStep.Name = "DoStep";
            this.DoStep.Size = new System.Drawing.Size(176, 23);
            this.DoStep.TabIndex = 7;
            this.DoStep.Text = "Сделать шаг";
            this.DoStep.UseVisualStyleBackColor = true;
            this.DoStep.Click += new System.EventHandler(this.DoStep_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Количество шагов всего:";
            // 
            // StepsCount
            // 
            this.StepsCount.AutoSize = true;
            this.StepsCount.Location = new System.Drawing.Point(437, 317);
            this.StepsCount.Name = "StepsCount";
            this.StepsCount.Size = new System.Drawing.Size(13, 13);
            this.StepsCount.TabIndex = 9;
            this.StepsCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Текущий вызов:";
            // 
            // CurrState
            // 
            this.CurrState.AutoSize = true;
            this.CurrState.Location = new System.Drawing.Point(437, 343);
            this.CurrState.Name = "CurrState";
            this.CurrState.Size = new System.Drawing.Size(13, 13);
            this.CurrState.TabIndex = 11;
            this.CurrState.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Программа:";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(440, 272);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(176, 23);
            this.Reset.TabIndex = 13;
            this.Reset.Text = "Сброс";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Введите значение задержки:";
            // 
            // delayBox
            // 
            this.delayBox.Location = new System.Drawing.Point(440, 140);
            this.delayBox.Name = "delayBox";
            this.delayBox.Size = new System.Drawing.Size(57, 20);
            this.delayBox.TabIndex = 15;
            this.delayBox.Text = "500";
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.NavajoWhite;
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Output.Location = new System.Drawing.Point(12, 11);
            this.Output.Name = "Output";
            this.Output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Output.Size = new System.Drawing.Size(602, 34);
            this.Output.TabIndex = 17;
            this.Output.Text = "";
            // 
            // PauseCalc
            // 
            this.PauseCalc.Location = new System.Drawing.Point(440, 243);
            this.PauseCalc.Name = "PauseCalc";
            this.PauseCalc.Size = new System.Drawing.Size(176, 23);
            this.PauseCalc.TabIndex = 18;
            this.PauseCalc.Text = "Приостановить";
            this.PauseCalc.UseVisualStyleBackColor = true;
            this.PauseCalc.Click += new System.EventHandler(this.PauseCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.PauseCalc);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delayBox);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CurrState);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StepsCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DoStep);
            this.Controls.Add(this.LoadProgram);
            this.Controls.Add(this.StartProgram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BeginStatement);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.ProgramText);
            this.MaximumSize = new System.Drawing.Size(639, 489);
            this.MinimumSize = new System.Drawing.Size(639, 489);
            this.Name = "Form1";
            this.Text = "Turing Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ProgramText;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.TextBox BeginStatement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartProgram;
        private System.Windows.Forms.Button LoadProgram;
        private System.Windows.Forms.Button DoStep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label StepsCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CurrState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox delayBox;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Button PauseCalc;
    }
}

