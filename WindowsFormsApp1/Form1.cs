using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        struct Account
        {
            internal readonly string login;
            internal readonly string password;
            public Account(string inl, string inp)
            {
                login = inl;
                password = inp;
            }
        }
        private readonly List<Account> Accounts = new List<Account>();
        public Form1()
        {
            Accounts.Add(new Account("admin", "admin"));
            InitializeComponent();
        }

        private void Compute_Click(object sender, EventArgs e)
        {
            InputEditor inEdit = new InputEditor();
            Logic logic = new Logic(Output, dataGridView1);
            if (Input.Text == "")
            {
                MessageBox.Show("Заполните поле!");
            }
            else
            {
                if (InputEditor.Parse(Input.Text))
                {
                    Logic.SetVars(InputEditor.Vars);
                    Logic.Compute();
                    Logic.MakeSDNF();
                    Logic.MakeSKNF();
                }
            }
        }

        private void AppendText(Button button)
        {
            Input.Text = Input.Text.Trim();
            Input.Text += $" {button.Text} ";
            Input.Focus();
            Input.SelectionStart = Input.Text.Length;
        }

        private void Conjunction_Click(object sender, EventArgs e)
        {
            AppendText(Conjunction);
        }

        private void Disjunction_Click(object sender, EventArgs e)
        {
            AppendText(Disjunction);
        }

        private void Implication_Click(object sender, EventArgs e)
        {
            AppendText(Implication);
        }

        private void Not_And_Click(object sender, EventArgs e)
        {
            AppendText(Not_And);
        }

        private void Not_Or_Click(object sender, EventArgs e)
        {
            AppendText(Not_Or);
        }

        private void Converse_Click(object sender, EventArgs e)
        {
            AppendText(Converse);
        }

        private void Exclusive_Disjunction_Click(object sender, EventArgs e)
        {
            AppendText(Exclusive_Disjunction);
        }

        private void Negation_Click(object sender, EventArgs e)
        {
            AppendText(Negation);
        }

        private void Equivalent_Click(object sender, EventArgs e)
        {
            AppendText(Equivalent);
        }

        private void Left_Bracket_Click(object sender, EventArgs e)
        {
            AppendText(Left_Bracket);
        }

        private void Right_Bracket_Click(object sender, EventArgs e)
        {
            AppendText(Right_Bracket);
        }

        private void A_Click(object sender, EventArgs e)
        {
            AppendText(A);
        }

        private void B_Click(object sender, EventArgs e)
        {
            AppendText(B);
        }

        private void C_Click(object sender, EventArgs e)
        {
            AppendText(C);
        }

        private void D_Click(object sender, EventArgs e)
        {
            AppendText(D);
        }

        private void E_Click(object sender, EventArgs e)
        {
            AppendText(E);
        }

        private void F_Click(object sender, EventArgs e)
        {
            AppendText(F);
        }

        private void X_Click(object sender, EventArgs e)
        {
            AppendText(X);
        }

        private void Y_Click(object sender, EventArgs e)
        {
            AppendText(Y);
        }

        private void Z_Click(object sender, EventArgs e)
        {
            AppendText(Z);
        }

        private void A__Click(object sender, EventArgs e)
        {
            AppendText(A_);
        }

        private void B__Click(object sender, EventArgs e)
        {
            AppendText(B_);
        }

        private void C__Click(object sender, EventArgs e)
        {
            AppendText(C_);
        }

        private void D__Click(object sender, EventArgs e)
        {
            AppendText(D_);
        }

        private void E__Click(object sender, EventArgs e)
        {
            AppendText(E_);
        }

        private void F__Click(object sender, EventArgs e)
        {
            AppendText(F_);
        }

        private void X__Click(object sender, EventArgs e)
        {
            AppendText(X_);
        }

        private void Y__Click(object sender, EventArgs e)
        {
            AppendText(Y_);
        }

        private void Z__Click(object sender, EventArgs e)
        {
            AppendText(Z_);
        }

        private void Log_In_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Accounts.Count; ++i)
            {
                if (Login.Text == Accounts[i].login && Password.Text == Accounts[i].password)
                {
                    LoginL.Hide();
                    Login.Hide();
                    PasswordL.Hide();
                    Password.Hide();
                    Log_In.Hide();
                    Register.Hide();
                    Compute.Show();
                    Input.TabStop = true;
                    Input.Focus();
                    Input.ReadOnly = false;
                    AcceptButton = Compute;
                    return;
                }
            }
            MessageBox.Show("Неверная пара логин-пароль!");
        }

        private void Register_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Accounts.Count; ++i)
            {
                if (Login.Text == Accounts[i].login && Password.Text == Accounts[i].password)
                {
                    MessageBox.Show("Данный пользователь уже зарегистрирован!");
                }
                else
                {
                    Accounts.Add(new Account(Login.Text, Password.Text));
                    MessageBox.Show("Регистрация успешна!");
                    return;
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            colorDialog1.ShowDialog();
            dataGridView1.BackgroundColor = colorDialog1.Color;
        }
    }
}
