/*
 * Created by SharpDevelop.
 * User: nk1449
 * Date: 2018/04/18
 * Time: 15:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using libZPlay;

namespace AwazAmbiriQorali
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string gAwazyol = @"";
		string gAldinqiSure="";
		bool   gAldinqiOzgerdi = false;
		
		private ZPlay gPlayer;
		
//		private Hotkey              gHotKey=null;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.SetStyle(ControlStyles.DoubleBuffer,true);
			
			//System.Diagnostics.Debug.Write(CleanText("Gheyret Tohti 47 yashqa kirdi, ma’arip[]2344 )"));
			//String oqu=SanlarniOqu("Gheyret Tohti 47 yashqa kirdi");
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			gPlayer = new ZPlay();
			if(Directory.Exists(gAwazyol)==false)
			{
				gAwazyol = Application.StartupPath;
			}
			textBox1.MaxLength = 0;
			DirectoryInfo di=new DirectoryInfo(gAwazyol);
			foreach(DirectoryInfo dir in di.GetDirectories())
			{
				cmbQisquchlar.Items.Add(dir.Name);
			}
			cmbQisquchlar.SelectedIndex=0;
		}
		
		void CmbQisquchlarSelectedIndexChanged(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(gAldinqiSure)==false){
				try{
					File.WriteAllText(gAldinqiSure,textBox1.Text,Encoding.UTF8);
				}catch(Exception){
					
				}
			}

			String selyol=cmbQisquchlar.SelectedItem.ToString();
			DirectoryInfo di =new DirectoryInfo(Path.Combine(gAwazyol,selyol));
			FileInfo[] hojjetler = di.GetFiles("*.wav");
			if(hojjetler.Length>0){
				chkWaves.BeginUpdate();
				chkWaves.Items.Clear();
				foreach(FileInfo wav in hojjetler){
					chkWaves.Items.Add(wav.Name);
				}
				chkWaves.EndUpdate();
			}
			
			labAwazCnt.Text = chkWaves.Items.Count + " Hojjet";

			String filenm = selyol+".txt";
			filenm = Path.Combine(gAwazyol,filenm);
			string tekist;
			try{
				if(File.Exists(filenm)==false){
					File.WriteAllText(filenm,"");
				}
				tekist = (File.ReadAllText(filenm,Encoding.UTF8)).Trim().ToLower();
				tekist = SanlarniOqu(tekist);
				tekist =tekist.Replace("　"," ");
//				tekist =tekist.Replace("német","ni’amet").Replace("niamiti","ni’amiti").Replace("meghpiret","meghfiret").Replace("qowm","qewim").Replace("kitab","kitap").Replace("yehudiy","yehudi");
//				tekist = tekist.Replace("-émal","-emal").Replace("mushrik","mushirik");
//				tekist = tekist.Replace("ée","éh").Replace("ea","ha").Replace("ae","ah").Replace("ei","hi").Replace("eo","ho").Replace("eé","hé").Replace("eö","hö").Replace("eu","hu");
//				tekist = tekist.Replace("dixan","déhqan").Replace("déqan","déhqan");
				tekist = tekist.Replace("("," ").Replace(")", " ").Replace("«"," ").Replace("»", " ").Replace("‹", " ").Replace("›", " ").Replace("\"", " ");
				tekist =tekist.Replace(" - ","-").Replace("- ","-").Replace(" -","-");
				tekist =tekist.Replace(" ,",", ").Replace(" .",". ").Replace(" ;","; ").Replace(" ?","? ").Replace(" !","! ");
				tekist =tekist.Replace(",",", ").Replace(".",". ").Replace(";","; ").Replace("!","! ").Replace("?","? ");
				tekist = tekist.Replace("  ", " ");
				textBox1.Text = tekist;
				if(chkWaves.Items.Count>0){
					chkWaves.SelectedIndex = 0;
				}

			}catch(Exception)
			{
				
			}
			gAldinqiSure=filenm;
			gAldinqiOzgerdi=false;
		}
		
		void TextBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			System.Diagnostics.Debug.WriteLine("Kunupka besildi");
		}
		
		void ChkWavesDoubleClick(object sender, EventArgs e)
		{
			gPlayer.StopPlayback();
			gPlayer.StartPlayback();
			textBox1.Focus();
		}
		
		void ChkWavesSelectedIndexChanged(object sender, EventArgs e)
		{
			if(chkWaves.SelectedIndex==-1) return;
			gPlayer.StopPlayback();
			gPlayer.Close();
			
			String selFile = chkWaves.SelectedItem.ToString();

			String folder  = cmbQisquchlar.SelectedItem.ToString();
			string yol = Path.Combine(gAwazyol,folder,selFile);
			TStreamInfo  info =new TStreamInfo();
			gPlayer.OpenFile(yol, TStreamFormat.sfAutodetect);
			gPlayer.GetStreamInfo(ref info);
			label2.Text=string.Format("Uzunluqi : {0} millisecond",info.Length.ms);
			
			int qur = chkWaves.SelectedIndex;
			textBox1.Focus();
			int qurUzun =0;
			if(qur<textBox1.Lines.Length){
				for(int i=0;i<qur;i++){
					qurUzun += textBox1.Lines[i].Length+2;
				}
			}
			textBox1.SelectionLength = 0;
			textBox1.SelectionStart = qurUzun;
			textBox1.ScrollToCaret();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			button1.Enabled=false;
			Random rd =new Random();
			try{
				string wavFolder =Path.GetDirectoryName(gAwazyol);
				string allTextFn = Path.Combine(wavFolder,"wavs.txt");
				wavFolder=Path.Combine(wavFolder,"wavs");
				if(Directory.Exists(wavFolder)==false){
					Directory.CreateDirectory(wavFolder);
				}
				String folder  = cmbQisquchlar.SelectedItem.ToString();
				String filenm = folder+".txt";
				filenm = Path.Combine(gAwazyol,filenm);
				File.WriteAllText(filenm,textBox1.Text,Encoding.UTF8);
				
				string[] wavFiles;
				string   waveName;
				string   id;
				String[] strMeta;
				String metaQur;
				StringBuilder metaBuf=new StringBuilder();
				StringBuilder txtBuf = new StringBuilder();
				List<string> asrBuf=new List<string>();
				
				String strClean;
				foreach(String qisquch in cmbQisquchlar.Items){
					cmbQisquchlar.SelectedItem=qisquch;
					filenm = Path.Combine(gAwazyol,qisquch);
					wavFiles=Directory.GetFiles(filenm,"*.wav");
					label2.Text="Qisquch: " + qisquch;
					Application.DoEvents();
					if(Directory.Exists(@"..\tekshurulgen\")){
						if(File.Exists(@"..\tekshurulgen\"+qisquch+".txt")==false){
							continue;
						}
					}
					try{
						strMeta = textBox1.Lines;
						if(strMeta.Length == wavFiles.Length){
							for(int i=0; i<strMeta.Length;i++){
								if(strMeta[i].Trim().Length>0){
									txtBuf.Append(strMeta[i].Trim()+"\r\n");
									waveName = wavFiles[i].Substring(wavFiles[i].LastIndexOf("\\")+1);
									id = waveName.Substring(0,waveName.LastIndexOf("."));
									metaQur = string.Format("{0}|{1}|{2}",id,strMeta[i].Trim(),strMeta[i].Trim());
									metaBuf.Append(metaQur+"\n");
									waveName = Path.Combine(wavFolder,waveName);
									if(File.Exists(waveName)){
										File.Delete(waveName);
									}

									strClean = CleanText(strMeta[i]);
									if(rd.NextDouble()>0.15){
										metaQur = string.Format("{0},{1},{2},training,",id,waveName,strClean);
									}
									else{
										metaQur = string.Format("{0},{1},{2},test,",id,waveName,strClean);
									}
									asrBuf.Add(metaQur);
									
									File.Copy(wavFiles[i],waveName);
									label1.Text=String.Format("{0}/{1}",(i+1),strMeta.Length);
									Application.DoEvents();
								}
							}
						}
						else{
							System.Diagnostics.Debug.WriteLine(Path.Combine(gAwazyol,qisquch) + " Texi teyyar bolmaptu");
						}
					}catch(Exception){
						System.Diagnostics.Debug.WriteLine("Hojjet {0} ni oqushta xataliq koruldi",filenm);
					}
				}
				
				filenm = Path.Combine(gAwazyol,"..\\metadata.csv");
				using (StreamWriter swr=new StreamWriter(filenm,false, Encoding.UTF8)){
					swr.Write(metaBuf.ToString());
				}
				
				using (StreamWriter swr=new StreamWriter(allTextFn,false, Encoding.UTF8)){
					swr.Write(txtBuf.ToString());
				}

				filenm = Path.Combine(gAwazyol,"..\\asrdata.csv");
				using (StreamWriter swr=new StreamWriter(filenm,false, Encoding.UTF8)){
					foreach(String qur in asrBuf){
						swr.WriteLine(qur);
					}
				}
				
			}catch(Exception){
				
			}
			button1.Enabled=true;
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if(gAldinqiOzgerdi){
				try{
					File.WriteAllText(gAldinqiSure,textBox1.Text,Encoding.UTF8);
				}catch(Exception){
					
				}
			}
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			gAldinqiOzgerdi= true;
			label1.Text =string.Format("Jemmiy {0} qur", textBox1.Lines.Length);
		}
		
		void Ochur()
		{
			String backFolder=Path.Combine(gAwazyol,"..\\ochurulgen");
			if(Directory.Exists(backFolder)==false){
				Directory.CreateDirectory(backFolder);
			}
			
			int curSel =chkWaves.SelectedIndex;
			String qisquch =cmbQisquchlar.SelectedItem.ToString();
			String wavFile = chkWaves.Items[curSel].ToString();
			String filenm = Path.Combine(gAwazyol,qisquch, wavFile);
			System.Diagnostics.Debug.WriteLine(filenm);
			try{
				String newFile = Path.Combine(backFolder,wavFile);
				gPlayer.StopPlayback();
				gPlayer.Close();
				File.Move(filenm,newFile);
				System.Diagnostics.Debug.WriteLine(newFile);
				chkWaves.Items.RemoveAt(curSel);
				if(curSel >= chkWaves.Items.Count){
					curSel=chkWaves.Items.Count-1;
				}
				chkWaves.SelectedIndex = curSel;
				labAwazCnt.Text = chkWaves.Items.Count + " Hojjet";
				ChkWavesSelectedIndexChanged(null, null);
				ChkWavesDoubleClick(null,null);
			}catch(Exception ee){
				System.Diagnostics.Debug.WriteLine(ee.Message);
			}
		}
		
		
		void MainFormKeyPress(object sender, KeyPressEventArgs e)
		{
			System.Diagnostics.Debug.WriteLine("Keldi -- Forum");
			if(e.KeyChar=='V'||e.KeyChar=='v'){
				ChkWavesDoubleClick(null,null);
				e.Handled = true;
			}
			
			if(e.KeyChar == '\\'){
				e.Handled = true;
				int curSel =chkWaves.SelectedIndex;
				curSel++;
				if(curSel<chkWaves.Items.Count){
					chkWaves.SelectedIndex = curSel;
				}
				else{
					chkWaves.SelectedIndex  = 0;
				}
				ChkWavesSelectedIndexChanged(null, null);
				ChkWavesDoubleClick(null,null);
			}

			if(e.KeyChar == '/'){
				e.Handled = true;
				int curSel =chkWaves.SelectedIndex;
				curSel--;
				if(curSel>=0){
					chkWaves.SelectedIndex = curSel;
				}
				else{
					chkWaves.SelectedIndex  = chkWaves.Items.Count-1;
				}
				ChkWavesSelectedIndexChanged(null, null);
				ChkWavesDoubleClick(null,null);
			}
			if(e.KeyChar =='0'){
				e.Handled = true;
				Ochur();
			}
			
			if(e.KeyChar == 'O'
			  )
			{
				e.KeyChar='ö';
			}
			if(e.KeyChar == 'U'
			  )
			{
				e.KeyChar='ü';
			}
			if(e.KeyChar == 'E'
			  )
			{
				e.KeyChar='é';
			}
		}
		
		string SanlarniOqu(string esli){
			string oqughan=esli;
			Regex reg = new Regex("[0-9]+[ ]*[-]?"); //(@"^\d$");
			oqughan=reg.Replace(esli,match=>
			                    {
			                    	string san = match.ToString();
			                    	return numstr2str(san);
			                    });
			return oqughan;
		}
		

		string SanlarniOquOrg(string esli){
			string oqughan=esli;
			Regex reg = new Regex("[0-9]+"); //(@"^\d$");
			oqughan=reg.Replace(esli,delegate(Match match)
			                    {
			                    	string san = match.ToString();
			                    	return numstr2str(san);
			                    });
			return oqughan;
		}

		
		public string numstr2str(string innumstr)
		{
			bool isninchi=false;
			string numstr=innumstr.Trim();
			if(innumstr.EndsWith("-")){
				numstr=innumstr.Substring(0,innumstr.Length-1).Trim();
				isninchi= true;
			}
			if (numstr.Length > 18) return "xane sani on sekkizdin yuqiri bolmisun";
			if (numstr == "0") return "nöl";
			string strstr = "";
			for (int i = 0; i < numstr.Length; i++)
			{
				char digit = numstr[i];
				if ((numstr.Length - i) % 3 == 0 || (numstr.Length - i) % 3 == 1)
				{
					switch (digit)
					{
						case '1':
							strstr = strstr + "bir ";
							break;
						case '2':
							strstr = strstr + "ikki ";
							break;
						case '3':
							strstr = strstr + "üch ";
							break;
						case '4':
							strstr = strstr + "töt ";
							break;
						case '5':
							strstr = strstr + "besh ";
							break;
						case '6':
							strstr = strstr + "alte ";
							break;
						case '7':
							strstr = strstr + "yette ";
							break;
						case '8':
							strstr = strstr + "sekkiz ";
							break;
						case '9':
							strstr = strstr + "toqquz ";
							break;
						case '0':
							break;
						default:
							return "sandin bashqa herp belgilerni kirgüzmeng!";
					}
				}
				if ((numstr.Length - i) % 3 == 2)
				{
					switch (digit)
					{
						case '1':
							strstr = strstr + "on ";
							break;
						case '2':
							strstr = strstr + "yigirme ";
							break;
						case '3':
							strstr = strstr + "ottuz ";
							break;
						case '4':
							strstr = strstr + "qiriq ";
							break;
						case '5':
							strstr = strstr + "ellik ";
							break;
						case '6':
							strstr = strstr + "atmish ";
							break;
						case '7':
							strstr = strstr + "yetmish ";
							break;
						case '8':
							strstr = strstr + "seksen ";
							break;
						case '9':
							strstr = strstr + "toqsan ";
							break;
						case '0':
							break;
						default:
							return "sandin bashqa herp belgilerni kirgüzmeng!";

					}
				}
				if ((numstr.Length - i) % 3 == 0 && numstr[i] != '0')
				{
					strstr = strstr + "yüz ";
				}
				if ((numstr.Length - i) / 16 == 1 && (numstr.Length - i) % 16 == 0)
				{
					if (numstr[numstr.Length - 16] == '0' && numstr[numstr.Length - 17] == '0' && numstr[numstr.Length - 18] == '0') continue;
					else strstr = strstr + "tirliyarda ";
				}
				if ((numstr.Length - i) / 13 == 1 && (numstr.Length - i) % 13 == 0)
				{
					if (numstr[numstr.Length - 13] == '0' && numstr[numstr.Length - 14] == '0' && numstr[numstr.Length - 15] == '0') continue;
					else strstr = strstr + "tirliyun ";
				}
				if ((numstr.Length - i) / 10 == 1 && (numstr.Length - i) % 10 == 0)
				{
					if (numstr[numstr.Length - 10] == '0' && numstr[numstr.Length - 11] == '0' && numstr[numstr.Length - 12] == '0') continue;
					else strstr = strstr + "miliyard ";
				}
				if ((numstr.Length - i) / 7 == 1 && (numstr.Length - i) % 7 == 0)
				{
					if (numstr[numstr.Length - 7] == '0' && numstr[numstr.Length - 8] == '0' && numstr[numstr.Length - 9] == '0') continue;
					else strstr = strstr + "miliyun ";
				}
				if ((numstr.Length - i) / 4 == 1 && (numstr.Length - i) % 4 == 0)
				{
					if (numstr[numstr.Length - 4] == '0' && numstr[numstr.Length - 5] == '0' && numstr[numstr.Length - 6] == '0') continue;
					else strstr = strstr + "ming ";
				}
			}
			if(isninchi){
				strstr=strstr.Trim();
				if(strstr.EndsWith("i")||strstr.EndsWith("e")){
					strstr=strstr.Substring(0,strstr.Length-1);
				}
				strstr=strstr+"inchi ";
			}
			return strstr;
		}
		
		string CleanText(String esli){
			Regex reg = new Regex(@"[^ a-z'éöü’]");
			String pakiz = reg.Replace(esli.ToLower(), " ").Replace("  "," ").Replace("  "," ").Replace("  "," ").Trim();
			return pakiz;
		}
	}
}

