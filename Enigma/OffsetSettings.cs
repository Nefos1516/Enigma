using System;
using System.Windows.Forms;

namespace Enigma
{
  public class OffsetSettings : Form
  {
    private Label lblRotorL;
    private Label lblRotorM;
    private Label lblRotorR;
    private Button Rotor1Down;
    private Button Rotor2Down;
    private Button Rotor1Up;
    private Button Rotor2Up;
    private Button Rotor3Down;
    private Button Rotor3Up;
    private Label Rotor1Info;
    private Label Rotor2Info;
    private Label Rotor3Info;
    private Label label1;
    private MainForm mainForm;
    private Rotor RightRotor, MiddleRotor, LeftRotor;
    private Button OkButton;

    public OffsetSettings(MainForm mainForm)
    {
      InitializeComponent();
      this.mainForm = mainForm;
    }

    private void Rotor1Up_Click(object sender, EventArgs e)
    {
      RightRotor.ChangeRotorOffsetUp();
    }

    private void Rotor1Down_Click(object sender, EventArgs e)
    {
      RightRotor.ChangeRotorOffsetDown();
    }
    private void Rotor2Up_Click(object sender, EventArgs e)
    {
      MiddleRotor.ChangeRotorOffsetUp();
    }

    private void Rotor2Down_Click(object sender, EventArgs e)
    {
      MiddleRotor.ChangeRotorOffsetDown();
    }

    private void Rotor3Up_Click(object sender, EventArgs e)
    {
      LeftRotor.ChangeRotorOffsetUp();
    }

    private void Rotor3Down_Click(object sender, EventArgs e)
    {
      LeftRotor.ChangeRotorOffsetDown();
    }

