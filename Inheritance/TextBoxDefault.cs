using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.ObjectModel
{
    internal class TextBoxDefault: TextBox
    {
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SetStyle(ControlStyles.UserPaint, TextLength==0);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (TextLength == 0)
            {
                DrawDefaultText(e);
            }
        }    
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            SetStyle(ControlStyles.UserPaint, TextLength == 0);
            if(TextLength == 0)
            {
                Invalidate();
            }
          
        }
            
        private void DrawDefaultText(PaintEventArgs e)
        {
            
            {
               TextRenderer.DrawText( e.Graphics,defaultText, base.Font, ClientRectangle,SystemColors.GrayText,TextFormatFlags.TextBoxControl);
            }
        }
        private string defaultText="Default value";


    }
}
