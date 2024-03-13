using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal class TextBoxDefault : TextBox
    {
        private readonly string defaultText = "Default value";

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetStyle(ControlStyles.UserPaint, TextLength == 0);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Text.Length == 0)
            {
                DrawDefaultText(e);
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            SetStyle(ControlStyles.UserPaint, TextLength == 0);
            if(Text.Length == 0)
            {
                Invalidate();
            }
        }

        private void DrawDefaultText(PaintEventArgs e)
        {
            TextRenderer.DrawText(e.Graphics, defaultText, Font, ClientRectangle, SystemColors.GrayText, TextFormatFlags.TextBoxControl);
        }
    }
}
