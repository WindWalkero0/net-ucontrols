
namespace UControls
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
            this.ucBtnExt1 = new UControls.UControl.Button.UCBtnExt();
            this.SuspendLayout();
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = null;
            this.ucBtnExt1.CornerRadius = 5;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnableMouseEffect = false;
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = true;
            this.ucBtnExt1.Location = new System.Drawing.Point(88, 51);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(184, 60);
            this.ucBtnExt1.TabIndex = 0;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsText = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucBtnExt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UControl.Button.UCBtnExt ucBtnExt1;
    }
}