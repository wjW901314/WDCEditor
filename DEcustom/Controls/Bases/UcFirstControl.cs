using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WDCCustom.Controls.Bases
{
    public sealed class UcFirstControl : Control
    {
        public UcFirstControl()
        {

        }

        private ContentAlignment _textAlignment = ContentAlignment.MiddleLeft;
        [Category("扩展属性")]
        [Description("获取或设置文本的对齐方式")]
        public ContentAlignment TextAlignment
        {
            get => _textAlignment;
            set
            {
                _textAlignment = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            StringFormat style = new StringFormat();
            style.Alignment = StringAlignment.Near;
            switch (_textAlignment)
            {
                case ContentAlignment.MiddleLeft:
                    style.Alignment = StringAlignment.Near;
                    break;
                case ContentAlignment.MiddleRight:
                    style.Alignment = StringAlignment.Far;
                    break;
                case ContentAlignment.MiddleCenter:
                    style.Alignment = StringAlignment.Center;
                    break;
            }
            e.Graphics.DrawString(
                Text,
                Font,
                new SolidBrush(ForeColor),
                ClientRectangle, style);
            base.OnPaint(e);
        }
    }
}