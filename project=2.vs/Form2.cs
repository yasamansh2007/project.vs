using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form2 : Form
    {
        private Label lblInfoUser;
        private Label lblInfoPass;

        public Form2()
        {
            InitializeComponent();
            this.Text = "Form2";
            this.Size = new System.Drawing.Size(300, 200);

            lblInfoUser = new Label()
            {
                Text = "User: ",
                Location = new System.Drawing.Point(20, 30),
                AutoSize = true
            };
            this.Controls.Add(lblInfoUser);

            lblInfoPass = new Label()
            {
                Text = "Password: ",
                Location = new System.Drawing.Point(20, 70),
                AutoSize = true
            };
            this.Controls.Add(lblInfoPass);
        }

        // تابع SetData که فرم اول صدا می‌زند
        public void SetData(string user, string pass)
        {
            lblInfoUser.Text = "User: " + user;
            lblInfoPass.Text = "Password: " + pass;
        }
    }
}
