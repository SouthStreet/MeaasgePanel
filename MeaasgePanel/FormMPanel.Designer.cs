namespace MeaasgePanel
{
    partial class FormMPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMPanel));
            this.iltMPanel = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelShowTime = new System.Windows.Forms.Label();
            this.tbxShowTrace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // iltMPanel
            // 
            this.iltMPanel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iltMPanel.ImageStream")));
            this.iltMPanel.TransparentColor = System.Drawing.Color.Transparent;
            this.iltMPanel.Images.SetKeyName(0, "ban.png");
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelShowTime
            // 
            this.labelShowTime.AutoSize = true;
            this.labelShowTime.Location = new System.Drawing.Point(620, 4);
            this.labelShowTime.Name = "labelShowTime";
            this.labelShowTime.Size = new System.Drawing.Size(0, 12);
            this.labelShowTime.TabIndex = 0;
            // 
            // tbxShowTrace
            // 
            this.tbxShowTrace.Location = new System.Drawing.Point(773, 26);
            this.tbxShowTrace.Multiline = true;
            this.tbxShowTrace.Name = "tbxShowTrace";
            this.tbxShowTrace.Size = new System.Drawing.Size(234, 348);
            this.tbxShowTrace.TabIndex = 1;
            // 
            // FormMPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 405);
            this.Controls.Add(this.tbxShowTrace);
            this.Controls.Add(this.labelShowTime);
            this.Name = "FormMPanel";
            this.Text = "FormMPanel";
            this.Load += new System.EventHandler(this.FormMPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList iltMPanel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelShowTime;
        private System.Windows.Forms.TextBox tbxShowTrace;
    }
}