namespace JuiceWindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.mix2 = new System.Windows.Forms.RadioButton();
            this.mix3 = new System.Windows.Forms.RadioButton();
            this.isMember = new System.Windows.Forms.RadioButton();
            this.isNotMember = new System.Windows.Forms.RadioButton();
            this.submit = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.Q = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mangoCheckBox = new System.Windows.Forms.CheckBox();
            this.pineappleCheckBox = new System.Windows.Forms.CheckBox();
            this.kiwiCheckBox = new System.Windows.Forms.CheckBox();
            this.appleCheckBox = new System.Windows.Forms.CheckBox();
            this.bananaCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mix4 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Q)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mix2
            // 
            this.mix2.AutoSize = true;
            this.mix2.Location = new System.Drawing.Point(6, 27);
            this.mix2.Name = "mix2";
            this.mix2.Size = new System.Drawing.Size(110, 16);
            this.mix2.TabIndex = 3;
            this.mix2.TabStop = true;
            this.mix2.Text = "2種水果混和 $25";
            this.mix2.UseVisualStyleBackColor = true;
            // 
            // mix3
            // 
            this.mix3.AutoSize = true;
            this.mix3.Location = new System.Drawing.Point(6, 49);
            this.mix3.Name = "mix3";
            this.mix3.Size = new System.Drawing.Size(110, 16);
            this.mix3.TabIndex = 4;
            this.mix3.TabStop = true;
            this.mix3.Text = "3種水果混和 $30";
            this.mix3.UseVisualStyleBackColor = true;
            // 
            // isMember
            // 
            this.isMember.AutoSize = true;
            this.isMember.Location = new System.Drawing.Point(6, 33);
            this.isMember.Name = "isMember";
            this.isMember.Size = new System.Drawing.Size(91, 16);
            this.isMember.TabIndex = 6;
            this.isMember.TabStop = true;
            this.isMember.Text = "是(九折優惠)";
            this.isMember.UseVisualStyleBackColor = true;
            // 
            // isNotMember
            // 
            this.isNotMember.AutoSize = true;
            this.isNotMember.Location = new System.Drawing.Point(6, 59);
            this.isNotMember.Name = "isNotMember";
            this.isNotMember.Size = new System.Drawing.Size(91, 16);
            this.isNotMember.TabIndex = 7;
            this.isNotMember.TabStop = true;
            this.isNotMember.Text = "否(原價計算)";
            this.isNotMember.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(738, 412);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(142, 52);
            this.submit.TabIndex = 8;
            this.submit.Text = "點餐";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(557, 505);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(142, 44);
            this.reset.TabIndex = 9;
            this.reset.Text = "清除";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(738, 500);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(142, 49);
            this.exit.TabIndex = 10;
            this.exit.Text = "離開";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Q
            // 
            this.Q.Location = new System.Drawing.Point(68, 52);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(120, 22);
            this.Q.TabIndex = 12;
            this.Q.ValueChanged += new System.EventHandler(this.Q_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mangoCheckBox);
            this.groupBox1.Controls.Add(this.pineappleCheckBox);
            this.groupBox1.Controls.Add(this.kiwiCheckBox);
            this.groupBox1.Controls.Add(this.appleCheckBox);
            this.groupBox1.Controls.Add(this.bananaCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(63, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 192);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選擇水果";
            // 
            // mangoCheckBox
            // 
            this.mangoCheckBox.AutoSize = true;
            this.mangoCheckBox.Location = new System.Drawing.Point(6, 129);
            this.mangoCheckBox.Name = "mangoCheckBox";
            this.mangoCheckBox.Size = new System.Drawing.Size(48, 16);
            this.mangoCheckBox.TabIndex = 4;
            this.mangoCheckBox.Text = "芒果";
            this.mangoCheckBox.UseVisualStyleBackColor = true;
            // 
            // pineappleCheckBox
            // 
            this.pineappleCheckBox.AutoSize = true;
            this.pineappleCheckBox.Location = new System.Drawing.Point(7, 106);
            this.pineappleCheckBox.Name = "pineappleCheckBox";
            this.pineappleCheckBox.Size = new System.Drawing.Size(48, 16);
            this.pineappleCheckBox.TabIndex = 3;
            this.pineappleCheckBox.Text = "鳳梨";
            this.pineappleCheckBox.UseVisualStyleBackColor = true;
            // 
            // kiwiCheckBox
            // 
            this.kiwiCheckBox.AutoSize = true;
            this.kiwiCheckBox.Location = new System.Drawing.Point(7, 83);
            this.kiwiCheckBox.Name = "kiwiCheckBox";
            this.kiwiCheckBox.Size = new System.Drawing.Size(60, 16);
            this.kiwiCheckBox.TabIndex = 2;
            this.kiwiCheckBox.Text = "奇異果";
            this.kiwiCheckBox.UseVisualStyleBackColor = true;
            // 
            // appleCheckBox
            // 
            this.appleCheckBox.AutoSize = true;
            this.appleCheckBox.Location = new System.Drawing.Point(7, 63);
            this.appleCheckBox.Name = "appleCheckBox";
            this.appleCheckBox.Size = new System.Drawing.Size(48, 16);
            this.appleCheckBox.TabIndex = 1;
            this.appleCheckBox.Text = "蘋果";
            this.appleCheckBox.UseVisualStyleBackColor = true;
            // 
            // bananaCheckbox
            // 
            this.bananaCheckbox.AutoSize = true;
            this.bananaCheckbox.Location = new System.Drawing.Point(7, 41);
            this.bananaCheckbox.Name = "bananaCheckbox";
            this.bananaCheckbox.Size = new System.Drawing.Size(48, 16);
            this.bananaCheckbox.TabIndex = 0;
            this.bananaCheckbox.Text = "香蕉";
            this.bananaCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mix4);
            this.groupBox2.Controls.Add(this.mix2);
            this.groupBox2.Controls.Add(this.mix3);
            this.groupBox2.Location = new System.Drawing.Point(63, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 119);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "選擇類型";
            // 
            // mix4
            // 
            this.mix4.AutoSize = true;
            this.mix4.Location = new System.Drawing.Point(6, 72);
            this.mix4.Name = "mix4";
            this.mix4.Size = new System.Drawing.Size(110, 16);
            this.mix4.TabIndex = 5;
            this.mix4.TabStop = true;
            this.mix4.Text = "4種水果混和 $40";
            this.mix4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.isMember);
            this.groupBox3.Controls.Add(this.isNotMember);
            this.groupBox3.Location = new System.Drawing.Point(385, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 119);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "是否為會員?";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Q);
            this.groupBox4.Location = new System.Drawing.Point(385, 181);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(234, 119);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "選擇份數";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 50);
            this.label1.TabIndex = 17;
            this.label1.Text = "點餐菜單";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(35, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "步驟1.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(35, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "步驟2.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(370, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "步驟3.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 590);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.submit);
            this.Name = "Form1";
            this.Text = "點餐菜單　2018.10.03   ( A107222011 林紘毅)";
            ((System.ComponentModel.ISupportInitialize)(this.Q)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton mix2;
        private System.Windows.Forms.RadioButton mix3;
        private System.Windows.Forms.RadioButton isMember;
        private System.Windows.Forms.RadioButton isNotMember;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.NumericUpDown Q;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox mangoCheckBox;
        private System.Windows.Forms.CheckBox pineappleCheckBox;
        private System.Windows.Forms.CheckBox kiwiCheckBox;
        private System.Windows.Forms.CheckBox appleCheckBox;
        private System.Windows.Forms.CheckBox bananaCheckbox;
        private System.Windows.Forms.RadioButton mix4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

