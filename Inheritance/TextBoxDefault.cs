using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal class TextBoxDefault : TextBox
    {
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetStyle(ControlStyles.UserPaint, TextLength == 0);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (TextLength == 0)
            {
                DrawDefaultText(e.Graphics);
            }
        }
        override OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (TextLenght == 0)
            {
                SetStyle(ControlStyles.UserPaint,true);
                Invalidate();   
            }
        }

        private void DrawDefaultText(Graphics graphics)
        {
            TextRenderer.DrawText(graphics,defaultText,Font,ClientRectangle,SystemColors.GrayText,TextFormatFlags.TextBoxControl);        }

        private string defaultText = "Default value";
    }
}
