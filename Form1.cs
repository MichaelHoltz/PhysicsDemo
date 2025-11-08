namespace PhysicsDemo
{
    public partial class Form1 : Form
    {
        List<Control> btnControls = new List<Control>();
        List<Point> originalPositions = new List<Point>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    btnControls.Add(control);
                    originalPositions.Add(control.Location);
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < btnControls.Count; i++)
            {
                btnControls[i].Location = originalPositions[i];
                btnControls[i].Enabled = true;
                btnControls[i].BackColor = SystemColors.Control;
            }
        }
        private async void btnSimpleFall_Click(object sender, EventArgs e)
        {
            await FeatherFallAsync(btnSimpleFall);
        }
        private async void btnBullet_Click(object sender, EventArgs e)
        {
            await Task.WhenAll(
                   SlideRightWithFrictionAsync(btnBullet),
                   FeatherFallAsync(btnBullet)
                   );
        }

        private async Task FeatherFallAsync(Control control)
        {
            control.BackColor = Color.LightBlue;                
            control.Enabled = false;
            float velocity = 0.0f;
            float acceleration = 0.2f;
            int bottomLimit = this.ClientSize.Height - control.Height;

            while (control.Top < bottomLimit)
            {
                await Task.Delay(20); // Smooth animation
                velocity += acceleration;
                int newTop = control.Top + (int)velocity;
                control.Top = Math.Min(newTop, bottomLimit);
            }
        }

        private async Task SlideRightWithFrictionAsync(Control control)
        {
            control.BackColor = Color.LightBlue;
            control.Enabled = false;
            float velocity = 9f; // Initial velocity (pixels per frame)
            float friction = 0.05f; // Friction (pixels per frame^2)
            int targetRight = (int)(this.ClientSize.Width * 0.85) - control.Width;


            while (control.Left < targetRight && velocity > 0.01f)
            {
                await Task.Delay(20); // Smooth animation
                control.Left = Math.Min(control.Left + (int)velocity, targetRight);
                velocity -= friction;
                if (velocity < 0) velocity = 0;
            }
            
        }

        private void BtnSimAll_Click(object sender, EventArgs e)
        {
            btnBullet.PerformClick();
            btnSimpleFall.PerformClick();
        }
    }
}
