namespace Calculator
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.BtnMulti = new System.Windows.Forms.Button();
            this.TxtNum1 = new System.Windows.Forms.TextBox();
            this.TxtNum2 = new System.Windows.Forms.TextBox();
            this.TxtAns = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAns = new System.Windows.Forms.Button();
            this.LblOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(49, 104);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(99, 35);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.Location = new System.Drawing.Point(169, 104);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(99, 35);
            this.BtnSub.TabIndex = 1;
            this.BtnSub.Text = "Subtract";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Location = new System.Drawing.Point(408, 104);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(99, 35);
            this.BtnDiv.TabIndex = 3;
            this.BtnDiv.Text = "Divide";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // BtnMulti
            // 
            this.BtnMulti.Location = new System.Drawing.Point(288, 104);
            this.BtnMulti.Name = "BtnMulti";
            this.BtnMulti.Size = new System.Drawing.Size(99, 35);
            this.BtnMulti.TabIndex = 2;
            this.BtnMulti.Text = "Multiply";
            this.BtnMulti.UseVisualStyleBackColor = true;
            this.BtnMulti.Click += new System.EventHandler(this.BtnMulti_Click);
            // 
            // TxtNum1
            // 
            this.TxtNum1.Location = new System.Drawing.Point(49, 58);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(213, 24);
            this.TxtNum1.TabIndex = 4;
            // 
            // TxtNum2
            // 
            this.TxtNum2.Location = new System.Drawing.Point(341, 58);
            this.TxtNum2.Name = "TxtNum2";
            this.TxtNum2.Size = new System.Drawing.Size(213, 24);
            this.TxtNum2.TabIndex = 5;
            // 
            // TxtAns
            // 
            this.TxtAns.Location = new System.Drawing.Point(49, 232);
            this.TxtAns.Name = "TxtAns";
            this.TxtAns.Size = new System.Drawing.Size(213, 24);
            this.TxtAns.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number 2";
            // 
            // BtnAns
            // 
            this.BtnAns.Location = new System.Drawing.Point(49, 182);
            this.BtnAns.Name = "BtnAns";
            this.BtnAns.Size = new System.Drawing.Size(99, 35);
            this.BtnAns.TabIndex = 10;
            this.BtnAns.Text = "Answer";
            this.BtnAns.UseVisualStyleBackColor = true;
            this.BtnAns.Click += new System.EventHandler(this.BtnAns_Click);
            // 
            // LblOperation
            // 
            this.LblOperation.AutoSize = true;
            this.LblOperation.Location = new System.Drawing.Point(294, 65);
            this.LblOperation.Name = "LblOperation";
            this.LblOperation.Size = new System.Drawing.Size(18, 17);
            this.LblOperation.TabIndex = 11;
            this.LblOperation.Text = "w";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblOperation);
            this.Controls.Add(this.BtnAns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAns);
            this.Controls.Add(this.TxtNum2);
            this.Controls.Add(this.TxtNum1);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.BtnMulti);
            this.Controls.Add(this.BtnSub);
            this.Controls.Add(this.BtnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Button BtnMulti;
        private System.Windows.Forms.TextBox TxtNum1;
        private System.Windows.Forms.TextBox TxtNum2;
        private System.Windows.Forms.TextBox TxtAns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAns;
        private System.Windows.Forms.Label LblOperation;
    }
}

