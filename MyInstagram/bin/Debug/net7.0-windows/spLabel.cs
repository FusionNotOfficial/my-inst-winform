using System.ComponentModel;

namespace MyInstagram
{
    public class spLabel : Label
    {
        [Category("Color")]
        public Color Color { get; set; }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            if (Enabled)
            {
                base.OnPaint(e);
                return;
            }
            using (Brush aBrush = new SolidBrush(Color))
            {
                e.Graphics.DrawString(Text, Font, aBrush, ClientRectangle);
            }
        }
    }
}
