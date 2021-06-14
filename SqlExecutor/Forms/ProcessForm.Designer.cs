
namespace SqlExecutor.Forms
{
    partial class ProcessForm
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ProcessingListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(638, 29);
            this.progressBar1.TabIndex = 0;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(669, 21);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(88, 20);
            this.StatusLabel.TabIndex = 1;
            this.StatusLabel.Text = "Processing...";
            // 
            // ProcessingListView
            // 
            this.ProcessingListView.HideSelection = false;
            this.ProcessingListView.Location = new System.Drawing.Point(12, 62);
            this.ProcessingListView.Name = "ProcessingListView";
            this.ProcessingListView.Size = new System.Drawing.Size(776, 376);
            this.ProcessingListView.TabIndex = 2;
            this.ProcessingListView.UseCompatibleStateImageBehavior = false;
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProcessingListView);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.progressBar1);
            this.Name = "ProcessForm";
            this.Text = "ProcessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ListView ProcessingListView;
    }
}