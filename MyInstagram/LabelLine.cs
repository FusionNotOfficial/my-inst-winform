namespace MyInstagram
{
    public class LabelLine : Label
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.DarkGray, ButtonBorderStyle.Solid);
        }
    }
}
