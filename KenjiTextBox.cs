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
	public class KenjiTextBox:TextBox
	{
		const int EM_GETFIRSTVISIBLELINE  = 0xCE;
		const int WM_MOUSEWHEEL   = 0x20a; // or 522
		const int WM_VSCROLL      = 0x115; // or 277
		
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

		public KenjiTextBox()
		{
		}
		
		public KenjiListBox ListBox{
			get;
			set;
		}
		
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if(m.Msg == 0x100 || m.Msg == WM_MOUSEWHEEL || m.Msg == WM_VSCROLL){
				int qur = (int)SendMessage(this.Handle,EM_GETFIRSTVISIBLELINE,(IntPtr)0, (IntPtr)0);
				System.Diagnostics.Debug.WriteLine(qur);
				if(qur!=ListBox.TopIndex){
					ListBox.TopIndex = qur;
					Application.DoEvents();
				}
				OrunOzgerdi();
			}			
		}
		
		public void OrunOzgerdi(){			
			int st = SelectionStart;
			int line = GetLineFromCharIndex(st);
			System.Diagnostics.Debug.WriteLine(line);
			ListBox.SelectedIndex = line;
		}
	}
}
