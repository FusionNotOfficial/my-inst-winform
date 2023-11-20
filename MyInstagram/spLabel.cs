﻿namespace MyInstagram
{
    public class spLabel : Label
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            if (Enabled)
            {
                base.OnPaint(e);
                return;
            }

            using (Brush aBrush = new SolidBrush(Color.White))
            {
                e.Graphics.DrawString(Text, Font, aBrush, ClientRectangle);
            }
        }
    }
}
