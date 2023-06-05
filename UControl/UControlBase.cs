using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;

namespace UControls.UControl
{
    /// <summary>
    /// Class UControlBase.
    /// </summary>
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
            { return this._isRadius; }
            set
            {
                this._isRadius = value;
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
                return this._cornerRadius;
            }
            set
            {
                this._cornerRadius = Math.Max(value, 1);
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
                return this._isShowRect;
            }
            set
            {
                this._isShowRect = value;
                Refresh();
            }
        }
    }
}
