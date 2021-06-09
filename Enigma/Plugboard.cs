using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace Enigma
{
	public class Plugboard : Form
	{
    private Button OkButton;
    private Button Cancel;
    private MaskedTextBox Plug1;
    private MaskedTextBox Plug2;
    private MaskedTextBox Plug12;
    private MaskedTextBox Plug11;
    private MaskedTextBox Plug10;
    private MaskedTextBox Plug9;
    private MaskedTextBox Plug8;
    private MaskedTextBox Plug7;
    private MaskedTextBox Plug6;
    private MaskedTextBox Plug5;
    private MaskedTextBox Plug4;
    private MaskedTextBox Plug3;
    private MaskedTextBox Plug13;
    private Label label1;
    private ArrayList charsForWiring = new();
    private Dictionary<int, char[]> SteckerWiring = new(13);
    private Button ClearArraysAndPlugs;
    private MainForm mainForm;

		public Plugboard(MainForm mainForm)
		{
			InitializeComponent();
			this.mainForm = mainForm;
		}

		private void InitializeComponent()
		{
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plugboard));
      this.OkButton = new System.Windows.Forms.Button();
      this.Cancel = new System.Windows.Forms.Button();
      this.Plug1 = new System.Windows.Forms.MaskedTextBox();
      this.Plug2 = new System.Windows.Forms.MaskedTextBox();
      this.Plug12 = new System.Windows.Forms.MaskedTextBox();
      this.Plug11 = new System.Windows.Forms.MaskedTextBox();
      this.Plug10 = new System.Windows.Forms.MaskedTextBox();
      this.Plug9 = new System.Windows.Forms.MaskedTextBox();
      this.Plug8 = new System.Windows.Forms.MaskedTextBox();
      this.Plug7 = new System.Windows.Forms.MaskedTextBox();
      this.Plug6 = new System.Windows.Forms.MaskedTextBox();
      this.Plug5 = new System.Windows.Forms.MaskedTextBox();
      this.Plug4 = new System.Windows.Forms.MaskedTextBox();
      this.Plug3 = new System.Windows.Forms.MaskedTextBox();
      this.Plug13 = new System.Windows.Forms.MaskedTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.ClearArraysAndPlugs = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // OkButton
      // 
      this.OkButton.Image = global::Enigma.Properties.Resources.Check;
      this.OkButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.OkButton.Location = new System.Drawing.Point(298, 384);
      this.OkButton.Name = "OkButton";
      this.OkButton.Size = new System.Drawing.Size(100, 38);
      this.OkButton.TabIndex = 0;
      this.OkButton.Text = "Ок";
      this.OkButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.OkButton.UseVisualStyleBackColor = true;
      this.OkButton.Click += new System.EventHandler(this.OkButtonClick);
      // 
      // Cancel
      // 
      this.Cancel.Image = global::Enigma.Properties.Resources.Delete;
      this.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.Cancel.Location = new System.Drawing.Point(192, 384);
      this.Cancel.Name = "Cancel";
      this.Cancel.Size = new System.Drawing.Size(100, 38);
      this.Cancel.TabIndex = 1;
      this.Cancel.Text = "Отмена";
      this.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.Cancel.UseVisualStyleBackColor = true;
      this.Cancel.Click += new System.EventHandler(this.CancelClick);
      // 
      // Plug1
      // 
      this.Plug1.AsciiOnly = true;
      this.Plug1.Culture = new System.Globalization.CultureInfo("en-US");
      this.Plug1.Location = new System.Drawing.Point(12, 113);
      this.Plug1.Mask = "LL";
      this.Plug1.Name = "Plug1";
      this.Plug1.Size = new System.Drawing.Size(50, 23);
      this.Plug1.TabIndex = 2;
      this.Plug1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Plug1.TextChanged += new System.EventHandler(this.Plug1TextChanged);
      // 
      // Plug2
      // 
      this.Plug2.AsciiOnly = true;
      this.Plug2.Culture = new System.Globalization.CultureInfo("en-US");
      this.Plug2.Location = new System.Drawing.Point(68, 113);
      this.Plug2.Mask = "LL";
      this.Plug2.Name = "Plug2";
      this.Plug2.Size = new System.Drawing.Size(50, 23);
      this.Plug2.TabIndex = 3;
      this.Plug2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Plug2.TextChanged += new System.EventHandler(this.Plug2TextChanged);
      // 
      // Plug12
      // 
      this.Plug12.AsciiOnly = true;
      this.Plug12.Culture = new System.Globalization.CultureInfo("en-US");
      this.Plug12.Location = new System.Drawing.Point(261, 142);
      this.Plug12.Mask = "LL";
      this.Plug12.Name = "Plug12";
      this.Plug12.Size = new System.Drawing.Size(50, 23);
      this.Plug12.TabIndex = 13;
      this.Plug12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Plug12.TextChanged += new System.EventHandler(this.Plug12TextChanged);
      // 
      // Plug11
      // 
      this.Plug11.AsciiOnly = true;
      this.Plug11.Culture = new System.Globalization.CultureInfo("en-US");
      this.Plug11.Location = new System.Drawing.Point(205, 142);
      this.Plug11.Mask = "LL";
      this.Plug11.Name = "Plug11";
      this.Plug11.Size = new System.Drawing.Size(50, 23);
      this.Plug11.TabIndex = 12;
      this.Plug11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Plug11.TextChanged += new System.EventHandler(this.Plug11TextChanged);
      // 
      // Plug10
      // 
      this.Plug10.AsciiOnly = true;
      this.Plug10.Culture = new System.Globalization.CultureInfo("en-US");
      this.Plug10.Location = new System.Drawing.Point(149, 142);
      this.Plug10.Mask = "LL";
      this.Plug10.Name = "Plug10";
      this.Plug10.Size = new System.Drawing.Size(50, 23);
      this.Plug10.TabIndex = 11;
      this.Plug10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Plug10.TextChanged += new System.EventHandler(this.Plug10TextChanged);
      // 
      // Plug9
      // 
      this.Plug9.AsciiOnly = true;
      this.Plug9.Culture = new System.Globalization.CultureInfo("en-US");
      this.Plug9.Location = new System.Drawing.Point(93, 142);
      this.Plug9.Mask = "LL";
      this.Plug9.Name = "Plug9";
      this.Plug9.Size = new System.Drawing.Size(50, 23);
      this.Plug9.TabIndex = 10;
      this.Plug9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Plug9.TextChanged += new System.EventHandler(this.Plug9TextChanged);
      // 
      // Plug8
      // 
      this.Plug8.AsciiOnly = true;
      this.Plug8.Culture = new System.Globalization.CultureInfo("en-US");
      this.Plug8.Location = new System.Drawing.Point(37, 142);
      this.Plug8.Mask = "LL";
      this.Plug8.Name = "Plug8";
      this.Plug8.Size = new System.Drawing.Size(50, 23);
      this.Plug8.TabIndex = 9;
      this.Plug8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Plug8.TextChanged += new System.EventHandler(this.Plug8TextChanged);
      // 
      // Plug7
      // 
      this.Plug7.AsciiOnly = true;
      this.Plug7.Culture = new System.Globalization.CultureInfo("en-US");
      this.Plug7.Location = new System.Drawing.Point(348, 113);
      this.Plug7.Mask = "LL";
      this.Plug7.Name = "Plug7";
      this.Plug7.Size = new System.Drawing.Size(50, 23);
      this.Plug7.TabIndex = 8;
      this.Plug7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Plug7.TextChanged += new System.EventHandler(this.Plug7TextChanged);
      // 
      // Plug6
      // 
      this.Plug6.AsciiOnly = true;
      this.Plug6.Culture = new System.Globalization.CultureInfo("en-US");
      this.Plug6.Location = new System.Drawing.Point(292, 113);
      this.Plug6.Mask = "LL";
      this.Plug6.Name = "Plug6";
      this.Plug6.Size = new System.Drawing.Size(50, 23);
      this.Plug6.TabIndex = 7;
      this.Plug6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Plug6.TextChanged += new System.EventHandler(this.Plug6TextChanged);
      // 
      // Plug5
      // 
      this.Plug5.AsciiOnly = true;
      this.Plug5.Culture = new System.Globalization.CultureInfo("en-US");
      this.Plug5.Location = new System.Drawing.Point(236, 113);
      this.Plug5.Mask = "LL";
      this.Plug5.Name = "Plug5";
      this.Plug5.Size = new System.Drawing.Size(50, 23);
      this.Plug5.TabIndex = 6;
      this.Plug5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Plug5.TextChanged += new System.EventHandler(this.Plug5TextChanged);
      // 
      // Plug4
      // 
      this.Plug4.AsciiOnly = true;
      this.Plug4.Culture = new System.Globalization.CultureInfo("en-US");
      this.Plug4.Location = new System.Drawing.Point(180, 113);
      this.Plug4.Mask = "LL";
      this.Plug4.Name = "Plug4";
      this.Plug4.Size = new System.Drawing.Size(50, 23);
      this.Plug4.TabIndex = 5;
      this.Plug4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Plug4.TextChanged += new System.EventHandler(this.Plug4TextChanged);
      // 
      // Plug3
      // 
      this.Plug3.AsciiOnly = true;
      this.Plug3.Culture = new System.Globalization.CultureInfo("en-US");
      this.Plug3.Location = new System.Drawing.Point(124, 113);
      this.Plug3.Mask = "LL";
      this.Plug3.Name = "Plug3";
      this.Plug3.Size = new System.Drawing.Size(50, 23);
      this.Plug3.TabIndex = 4;
      this.Plug3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Plug3.TextChanged += new System.EventHandler(this.Plug3TextChanged);
      // 
      // Plug13
      // 
      this.Plug13.AsciiOnly = true;
      this.Plug13.Culture = new System.Globalization.CultureInfo("en-US");
      this.Plug13.Location = new System.Drawing.Point(317, 142);
      this.Plug13.Mask = "LL";
      this.Plug13.Name = "Plug13";
      this.Plug13.Size = new System.Drawing.Size(50, 23);
      this.Plug13.TabIndex = 14;
      this.Plug13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.Plug13.TextChanged += new System.EventHandler(this.Plug13TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 59);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(391, 30);
      this.label1.TabIndex = 15;
      this.label1.Text = "Каждое окно ввода отвечает за две буквы, то есть за одно соединение\n Буквы могут " +
    "быть только латинского алфавита";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // ClearArraysAndPlugs
      // 
      this.ClearArraysAndPlugs.Image = global::Enigma.Properties.Resources.Delete;
      this.ClearArraysAndPlugs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.ClearArraysAndPlugs.Location = new System.Drawing.Point(134, 171);
      this.ClearArraysAndPlugs.Name = "ClearArraysAndPlugs";
      this.ClearArraysAndPlugs.Size = new System.Drawing.Size(134, 39);
      this.ClearArraysAndPlugs.TabIndex = 16;
      this.ClearArraysAndPlugs.Text = "Очистить всё";
      this.ClearArraysAndPlugs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.ClearArraysAndPlugs.UseVisualStyleBackColor = true;
      this.ClearArraysAndPlugs.Click += new System.EventHandler(this.ClearArraysAndPlugs_Click);
      // 
      // Plugboard
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
      this.ClientSize = new System.Drawing.Size(410, 434);
      this.Controls.Add(this.ClearArraysAndPlugs);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.Plug13);
      this.Controls.Add(this.Plug3);
      this.Controls.Add(this.Plug4);
      this.Controls.Add(this.Plug5);
      this.Controls.Add(this.Plug6);
      this.Controls.Add(this.Plug7);
      this.Controls.Add(this.Plug8);
      this.Controls.Add(this.Plug9);
      this.Controls.Add(this.Plug10);
      this.Controls.Add(this.Plug11);
      this.Controls.Add(this.Plug12);
      this.Controls.Add(this.Plug2);
      this.Controls.Add(this.Plug1);
      this.Controls.Add(this.Cancel);
      this.Controls.Add(this.OkButton);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "Plugboard";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Настройка коммутационной панели";
      this.Load += new System.EventHandler(this.Plugboard_Load);
      this.ResumeLayout(false);
      this.PerformLayout();
    }


    private void Plug1TextChanged (object sender, EventArgs e)
    {
      if (Plug1.Text.Length == 2)
      {
        char[] CharArray = Plug1.Text.ToUpper().ToCharArray();
        if (CharArray[0] == CharArray[1] || charsForWiring.Contains(CharArray[0]) || charsForWiring.Contains(CharArray[1]))
        {
          MessageBox.Show(this, "Введите две отличные друг от друга и других букв буквы!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Plug1.Clear();
          return;
        }
        else
        {
          SetPlugboard(CharArray, 1);
        }
      }
      if (Plug1.Text.Length == 0 && SteckerWiring.ContainsKey(1))
      {
        ClearPlug(1);
      }
    }

    private void Plug2TextChanged(object sender, EventArgs e)
    {
      if (Plug2.Text.Length == 2)
      {
        char[] CharArray = Plug2.Text.ToUpper().ToCharArray();
        if (CharArray[0] == CharArray[1] || SteckerWiring.ContainsValue(CharArray))
        {
          MessageBox.Show(this, "Введите две отличные друг от друга и других букв буквы!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Plug2.Clear();
          return;
        }
        else
        {
          SetPlugboard(CharArray, 2);
        }
      }
      if (Plug2.Text.Length == 0 && SteckerWiring.ContainsKey(2))
      {
        ClearPlug(2);
      }
    }

    private void Plug3TextChanged(object sender, EventArgs e)
    {
      if (Plug3.Text.Length == 2)
      {
        char[] CharArray = Plug3.Text.ToUpper().ToCharArray();
        if (CharArray[0] == CharArray[1] || charsForWiring.Contains(CharArray[0]) || charsForWiring.Contains(CharArray[1]))
        {
          MessageBox.Show(this, "Введите две отличные друг от друга и других букв буквы!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Plug3.Clear();
          return;
        }
        else
        {
          SetPlugboard(CharArray, 3);
        }
      }
      if (Plug3.Text.Length == 0 && SteckerWiring.ContainsKey(3))
      {
        ClearPlug(3);
      }
    }
    private void Plug4TextChanged(object sender, EventArgs e)
    {
      if (Plug4.Text.Length == 2)
      {
        char[] CharArray = Plug4.Text.ToUpper().ToCharArray();
        if (CharArray[0] == CharArray[1] || charsForWiring.Contains(CharArray[0]) || charsForWiring.Contains(CharArray[1]))
        {
          MessageBox.Show(this, "Введите две отличные друг от друга и других букв буквы!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Plug4.Clear();
          return;
        }
        else
        {
          SetPlugboard(CharArray, 4);
        }
      }
      if (Plug4.Text.Length == 0 && SteckerWiring.ContainsKey(4))
      {
        ClearPlug(4);
      }
    }
    private void Plug5TextChanged(object sender, EventArgs e)
    {
      if (Plug5.Text.Length == 2)
      {
        char[] CharArray = Plug5.Text.ToUpper().ToCharArray();
        if (CharArray[0] == CharArray[1] || charsForWiring.Contains(CharArray[0]) || charsForWiring.Contains(CharArray[1]))
        {
          MessageBox.Show(this, "Введите две отличные друг от друга и других букв буквы!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Plug5.Clear();
          return;
        }
        else
        {
          SetPlugboard(CharArray, 5);
        }
      }
      if (Plug5.Text.Length == 0 && SteckerWiring.ContainsKey(5))
      {
        ClearPlug(5);
      }
    }
    private void Plug6TextChanged(object sender, EventArgs e)
    {
      if (Plug6.Text.Length == 2)
      {
        char[] CharArray = Plug6.Text.ToUpper().ToCharArray();
        if (CharArray[0] == CharArray[1] || charsForWiring.Contains(CharArray[0]) || charsForWiring.Contains(CharArray[1]))
        {
          MessageBox.Show(this, "Введите две отличные друг от друга и других букв буквы!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Plug6.Clear();
          return;
        }
        else
        {
          SetPlugboard(CharArray, 6);
        }
        if (Plug6.Text.Length == 0 && SteckerWiring.ContainsKey(6))
        {
          ClearPlug(6);
        }
      }
    }

    private void Plug7TextChanged(object sender, EventArgs e)
    {
      if (Plug7.Text.Length == 2)
      {
        char[] CharArray = Plug7.Text.ToUpper().ToCharArray();
        if (CharArray[0] == CharArray[1] || charsForWiring.Contains(CharArray[0]) || charsForWiring.Contains(CharArray[1]))
        {
          MessageBox.Show(this, "Введите две отличные друг от друга и других букв буквы!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Plug7.Clear();
          return;
        }
        else
        {
          SetPlugboard(CharArray, 7);
        }
      }
      if (Plug7.Text.Length == 0 && SteckerWiring.ContainsKey(7))
      {
        ClearPlug(8);
      }
    }

    private void Plug8TextChanged(object sender, EventArgs e)
    {
      if (Plug8.Text.Length == 2)
      {
        char[] CharArray = Plug8.Text.ToUpper().ToCharArray();
        if (CharArray[0] == CharArray[1] || charsForWiring.Contains(CharArray[0]) || charsForWiring.Contains(CharArray[1]))
        {
          MessageBox.Show(this, "Введите две отличные друг от друга и других букв буквы!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Plug8.Clear();
          return;
        }
        else
        {
          SetPlugboard(CharArray, 8);
        }
      }
      if (Plug8.Text.Length == 0 && SteckerWiring.ContainsKey(8))
      {
        ClearPlug(8);
      }
    }
    private void Plug9TextChanged(object sender, EventArgs e)
    {
      if (Plug9.Text.Length == 2)
      {
        char[] CharArray = Plug9.Text.ToUpper().ToCharArray();
        if (CharArray[0] == CharArray[1] || charsForWiring.Contains(CharArray[0]) || charsForWiring.Contains(CharArray[1]))
        {
          MessageBox.Show(this, "Введите две отличные друг от друга и других букв буквы!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Plug9.Clear();
          return;
        }
        else
        {
          SetPlugboard(CharArray, 9);
        }
      }
      if (Plug9.Text.Length == 0 && SteckerWiring.ContainsKey(9))
      {
        ClearPlug(9);
      }
    }
    private void Plug10TextChanged(object sender, EventArgs e)
    {
      if (Plug10.Text.Length == 2)
      {
        char[] CharArray = Plug10.Text.ToUpper().ToCharArray();
        if (CharArray[0] == CharArray[1] || charsForWiring.Contains(CharArray[0]) || charsForWiring.Contains(CharArray[1]))
        {
          MessageBox.Show(this, "Введите две отличные друг от друга и других букв буквы!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Plug10.Clear();
          return;
        }
        else
        {
          SetPlugboard(CharArray, 10);
        }
      }
      if (Plug10.Text.Length == 0 && SteckerWiring.ContainsKey(10))
      {
        ClearPlug(10);
      }
    }
    private void Plug11TextChanged(object sender, EventArgs e)
    {
      if (Plug11.Text.Length == 2)
      {
        char[] CharArray = Plug11.Text.ToUpper().ToCharArray();
        if (CharArray[0] == CharArray[1] || charsForWiring.Contains(CharArray[0]) || charsForWiring.Contains(CharArray[1]))
        {
          MessageBox.Show(this, "Введите две отличные друг от друга и других букв буквы!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Plug11.Clear();
          return;
        }
        else
        {
          SetPlugboard(CharArray, 11);
        }
      }
      if (Plug11.Text.Length == 0 && SteckerWiring.ContainsKey(11))
      {
        ClearPlug(11);
      }
    }

    private void Plug12TextChanged(object sender, EventArgs e)
    {
      if (Plug12.Text.Length == 2)
      {
        char[] CharArray = Plug12.Text.ToUpper().ToCharArray();
        if (CharArray[0] == CharArray[1] || charsForWiring.Contains(CharArray[0]) || charsForWiring.Contains(CharArray[1]))
        {
          MessageBox.Show(this, "Введите две отличные друг от друга и других букв буквы!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Plug12.Clear();
          return;
        }
        else
        {
          SetPlugboard(CharArray, 12);
        }
      }
      if (Plug12.Text.Length == 0 && SteckerWiring.ContainsKey(12))
      {
        ClearPlug(12);
      }
    }

    private void Plug13TextChanged(object sender, EventArgs e)
    {
      if (Plug13.Text.Length == 2)
      {
        char[] CharArray = Plug13.Text.ToUpper().ToCharArray();
        if (CharArray[0] == CharArray[1] || charsForWiring.Contains(CharArray[0]) || charsForWiring.Contains(CharArray[1]))
        {
          MessageBox.Show(this, "Введите две отличные друг от друга и других букв буквы!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          Plug13.Clear();
          return;
        }
        else
        {
          SetPlugboard(CharArray, 13);
        }

      }
      if (Plug13.Text.Length == 0 && SteckerWiring.ContainsKey(13))
      {
        ClearPlug(13);
      }
    }


    private void OkButtonClick(object sender, EventArgs e)
    {
      mainForm.GetPlugbord(SteckerWiring);
      Close();
    }

    private void CancelClick(object sender, EventArgs e)
    {
      Close();
    }

    private void SetPlugboard(char[] CharArray, int i)
    {
      if (SteckerWiring.ContainsKey(i))
      {
        SteckerWiring.Remove(i);
        charsForWiring.Remove(CharArray[0]);
        charsForWiring.Remove(CharArray[1]);
        charsForWiring.Add(CharArray[0]);
        charsForWiring.Add(CharArray[1]);
        SteckerWiring.Add(i, CharArray);
      }
      else
      {
        charsForWiring.Add(CharArray[0]);
        charsForWiring.Add(CharArray[1]);
        SteckerWiring.Add(i, CharArray);
      }
    }

    private void ClearPlug(int i)
    {
      char[] CharArray = SteckerWiring.GetValueOrDefault(i);
      SteckerWiring.Remove(i);
      charsForWiring.Remove(CharArray[0]);
      charsForWiring.Remove(CharArray[1]);
    }

    private void ClearArraysAndPlugs_Click(object sender, EventArgs e)
    {
      Plug1.Clear();
      Plug2.Clear();
      Plug3.Clear();
      Plug4.Clear();
      Plug5.Clear();
      Plug6.Clear();
      Plug7.Clear();
      Plug8.Clear();
      Plug9.Clear();
      Plug10.Clear();
      Plug11.Clear();
      Plug12.Clear();
      Plug13.Clear();
      SteckerWiring.Clear();
      charsForWiring.Clear();
    }

    
    private void Plugboard_Load(object sender, EventArgs e)
    {
     

    }
  }
}