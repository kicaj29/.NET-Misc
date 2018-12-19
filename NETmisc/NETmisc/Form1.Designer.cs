namespace NETmisc
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
            this.btnThrowVsThrowEx = new System.Windows.Forms.Button();
            this.btnCovarianceAndContravariance = new System.Windows.Forms.Button();
            this.btnDoubleQuestionMark = new System.Windows.Forms.Button();
            this.btnTryCatchFinally = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThrowVsThrowEx
            // 
            this.btnThrowVsThrowEx.Location = new System.Drawing.Point(21, 12);
            this.btnThrowVsThrowEx.Name = "btnThrowVsThrowEx";
            this.btnThrowVsThrowEx.Size = new System.Drawing.Size(189, 23);
            this.btnThrowVsThrowEx.TabIndex = 0;
            this.btnThrowVsThrowEx.Text = "Throw vs ThrowEx";
            this.btnThrowVsThrowEx.UseVisualStyleBackColor = true;
            this.btnThrowVsThrowEx.Click += new System.EventHandler(this.btnThrowVsThrowEx_Click);
            // 
            // btnCovarianceAndContravariance
            // 
            this.btnCovarianceAndContravariance.Location = new System.Drawing.Point(21, 69);
            this.btnCovarianceAndContravariance.Name = "btnCovarianceAndContravariance";
            this.btnCovarianceAndContravariance.Size = new System.Drawing.Size(189, 23);
            this.btnCovarianceAndContravariance.TabIndex = 1;
            this.btnCovarianceAndContravariance.Text = "CovarianceAndContravariance";
            this.btnCovarianceAndContravariance.UseVisualStyleBackColor = true;
            this.btnCovarianceAndContravariance.Click += new System.EventHandler(this.btnCovarianceAndContravariance_Click);
            // 
            // btnDoubleQuestionMark
            // 
            this.btnDoubleQuestionMark.Location = new System.Drawing.Point(21, 137);
            this.btnDoubleQuestionMark.Name = "btnDoubleQuestionMark";
            this.btnDoubleQuestionMark.Size = new System.Drawing.Size(189, 23);
            this.btnDoubleQuestionMark.TabIndex = 2;
            this.btnDoubleQuestionMark.Text = "??";
            this.btnDoubleQuestionMark.UseVisualStyleBackColor = true;
            this.btnDoubleQuestionMark.Click += new System.EventHandler(this.btnDoubleQuestionMark_Click);
            // 
            // btnTryCatchFinally
            // 
            this.btnTryCatchFinally.Location = new System.Drawing.Point(230, 12);
            this.btnTryCatchFinally.Name = "btnTryCatchFinally";
            this.btnTryCatchFinally.Size = new System.Drawing.Size(189, 23);
            this.btnTryCatchFinally.TabIndex = 3;
            this.btnTryCatchFinally.Text = "TryCatchFinally";
            this.btnTryCatchFinally.UseVisualStyleBackColor = true;
            this.btnTryCatchFinally.Click += new System.EventHandler(this.btnTryCatchFinally_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 351);
            this.Controls.Add(this.btnTryCatchFinally);
            this.Controls.Add(this.btnDoubleQuestionMark);
            this.Controls.Add(this.btnCovarianceAndContravariance);
            this.Controls.Add(this.btnThrowVsThrowEx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThrowVsThrowEx;
        private System.Windows.Forms.Button btnCovarianceAndContravariance;
        private System.Windows.Forms.Button btnDoubleQuestionMark;
        private System.Windows.Forms.Button btnTryCatchFinally;
    }
}

