using CapaPresentaciòn.BtControles;

namespace capaPresentación
{
    public partial class frPadres : Form
    {
        public frPadres()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //inicio

        private void addUserControl(UserControl userControl)
        { 
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UserInicio userInic = new UserInicio();
            addUserControl(userInic);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            UserNinnos userNino = new UserNinnos();
            addUserControl(userNino);


        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            UserPadres userPadr = new UserPadres();
            addUserControl(userPadr);


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

            UserPagos userpag = new UserPagos();
            addUserControl(userpag);

        }
        private void guna2Button8_Click(object sender, EventArgs e)
        {

            Bienvenida userprinc = new Bienvenida();
            addUserControl(userprinc);

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}