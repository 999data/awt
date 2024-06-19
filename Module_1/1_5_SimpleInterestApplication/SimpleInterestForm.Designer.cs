namespace SimpleInterestApplication
{
    partial class SimpleInterestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pamount = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple Interest Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Principle Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Years";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Rate of Interest";
            // 
            // pamount
            // 
            this.pamount.Location = new System.Drawing.Point(364, 112);
            this.pamount.Name = "pamount";
            this.pamount.Size = new System.Drawing.Size(341, 22);
            this.pamount.TabIndex = 4;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(364, 178);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(341, 22);
            this.txtyear.TabIndex = 5;
            // 
            // txtrate
            // 
            this.txtrate.Location = new System.Drawing.Point(364, 246);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(341, 22);
            this.txtrate.TabIndex = 6;
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.Location = new System.Drawing.Point(291, 322);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(207, 74);
            this.Calculate.TabIndex = 7;
            this.Calculate.Text = "CALCULATE";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // SimpleInterestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.txtrate);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.pamount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SimpleInterestForm";
            this.Text = "SimpleInterestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pamount;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.Button Calculate;
    }
}

