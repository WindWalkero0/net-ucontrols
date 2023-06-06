
namespace UControls.UControl.Button
{
    partial class UCBtnExt
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_Tips = new System.Windows.Forms.Label();
            this.LB_Display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_Tips
            // 
            this.LB_Tips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Tips.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Tips.ForeColor = System.Drawing.Color.White;
            this.LB_Tips.Location = new System.Drawing.Point(158, 0);
            this.LB_Tips.Name = "LB_Tips";
            this.LB_Tips.Size = new System.Drawing.Size(24, 24);
            this.LB_Tips.TabIndex = 0;
            this.LB_Tips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Tips.Visible = false;
            // 
            // LB_Display
            // 
            this.LB_Display.AutoSize = true;
            this.LB_Display.BackColor = System.Drawing.Color.Transparent;
            this.LB_Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Display.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_Display.ForeColor = System.Drawing.Color.White;
            this.LB_Display.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LB_Display.Location = new System.Drawing.Point(0, 0);
            this.LB_Display.Name = "LB_Display";
            this.LB_Display.Size = new System.Drawing.Size(90, 21);
            this.LB_Display.TabIndex = 1;
            this.LB_Display.Text = "自定义按钮";
            this.LB_Display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Display.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LB_Display_MouseClick);
            this.LB_Display.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_Display_MouseDown);
            this.LB_Display.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LB_Display_MouseUp);
            // 
            // UCBtnExt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LB_Display);
            this.Controls.Add(this.LB_Tips);
            this.CornerRadius = 5;
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IsRadius = true;
            this.IsShowRect = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCBtnExt";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.Size = new System.Drawing.Size(184, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Tips;
        public System.Windows.Forms.Label LB_Display;
    }
}
