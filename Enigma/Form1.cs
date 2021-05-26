using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
	public class MainForm : Form
	{
		private Button Rotor1Down;
		private Label lblRotorD;
		private Label lblRotorS;
		private Button EncryptDecryptButton;
		private Button SettingsButton;
		private GroupBox RingRotorsInfo;
		private Button Rotor2Down;
		private Label Rotor3Info;
		private Label Rotor1Info;
		private TextBox txtInit;
		private Button Rotor1Up;
		private TextBox txtFinal;
		private Button Rotor2Up;
		private Label lblRotorM;
		private Button Rotor3Up;
		private Label Rotor2Info;
		private Button Rotor3Down;
    private Button PlugboardSettings;

    private Rotor RightRotor, MiddleRotor, LeftRotor, reflector;

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.Rotor3Down = new System.Windows.Forms.Button();
      this.Rotor2Info = new System.Windows.Forms.Label();
      this.Rotor3Up = new System.Windows.Forms.Button();
      this.lblRotorM = new System.Windows.Forms.Label();
      this.Rotor2Up = new System.Windows.Forms.Button();
      this.txtFinal = new System.Windows.Forms.TextBox();
      this.Rotor1Up = new System.Windows.Forms.Button();
      this.txtInit = new System.Windows.Forms.TextBox();
      this.Rotor1Info = new System.Windows.Forms.Label();
      this.Rotor3Info = new System.Windows.Forms.Label();
      this.Rotor2Down = new System.Windows.Forms.Button();
      this.RingRotorsInfo = new System.Windows.Forms.GroupBox();
      this.lblRotorS = new System.Windows.Forms.Label();
      this.lblRotorD = new System.Windows.Forms.Label();
      this.Rotor1Down = new System.Windows.Forms.Button();
      this.SettingsButton = new System.Windows.Forms.Button();
      this.EncryptDecryptButton = new System.Windows.Forms.Button();
      this.PlugboardSettings = new System.Windows.Forms.Button();
      this.RingRotorsInfo.SuspendLayout();
      this.SuspendLayout();
      // 
      // Rotor3Down
      // 
      this.Rotor3Down.Image = ((System.Drawing.Image)(resources.GetObject("Rotor3Down.Image")));
      this.Rotor3Down.Location = new System.Drawing.Point(19, 187);
      this.Rotor3Down.Name = "Rotor3Down";
      this.Rotor3Down.Size = new System.Drawing.Size(39, 79);
      this.Rotor3Down.TabIndex = 13;
      this.Rotor3Down.Click += new System.EventHandler(this.BtnRotor3DownClick);
      // 
      // Rotor2Info
      // 
      this.Rotor2Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Rotor2Info.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.Rotor2Info.Location = new System.Drawing.Point(67, 138);
      this.Rotor2Info.Name = "Rotor2Info";
      this.Rotor2Info.Size = new System.Drawing.Size(39, 39);
      this.Rotor2Info.TabIndex = 10;
      this.Rotor2Info.Text = "A";
      this.Rotor2Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Rotor3Up
      // 
      this.Rotor3Up.Image = ((System.Drawing.Image)(resources.GetObject("Rotor3Up.Image")));
      this.Rotor3Up.Location = new System.Drawing.Point(19, 49);
      this.Rotor3Up.Name = "Rotor3Up";
      this.Rotor3Up.Size = new System.Drawing.Size(39, 79);
      this.Rotor3Up.TabIndex = 12;
      this.Rotor3Up.Click += new System.EventHandler(this.BtnRotor3UpClick);
      // 
      // lblRotorM
      // 
      this.lblRotorM.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.lblRotorM.Location = new System.Drawing.Point(67, 20);
      this.lblRotorM.Name = "lblRotorM";
      this.lblRotorM.Size = new System.Drawing.Size(39, 29);
      this.lblRotorM.TabIndex = 19;
      this.lblRotorM.Text = "II";
      this.lblRotorM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Rotor2Up
      // 
      this.Rotor2Up.Image = ((System.Drawing.Image)(resources.GetObject("Rotor2Up.Image")));
      this.Rotor2Up.Location = new System.Drawing.Point(67, 49);
      this.Rotor2Up.Name = "Rotor2Up";
      this.Rotor2Up.Size = new System.Drawing.Size(39, 79);
      this.Rotor2Up.TabIndex = 14;
      this.Rotor2Up.Click += new System.EventHandler(this.BtnRotor2UpClick);
      // 
      // txtFinal
      // 
      this.txtFinal.Location = new System.Drawing.Point(19, 187);
      this.txtFinal.Multiline = true;
      this.txtFinal.Name = "txtFinal";
      this.txtFinal.Size = new System.Drawing.Size(519, 108);
      this.txtFinal.TabIndex = 10;
      // 
      // Rotor1Up
      // 
      this.Rotor1Up.Image = ((System.Drawing.Image)(resources.GetObject("Rotor1Up.Image")));
      this.Rotor1Up.Location = new System.Drawing.Point(115, 49);
      this.Rotor1Up.Name = "Rotor1Up";
      this.Rotor1Up.Size = new System.Drawing.Size(39, 79);
      this.Rotor1Up.TabIndex = 15;
      this.Rotor1Up.Click += new System.EventHandler(this.BtnRotor1UpClick);
      // 
      // txtInit
      // 
      this.txtInit.Location = new System.Drawing.Point(19, 20);
      this.txtInit.Multiline = true;
      this.txtInit.Name = "txtInit";
      this.txtInit.Size = new System.Drawing.Size(519, 108);
      this.txtInit.TabIndex = 9;
      this.txtInit.TextChanged += new System.EventHandler(this.TxtInitTextChanged);
      this.txtInit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtInitKeyUp);
      // 
      // Rotor1Info
      // 
      this.Rotor1Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Rotor1Info.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.Rotor1Info.Location = new System.Drawing.Point(115, 138);
      this.Rotor1Info.Name = "Rotor1Info";
      this.Rotor1Info.Size = new System.Drawing.Size(39, 39);
      this.Rotor1Info.TabIndex = 11;
      this.Rotor1Info.Text = "A";
      this.Rotor1Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Rotor3Info
      // 
      this.Rotor3Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Rotor3Info.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.Rotor3Info.Location = new System.Drawing.Point(19, 138);
      this.Rotor3Info.Name = "Rotor3Info";
      this.Rotor3Info.Size = new System.Drawing.Size(39, 39);
      this.Rotor3Info.TabIndex = 9;
      this.Rotor3Info.Text = "A";
      this.Rotor3Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Rotor2Down
      // 
      this.Rotor2Down.Image = ((System.Drawing.Image)(resources.GetObject("Rotor2Down.Image")));
      this.Rotor2Down.Location = new System.Drawing.Point(67, 187);
      this.Rotor2Down.Name = "Rotor2Down";
      this.Rotor2Down.Size = new System.Drawing.Size(39, 79);
      this.Rotor2Down.TabIndex = 16;
      this.Rotor2Down.Click += new System.EventHandler(this.BtnRotor2DownClick);
      // 
      // RingRotorsInfo
      // 
      this.RingRotorsInfo.Controls.Add(this.lblRotorS);
      this.RingRotorsInfo.Controls.Add(this.lblRotorM);
      this.RingRotorsInfo.Controls.Add(this.lblRotorD);
      this.RingRotorsInfo.Controls.Add(this.Rotor1Down);
      this.RingRotorsInfo.Controls.Add(this.Rotor2Down);
      this.RingRotorsInfo.Controls.Add(this.Rotor1Up);
      this.RingRotorsInfo.Controls.Add(this.Rotor2Up);
      this.RingRotorsInfo.Controls.Add(this.Rotor3Down);
      this.RingRotorsInfo.Controls.Add(this.Rotor3Up);
      this.RingRotorsInfo.Controls.Add(this.Rotor1Info);
      this.RingRotorsInfo.Controls.Add(this.Rotor2Info);
      this.RingRotorsInfo.Controls.Add(this.Rotor3Info);
      this.RingRotorsInfo.Location = new System.Drawing.Point(547, 10);
      this.RingRotorsInfo.Name = "RingRotorsInfo";
      this.RingRotorsInfo.Size = new System.Drawing.Size(173, 285);
      this.RingRotorsInfo.TabIndex = 15;
      this.RingRotorsInfo.TabStop = false;
      this.RingRotorsInfo.Text = "Роторы и настройка колец";
      // 
      // lblRotorS
      // 
      this.lblRotorS.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.lblRotorS.Location = new System.Drawing.Point(19, 20);
      this.lblRotorS.Name = "lblRotorS";
      this.lblRotorS.Size = new System.Drawing.Size(39, 29);
      this.lblRotorS.TabIndex = 20;
      this.lblRotorS.Text = "I";
      this.lblRotorS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblRotorD
      // 
      this.lblRotorD.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.lblRotorD.Location = new System.Drawing.Point(115, 20);
      this.lblRotorD.Name = "lblRotorD";
      this.lblRotorD.Size = new System.Drawing.Size(39, 29);
      this.lblRotorD.TabIndex = 18;
      this.lblRotorD.Text = "III";
      this.lblRotorD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Rotor1Down
      // 
      this.Rotor1Down.Image = ((System.Drawing.Image)(resources.GetObject("Rotor1Down.Image")));
      this.Rotor1Down.Location = new System.Drawing.Point(115, 187);
      this.Rotor1Down.Name = "Rotor1Down";
      this.Rotor1Down.Size = new System.Drawing.Size(39, 79);
      this.Rotor1Down.TabIndex = 17;
      this.Rotor1Down.Click += new System.EventHandler(this.BtnRotor1DownClick);
      // 
      // SettingsButton
      // 
      this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
      this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.SettingsButton.Location = new System.Drawing.Point(19, 138);
      this.SettingsButton.Name = "SettingsButton";
      this.SettingsButton.Size = new System.Drawing.Size(96, 39);
      this.SettingsButton.TabIndex = 12;
      this.SettingsButton.Text = "Настройки";
      this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.SettingsButton.Click += new System.EventHandler(this.BtnSettingsClick);
      // 
      // EncryptDecryptButton
      // 
      this.EncryptDecryptButton.Image = ((System.Drawing.Image)(resources.GetObject("EncryptDecryptButton.Image")));
      this.EncryptDecryptButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.EncryptDecryptButton.Location = new System.Drawing.Point(310, 138);
      this.EncryptDecryptButton.Name = "EncryptDecryptButton";
      this.EncryptDecryptButton.Size = new System.Drawing.Size(228, 39);
      this.EncryptDecryptButton.TabIndex = 14;
      this.EncryptDecryptButton.Text = "Зашифровать/дешифровать текст";
      this.EncryptDecryptButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.EncryptDecryptButton.Click += new System.EventHandler(this.Button1Click);
      // 
      // PlugboardSettings
      // 
      this.PlugboardSettings.Location = new System.Drawing.Point(121, 138);
      this.PlugboardSettings.Name = "PlugboardSettings";
      this.PlugboardSettings.Size = new System.Drawing.Size(183, 39);
      this.PlugboardSettings.TabIndex = 16;
      this.PlugboardSettings.Text = "Ком.панель";
      this.PlugboardSettings.UseVisualStyleBackColor = true;
      this.PlugboardSettings.Click += new System.EventHandler(this.PlugboardSettingsClick);
      // 
      // MainForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
      this.ClientSize = new System.Drawing.Size(728, 337);
      this.Controls.Add(this.PlugboardSettings);
      this.Controls.Add(this.RingRotorsInfo);
      this.Controls.Add(this.EncryptDecryptButton);
      this.Controls.Add(this.SettingsButton);
      this.Controls.Add(this.txtFinal);
      this.Controls.Add(this.txtInit);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Enigma";
      this.Load += new System.EventHandler(this.MainFormLoad);
      this.RingRotorsInfo.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }
		

		void MainFormLoad(object sender, System.EventArgs e)
		{
			RightRotor = new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", Rotor1Info, 'V');
			MiddleRotor = new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", Rotor2Info, 'E');
			LeftRotor = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", Rotor3Info, 'Q');
			reflector = new Rotor("YRUHQSLDPXNGOKMIEBFZCWVJAT", null, '\0');

			//J,Z

			RightRotor.SetNextRotor(MiddleRotor);
			MiddleRotor.SetNextRotor(LeftRotor);
			LeftRotor.SetNextRotor(reflector);
			MiddleRotor.SetPreviousRotor(RightRotor);
			LeftRotor.SetPreviousRotor(MiddleRotor);
			reflector.SetPreviousRotor(LeftRotor);

		}


		void BtnSettingsClick(object sender, System.EventArgs e)
		{
			Settings s = new(this);
			s.ShowDialog();
		}

		void TxtInitTextChanged(object sender, System.EventArgs e)
		{
      
    }

		void TxtInitKeyUp(object sender, KeyEventArgs e)
		{
			if ((e.KeyValue >= 65 && e.KeyValue <= 90) && !e.Control)
			{
				RightRotor.Move();
				RightRotor.PutDataIn((char)e.KeyValue);
				txtFinal.AppendText("" + RightRotor.GetDataOut());
			}
		}

		void BtnRotor1UpClick(object sender, System.EventArgs e)
		{
			RightRotor.Move();
		}

		void BtnRotor1DownClick(object sender, System.EventArgs e)
		{
			RightRotor.MoveBack();
		}
		void BtnRotor2UpClick(object sender, System.EventArgs e)
		{
			MiddleRotor.Move();
		}
		void BtnRotor2DownClick(object sender, System.EventArgs e)
		{
			MiddleRotor.MoveBack();
		}
		void BtnRotor3UpClick(object sender, System.EventArgs e)
		{
			LeftRotor.Move();
		}

		void BtnRotor3DownClick(object sender, System.EventArgs e)
		{
			LeftRotor.MoveBack();
		}

		void Button1Click(object sender, System.EventArgs e)
		{
			char[] chIn = txtInit.Text.ToUpper().ToCharArray();
			txtFinal.Text = "";
			for (int i = 0; i < chIn.Length; i++)
			{
				if (chIn[i] >= 65 && chIn[i] <= 90)
				{
					RightRotor.Move();
					RightRotor.PutDataIn(chIn[i]);
					txtFinal.AppendText("" + RightRotor.GetDataOut());
				}
			}
		}

		public void ChangeRotors(string rot1, string rotName1, char rotNotch1,
														 string rot2, string rotName2, char rotNotch2,
														 string rot3, string rotName3, char rotNotch3)
		{
			lblRotorS.Text = rotName1;
			lblRotorM.Text = rotName2;
			lblRotorD.Text = rotName3;
			RightRotor = null;
			MiddleRotor = null;
			LeftRotor = null;

			RightRotor = new Rotor(rot3, Rotor1Info, rotNotch3);
			MiddleRotor = new Rotor(rot2, Rotor2Info, rotNotch2);
			LeftRotor = new Rotor(rot1, Rotor3Info, rotNotch1);

			RightRotor.ResetOffset();
			MiddleRotor.ResetOffset();
			LeftRotor.ResetOffset();

			RightRotor.SetNextRotor(MiddleRotor);
			MiddleRotor.SetNextRotor(LeftRotor);
			LeftRotor.SetNextRotor(reflector);
			MiddleRotor.SetPreviousRotor(RightRotor);
			LeftRotor.SetPreviousRotor(MiddleRotor);
			reflector.SetPreviousRotor(LeftRotor);

			Rotor1Info.Text = "A";
			Rotor2Info.Text = "A";
			Rotor3Info.Text = "A";
		}

		public void SetReflector(string refl)
		{
			reflector = new Rotor(refl, null, '\0');
			reflector.SetPreviousRotor(LeftRotor);
			LeftRotor.SetNextRotor(reflector);
		}

		public string GetReflector()
		{
			return reflector.GetLayout();
		}

    public string GetRightRotor()
		{
			return RightRotor.GetLayout();
		}

    private void PlugboardSettingsClick(object sender, EventArgs e)
    {
      Plugboard p = new(this);
      p.ShowDialog();
    }

    public string GetMiddleRotor()
		{
			return MiddleRotor.GetLayout();
		}
		public string GetLeftRotor()
		{
			return LeftRotor.GetLayout();
		}

    
  }
}