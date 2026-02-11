using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWENG_421_Lab_5
{
    public partial class Form1 : Form
    {
        private readonly ModuleFactoryIF factory = new ModuleFactory();

        private string ModulesFilePath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "modules.txt");

        public Form1()
        {
            InitializeComponent();
            LoadModulesToList();
            UpdateCurrentValueLabel();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (lstModules.SelectedItem == null)
            {
                MessageBox.Show("Please select a module.");
                return;
            }

            string typeName = lstModules.SelectedItem.ToString();

            try
            {
                IModule module = factory.Create(typeName);

                if (module is IInputModule inputModule)
                {
                    double input = PromptDouble($"Enter input for {module.Name}:");
                    inputModule.Execute(input);
                }
                else if (module is INoInputModule noInputModule)
                {
                    noInputModule.Execute();
                }
                else
                {
                    MessageBox.Show("Unknown module type.");
                    return;
                }

                UpdateCurrentValueLabel();
            }

            catch (OperationCanceledException)
            {
          
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //private void btnReload_Click(object sender, EventArgs e)
        //{
           
        //}

        private void LoadModulesToList()
        {
            lstModules.Items.Clear();

            if (!File.Exists(ModulesFilePath))
            {
                MessageBox.Show($"modules.txt not found at:\n{ModulesFilePath}");
                return;
            }

            var modules = File.ReadAllLines(ModulesFilePath)
                              .Select(x => x.Trim())
                              .Where(x => !string.IsNullOrWhiteSpace(x))
                              .Distinct()
                              .OrderBy(x => x)
                              .ToList();

            foreach (var m in modules)
                lstModules.Items.Add(m);

            if (lstModules.Items.Count > 0)
                lstModules.SelectedIndex = 0;
        }

        private void UpdateCurrentValueLabel()
        {
            lblCurrent.Text = $"Current Value: {CurrentValue.Instance.Value}";
        }

        private double PromptDouble(string prompt)
        {
            while (true)
            {
                string text;
                bool ok = PromptText(prompt, out text);

                if (!ok)
                {
                    throw new OperationCanceledException("User cancelled input.");
                }

                if (double.TryParse(text.Trim(), out double value))
                    return value;

                MessageBox.Show("Please enter a valid number.");
            }
        }

        private bool PromptText(string prompt, out string text)
        {
            text = "";

            using (Form dialog = new Form())
            using (Label lbl = new Label())
            using (TextBox txt = new TextBox())
            using (Button ok = new Button())
            using (Button cancel = new Button())
            {
                dialog.Text = "Input Required";
                dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
                dialog.StartPosition = FormStartPosition.CenterParent;
                dialog.MinimizeBox = false;
                dialog.MaximizeBox = false;
                dialog.Width = 420;
                dialog.Height = 160;

                lbl.Left = 12;
                lbl.Top = 12;
                lbl.Width = 380;
                lbl.Text = prompt;

                txt.Left = 12;
                txt.Top = 40;
                txt.Width = 380;

                ok.Text = "OK";
                ok.Left = 232;
                ok.Top = 75;
                ok.Width = 75;
                ok.DialogResult = DialogResult.OK;

                cancel.Text = "Cancel";
                cancel.Left = 317;
                cancel.Top = 75;
                cancel.Width = 75;
                cancel.DialogResult = DialogResult.Cancel;

                dialog.Controls.Add(lbl);
                dialog.Controls.Add(txt);
                dialog.Controls.Add(ok);
                dialog.Controls.Add(cancel);

                dialog.AcceptButton = ok;
                dialog.CancelButton = cancel;

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    text = txt.Text;
                    return true;
                }

                return false;
            }
        }

        private void lblCurrent_Click(object sender, EventArgs e)
        {
  
        }

    }
}
