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
            this.SuspendLayout();
            // 
            // iltMPanel
            // 
            this.iltMPanel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iltMPanel.ImageStream")));
            this.iltMPanel.TransparentColor = System.Drawing.Color.Transparent;
            this.iltMPanel.Images.SetKeyName(0, "ban.png");
            // 
            // FormMPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 335);
            this.Name = "FormMPanel";
            this.Text = "FormMPanel";
            this.Load += new System.EventHandler(this.FormMPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList iltMPanel;
    }
}