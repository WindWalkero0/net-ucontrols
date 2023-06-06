using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UControls.Helpers;

namespace UControls.UControl.Button
{
    /// <summary>
    /// Class UCBtnExt.
    /// Implements the <see cref="UControlBase"/>
    /// </summary>
    /// <seealso cref="UControlBase"/>
    [DefaultEvent("BtnClick")]

    public partial class UCBtnExt : UControlBase
    {
        #region 字段属性
        private bool enableMouseEffect = false;
        [Description("是否启用鼠标效果"), Category("自定义")]
        public bool EnableMouseEffect
        {
            get { return this.enableMouseEffect; }
            set { enableMouseEffect = value; }
        }
        #endregion

        public UCBtnExt()
        {
            InitializeComponent();
            TabStop = false;
            LB_Tips.Paint += LB_Tips_Paint;
            LB_Display.MouseEnter += LB_Display_MouseEnter;
            LB_Display.MouseLeave += LB_Display_MouseLeave;
        }

        Color cacheColor = Color.Empty;

        private void LB_Display_MouseLeave(object sender, EventArgs e)
        {
            if (enableMouseEffect)
            {
                if (MouseEffecting != null && MouseEffected != null)
                {
                    MouseEffected(this, e);
                }
                else
                {
                    if (cacheColor != Color.Empty)
                    {
                        FillColor = cacheColor;
                        cacheColor = Color.Empty;
                    }
                }
            }
        }

        private void LB_Display_MouseEnter(object sender, EventArgs e)
        {
            if (enableMouseEffect)
            {
                if (MouseEffecting != null && MouseEffected != null)
                {
                    MouseEffecting(this, e);
                }
                else
                {
                    if (FillColor != Color.Empty && FillColor != null)
                    {
                        cacheColor = FillColor;
                        FillColor = FillColor.ChangeColor(-0.2f);
                    }
                }
            }
        }

        /// <summary>
        /// handles the paint event of the LB_Tips control.
        /// </summary>
        /// <param name="sender">the source of the event.</param>
        /// <param name="e">the <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void LB_Tips_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SetGDIHigh();
            e.Graphics.FillEllipse(new SolidBrush(m_tipsColor), new Rectangle(0, 0, LB_Tips.Width - 1, LB_Tips.Height - 1));
            SizeF sizeEnd = e.Graphics.MeasureString(TipsText, LB_Tips.Font);
            e.Graphics.DrawString(TipsText, LB_Tips.Font, new SolidBrush(LB_Tips.ForeColor), new PointF((LB_Tips.Width - sizeEnd.Width) / 2, (LB_Tips.Height - sizeEnd.Height) / 2 + 1));
        }

        private void LB_Display_MouseClick(object sender, MouseEventArgs e)
        {
            BtnClick?.Invoke(this, e);
        }

        private void LB_Display_MouseDown(object sender, MouseEventArgs e)
        {
            BtnMouseDown?.Invoke(this, e);
        }

        private void LB_Display_MouseUp(object sender, MouseEventArgs e)
        {
            BtnMouseUp?.Invoke(this, e);
        }
    }
}
