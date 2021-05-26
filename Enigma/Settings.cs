using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace Enigma
{
	/// <summary>
	/// Description of Settings.
	/// </summary>
	public class Settings : Form
	{
		private System.ComponentModel.IContainer components;
		private ListBox SelectedRotors;
		private Label RotorStructure;
		private ListBox AvailableRotors;
		private Button Cancel;
		private GroupBox RotorLayoutsBox;
		private ComboBox ComboReflector;
		private ToolTip ToolTipDownButton;
		private ToolTip ToolTipSelectButton;
		private ToolTip ToolTipDeSelectButton;
		private Button RotorUpButton;
		private Label SelectedRotorsLabel;
		private Label AvailableRotorsLabel;
		private Label DefaultLayout;
		private Button DeselectButton;
		private Button OkButton;
		private Label ReflectorLabel;
		private Button RotorDownButton;
		private Button SelectButton;
		private ToolTip ToolTipRotorUp;
		private string rotor1, rotor2, rotor3, rotor4, rotor5;
		private MainForm mainForm;
		private ArrayList al1, al2, al3;

		public Settings(MainForm mainForm)
		{
			InitializeComponent();
			this.mainForm = mainForm;
		}

		#region Windows Forms Designer generated code

		private void InitializeComponent()
		{
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
      this.ToolTipRotorUp = new System.Windows.Forms.ToolTip(this.components);
      this.SelectButton = new System.Windows.Forms.Button();
      this.RotorDownButton = new System.Windows.Forms.Button();
      this.ReflectorLabel = new System.Windows.Forms.Label();
      this.OkButton = new System.Windows.Forms.Button();
      this.DeselectButton = new System.Windows.Forms.Button();
      this.DefaultLayout = new System.Windows.Forms.Label();
      this.AvailableRotorsLabel = new System.Windows.Forms.Label();
      this.SelectedRotorsLabel = new System.Windows.Forms.Label();
      this.RotorUpButton = new System.Windows.Forms.Button();
      this.ToolTipDeSelectButton = new System.Windows.Forms.ToolTip(this.components);
      this.ToolTipSelectButton = new System.Windows.Forms.ToolTip(this.components);
      this.ToolTipDownButton = new System.Windows.Forms.ToolTip(this.components);
      this.ComboReflector = new System.Windows.Forms.ComboBox();
      this.RotorLayoutsBox = new System.Windows.Forms.GroupBox();
      this.RotorStructure = new System.Windows.Forms.Label();
      this.Cancel = new System.Windows.Forms.Button();
      this.AvailableRotors = new System.Windows.Forms.ListBox();
      this.SelectedRotors = new System.Windows.Forms.ListBox();
      this.RotorLayoutsBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // SelectButton
      // 
      this.SelectButton.Image = ((System.Drawing.Image)(resources.GetObject("SelectButton.Image")));
      this.SelectButton.Location = new System.Drawing.Point(182, 46);
      this.SelectButton.Name = "SelectButton";
      this.SelectButton.Size = new System.Drawing.Size(48, 36);
      this.SelectButton.TabIndex = 1;
      this.SelectButton.Click += new System.EventHandler(this.SelectRotor);
      // 
      // RotorDownButton
      // 
      this.RotorDownButton.Image = ((System.Drawing.Image)(resources.GetObject("RotorDownButton.Image")));
      this.RotorDownButton.Location = new System.Drawing.Point(182, 183);
      this.RotorDownButton.Name = "RotorDownButton";
      this.RotorDownButton.Size = new System.Drawing.Size(48, 36);
      this.RotorDownButton.TabIndex = 4;
      this.RotorDownButton.Click += new System.EventHandler(this.RotorFurther);
      // 
      // ReflectorLabel
      // 
      this.ReflectorLabel.Location = new System.Drawing.Point(19, 320);
      this.ReflectorLabel.Name = "ReflectorLabel";
      this.ReflectorLabel.Size = new System.Drawing.Size(120, 18);
      this.ReflectorLabel.TabIndex = 13;
      this.ReflectorLabel.Text = "Отражатель";
      // 
      // OkButton
      // 
      this.OkButton.Image = ((System.Drawing.Image)(resources.GetObject("OkButton.Image")));
      this.OkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.OkButton.Location = new System.Drawing.Point(307, 375);
      this.OkButton.Name = "OkButton";
      this.OkButton.Size = new System.Drawing.Size(90, 36);
      this.OkButton.TabIndex = 8;
      this.OkButton.Text = "Ок";
      this.OkButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.OkButton.Click += new System.EventHandler(this.OkButtonClick);
      // 
      // DeselectButton
      // 
      this.DeselectButton.Image = ((System.Drawing.Image)(resources.GetObject("DeselectButton.Image")));
      this.DeselectButton.Location = new System.Drawing.Point(182, 91);
      this.DeselectButton.Name = "DeselectButton";
      this.DeselectButton.Size = new System.Drawing.Size(48, 37);
      this.DeselectButton.TabIndex = 2;
      this.DeselectButton.Click += new System.EventHandler(this.DeSelectRotor);
      // 
      // DefaultLayout
      // 
      this.DefaultLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.DefaultLayout.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.DefaultLayout.Location = new System.Drawing.Point(10, 18);
      this.DefaultLayout.Name = "DefaultLayout";
      this.DefaultLayout.Size = new System.Drawing.Size(355, 28);
      this.DefaultLayout.TabIndex = 8;
      this.DefaultLayout.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      this.DefaultLayout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // AvailableRotorsLabel
      // 
      this.AvailableRotorsLabel.Location = new System.Drawing.Point(19, 18);
      this.AvailableRotorsLabel.Name = "AvailableRotorsLabel";
      this.AvailableRotorsLabel.Size = new System.Drawing.Size(144, 19);
      this.AvailableRotorsLabel.TabIndex = 10;
      this.AvailableRotorsLabel.Text = "Доступные роторы";
      // 
      // SelectedRotorsLabel
      // 
      this.SelectedRotorsLabel.Location = new System.Drawing.Point(250, 18);
      this.SelectedRotorsLabel.Name = "SelectedRotorsLabel";
      this.SelectedRotorsLabel.Size = new System.Drawing.Size(144, 19);
      this.SelectedRotorsLabel.TabIndex = 11;
      this.SelectedRotorsLabel.Text = "Выбранные роторы";
      // 
      // RotorUpButton
      // 
      this.RotorUpButton.Image = ((System.Drawing.Image)(resources.GetObject("RotorUpButton.Image")));
      this.RotorUpButton.Location = new System.Drawing.Point(182, 137);
      this.RotorUpButton.Name = "RotorUpButton";
      this.RotorUpButton.Size = new System.Drawing.Size(48, 37);
      this.RotorUpButton.TabIndex = 3;
      this.RotorUpButton.Click += new System.EventHandler(this.RotorEarlier);
      // 
      // ComboReflector
      // 
      this.ComboReflector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.ComboReflector.Items.AddRange(new object[] {
            "Отражатель B = YRUHQSLDPXNGOKMIEBFZCWVJAT",
            "Отражатель C = FVPJIAOYEDRZXWGCTKUQSBNMHL"});
      this.ComboReflector.Location = new System.Drawing.Point(19, 338);
      this.ComboReflector.Name = "ComboReflector";
      this.ComboReflector.Size = new System.Drawing.Size(375, 23);
      this.ComboReflector.TabIndex = 14;
      // 
      // RotorLayoutsBox
      // 
      this.RotorLayoutsBox.Controls.Add(this.RotorStructure);
      this.RotorLayoutsBox.Controls.Add(this.DefaultLayout);
      this.RotorLayoutsBox.Location = new System.Drawing.Point(19, 229);
      this.RotorLayoutsBox.Name = "RotorLayoutsBox";
      this.RotorLayoutsBox.Size = new System.Drawing.Size(375, 82);
      this.RotorLayoutsBox.TabIndex = 12;
      this.RotorLayoutsBox.TabStop = false;
      this.RotorLayoutsBox.Text = "Шифрование роторов";
      // 
      // RotorStructure
      // 
      this.RotorStructure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.RotorStructure.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.RotorStructure.Location = new System.Drawing.Point(10, 48);
      this.RotorStructure.Name = "RotorStructure";
      this.RotorStructure.Size = new System.Drawing.Size(355, 26);
      this.RotorStructure.TabIndex = 9;
      this.RotorStructure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Cancel
      // 
      this.Cancel.Image = ((System.Drawing.Image)(resources.GetObject("Cancel.Image")));
      this.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.Cancel.Location = new System.Drawing.Point(211, 375);
      this.Cancel.Name = "Cancel";
      this.Cancel.Size = new System.Drawing.Size(90, 36);
      this.Cancel.TabIndex = 9;
      this.Cancel.Text = "Отмена";
      this.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.Cancel.Click += new System.EventHandler(this.CancelClick);
      // 
      // AvailableRotors
      // 
      this.AvailableRotors.ItemHeight = 15;
      this.AvailableRotors.Items.AddRange(new object[] {
            "Rotor I",
            "Rotor II",
            "Rotor III",
            "Rotor IV",
            "Rotor V"});
      this.AvailableRotors.Location = new System.Drawing.Point(19, 37);
      this.AvailableRotors.Name = "AvailableRotors";
      this.AvailableRotors.Size = new System.Drawing.Size(144, 169);
      this.AvailableRotors.TabIndex = 0;
      this.AvailableRotors.SelectedIndexChanged += new System.EventHandler(this.AvailableRotorsSelectedIndexChanged);
      // 
      // SelectedRotors
      // 
      this.SelectedRotors.ItemHeight = 15;
      this.SelectedRotors.Location = new System.Drawing.Point(250, 37);
      this.SelectedRotors.Name = "SelectedRotors";
      this.SelectedRotors.Size = new System.Drawing.Size(144, 169);
      this.SelectedRotors.TabIndex = 5;
      // 
      // Settings
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
      this.ClientSize = new System.Drawing.Size(410, 416);
      this.Controls.Add(this.ComboReflector);
      this.Controls.Add(this.ReflectorLabel);
      this.Controls.Add(this.RotorLayoutsBox);
      this.Controls.Add(this.SelectedRotorsLabel);
      this.Controls.Add(this.AvailableRotorsLabel);
      this.Controls.Add(this.Cancel);
      this.Controls.Add(this.OkButton);
      this.Controls.Add(this.SelectedRotors);
      this.Controls.Add(this.RotorDownButton);
      this.Controls.Add(this.RotorUpButton);
      this.Controls.Add(this.DeselectButton);
      this.Controls.Add(this.SelectButton);
      this.Controls.Add(this.AvailableRotors);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Settings";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Настройки";
      this.Load += new System.EventHandler(this.SettingsLoad);
      this.RotorLayoutsBox.ResumeLayout(false);
      this.ResumeLayout(false);

		}
		#endregion
		void CancelClick(object sender, System.EventArgs e)
		{
			Close();
		}

		void SettingsLoad(object sender, System.EventArgs e)
		{
			al1 = new ArrayList();
			al2 = new ArrayList();
			al3 = new ArrayList();
			al1.Add("Rotor I");
			al1.Add("Rotor II");
			al1.Add("Rotor III");
			al1.Add("Rotor IV");
			al1.Add("Rotor V");
			rotor1 = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
			rotor2 = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
			rotor3 = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
			rotor4 = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
			rotor5 = "VZBRGITYUPSDNHLXAWMJQOFECK";
			al2.Add(rotor1);
			al2.Add(rotor2);
			al2.Add(rotor3);
			al2.Add(rotor4);
			al2.Add(rotor5);
			al3.Add("Q");
			al3.Add("E");
			al3.Add("V");
			al3.Add("J");
			al3.Add("Z");
			AvailableRotors.Items.Clear();
			for (int i = 0; i < al1.Count; i++)
			{
				AvailableRotors.Items.Add(al1[i]);
			}
			ToolTipSelectButton.SetToolTip(SelectButton, "Включить ротор");
			ToolTipDeSelectButton.SetToolTip(DeselectButton, "Выключить ротор");
			ToolTipRotorUp.SetToolTip(RotorUpButton, "Ротор вверх");
			ToolTipDownButton.SetToolTip(RotorDownButton, "Ротор вниз");

			for (int i = 0; i < ComboReflector.Items.Count; i++)
			{
				if (ComboReflector.Items[i].ToString().EndsWith(mainForm.GetReflector()))
				{
					ComboReflector.SelectedIndex = i;
				}
			}

			for (int i = 0; i < al2.Count; i++)
			{
				if (al2[i].ToString() == mainForm.GetLeftRotor())
				{
					AvailableRotors.Items.Remove(al1[i].ToString());
					SelectedRotors.Items.Add(al1[i].ToString());
					break;
				}
			}

			for (int i = 0; i < al2.Count; i++)
			{
				if (al2[i].ToString() == mainForm.GetMiddleRotor())
				{
					AvailableRotors.Items.Remove(al1[i].ToString());
					SelectedRotors.Items.Add(al1[i].ToString());
					break;
				}
			}
			for (int i = 0; i < al2.Count; i++)
			{
				if (al2[i].ToString() == mainForm.GetRightRotor())
				{
					AvailableRotors.Items.Remove(al1[i].ToString());
					SelectedRotors.Items.Add(al1[i].ToString());
					break;
				}
			}
		}

		void AvailableRotorsSelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (AvailableRotors.SelectedIndex < 0)
			{
				return;
			}
			for (int i = 0; i < al1.Count; i++)
			{
				if (AvailableRotors.SelectedItem.ToString() == "" + al1[i])
				{
					RotorStructure.Text = "" + al2[i];
					return;
				}
			}
			RotorStructure.Text = "";
		}

		void SelectRotor(object sender, System.EventArgs e)
		{
			if (AvailableRotors.SelectedIndex < 0)
			{
				MessageBox.Show(this, "Выберите ротор слева!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			SelectedRotors.Items.Add(AvailableRotors.SelectedItem);
			AvailableRotors.Items.Remove(AvailableRotors.SelectedItem);
			RotorStructure.Text = "";
		}

		void DeSelectRotor(object sender, System.EventArgs e)
		{
			if (SelectedRotors.SelectedIndex < 0)
			{
				MessageBox.Show(this, "Выберите ротор справа!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			AvailableRotors.Items.Add(SelectedRotors.SelectedItem);
			SelectedRotors.Items.Remove(SelectedRotors.SelectedItem);
		}

		void RotorEarlier(object sender, System.EventArgs e)
		{
			if (SelectedRotors.SelectedIndex <= 0)
			{
				return;
			}

			string strTemp = "" + SelectedRotors.Items[SelectedRotors.SelectedIndex - 1];
			SelectedRotors.Items[SelectedRotors.SelectedIndex - 1] = SelectedRotors.SelectedItem;
			SelectedRotors.Items[SelectedRotors.SelectedIndex] = strTemp;
			SelectedRotors.SelectedIndex--;

		}

		void RotorFurther(object sender, System.EventArgs e)
		{
			if (SelectedRotors.SelectedIndex < 0 || SelectedRotors.SelectedIndex == SelectedRotors.Items.Count - 1)
			{
				return;
			}

			string strTemp = "" + SelectedRotors.Items[SelectedRotors.SelectedIndex + 1];
			SelectedRotors.Items[SelectedRotors.SelectedIndex + 1] = SelectedRotors.SelectedItem;
			SelectedRotors.Items[SelectedRotors.SelectedIndex] = strTemp;
			SelectedRotors.SelectedIndex++;
		}

		void OkButtonClick(object sender, System.EventArgs e)
		{
			if (SelectedRotors.Items.Count != 3)
			{
				MessageBox.Show(this, "Выберите ровно три ротора!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			ArrayList alRot = new();
			ArrayList alRotName = new();
      ArrayList arrayList = new();
      ArrayList alRotNotch = arrayList;

			for (int j = 0; j < SelectedRotors.Items.Count; j++)
			{
				for (int i = 0; i < al1.Count; i++)
				{
					if (SelectedRotors.Items[j].ToString() == "" + al1[i])
					{
						alRot.Add(al2[i]);
            _ = alRotName.Add(al1[i].ToString()[al1[i].ToString().LastIndexOf(" ")..].Trim());
						alRotNotch.Add(al3[i]);
						break;
					}
				}
			}

			mainForm.ChangeRotors(alRot[0].ToString(),
											alRotName[0].ToString(),
											alRotNotch[0].ToString().ToCharArray()[0],
											alRot[1].ToString(),
											alRotName[1].ToString(),
											alRotNotch[1].ToString().ToCharArray()[0],
											alRot[2].ToString(),
											alRotName[2].ToString(),
											alRotNotch[2].ToString().ToCharArray()[0]);

			if (ComboReflector.SelectedIndex > -0)
			{
				mainForm.SetReflector(refl: ComboReflector.SelectedItem.ToString()[(ComboReflector.SelectedItem.ToString().LastIndexOf("=") + 2)..].Trim());
			}
			Close();
		}

	}
}