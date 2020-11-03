/*
 * Created by SharpDevelop.
 * User: nk1449
 * Date: 2018/04/18
 * Time: 15:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AwazAmbiriQorali
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private KenjiListBox chkWaves;
		private System.Windows.Forms.ComboBox cmbQisquchlar;
		private KenjiTextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labAwazCnt;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.SplitContainer splitContainer1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		private void InitializeComponent()
		{
			this.chkWaves = new AwazAmbiriQorali.KenjiListBox();
			this.cmbQisquchlar = new System.Windows.Forms.ComboBox();
			this.textBox1 = new AwazAmbiriQorali.KenjiTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labAwazCnt = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// chkWaves
			// 
			this.chkWaves.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.chkWaves.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkWaves.IntegralHeight = false;
			this.chkWaves.ItemHeight = 20;
			this.chkWaves.KenjiTextBox = null;
			this.chkWaves.Location = new System.Drawing.Point(0, 0);
			this.chkWaves.Margin = new System.Windows.Forms.Padding(2);
			this.chkWaves.Name = "chkWaves";
			this.chkWaves.Size = new System.Drawing.Size(200, 389);
			this.chkWaves.TabIndex = 2;
			this.chkWaves.SelectedIndexChanged += new System.EventHandler(this.ChkWavesSelectedIndexChanged);
			this.chkWaves.DoubleClick += new System.EventHandler(this.ChkWavesDoubleClick);
//			this.chkWaves.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.ChkWavestMouseWheel);
			// 
			// cmbQisquchlar
			// 
			this.cmbQisquchlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbQisquchlar.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbQisquchlar.FormattingEnabled = true;
			this.cmbQisquchlar.Location = new System.Drawing.Point(9, 10);
			this.cmbQisquchlar.Margin = new System.Windows.Forms.Padding(2);
			this.cmbQisquchlar.Name = "cmbQisquchlar";
			this.cmbQisquchlar.Size = new System.Drawing.Size(150, 30);
			this.cmbQisquchlar.TabIndex = 17;
			this.cmbQisquchlar.SelectedIndexChanged += new System.EventHandler(this.CmbQisquchlarSelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ListBox = null;
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.MaxLength = 204800;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(723, 407);
			this.textBox1.TabIndex = 18;
			this.textBox1.WordWrap = false;
			this.textBox1.Click += new System.EventHandler(this.TextBox1Click);
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1KeyPress);
			//this.textBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Text1MouseWheel);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(834, 457);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(102, 28);
			this.button1.TabIndex = 19;
			this.button1.Text = "Yasa";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(382, 457);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 28);
			this.label1.TabIndex = 20;
			this.label1.Text = "labUchur";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(168, 457);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(209, 28);
			this.label2.TabIndex = 21;
			this.label2.Text = "labUchur";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labAwazCnt
			// 
			this.labAwazCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labAwazCnt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labAwazCnt.Location = new System.Drawing.Point(10, 457);
			this.labAwazCnt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labAwazCnt.Name = "labAwazCnt";
			this.labAwazCnt.Size = new System.Drawing.Size(104, 28);
			this.labAwazCnt.TabIndex = 22;
			this.labAwazCnt.Text = "labAwazCnt";
			this.labAwazCnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(628, 457);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(188, 28);
			this.button2.TabIndex = 23;
			this.button2.Text = "Hemmini Qoy";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(10, 45);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.chkWaves);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.textBox1);
			this.splitContainer1.Size = new System.Drawing.Size(927, 407);
			this.splitContainer1.SplitterDistance = 200;
			this.splitContainer1.TabIndex = 24;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(945, 492);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.labAwazCnt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cmbQisquchlar);
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "Awaz Ambiri Yashash Qorali( V, /, \\ lar tezletme kunupkilardur) ";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
