namespace menuWindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.redteaQ = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.greenteaQ = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.milkteaQ = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.oder = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.isMember = new System.Windows.Forms.RadioButton();
            this.isNotMember = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.redteaQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenteaQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkteaQ)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(27, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "紅茶 $20";
            // 
            // redteaQ
            // 
            this.redteaQ.Location = new System.Drawing.Point(166, 79);
            this.redteaQ.Name = "redteaQ";
            this.redteaQ.Size = new System.Drawing.Size(120, 22);
            this.redteaQ.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(29, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "綠茶 $20";
            // 
            // greenteaQ
            // 
            this.greenteaQ.Location = new System.Drawing.Point(166, 146);
            this.greenteaQ.Name = "greenteaQ";
            this.greenteaQ.Size = new System.Drawing.Size(120, 22);
            this.greenteaQ.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(29, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "奶茶 $25";
            // 
            // milkteaQ
            // 
            this.milkteaQ.Location = new System.Drawing.Point(166, 224);
            this.milkteaQ.Name = "milkteaQ";
            this.milkteaQ.Size = new System.Drawing.Size(120, 22);
            this.milkteaQ.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(29, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "請問您是否為會員?";
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.result.Font = new System.Drawing.Font("新細明體", 15F);
            this.result.Location = new System.Drawing.Point(332, 65);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(427, 254);
            this.result.TabIndex = 9;
            // 
            // oder
            // 
            this.oder.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.oder.Location = new System.Drawing.Point(600, 380);
            this.oder.Name = "oder";
            this.oder.Size = new System.Drawing.Size(159, 60);
            this.oder.TabIndex = 10;
            this.oder.Text = "點餐";
            this.oder.UseVisualStyleBackColor = true;
            this.oder.Click += new System.EventHandler(this.oder_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exit.Location = new System.Drawing.Point(600, 463);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(159, 60);
            this.exit.TabIndex = 11;
            this.exit.Text = "離開";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // isMember
            // 
            this.isMember.AutoSize = true;
            this.isMember.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.isMember.Location = new System.Drawing.Point(35, 435);
            this.isMember.Name = "isMember";
            this.isMember.Size = new System.Drawing.Size(138, 20);
            this.isMember.TabIndex = 12;
            this.isMember.TabStop = true;
            this.isMember.Text = "是(享9折優惠)";
            this.isMember.UseVisualStyleBackColor = true;
            this.isMember.CheckedChanged += new System.EventHandler(this.isMember_CheckedChanged);
            // 
            // isNotMember
            // 
            this.isNotMember.AutoSize = true;
            this.isNotMember.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.isNotMember.Location = new System.Drawing.Point(33, 484);
            this.isNotMember.Name = "isNotMember";
            this.isNotMember.Size = new System.Drawing.Size(43, 20);
            this.isNotMember.TabIndex = 13;
            this.isNotMember.TabStop = true;
            this.isNotMember.Text = "否";
            this.isNotMember.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 578);
            this.Controls.Add(this.isNotMember);
            this.Controls.Add(this.isMember);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.oder);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.milkteaQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.greenteaQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.redteaQ);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "點餐機 2018.10.03";
            ((System.ComponentModel.ISupportInitialize)(this.redteaQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenteaQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkteaQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown redteaQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown greenteaQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown milkteaQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button oder;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.RadioButton isMember;
        private System.Windows.Forms.RadioButton isNotMember;
    }
}

