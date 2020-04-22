namespace task2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMSG = new System.Windows.Forms.Label();
            this.lableInfo = new System.Windows.Forms.Label();
            this.boxAnswer = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(221, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.StartToolStripMenuItem.Text = "Старт";
            this.StartToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // labelMSG
            // 
            this.labelMSG.Location = new System.Drawing.Point(12, 24);
            this.labelMSG.Name = "labelMSG";
            this.labelMSG.Size = new System.Drawing.Size(197, 82);
            this.labelMSG.TabIndex = 1;
            this.labelMSG.Text = "Для начала игры нажмите \"старт\"";
            this.labelMSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lableInfo
            // 
            this.lableInfo.AutoSize = true;
            this.lableInfo.Location = new System.Drawing.Point(70, 117);
            this.lableInfo.Name = "lableInfo";
            this.lableInfo.Size = new System.Drawing.Size(84, 13);
            this.lableInfo.TabIndex = 2;
            this.lableInfo.Text = "Введите число:";
            // 
            // boxAnswer
            // 
            this.boxAnswer.Location = new System.Drawing.Point(64, 133);
            this.boxAnswer.Name = "boxAnswer";
            this.boxAnswer.ShortcutsEnabled = false;
            this.boxAnswer.Size = new System.Drawing.Size(100, 20);
            this.boxAnswer.TabIndex = 3;
            this.boxAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxAnswer_KeyPress);
            // 
            // btnAction
            // 
            this.btnAction.Enabled = false;
            this.btnAction.Location = new System.Drawing.Point(73, 159);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 4;
            this.btnAction.Text = "Проверить";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.BtnAction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 215);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.boxAnswer);
            this.Controls.Add(this.lableInfo);
            this.Controls.Add(this.labelMSG);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Угадай число\"";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
        private System.Windows.Forms.Label labelMSG;
        private System.Windows.Forms.Label lableInfo;
        private System.Windows.Forms.TextBox boxAnswer;
        private System.Windows.Forms.Button btnAction;
    }
}

