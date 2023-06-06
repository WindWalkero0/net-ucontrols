using System;
using System.ComponentModel;
using System.Drawing;
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

        /// <summary>
        /// 是否显示角标
        /// </summary>
        /// <value><c>true</c> if the instance is show tips, otherwise <c>false</c>.</value>
        [Description("是否显示角标"), Category("自定义")]
        public bool IsShowTips
        {
            get
            {
                return LB_Tips.Visible;
            }
            set
            {
                LB_Tips.Visible = value;
            }
        }

        /// <summary>
        /// 角标文字
        /// </summary>
        /// <value>the tips text.</value>
        [Description("角标文字"), Category("自定义")]
        public string TipsText
        {
            get
            {
                return LB_Tips.Text;
            }
            set
            {
                LB_Tips.Text = value;
            }
        }

        /// <summary>
        /// the label tips color
        /// </summary>
        private Color m_tipsColor = Color.FromArgb(232, 30, 99);
        /// <summary>
        /// 角标颜色
        /// </summary>
        /// <value >the color of the label tips.</value>
        public Color TipsColor
        {
            get { return m_tipsColor; }
            set { m_tipsColor = value; }
        }

        /// <summary>
        /// the button background color.
        /// </summary>
        private Color _btnBackColor = Color.White;
        /// <summary>
        /// 按钮背景色
        /// </summary>
        /// <value>the color of the button background.</value>
        public Color BtnBackColor
        {
            get { return _btnBackColor; }
            set
            {
                _btnBackColor = value;
                BackColor = value;
            }
        }

        /// <summary>
        /// the button fore color.
        /// </summary>
        private Color _btnForeColor = Color.White;
        /// <summary>
        /// 按钮字体颜色
        /// </summary>
        /// <value>the color of the button fore.</value>
        [Description("按钮字体颜色"), Category("自定义")]
        public Color BtnForeColor
        {
            get { return _btnForeColor; }
            set
            {
                _btnForeColor = value;
                LB_Display.ForeColor = value;
            }
        }

        /// <summary>
        /// the button font
        /// </summary>
        private Font _btnFont = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
        /// <summary>
        /// 按钮字体
        /// </summary>
        /// <value>the button font.</value>
        [Description("按钮字体"), Category("自定义")]
        public Font BtnFont
        {
            get { return _btnFont; }
            set
            {
                _btnFont = value;
                LB_Display.Font = value;
            }
        }

        /// <summary>
        /// 按钮点击事件
        /// </summary>
        [Description("按钮点击事件"), Category("自定义")]
        public event EventHandler BtnClick;

        /// <summary>
        /// 按钮按下事件
        /// </summary>
        [Description("按钮按下事件"), Category("自定义")]
        public event EventHandler BtnMouseDown;

        /// <summary>
        /// 按钮抬起事件
        /// </summary>
        [Description("按钮抬起事件"), Category("自定义")]
        public event EventHandler BtnMouseUp;

        /// <summary>
        /// the button text
        /// </summary>
        private string _btnText;

        /// <summary>
        /// 按钮文字
        /// </summary>
        /// <value>the button text.</value>
        [Description("按钮文字"), Category("自定义")]
        public virtual string BtnText
        {
            get { return _btnText; }
            set
            {
                _btnText = value;
                LB_Display.Text = value;
            }
        }

        [Description("鼠标效果生效时发生，需要和 MouseEffected 同时使用，否则无效"), Category("自定义")]
        public event EventHandler MouseEffecting;

        [Description("鼠标效果结束时发生，需要和 MouseEffecting 同时使用，否则无效"), Category("自定义")]
        public event EventHandler MouseEffected;
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
