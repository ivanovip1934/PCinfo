namespace PCinfo
{
    partial class PCInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PCInfo));
            this.buttongetinfo = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpcname = new System.Windows.Forms.Label();
            this.lblipadress = new System.Windows.Forms.Label();
            this.butTestNet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbllocalnet = new System.Windows.Forms.Label();
            this.lblglobalnet = new System.Windows.Forms.Label();
            this.lblEMTS = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttongetinfo
            // 
            this.buttongetinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttongetinfo.Location = new System.Drawing.Point(470, 348);
            this.buttongetinfo.Name = "buttongetinfo";
            this.buttongetinfo.Size = new System.Drawing.Size(251, 47);
            this.buttongetinfo.TabIndex = 0;
            this.buttongetinfo.Text = "Запросить";
            this.buttongetinfo.UseVisualStyleBackColor = true;
            this.buttongetinfo.Visible = false;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblusername.Location = new System.Drawing.Point(6, 37);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(102, 37);
            this.lblusername.TabIndex = 3;
            this.lblusername.Text = "label3";
            this.lblusername.Visible = false;
            // 
            // lblpcname
            // 
            this.lblpcname.AutoSize = true;
            this.lblpcname.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblpcname.Location = new System.Drawing.Point(6, 37);
            this.lblpcname.Name = "lblpcname";
            this.lblpcname.Size = new System.Drawing.Size(102, 37);
            this.lblpcname.TabIndex = 4;
            this.lblpcname.Text = "label4";
            this.lblpcname.Visible = false;
            // 
            // lblipadress
            // 
            this.lblipadress.AutoSize = true;
            this.lblipadress.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblipadress.Location = new System.Drawing.Point(6, 37);
            this.lblipadress.Name = "lblipadress";
            this.lblipadress.Size = new System.Drawing.Size(102, 37);
            this.lblipadress.TabIndex = 6;
            this.lblipadress.Text = "label4";
            this.lblipadress.Visible = false;
            // 
            // butTestNet
            // 
            this.butTestNet.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butTestNet.Location = new System.Drawing.Point(630, 249);
            this.butTestNet.Name = "butTestNet";
            this.butTestNet.Size = new System.Drawing.Size(124, 61);
            this.butTestNet.TabIndex = 9;
            this.butTestNet.Text = "ТЕСТ";
            this.butTestNet.UseVisualStyleBackColor = true;
            this.butTestNet.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "Локальная сеть";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "Глобальная сеть";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 37);
            this.label8.TabIndex = 13;
            this.label8.Text = "ЕМТС сеть";
            // 
            // lbllocalnet
            // 
            this.lbllocalnet.AutoSize = true;
            this.lbllocalnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbllocalnet.Location = new System.Drawing.Point(287, 37);
            this.lbllocalnet.Name = "lbllocalnet";
            this.lbllocalnet.Size = new System.Drawing.Size(127, 37);
            this.lbllocalnet.TabIndex = 14;
            this.lbllocalnet.Text = "localnet";
            this.lbllocalnet.Visible = false;
            // 
            // lblglobalnet
            // 
            this.lblglobalnet.AutoSize = true;
            this.lblglobalnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblglobalnet.Location = new System.Drawing.Point(287, 95);
            this.lblglobalnet.Name = "lblglobalnet";
            this.lblglobalnet.Size = new System.Drawing.Size(147, 37);
            this.lblglobalnet.TabIndex = 15;
            this.lblglobalnet.Text = "globalnet";
            this.lblglobalnet.Visible = false;
            // 
            // lblEMTS
            // 
            this.lblEMTS.AutoSize = true;
            this.lblEMTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEMTS.Location = new System.Drawing.Point(287, 154);
            this.lblEMTS.Name = "lblEMTS";
            this.lblEMTS.Size = new System.Drawing.Size(130, 37);
            this.lblEMTS.TabIndex = 16;
            this.lblEMTS.Text = "emtsnet";
            this.lblEMTS.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblusername);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(56, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 90);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Имя пользователя";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblpcname);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(56, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 90);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Имя компьютера";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblipadress);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(56, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(396, 219);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Адресс(а) компьютера";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.lbllocalnet);
            this.groupBox4.Controls.Add(this.lblEMTS);
            this.groupBox4.Controls.Add(this.lblglobalnet);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(480, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(395, 206);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Состояние сети";
            // 
            // PCInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 461);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.butTestNet);
            this.Controls.Add(this.buttongetinfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PCInfo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARM info";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttongetinfo;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpcname;
        private System.Windows.Forms.Label lblipadress;
        private System.Windows.Forms.Button butTestNet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbllocalnet;
        private System.Windows.Forms.Label lblglobalnet;
        private System.Windows.Forms.Label lblEMTS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

