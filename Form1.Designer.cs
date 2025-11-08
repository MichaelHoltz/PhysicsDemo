namespace PhysicsDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnSimpleFall = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnReset = new Button();
            btnBullet = new Button();
            BtnSimAll = new Button();
            SuspendLayout();
            // 
            // btnSimpleFall
            // 
            btnSimpleFall.Location = new Point(690, 86);
            btnSimpleFall.Name = "btnSimpleFall";
            btnSimpleFall.Size = new Size(98, 23);
            btnSimpleFall.TabIndex = 0;
            btnSimpleFall.Text = "Simple Fall";
            btnSimpleFall.UseVisualStyleBackColor = true;
            btnSimpleFall.Click += btnSimpleFall_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(23, 18);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnBullet
            // 
            btnBullet.Location = new Point(23, 86);
            btnBullet.Name = "btnBullet";
            btnBullet.Size = new Size(98, 23);
            btnBullet.TabIndex = 2;
            btnBullet.Text = "Bullet";
            btnBullet.UseVisualStyleBackColor = true;
            btnBullet.Click += btnBullet_Click;
            // 
            // BtnSimAll
            // 
            BtnSimAll.Location = new Point(130, 18);
            BtnSimAll.Name = "BtnSimAll";
            BtnSimAll.Size = new Size(98, 23);
            BtnSimAll.TabIndex = 3;
            BtnSimAll.Text = "SimulateAll";
            BtnSimAll.UseVisualStyleBackColor = true;
            BtnSimAll.Click += BtnSimAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 886);
            Controls.Add(BtnSimAll);
            Controls.Add(btnBullet);
            Controls.Add(btnReset);
            Controls.Add(btnSimpleFall);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSimpleFall;
        private System.Windows.Forms.Timer timer1;
        private Button btnReset;
        private Button btnBullet;
        private Button BtnSimAll;
    }
}
