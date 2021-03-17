
namespace SP_Execute
{
    partial class ExecuteNonQuery
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
            this.txtExec = new System.Windows.Forms.Label();
            this.lblExecuter = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // txtExec
            // 
            this.txtExec.AutoSize = true;
            this.txtExec.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExec.Location = new System.Drawing.Point(12, 9);
            this.txtExec.Name = "txtExec";
            this.txtExec.Size = new System.Drawing.Size(366, 74);
            this.txtExec.TabIndex = 0;
            this.txtExec.Text = "Executed: ";
            // 
            // lblExecuter
            // 
            this.lblExecuter.AutoSize = true;
            this.lblExecuter.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExecuter.Location = new System.Drawing.Point(391, 9);
            this.lblExecuter.Name = "lblExecuter";
            this.lblExecuter.Size = new System.Drawing.Size(71, 74);
            this.lblExecuter.TabIndex = 1;
            this.lblExecuter.Text = "0";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(71, 109);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(249, 74);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "Errors:";
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrors.Location = new System.Drawing.Point(391, 109);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(71, 74);
            this.lblErrors.TabIndex = 3;
            this.lblErrors.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 55);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ultima Ejecucion:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(693, 109);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(205, 55);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "this.data";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // ExecuteNonQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1040, 192);
            this.ControlBox = false;
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblExecuter);
            this.Controls.Add(this.txtExec);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "ExecuteNonQuery";
            this.Text = "ExecuteNonQuery";
            this.Load += new System.EventHandler(this.ExecuteNonQuery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtExec;
        private System.Windows.Forms.Label lblExecuter;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblData;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}