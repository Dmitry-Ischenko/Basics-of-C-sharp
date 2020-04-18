namespace task1
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
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.textCountAllClickButton = new System.Windows.Forms.Label();
            this.ResultCountAllClickButton = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StartGame = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            this.textNeedResult = new System.Windows.Forms.Label();
            this.lebelNeedResult = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(215, 27);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(75, 23);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "button1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(215, 56);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(75, 23);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "button2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(215, 114);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "button3";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumber.Location = new System.Drawing.Point(12, 52);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(109, 39);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "label1";
            // 
            // textCountAllClickButton
            // 
            this.textCountAllClickButton.AutoSize = true;
            this.textCountAllClickButton.Location = new System.Drawing.Point(13, 139);
            this.textCountAllClickButton.Name = "textCountAllClickButton";
            this.textCountAllClickButton.Size = new System.Drawing.Size(38, 13);
            this.textCountAllClickButton.TabIndex = 4;
            this.textCountAllClickButton.Text = "Count:";
            // 
            // ResultCountAllClickButton
            // 
            this.ResultCountAllClickButton.AutoSize = true;
            this.ResultCountAllClickButton.Location = new System.Drawing.Point(55, 139);
            this.ResultCountAllClickButton.Name = "ResultCountAllClickButton";
            this.ResultCountAllClickButton.Size = new System.Drawing.Size(13, 13);
            this.ResultCountAllClickButton.TabIndex = 5;
            this.ResultCountAllClickButton.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartGame});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(302, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StartGame
            // 
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(57, 20);
            this.StartGame.Text = "Играть";
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(215, 85);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "button1";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // textNeedResult
            // 
            this.textNeedResult.AutoSize = true;
            this.textNeedResult.Location = new System.Drawing.Point(8, 24);
            this.textNeedResult.Name = "textNeedResult";
            this.textNeedResult.Size = new System.Drawing.Size(60, 13);
            this.textNeedResult.TabIndex = 8;
            this.textNeedResult.Text = "Получите: ";
            // 
            // lebelNeedResult
            // 
            this.lebelNeedResult.AutoSize = true;
            this.lebelNeedResult.Location = new System.Drawing.Point(74, 24);
            this.lebelNeedResult.Name = "lebelNeedResult";
            this.lebelNeedResult.Size = new System.Drawing.Size(13, 13);
            this.lebelNeedResult.TabIndex = 9;
            this.lebelNeedResult.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 164);
            this.Controls.Add(this.lebelNeedResult);
            this.Controls.Add(this.textNeedResult);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.ResultCountAllClickButton);
            this.Controls.Add(this.textCountAllClickButton);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(318, 203);
            this.MinimumSize = new System.Drawing.Size(318, 203);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Игра \"Удвоитель\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label textCountAllClickButton;
        private System.Windows.Forms.Label ResultCountAllClickButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem StartGame;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label textNeedResult;
        private System.Windows.Forms.Label lebelNeedResult;
    }
}

