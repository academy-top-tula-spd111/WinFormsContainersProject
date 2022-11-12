namespace WinFormsContainersProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Label lblName= new Label();
            Label lblPassword = new Label();

            TextBox txtName = new TextBox();
            TextBox txtPassword = new TextBox();

            Button btnSend = new Button();

            lblName.Text = "Имя";
            lblPassword.Text = "Пароль";

            txtName.Width = 250;
            txtPassword.Width = 250;

            btnSend.Text = "Отправить";


            lblName.Location = new Point(10, 27);
            txtName.Location = new Point(10, 50);

            lblPassword.Location = new Point(10, 87);
            txtPassword.Location = new Point(10, 110);
            //txtPassword.PasswordChar = '*';
            txtPassword.UseSystemPasswordChar = true;

            btnSend.Location = new Point(100, 170);

            grpBoxFirst.Controls.Add(lblName);
            grpBoxFirst.Controls.Add(txtName);
            grpBoxFirst.Controls.AddRange(new Control[]
                                    { lblPassword, txtPassword, btnSend });

            List<Button> buttonsDigit = new List<Button>();
            for (int i = 0; i < 9; i++)
            {
                buttonsDigit.Add(new Button() { Dock = DockStyle.Fill, Text = (i + 1).ToString() });
                tablePanel.Controls.Add((Button)buttonsDigit[i]);
            }

            TabPage page4 = new() { Text = "Tab #4" };
            tabControl1.TabPages.Add(page4);
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.RemoveAt(1);
        }
    }
}