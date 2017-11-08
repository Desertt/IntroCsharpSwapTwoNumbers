namespace IntroCsharpSwapTwoNumbers
{
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelResultN2 = new System.Windows.Forms.Label();
            this.labelResultNumber2 = new System.Windows.Forms.Label();
            this.labelFirstNumber = new System.Windows.Forms.Label();
            this.labelResultN1 = new System.Windows.Forms.Label();
            this.textBoxNumber1 = new System.Windows.Forms.TextBox();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelResultNumber1 = new System.Windows.Forms.Label();
            this.textBoxNumber2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelResultN2);
            this.groupBox1.Controls.Add(this.labelResultNumber2);
            this.groupBox1.Controls.Add(this.labelFirstNumber);
            this.groupBox1.Controls.Add(this.labelResultN1);
            this.groupBox1.Controls.Add(this.textBoxNumber1);
            this.groupBox1.Controls.Add(this.buttonSwap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelResultNumber1);
            this.groupBox1.Controls.Add(this.textBoxNumber2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 211);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sayıların Yerini Değiştirme/Swap two numbers";
            // 
            // labelResultN2
            // 
            this.labelResultN2.Location = new System.Drawing.Point(131, 165);
            this.labelResultN2.Name = "labelResultN2";
            this.labelResultN2.Size = new System.Drawing.Size(83, 24);
            this.labelResultN2.TabIndex = 22;
            this.labelResultN2.Text = "0";
            // 
            // labelResultNumber2
            // 
            this.labelResultNumber2.Location = new System.Drawing.Point(0, 165);
            this.labelResultNumber2.Name = "labelResultNumber2";
            this.labelResultNumber2.Size = new System.Drawing.Size(125, 22);
            this.labelResultNumber2.TabIndex = 21;
            this.labelResultNumber2.Text = "Sonuç:/Result-Number2:";
            // 
            // labelFirstNumber
            // 
            this.labelFirstNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelFirstNumber.Location = new System.Drawing.Point(356, 102);
            this.labelFirstNumber.Name = "labelFirstNumber";
            this.labelFirstNumber.Size = new System.Drawing.Size(74, 85);
            this.labelFirstNumber.TabIndex = 20;
            // 
            // labelResultN1
            // 
            this.labelResultN1.Location = new System.Drawing.Point(131, 139);
            this.labelResultN1.Name = "labelResultN1";
            this.labelResultN1.Size = new System.Drawing.Size(83, 24);
            this.labelResultN1.TabIndex = 11;
            this.labelResultN1.Text = "0";
            // 
            // textBoxNumber1
            // 
            this.textBoxNumber1.Location = new System.Drawing.Point(230, 28);
            this.textBoxNumber1.Name = "textBoxNumber1";
            this.textBoxNumber1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber1.TabIndex = 2;
            // 
            // buttonSwap
            // 
            this.buttonSwap.Location = new System.Drawing.Point(213, 93);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(117, 30);
            this.buttonSwap.TabIndex = 6;
            this.buttonSwap.Text = "Değiştir/Swap";
            this.buttonSwap.UseVisualStyleBackColor = true;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "İkinci Sayıyı Giriniz:/Enter Second Number:";
            // 
            // labelResultNumber1
            // 
            this.labelResultNumber1.Location = new System.Drawing.Point(0, 141);
            this.labelResultNumber1.Name = "labelResultNumber1";
            this.labelResultNumber1.Size = new System.Drawing.Size(125, 24);
            this.labelResultNumber1.TabIndex = 7;
            this.labelResultNumber1.Text = "Sonuç:/Result-Number1:";
            // 
            // textBoxNumber2
            // 
            this.textBoxNumber2.Location = new System.Drawing.Point(230, 63);
            this.textBoxNumber2.Name = "textBoxNumber2";
            this.textBoxNumber2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumber2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Birinci Sayıyı Giriniz:/Enter First Number:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 211);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayıların Yerini Değiştirme/Swap two numbers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelResultN2;
        private System.Windows.Forms.Label labelResultNumber2;
        private System.Windows.Forms.Label labelFirstNumber;
        private System.Windows.Forms.Label labelResultN1;
        private System.Windows.Forms.TextBox textBoxNumber1;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelResultNumber1;
        private System.Windows.Forms.TextBox textBoxNumber2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

