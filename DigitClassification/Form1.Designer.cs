using System.Diagnostics;

namespace DigitClassification;

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
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnPredict = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTextBox = new System.Windows.Forms.Label();
            this.lblChoose = new System.Windows.Forms.Label();
            this.lblClear = new System.Windows.Forms.Label();
            this.lblTrain = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picChar = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = Color.Khaki;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 10F, FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(17, 38);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 53);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Font = new System.Drawing.Font("Century Gothic", 10F, FontStyle.Bold);
            this.btnChoose.Location = new System.Drawing.Point(17, 108);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(154, 53);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "Обрати";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Font = new System.Drawing.Font("Century Gothic", 10F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrain.Location = new System.Drawing.Point(17, 248);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(154, 53);
            this.btnTrain.TabIndex = 2;
            this.btnTrain.Text = "Натренувати";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnPredict
            // 
            this.btnPredict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPredict.Font = new System.Drawing.Font("Century Gothic", 14F, FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPredict.Location = new System.Drawing.Point(42, 35);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(290, 53);
            this.btnPredict.TabIndex = 3;
            this.btnPredict.Text = "Розпізнати";
            this.btnPredict.UseVisualStyleBackColor = false;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTextBox);
            this.groupBox1.Controls.Add(this.lblChoose);
            this.groupBox1.Controls.Add(this.lblClear);
            this.groupBox1.Controls.Add(this.lblTrain);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnTrain);
            this.groupBox1.Controls.Add(this.btnChoose);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(573, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 320);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Функції";
            // 
            // lblTextBox
            // 
            this.lblTextBox.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextBox.Location = new System.Drawing.Point(190, 178);
            this.lblTextBox.Name = "lblTextBox";
            this.lblTextBox.Size = new System.Drawing.Size(154, 53);
            this.lblTextBox.TabIndex = 9;
            this.lblTextBox.Text = "Введіть новий символ тут";
            this.lblTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChoose
            // 
            this.lblChoose.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChoose.Location = new System.Drawing.Point(190, 108);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(154, 53);
            this.lblChoose.TabIndex = 8;
            this.lblChoose.Text = "Обрати зображення на пристрої";
            this.lblChoose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClear
            // 
            this.lblClear.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClear.Location = new System.Drawing.Point(190, 38);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(154, 53);
            this.lblClear.TabIndex = 7;
            this.lblClear.Text = "Очищує полотно для нового малюнку";
            this.lblClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTrain
            // 
            this.lblTrain.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTrain.Location = new System.Drawing.Point(190, 248);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(154, 53);
            this.lblTrain.TabIndex = 6;
            this.lblTrain.Text = "Додати власний символ";
            this.lblTrain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(17, 178);
            this.textBox1.MaxLength = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.textBox1.Name = "textBox1";
            this.textBox1.AutoSize = false;
            this.textBox1.Size = new System.Drawing.Size(154, 53);
            this.textBox1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picChar);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(5, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 567);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Малювати";
            // 
            // picChar
            // 
            this.picChar.Location = new System.Drawing.Point(10, 22);
            this.picChar.Name = "picChar";
            this.picChar.Size = new System.Drawing.Size(542, 532);
            this.picChar.TabIndex = 0;
            this.picChar.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblAccuracy);
            this.groupBox3.Controls.Add(this.lblResult);
            this.groupBox3.Controls.Add(this.btnPredict);
            this.groupBox3.Location = new System.Drawing.Point(573, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(373, 240);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 35F);
            this.label4.Location = new System.Drawing.Point(214, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 78);
            this.label4.BackColor = Color.Empty;
            this.label4.TabIndex = 2;
            // this.label4.Text = "";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.lblAccuracy.Location = new System.Drawing.Point(101, 179);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.BackColor = Color.Empty;
            this.lblAccuracy.Size = new System.Drawing.Size(155, 41);
            this.lblAccuracy.TabIndex = 1;
            this.lblAccuracy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            // this.lblResult.BackColor = System.Drawing.SystemColors.Window;
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(71, 123);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(121, 42);
            this.lblResult.BackColor = Color.LawnGreen;
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Результат:";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 580);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.Name = "Form1";
            this.Text = "Розпізнавання рукописних символів";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picChar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTextBox;

        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.Label lblChoose;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label lblAccuracy;

        private System.Windows.Forms.Label lblResult;

        private System.Windows.Forms.Label lblTrain;

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.PictureBox picChar;

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        #endregion
}