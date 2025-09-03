namespace WinFormsControl
{
    partial class SampleControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(SampleControl));
            picView = new PictureBox();
            btnRun = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)picView).BeginInit();
            this.SuspendLayout();
            //
            // btnRun
            //
            resources.ApplyResources(btnRun, "btnRun");
            btnRun.Name = "btnRun";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            //
            // btnClear
            //
            resources.ApplyResources(btnClear, "btnClear");
            btnClear.Name = "btnClear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            //
            // picView
            //
            resources.ApplyResources(picView, "picView");
            picView.Name = "picView";
            picView.TabStop = false;
            //
            // SampleControl
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(picView);
            this.Controls.Add(btnRun);
            this.Controls.Add(btnClear);
            resources.ApplyResources(this, "$this");
            this.Name = "SampleControl";
            ((System.ComponentModel.ISupportInitialize)picView).EndInit();
            this.PerformLayout();
        }

        #endregion

        private PictureBox picView;
        private Button btnRun;
        private Button btnClear;
    }
}
