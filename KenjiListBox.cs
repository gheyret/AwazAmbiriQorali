/*
 * Created by SharpDevelop.
 * User: nk1449
 * Date: 2020/07/22
 * Time: 15:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AwazAmbiriQorali
{
	/// <summary>
	/// Description of KenjiListBox.
	/// </summary>
	public class KenjiListBox:ListBox
	{
		const int WM_MOUSEWHEEL   = 0x20a; // or 522
		const int WM_VSCROLL      = 0x115; // or 277
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

		public KenjiListBox()
		{
		}
		
		public TextBox KenjiTextBox{
			get;
			set;
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == WM_MOUSEWHEEL || m.Msg == WM_VSCROLL)  //mouse wheel
			{
//				if ((int)m.WParam < 0)  //mouse wheel scrolls down
//					SendMessage(KenjiTextBox.Handle, (int)0x0115, new IntPtr(1), new IntPtr(0)); //WParam: 1- scroll down, 0- scroll up
//				else if ((int)m.WParam > 0)
//					SendMessage(KenjiTextBox.Handle, (int)0x0115, new IntPtr(0), new IntPtr(0));
				base.WndProc(ref m);
				SendMessage(KenjiTextBox.Handle, m.Msg,m.WParam,m.LParam);
				return;
			}
			if (m.Msg == WM_VSCROLL)
			{				
				System.Diagnostics.Debug.WriteLine("WM_VSCROLL");
			}
			//do the usual
			base.WndProc(ref m);
		}		
	}
}
