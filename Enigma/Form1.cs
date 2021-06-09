using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Enigma
{
  public class MainForm : Form
  {
    private Button Rotor1Down;
    private Label lblRotorR;
    private Label lblRotorL;
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
    private Button GoToOffsetSettings;
    private Rotor RightRotor, MiddleRotor, LeftRotor, reflector;
    private Dictionary<int, char[]> SteckerWiring = new();

    public MainForm()
    {
      InitializeComponent();
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
      this.lblRotorL = new System.Windows.Forms.Label();
      this.lblRotorR = new System.Windows.Forms.Label();
      this.Rotor1Down = new System.Windows.Forms.Button();
      this.SettingsButton = new System.Windows.Forms.Button();
      this.PlugboardSettings = new System.Windows.Forms.Button();
      this.GoToOffsetSettings = new System.Windows.Forms.Button();
      this.RingRotorsInfo.SuspendLayout();
      this.SuspendLayout();
      // 
      // Rotor3Down
      // 
      this.Rotor3Down.Image = global::Enigma.Properties.Resources.Down;
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
      this.Rotor3Up.Image = global::Enigma.Properties.Resources.Up;
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
      this.Rotor2Up.Image = global::Enigma.Properties.Resources.Up;
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
      this.txtFinal.PlaceholderText = "Полученный текст";
      this.txtFinal.Size = new System.Drawing.Size(519, 108);
      this.txtFinal.TabIndex = 10;
      // 
      // Rotor1Up
      // 
      this.Rotor1Up.Image = global::Enigma.Properties.Resources.Up;
      this.Rotor1Up.Location = new System.Drawing.Point(115, 49);
      this.Rotor1Up.Name = "Rotor1Up";
      this.Rotor1Up.Size = new System.Drawing.Size(39, 79);
      this.Rotor1Up.TabIndex = 15;
      this.Rotor1Up.Click += new System.EventHandler(this.BtnRotor1UpClick);
      // 
      // txtInit
      // 
      this.txtInit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtInit.Location = new System.Drawing.Point(19, 20);
      this.txtInit.Multiline = true;
      this.txtInit.Name = "txtInit";
      this.txtInit.PlaceholderText = "Введите текст на латинице";
      this.txtInit.Size = new System.Drawing.Size(519, 108);
      this.txtInit.TabIndex = 9;
      this.txtInit.TextChanged += new System.EventHandler(this.TxtInitTextChanged);
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
      this.Rotor2Down.Image = global::Enigma.Properties.Resources.Down;
      this.Rotor2Down.Location = new System.Drawing.Point(67, 187);
      this.Rotor2Down.Name = "Rotor2Down";
      this.Rotor2Down.Size = new System.Drawing.Size(39, 79);
      this.Rotor2Down.TabIndex = 16;
      this.Rotor2Down.Click += new System.EventHandler(this.BtnRotor2DownClick);
      // 
      // RingRotorsInfo
      // 
      this.RingRotorsInfo.Controls.Add(this.lblRotorL);
      this.RingRotorsInfo.Controls.Add(this.lblRotorM);
      this.RingRotorsInfo.Controls.Add(this.lblRotorR);
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
      // lblRotorL
      // 
      this.lblRotorL.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.lblRotorL.Location = new System.Drawing.Point(19, 20);
      this.lblRotorL.Name = "lblRotorL";
      this.lblRotorL.Size = new System.Drawing.Size(39, 29);
      this.lblRotorL.TabIndex = 20;
      this.lblRotorL.Text = "III";
      this.lblRotorL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblRotorR
      // 
      this.lblRotorR.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.lblRotorR.Location = new System.Drawing.Point(115, 20);
      this.lblRotorR.Name = "lblRotorR";
      this.lblRotorR.Size = new System.Drawing.Size(39, 29);
      this.lblRotorR.TabIndex = 18;
      this.lblRotorR.Text = "I";
      this.lblRotorR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Rotor1Down
      // 
      this.Rotor1Down.Image = global::Enigma.Properties.Resources.Down;
      this.Rotor1Down.Location = new System.Drawing.Point(115, 187);
      this.Rotor1Down.Name = "Rotor1Down";
      this.Rotor1Down.Size = new System.Drawing.Size(39, 79);
      this.Rotor1Down.TabIndex = 17;
      this.Rotor1Down.Click += new System.EventHandler(this.BtnRotor1DownClick);
      // 
      // SettingsButton
      // 
      this.SettingsButton.Image = global::Enigma.Properties.Resources.Gearwheel;
      this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.SettingsButton.Location = new System.Drawing.Point(19, 138);
      this.SettingsButton.Name = "SettingsButton";
      this.SettingsButton.Size = new System.Drawing.Size(96, 39);
      this.SettingsButton.TabIndex = 12;
      this.SettingsButton.Text = "Настройки";
      this.SettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.SettingsButton.Click += new System.EventHandler(this.BtnSettingsClick);
      // 
      // PlugboardSettings
      // 
      this.PlugboardSettings.Location = new System.Drawing.Point(355, 138);
      this.PlugboardSettings.Name = "PlugboardSettings";
      this.PlugboardSettings.Size = new System.Drawing.Size(183, 39);
      this.PlugboardSettings.TabIndex = 16;
      this.PlugboardSettings.Text = "Комммутационная панель";
      this.PlugboardSettings.UseVisualStyleBackColor = true;
      this.PlugboardSettings.Click += new System.EventHandler(this.PlugboardSettingsClick);
      // 
      // GoToOffsetSettings
      // 
      this.GoToOffsetSettings.Location = new System.Drawing.Point(121, 138);
      this.GoToOffsetSettings.Name = "GoToOffsetSettings";
      this.GoToOffsetSettings.Size = new System.Drawing.Size(228, 39);
      this.GoToOffsetSettings.TabIndex = 17;
      this.GoToOffsetSettings.Text = "Настройка разницы кольца и ротора";
      this.GoToOffsetSettings.UseVisualStyleBackColor = true;
      this.GoToOffsetSettings.Click += new System.EventHandler(this.button1_Click);
      // 
      // MainForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
      this.ClientSize = new System.Drawing.Size(728, 337);
      this.Controls.Add(this.GoToOffsetSettings);
      this.Controls.Add(this.PlugboardSettings);
      this.Controls.Add(this.RingRotorsInfo);
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
      LeftRotor = new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", Rotor3Info, 'V');
      MiddleRotor = new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", Rotor2Info, 'E');
      RightRotor = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", Rotor1Info, 'Q');
      reflector = new Rotor("YRUHQSLDPXNGOKMIEBFZCWVJAT", null, '\0');

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
      if (txtInit.Text.Length < txtFinal.Text.Length)
      {
        string s = txtFinal.Text;
        for (int i = 0; i < s.Length - txtInit.Text.Length; i++)
        {
          RightRotor.MoveBack();
        }
        txtFinal.Clear();
        txtFinal.AppendText(s.Remove(txtInit.Text.Length));
      }

      if (txtInit.Text.Length > txtFinal.Text.Length)
      {
        char[] charArray = txtInit.Text[txtFinal.Text.Length..].ToUpper().ToCharArray();
        foreach (char c in charArray)
        {
          char q = c;
          if (q >= 65 && q <= 90)
          {
            q = ChangeCharPlugs(q);
            RightRotor.Move();
            RightRotor.PutDataIn(q);
            q = RightRotor.GetDataOut();
            txtFinal.AppendText("" + ChangeCharPlugs(q));
          }
          else
          {
            int l = txtInit.Text.IndexOf(q);
            if (l == 0)
            {
              txtInit.Clear();
            }
            else if (l <= txtInit.Text.Length && l > 0)
            {
              txtInit.Text = txtInit.Text.Remove(l, 1);
              txtInit.SelectionStart = txtInit.Text.Length;
            }
          }
        }
      }
    }
    void BtnRotor1UpClick(object sender, System.EventArgs e)
    {
      RightRotor.MoveByClick();
    }

    void BtnRotor1DownClick(object sender, System.EventArgs e)
    {
      RightRotor.MoveBackByClick();
    }
    void BtnRotor2UpClick(object sender, System.EventArgs e)
    {
      MiddleRotor.MoveByClick();
    }
    void BtnRotor2DownClick(object sender, System.EventArgs e)
    {
      MiddleRotor.MoveBackByClick();
    }
    void BtnRotor3UpClick(object sender, System.EventArgs e)
    {
      LeftRotor.MoveByClick();
    }

    void BtnRotor3DownClick(object sender, System.EventArgs e)
    {
      LeftRotor.MoveBackByClick();
    }
    public void ChangeRotors(string rot1, string rotName1, char rotNotch1,
                             string rot2, string rotName2, char rotNotch2,
                             string rot3, string rotName3, char rotNotch3)
    {
      lblRotorL.Text = rotName1;
      lblRotorM.Text = rotName2;
      lblRotorR.Text = rotName3;
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

    private void button1_Click(object sender, EventArgs e)
    {
      OffsetSettings os = new(this);
      os.ShowDialog();
    }

    public char ChangeCharPlugs(char c)
    {
      foreach (char[] wires in SteckerWiring.Values)
      {
        if (c == wires[0])
        {
          c = wires[1];
          return c;
        }
        else if (c == wires[1])
        {
          c = wires[0];
          return c;
        }
      }
      return c;
    }
    public void GetPlugbord(Dictionary<int, char[]> dict)
    {
      SteckerWiring = dict;
    }

    public string GiveInfoAbtLblL()
    {
      return lblRotorL.Text;
    }

    public string GiveInfoAbtLblM()
    {
      return lblRotorM.Text;
    }

    public string GiveInfoAbtLblR()
    {
      return lblRotorR.Text;
    }
    public Rotor GiveInfoAbtRotorL()
    {
      return LeftRotor;
    }
    public Rotor GiveInfoAbtRotorM()
    {
      return MiddleRotor;
    }
    public Rotor GiveInfoAbtRotorR()
    {
      return RightRotor;
    }

    public void GetInfoAbtRotors(Rotor rot1, Rotor rot2, Rotor rot3)
    {
      LeftRotor = rot1;
      MiddleRotor = rot2;
      RightRotor = rot3;
    }
  }
}