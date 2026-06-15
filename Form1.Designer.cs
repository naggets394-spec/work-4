namespace Практическая_работа_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxMatrix = new System.Windows.Forms.TextBox();
            this.labelCool = new System.Windows.Forms.Label();
            this.groupBoxRandom = new System.Windows.Forms.GroupBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelFrom = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.buttonFillRandom = new System.Windows.Forms.Button();
            this.groupBoxCreateMatrix = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelRowNums = new System.Windows.Forms.Label();
            this.labelColNums = new System.Windows.Forms.Label();
            this.textBoxRowNums = new System.Windows.Forms.TextBox();
            this.textBoxColumnsNum = new System.Windows.Forms.TextBox();
            this.textBoxHandRow = new System.Windows.Forms.TextBox();
            this.textBoxHandCol = new System.Windows.Forms.TextBox();
            this.groupBoxHandFill = new System.Windows.Forms.GroupBox();
            this.labelMethod = new System.Windows.Forms.Label();
            this.textBoxMethod = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelValue = new System.Windows.Forms.Label();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.groupBoxRandom.SuspendLayout();
            this.groupBoxCreateMatrix.SuspendLayout();
            this.groupBoxHandFill.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxMatrix
            // 
            this.textBoxMatrix.ForeColor = System.Drawing.Color.IndianRed;
            this.textBoxMatrix.Location = new System.Drawing.Point(33, 81);
            this.textBoxMatrix.Multiline = true;
            this.textBoxMatrix.Name = "textBoxMatrix";
            this.textBoxMatrix.ReadOnly = true;
            this.textBoxMatrix.Size = new System.Drawing.Size(436, 332);
            this.textBoxMatrix.TabIndex = 0;
            // 
            // labelCool
            // 
            this.labelCool.AutoSize = true;
            this.labelCool.BackColor = System.Drawing.Color.MistyRose;
            this.labelCool.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCool.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelCool.Location = new System.Drawing.Point(40, 35);
            this.labelCool.Name = "labelCool";
            this.labelCool.Size = new System.Drawing.Size(643, 32);
            this.labelCool.TabIndex = 1;
            this.labelCool.Text = "Здесь РЕАЛЬНО можно сделать крутую матрицу ";
            // 
            // groupBoxRandom
            // 
            this.groupBoxRandom.BackColor = System.Drawing.Color.White;
            this.groupBoxRandom.Controls.Add(this.labelTo);
            this.groupBoxRandom.Controls.Add(this.labelFrom);
            this.groupBoxRandom.Controls.Add(this.textBoxTo);
            this.groupBoxRandom.Controls.Add(this.textBoxFrom);
            this.groupBoxRandom.Controls.Add(this.buttonFillRandom);
            this.groupBoxRandom.Enabled = false;
            this.groupBoxRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxRandom.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBoxRandom.Location = new System.Drawing.Point(487, 244);
            this.groupBoxRandom.Name = "groupBoxRandom";
            this.groupBoxRandom.Size = new System.Drawing.Size(243, 112);
            this.groupBoxRandom.TabIndex = 2;
            this.groupBoxRandom.TabStop = false;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(133, 22);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(24, 16);
            this.labelTo.TabIndex = 4;
            this.labelTo.Text = "До";
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(22, 22);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(24, 16);
            this.labelFrom.TabIndex = 3;
            this.labelFrom.Text = "От";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(136, 41);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(86, 22);
            this.textBoxTo.TabIndex = 2;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(16, 41);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(86, 22);
            this.textBoxFrom.TabIndex = 1;
            // 
            // buttonFillRandom
            // 
            this.buttonFillRandom.Location = new System.Drawing.Point(14, 69);
            this.buttonFillRandom.Name = "buttonFillRandom";
            this.buttonFillRandom.Size = new System.Drawing.Size(208, 24);
            this.buttonFillRandom.TabIndex = 0;
            this.buttonFillRandom.Text = "Заполнить!";
            this.buttonFillRandom.UseVisualStyleBackColor = true;
            this.buttonFillRandom.Click += new System.EventHandler(this.buttonFillRandom_Click);
            // 
            // groupBoxCreateMatrix
            // 
            this.groupBoxCreateMatrix.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxCreateMatrix.Controls.Add(this.button1);
            this.groupBoxCreateMatrix.Controls.Add(this.label5);
            this.groupBoxCreateMatrix.Controls.Add(this.labelRowNums);
            this.groupBoxCreateMatrix.Controls.Add(this.labelColNums);
            this.groupBoxCreateMatrix.Controls.Add(this.textBoxRowNums);
            this.groupBoxCreateMatrix.Controls.Add(this.textBoxColumnsNum);
            this.groupBoxCreateMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCreateMatrix.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBoxCreateMatrix.Location = new System.Drawing.Point(487, 81);
            this.groupBoxCreateMatrix.Name = "groupBoxCreateMatrix";
            this.groupBoxCreateMatrix.Size = new System.Drawing.Size(241, 113);
            this.groupBoxCreateMatrix.TabIndex = 3;
            this.groupBoxCreateMatrix.TabStop = false;
            this.groupBoxCreateMatrix.Text = "Создать матрицу";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 9;
            // 
            // labelRowNums
            // 
            this.labelRowNums.AutoSize = true;
            this.labelRowNums.Location = new System.Drawing.Point(133, 31);
            this.labelRowNums.Name = "labelRowNums";
            this.labelRowNums.Size = new System.Drawing.Size(54, 16);
            this.labelRowNums.TabIndex = 4;
            this.labelRowNums.Text = "Строки";
            // 
            // labelColNums
            // 
            this.labelColNums.AutoSize = true;
            this.labelColNums.Location = new System.Drawing.Point(13, 31);
            this.labelColNums.Name = "labelColNums";
            this.labelColNums.Size = new System.Drawing.Size(64, 16);
            this.labelColNums.TabIndex = 2;
            this.labelColNums.Text = "Столбцы";
            // 
            // textBoxRowNums
            // 
            this.textBoxRowNums.Location = new System.Drawing.Point(136, 50);
            this.textBoxRowNums.Name = "textBoxRowNums";
            this.textBoxRowNums.Size = new System.Drawing.Size(96, 22);
            this.textBoxRowNums.TabIndex = 1;
            // 
            // textBoxColumnsNum
            // 
            this.textBoxColumnsNum.Location = new System.Drawing.Point(16, 50);
            this.textBoxColumnsNum.Name = "textBoxColumnsNum";
            this.textBoxColumnsNum.Size = new System.Drawing.Size(96, 22);
            this.textBoxColumnsNum.TabIndex = 0;
            this.textBoxColumnsNum.TextChanged += new System.EventHandler(this.textBoxColumnsNum_TextChanged);
            // 
            // textBoxHandRow
            // 
            this.textBoxHandRow.Enabled = false;
            this.textBoxHandRow.Location = new System.Drawing.Point(460, 336);
            this.textBoxHandRow.Name = "textBoxHandRow";
            this.textBoxHandRow.Size = new System.Drawing.Size(77, 22);
            this.textBoxHandRow.TabIndex = 6;
            // 
            // textBoxHandCol
            // 
            this.textBoxHandCol.Enabled = false;
            this.textBoxHandCol.Location = new System.Drawing.Point(19, 33);
            this.textBoxHandCol.Name = "textBoxHandCol";
            this.textBoxHandCol.ReadOnly = true;
            this.textBoxHandCol.Size = new System.Drawing.Size(170, 22);
            this.textBoxHandCol.TabIndex = 7;
            this.textBoxHandCol.Text = "Строка 1, столбец 1";
            this.textBoxHandCol.TextChanged += new System.EventHandler(this.textBoxHandCol_TextChanged);
            // 
            // groupBoxHandFill
            // 
            this.groupBoxHandFill.BackColor = System.Drawing.Color.White;
            this.groupBoxHandFill.Controls.Add(this.labelValue);
            this.groupBoxHandFill.Controls.Add(this.buttonEnter);
            this.groupBoxHandFill.Controls.Add(this.textBoxValue);
            this.groupBoxHandFill.Controls.Add(this.textBoxHandCol);
            this.groupBoxHandFill.Controls.Add(this.textBoxHandRow);
            this.groupBoxHandFill.Enabled = false;
            this.groupBoxHandFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxHandFill.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBoxHandFill.Location = new System.Drawing.Point(485, 384);
            this.groupBoxHandFill.Name = "groupBoxHandFill";
            this.groupBoxHandFill.Size = new System.Drawing.Size(242, 125);
            this.groupBoxHandFill.TabIndex = 9;
            this.groupBoxHandFill.TabStop = false;
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.BackColor = System.Drawing.Color.Transparent;
            this.labelMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMethod.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelMethod.Location = new System.Drawing.Point(43, 435);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(160, 64);
            this.labelMethod.TabIndex = 10;
            this.labelMethod.Text = "Седловые точка \r\n(минимальная в\r\nстроке и максимальная\r\nв столбце)";
            this.labelMethod.Click += new System.EventHandler(this.labelMethod_Click);
            // 
            // textBoxMethod
            // 
            this.textBoxMethod.Location = new System.Drawing.Point(243, 434);
            this.textBoxMethod.Multiline = true;
            this.textBoxMethod.Name = "textBoxMethod";
            this.textBoxMethod.ReadOnly = true;
            this.textBoxMethod.Size = new System.Drawing.Size(226, 75);
            this.textBoxMethod.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(487, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 1);
            this.label1.TabIndex = 13;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(487, 221);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(128, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Заполнить случайно";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(487, 361);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(123, 17);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Заполнить вручную";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(103, 81);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(113, 32);
            this.buttonEnter.TabIndex = 12;
            this.buttonEnter.Text = "Далее";
            this.buttonEnter.UseMnemonic = false;
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(15, 72);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(72, 16);
            this.labelValue.TabIndex = 13;
            this.labelValue.Text = "Значение";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(18, 91);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(60, 22);
            this.textBoxValue.TabIndex = 8;
            this.textBoxValue.TextChanged += new System.EventHandler(this.textBoxValue_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(753, 533);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMethod);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.groupBoxHandFill);
            this.Controls.Add(this.groupBoxCreateMatrix);
            this.Controls.Add(this.groupBoxRandom);
            this.Controls.Add(this.labelCool);
            this.Controls.Add(this.textBoxMatrix);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Практическая работа №4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxRandom.ResumeLayout(false);
            this.groupBoxRandom.PerformLayout();
            this.groupBoxCreateMatrix.ResumeLayout(false);
            this.groupBoxCreateMatrix.PerformLayout();
            this.groupBoxHandFill.ResumeLayout(false);
            this.groupBoxHandFill.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMatrix;
        private System.Windows.Forms.Label labelCool;
        private System.Windows.Forms.GroupBox groupBoxRandom;
        private System.Windows.Forms.Button buttonFillRandom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.GroupBox groupBoxCreateMatrix;
        private System.Windows.Forms.TextBox textBoxHandCol;
        private System.Windows.Forms.TextBox textBoxHandRow;
        private System.Windows.Forms.Label labelRowNums;
        private System.Windows.Forms.Label labelColNums;
        private System.Windows.Forms.TextBox textBoxRowNums;
        private System.Windows.Forms.TextBox textBoxColumnsNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxHandFill;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.TextBox textBoxMethod;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.TextBox textBoxValue;
    }
}