    private void OkButton_Click(object sender, EventArgs e)
    {
      mainForm.GetInfoAbtRotors(LeftRotor, MiddleRotor, RightRotor);
      Close();
    }

    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OffsetSettings));
      this.lblRotorL = new System.Windows.Forms.Label();
      this.lblRotorM = new System.Windows.Forms.Label();
      this.lblRotorR = new System.Windows.Forms.Label();
      this.Rotor1Down = new System.Windows.Forms.Button();
      this.Rotor2Down = new System.Windows.Forms.Button();
      this.Rotor1Up = new System.Windows.Forms.Button();
      this.Rotor2Up = new System.Windows.Forms.Button();
      this.Rotor3Down = new System.Windows.Forms.Button();
      this.Rotor3Up = new System.Windows.Forms.Button();
      this.Rotor1Info = new System.Windows.Forms.Label();
      this.Rotor2Info = new System.Windows.Forms.Label();
      this.Rotor3Info = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.OkButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblRotorL
      // 
      this.lblRotorL.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.lblRotorL.Location = new System.Drawing.Point(141, 99);
      this.lblRotorL.Name = "lblRotorL";
      this.lblRotorL.Size = new System.Drawing.Size(39, 29);
      this.lblRotorL.TabIndex = 32;
      this.lblRotorL.Text = "I";
      this.lblRotorL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblRotorM
      // 
      this.lblRotorM.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.lblRotorM.Location = new System.Drawing.Point(186, 99);
      this.lblRotorM.Name = "lblRotorM";
      this.lblRotorM.Size = new System.Drawing.Size(39, 29);
      this.lblRotorM.TabIndex = 31;
      this.lblRotorM.Text = "II";
      this.lblRotorM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblRotorR
      // 
      this.lblRotorR.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.lblRotorR.Location = new System.Drawing.Point(237, 99);
      this.lblRotorR.Name = "lblRotorR";
      this.lblRotorR.Size = new System.Drawing.Size(39, 29);
      this.lblRotorR.TabIndex = 30;
      this.lblRotorR.Text = "III";
      this.lblRotorR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Rotor1Down
      // 
      this.Rotor1Down.Image = global::Enigma.Properties.Resources.Down;
      this.Rotor1Down.Location = new System.Drawing.Point(237, 269);
      this.Rotor1Down.Name = "Rotor1Down";
      this.Rotor1Down.Size = new System.Drawing.Size(39, 79);
      this.Rotor1Down.TabIndex = 29;
      this.Rotor1Down.Click += new System.EventHandler(this.Rotor1Down_Click);
      // 
      // Rotor2Down
      // 
      this.Rotor2Down.Image = global::Enigma.Properties.Resources.Down;
      this.Rotor2Down.Location = new System.Drawing.Point(189, 269);
      this.Rotor2Down.Name = "Rotor2Down";
      this.Rotor2Down.Size = new System.Drawing.Size(39, 79);
      this.Rotor2Down.TabIndex = 28;
      this.Rotor2Down.Click += new System.EventHandler(this.Rotor2Down_Click);
      // 
      // Rotor1Up
      // 
      this.Rotor1Up.Image = global::Enigma.Properties.Resources.Up;
      this.Rotor1Up.Location = new System.Drawing.Point(237, 131);
      this.Rotor1Up.Name = "Rotor1Up";
      this.Rotor1Up.Size = new System.Drawing.Size(39, 79);
      this.Rotor1Up.TabIndex = 27;
      this.Rotor1Up.Click += new System.EventHandler(this.Rotor1Up_Click);
      // 
      // Rotor2Up
      // 
      this.Rotor2Up.Image = global::Enigma.Properties.Resources.Up;
      this.Rotor2Up.Location = new System.Drawing.Point(189, 131);
      this.Rotor2Up.Name = "Rotor2Up";
      this.Rotor2Up.Size = new System.Drawing.Size(39, 79);
      this.Rotor2Up.TabIndex = 26;
      this.Rotor2Up.Click += new System.EventHandler(this.Rotor2Up_Click);
      // 
      // Rotor3Down
      // 
      this.Rotor3Down.Image = global::Enigma.Properties.Resources.Down;
      this.Rotor3Down.Location = new System.Drawing.Point(141, 269);
      this.Rotor3Down.Name = "Rotor3Down";
      this.Rotor3Down.Size = new System.Drawing.Size(39, 79);
      this.Rotor3Down.TabIndex = 25;
      this.Rotor3Down.Click += new System.EventHandler(this.Rotor3Down_Click);
      // 
      // Rotor3Up
      // 
      this.Rotor3Up.Image = global::Enigma.Properties.Resources.Up;
      this.Rotor3Up.Location = new System.Drawing.Point(141, 131);
      this.Rotor3Up.Name = "Rotor3Up";
      this.Rotor3Up.Size = new System.Drawing.Size(39, 79);
      this.Rotor3Up.TabIndex = 24;
      this.Rotor3Up.Click += new System.EventHandler(this.Rotor3Up_Click);
      // 
      // Rotor1Info
      // 
      this.Rotor1Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Rotor1Info.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.Rotor1Info.Location = new System.Drawing.Point(237, 220);
      this.Rotor1Info.Name = "Rotor1Info";
      this.Rotor1Info.Size = new System.Drawing.Size(39, 39);
      this.Rotor1Info.TabIndex = 23;
      this.Rotor1Info.Text = "A";
      this.Rotor1Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Rotor2Info
      // 
      this.Rotor2Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Rotor2Info.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.Rotor2Info.Location = new System.Drawing.Point(189, 220);
      this.Rotor2Info.Name = "Rotor2Info";
      this.Rotor2Info.Size = new System.Drawing.Size(39, 39);
      this.Rotor2Info.TabIndex = 22;
      this.Rotor2Info.Text = "A";
      this.Rotor2Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Rotor3Info
      // 
      this.Rotor3Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Rotor3Info.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.Rotor3Info.Location = new System.Drawing.Point(141, 220);
      this.Rotor3Info.Name = "Rotor3Info";
      this.Rotor3Info.Size = new System.Drawing.Size(39, 39);
      this.Rotor3Info.TabIndex = 21;
      this.Rotor3Info.Text = "A";
      this.Rotor3Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(88, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(245, 75);
      this.label1.TabIndex = 33;
      this.label1.Text = "В данном окне настраивается разница \r\nмежду кольцом ротора и самим ротором. \r\nЕсл" +
    "и по умолчанию разница отсутствует, \r\nто в случае изменения этого параметра\r\nкод" +
    "ировка может измениться.";
      // 
      // OkButton
      // 
      this.OkButton.Image = global::Enigma.Properties.Resources.Check;
      this.OkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.OkButton.Location = new System.Drawing.Point(324, 325);
      this.OkButton.Name = "OkButton";
      this.OkButton.Size = new System.Drawing.Size(91, 40);
      this.OkButton.TabIndex = 34;
      this.OkButton.Text = "Ок";
      this.OkButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.OkButton.UseVisualStyleBackColor = true;
      this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
      // 
      // OffsetSettings
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
      this.ClientSize = new System.Drawing.Size(427, 377);
      this.Controls.Add(this.OkButton);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.lblRotorL);
      this.Controls.Add(this.lblRotorM);
      this.Controls.Add(this.lblRotorR);
      this.Controls.Add(this.Rotor1Down);
      this.Controls.Add(this.Rotor2Down);
      this.Controls.Add(this.Rotor1Up);
      this.Controls.Add(this.Rotor2Up);
      this.Controls.Add(this.Rotor3Down);
      this.Controls.Add(this.Rotor3Up);
      this.Controls.Add(this.Rotor1Info);
      this.Controls.Add(this.Rotor2Info);
      this.Controls.Add(this.Rotor3Info);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "OffsetSettings";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Настройка разницы между ротором и кольцом";
      this.Load += new System.EventHandler(this.OffsetSettings_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    private void OffsetSettings_Load(object sender, EventArgs e)
    {
      LeftRotor = mainForm.GiveInfoAbtRotorL();
      MiddleRotor = mainForm.GiveInfoAbtRotorM();
      RightRotor = mainForm.GiveInfoAbtRotorR();
      LeftRotor.ChangeOffsetLabel(Rotor3Info);
      MiddleRotor.ChangeOffsetLabel(Rotor2Info);
      RightRotor.ChangeOffsetLabel(Rotor1Info);
      lblRotorL.Text = mainForm.GiveInfoAbtLblL();
      lblRotorM.Text = mainForm.GiveInfoAbtLblM();
      lblRotorR.Text = mainForm.GiveInfoAbtLblR();
    }


  }

}