using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal class TextBoxDefault:TextBox
    {
        private string defaultText = "Default value";
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (TextLength == 0)
            {
                DrawDefaultText(e.Graphics);
            }
        }

        private void DrawDefaultText(Graphics graphics)
        {
           TextRenderer.DrawText(graphics,defaultText,Font,ClientRectangle,SystemColors.GrayText,TextFormatFlags.TextBoxControl);

        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetStyle(ControlStyles.UserPaint,TextLength==0);
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            SetStyle(ControlStyles.UserPaint, TextLength == 0);
            Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            SetStyle(ControlStyles.UserPaint, TextLength == 0);
            Invalidate();
        }

    }
}
