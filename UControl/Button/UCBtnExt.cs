using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
