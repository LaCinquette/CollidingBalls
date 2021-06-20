namespace PhysicsStudy
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.Circle1Mass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Circle1Radius = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Circle2Mass = new System.Windows.Forms.TextBox();
            this.Circle2Radius = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Circle1Speed = new System.Windows.Forms.TextBox();
            this.Circle2Speed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Circle1Distance = new System.Windows.Forms.TextBox();
            this.Circle2Distance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start/Restrart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Circle1Mass
            // 
            this.Circle1Mass.Location = new System.Drawing.Point(812, 5);
            this.Circle1Mass.Name = "Circle1Mass";
            this.Circle1Mass.Size = new System.Drawing.Size(64, 20);
            this.Circle1Mass.TabIndex = 2;
            this.Circle1Mass.Text = "10";
            this.Circle1Mass.Leave += new System.EventHandler(this.Circle1Mass_Leave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(882, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Масса 1 шара, кг";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(882, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Радиус 1 шара, м";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Circle1Radius
            // 
            this.Circle1Radius.Location = new System.Drawing.Point(812, 57);
            this.Circle1Radius.Name = "Circle1Radius";
            this.Circle1Radius.Size = new System.Drawing.Size(64, 20);
            this.Circle1Radius.TabIndex = 4;
            this.Circle1Radius.Text = "2";
            this.Circle1Radius.Leave += new System.EventHandler(this.Circle1Radius_Leave);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(882, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Масса 2 шара, кг";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Circle2Mass
            // 
            this.Circle2Mass.Location = new System.Drawing.Point(812, 31);
            this.Circle2Mass.Name = "Circle2Mass";
            this.Circle2Mass.Size = new System.Drawing.Size(64, 20);
            this.Circle2Mass.TabIndex = 6;
            this.Circle2Mass.Text = "10";
            this.Circle2Mass.Leave += new System.EventHandler(this.Circle2Mass_Leave);
            // 
            // Circle2Radius
            // 
            this.Circle2Radius.Location = new System.Drawing.Point(812, 83);
            this.Circle2Radius.Name = "Circle2Radius";
            this.Circle2Radius.Size = new System.Drawing.Size(64, 20);
            this.Circle2Radius.TabIndex = 9;
            this.Circle2Radius.Text = "2";
            this.Circle2Radius.Leave += new System.EventHandler(this.Circle2Radius_Leave);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(882, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Радиус 2 шара, м";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 601);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Упругое";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(106, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.Text = "Неупругое";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(812, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 36);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // Circle1Speed
            // 
            this.Circle1Speed.Location = new System.Drawing.Point(812, 109);
            this.Circle1Speed.Name = "Circle1Speed";
            this.Circle1Speed.Size = new System.Drawing.Size(64, 20);
            this.Circle1Speed.TabIndex = 15;
            this.Circle1Speed.Text = "10";
            this.Circle1Speed.Leave += new System.EventHandler(this.Circle1Speed_Leave);
            // 
            // Circle2Speed
            // 
            this.Circle2Speed.Location = new System.Drawing.Point(812, 135);
            this.Circle2Speed.Name = "Circle2Speed";
            this.Circle2Speed.Size = new System.Drawing.Size(64, 20);
            this.Circle2Speed.TabIndex = 16;
            this.Circle2Speed.Text = "5";
            this.Circle2Speed.Leave += new System.EventHandler(this.Circle2Speed_Leave);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(882, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Скорость 1 шара, м/с";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(882, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Скорость 2 шара, м/с";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Circle1Distance
            // 
            this.Circle1Distance.Location = new System.Drawing.Point(812, 161);
            this.Circle1Distance.Name = "Circle1Distance";
            this.Circle1Distance.Size = new System.Drawing.Size(64, 20);
            this.Circle1Distance.TabIndex = 19;
            this.Circle1Distance.Text = "10";
            this.Circle1Distance.Leave += new System.EventHandler(this.Circle1Distance_Leave);
            // 
            // Circle2Distance
            // 
            this.Circle2Distance.Location = new System.Drawing.Point(812, 187);
            this.Circle2Distance.Name = "Circle2Distance";
            this.Circle2Distance.Size = new System.Drawing.Size(64, 20);
            this.Circle2Distance.TabIndex = 20;
            this.Circle2Distance.Text = "20";
            this.Circle2Distance.Leave += new System.EventHandler(this.Circle2Distance_Leave);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(882, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Положение 2 шара, м";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(882, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Положение 2 шара, м";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 615);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Circle2Distance);
            this.Controls.Add(this.Circle1Distance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Circle2Speed);
            this.Controls.Add(this.Circle1Speed);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Circle2Radius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Circle2Mass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Circle1Radius);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Circle1Mass);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Рисование графика";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Circle1Mass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Circle1Radius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Circle2Mass;
        private System.Windows.Forms.TextBox Circle2Radius;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Circle1Speed;
        private System.Windows.Forms.TextBox Circle2Speed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Circle1Distance;
        private System.Windows.Forms.TextBox Circle2Distance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

