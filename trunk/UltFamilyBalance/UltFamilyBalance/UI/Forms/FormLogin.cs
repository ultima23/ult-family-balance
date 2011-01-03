using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ult.Util;

namespace Ult.FamilyBalance.UI
{
    public partial class FormLogin : Form
    {

        private bool _canClose;

        private bool _canCancel;

        public FormLogin()
        {
            InitializeComponent();
        }


        public bool CanCancel
        {
            get { return _canCancel; }
            set { _canCancel = value; }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {   
            if (_canCancel)
            {
                btnCancel.Visible = true;
                btnCancel.Left = 183;
                btnLogin.Left = 102;
            }
            else
            {
                btnLogin.Left = 183;
                btnCancel.Visible = false;
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !_canClose;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool errors = false;
            bool success = false;

            errorLogin.Clear();
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                errorLogin.SetError(txtUsername, "Inserire un username valido");
                errors = true;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorLogin.SetError(txtPassword, "Inserire una password valida");
                errors = true;
            }

            if (!errors)
            {
                string msg = string.Empty;
                try
                {
                    if (UltFamilyBalance.GetUltFamilyBalance().Login(txtUsername.Text, txtPassword.Text))
                    {
                        success = true;
                    }
                    else
                    {
                        success = false;
                        msg = String.Format("Login for username {0} failed.\r\nCheck username and password", txtUsername.Text);
                    }
                }
                catch (Exception ex)
                {
                    msg = ex.Message;
                }

                if (success)
                {
                    _canClose = true;
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    if (msg != null)
                    {
                        UIUtils.Alert(msg);
                    }
                }
            }
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_canCancel)
            {
                _canClose = true;
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(btnLogin, new EventArgs());
            }

            if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(btnCancel, new EventArgs());
            }

        }

    }
}
