using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UControls.UControl
{
    /// <summary>
    /// Class UControlBase.
    /// Implements the <see cref="UserControl"/>
    /// Implements the <see cref="IContainerControl"/>
    /// </summary>
    /// <seealso cref="UserControl"/>
    /// <seealso cref="IContainerControl"/>
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class UControlBase : UserControl, IContainerControl
    {
        /// <summary>
        /// is radius
        /// </summary>
        private bool _isRadius = false;

        /// <summary>
        /// the corner radius
        /// </summary>
        private int _cornerRadius = 24;

        /// <summary>
        /// is show rectangle
        /// </summary>
        private bool _isShowRect = false;

        /// <summary>
        /// the rectangle color
        /// </summary>
        private Color _rectColor = Color.FromArgb(220, 220, 220);

        /// <summary>
        /// the rectangle width
        /// </summary>
        private int _rectWidth = 1;

        /// <summary>
        /// the fill color
        /// </summary>
        private Color _fillColor = Color.Transparent;

        /// <summary>
        /// 是否圆角
        /// </summary>
        /// <value><c>true</c> if the instance is radius, otherwise <c>false</c></value>
        [Description("是否圆角"), Category("自定义")]
        public virtual bool IsRadius
        {
            get
            { return _isRadius; }
            set
            {
                _isRadius = value;
                Refresh();
            }
        }

        /// <summary>
        /// 圆角角度
        /// </summary>
        /// <value>the corner radius.</value>
        [Description("圆角角度"), Category("自定义")]
        public virtual int CornerRadius
        {
            get
            {
                return _cornerRadius;
            }
            set
            {
                _cornerRadius = Math.Max(value, 1);
                Refresh();
            }
        }

        /// <summary>
        /// 是否显示边框
        /// </summary>
        /// <value><c>true</c> if this instance is show rect, otherwise <c>false.</c></value>
        [Description("是否显示边框"), Category("自定义")]
        public virtual bool IsShowRect
        {
            get
            {
                return _isShowRect;
            }
            set
            {
                _isShowRect = value;
                Refresh();
            }
        }

        /// <summary>
        /// 边框颜色
        /// </summary>
        /// <value>the color of the rect.</value>
        [Description("边框颜色"), Category("自定义")]
        public virtual Color RectColor
        {
            get
            {
                return _rectColor;
            }
            set
            {
                _rectColor = value;
                Refresh();
            }
        }

        /// <summary>
        /// 边框宽度
        /// </summary>
        /// <value>the width of the rect.</value>
        [Description("边框宽度"), Category("自定义")]
        public virtual int RectWidth
        {
            get
            {
                return _rectWidth;
            }
            set
            {
                _rectWidth = value;
                Refresh();
            }
        }

        /// <summary>
        /// 当使用边框时填充颜色，当值为背景色或透明色或空值则不填充
        /// </summary>
        /// <value>the color of the fill.</value>
        [Description("当使用边框时填充颜色，当值为背景色或透明色或空值则不填充"), Category("自定义")]
        public virtual Color FillColor
        {
            get
            {
                return _fillColor;
            }
            set
            {
                _fillColor = value;
                Refresh();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UControlBase"/> class.
        /// </summary>
        public UControlBase()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.Selectable, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserPaint, true);
        }

        /// <summary>
        /// 引发 <see cref="System.Windows.Forms.Control.Paint"/> 事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (Visible)
            {
                if (IsRadius)
                {
                    SetWindowRegion();
                }
            }
        }

        private void SetWindowRegion()
        {
            GraphicsPath path;
            Rectangle rect = new Rectangle(-1, -1, Width + 1, Height);
            path = GetRoundedRectPath(rect, _cornerRadius);
            Region = new Region(path);
        }

        /// <summary>
        /// get the rounded rect path.
        /// </summary>
        /// <param name="rect">the rect.</param>
        /// <param name="radius">the radius.</param>
        /// <returns></returns>
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            Rectangle rect1 = new Rectangle(rect.Location, new Size(radius, radius));
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddArc(rect1, 180f, 90f); // 左上角
            rect1.X = rect.Right - radius;
            graphicsPath.AddArc(rect1, 270f, 90f); //右上角
            rect1.Y = rect.Bottom - radius;
            rect1.Width += 1;
            rect1.Height += 1;
            graphicsPath.AddArc(rect1, 360f, 90f); // 右下角
            rect1.X = rect.Left;
            graphicsPath.AddArc(rect1, 90f, 90f); // 左下角
            graphicsPath.CloseAllFigures();
            return graphicsPath;
        }

        /// <summary>
        /// Wnds the proc.
        /// </summary>
        /// <param name="m">要处理的 Windows <see cref="System.Windows.Forms.Message"/></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg != 20)
            {
                base.WndProc(ref m);
            }
        }
    }
}
