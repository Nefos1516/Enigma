using System;
using System.Windows.Forms;

namespace Enigma
{
	public class Rotor
	{
		private readonly string layout;
		private byte RingOffset;
		private byte RotorOffset;
		private Rotor previous, next;
		private readonly Label lbl;
		private Label OffLabel;
		private char cIn = '\0', notchPos;

		public Rotor(string layout, Label lbl, char notchPos)
		{
			this.layout = layout;
			this.lbl = lbl;
			this.notchPos = notchPos;
			RingOffset = 0;
			RotorOffset = 0;
		}

		public string GetLayout()
		{
			return layout;
		}

		public void SetNextRotor(Rotor next)
		{
			this.next = next;
		}
		public void SetPreviousRotor(Rotor previous)
		{
			this.previous = previous;
		}

		public char GetInverseCharAt(string ch)
		{
			int pos = layout.IndexOf(ch);
			int q = RingOffset + RotorOffset;
			if (q > pos)
			{
				pos = 26 - (q - pos);
			}
			else
			{
				pos = pos - q;
			}

			if (previous != null)
			{
				int q1 = previous.RingOffset + previous.RotorOffset;
				if (q1 >= 26) q1 -= 26;
				pos = (pos + q1) % 26;
			}

			return (char)(65 + pos);
		}
		public void ResetOffset()
		{
			RingOffset = 0;
			RotorOffset = 0;
		}

		public void Move()
		{
			if (next == null)
			{
				return;
			}
			RingOffset++;
			if (RingOffset == 26)
			{
				RingOffset = 0;
			}

			if (next != null && (RingOffset + 66) == ((notchPos - 64) % 26) + 66)
			{
				next.Move();
			}
			lbl.Text = "" + ((char)(65 + RingOffset));
		}

		public void ChangeRotorOffsetUp()
    {
			RotorOffset++;
			if (RotorOffset == 26)
			{
				RotorOffset = 0;
			}
			OffLabel.Text = "" + ((char)(65 + RotorOffset));
		}
		public void ChangeRotorOffsetDown()
		{
			if (RotorOffset == 0)
			{
				RotorOffset = 26;
			}
			RotorOffset--;
			OffLabel.Text = "" + ((char)(65 + RotorOffset));
		}


		public void MoveByClick()
    {
			RingOffset++;
			if (RingOffset == 26)
			{
				RingOffset = 0;
			}
			lbl.Text = "" + ((char)(65 + RingOffset));
		}

		public void MoveBackByClick()
    {
			if (RingOffset == 0)
			{
				RingOffset = 26;
			}
			RingOffset--;
			lbl.Text = "" + ((char)(65 + RingOffset));
		}
		
		public void MoveBack()
		{
			if (RingOffset == 0)
			{
				RingOffset = 26;
			}
			RingOffset--;

			if (next != null && (RingOffset + 66) == ((notchPos - 64) % 26) + 66)
			{
				next.MoveBack();
			}

			lbl.Text = "" + ((char)(65 + RingOffset));
		}

		public void PutDataIn(char s)
		{
			cIn = s;
			char c = s;
			int q = RingOffset + RotorOffset;
			if (q >= 26) q -= 26;
			c = (char)((c - 65 + q) % 26 + 65);

			if (next != null)
			{
				c = layout.Substring((c - 65), 1).ToCharArray()[0];
				if (((c - 65 - q) % 26 + 65) >= 65)
				{
					c = (char)((c - 65 - q) % 26 + 65);
				}
				else
				{
					c = (char)((c - 65 + 26 - q) % 26 + 65);
				}
				next.PutDataIn(c);

			}
		}

		public void ChangeOffsetLabel(Label Lbl)
    {
			OffLabel = Lbl;
			OffLabel.Text = "" + (char)(65 + RotorOffset);
    }

		public char GetDataOut()
		{
      char c;
      if (next != null)
			{
				c = next.GetDataOut();
				c = GetInverseCharAt("" + c);
			}
			else
			{
				c = layout.Substring((cIn - 65), 1).ToCharArray()[0];
				int q = previous.RingOffset + previous.RotorOffset;
				if (q >= 26) q -= 26;
				c = (char)(((c - 65) + q) % 26 + 65);
			}
			return c;
		}

	}
}
