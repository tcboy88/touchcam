﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchCam
{
    /// <summary>
    /// Helper form to easily allow multiple startup programs
    /// </summary>
    public partial class ProgramSelectionForm : Form
    {
        public ProgramSelectionForm()
        {
            InitializeComponent();
        }

        List<Type> forms = new List<Type>();
        private void ProgramSelectionForm_Load(object sender, EventArgs e)
        {
            // build a list of valid startup forms
            foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies().Where(a => !a.FullName.StartsWith("System.") || !a.FullName.StartsWith("Microsoft.")))
            {
                Type[] types = a.GetTypes().Where(t => (typeof(Form).IsAssignableFrom(t)) && t.IsClass && t.FullName.StartsWith(this.GetType().Namespace) && t != this.GetType()).ToArray<Type>();
                forms.AddRange(types);
            }

            foreach (Type formType in forms)
            {
                PropertyInfo info = formType.GetProperty("HideFromList");
                if(info == null) ProgramList.Items.Add(formType.Name);
            }
            ProgramList.SelectedItem = Properties.Settings.Default.StartupForm;
            ProgramList.Focus();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.StartupForm = (string)ProgramList.SelectedItem;
            Properties.Settings.Default.Save();
            Type formType = null;
            foreach (Type type in forms) if (type.Name == ProgramList.SelectedItem.ToString()) formType = type;
            Form form = (Form)Activator.CreateInstance(formType);
            form.Show();
            form.FormClosed += delegate { this.Close(); };
            this.Hide();
        }
    }
}
