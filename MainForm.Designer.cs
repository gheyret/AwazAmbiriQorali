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
		private System.Windows.Forms.ListBox chkWaves;
		private System.Windows.Forms.ComboBox cmbQisquchlar;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labAwazCnt;
		private System.Windows.Forms.Button button2;
		
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
			this.chkWaves = new System.Windows.Forms.ListBox();
			this.cmbQisquchlar = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labAwazCnt = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// chkWaves
			// 
			this.chkWaves.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.chkWaves.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkWaves.IntegralHeight = false;
			this.chkWaves.ItemHeight = 23;
			this.chkWaves.Location = new System.Drawing.Point(13, 58);
			this.chkWaves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkWaves.Name = "chkWaves";
			this.chkWaves.Size = new System.Drawing.Size(199, 504);
			this.chkWaves.TabIndex = 2;
			this.chkWaves.SelectedIndexChanged += new System.EventHandler(this.ChkWavesSelectedIndexChanged);
			this.chkWaves.DoubleClick += new System.EventHandler(this.ChkWavesDoubleClick);
			// 
			// cmbQisquchlar
			// 
			this.cmbQisquchlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbQisquchlar.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbQisquchlar.FormattingEnabled = true;
			this.cmbQisquchlar.Location = new System.Drawing.Point(12, 12);
			this.cmbQisquchlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbQisquchlar.Name = "cmbQisquchlar";
			this.cmbQisquchlar.Size = new System.Drawing.Size(199, 36);
			this.cmbQisquchlar.TabIndex = 17;
			this.cmbQisquchlar.SelectedIndexChanged += new System.EventHandler(this.CmbQisquchlarSelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(216, 12);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox1.MaxLength = 204800;
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(1032, 549);
			this.textBox1.TabIndex = 18;
			this.textBox1.WordWrap = false;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1KeyPress);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(1112, 571);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(136, 35);
			this.button1.TabIndex = 19;
			this.button1.Text = "Yasa";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(509, 571);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(248, 35);
			this.label1.TabIndex = 20;
			this.label1.Text = "labUchur";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(224, 571);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(279, 35);
			this.label2.TabIndex = 21;
			this.label2.Text = "labUchur";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labAwazCnt
			// 
			this.labAwazCnt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labAwazCnt.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labAwazCnt.Location = new System.Drawing.Point(13, 571);
			this.labAwazCnt.Name = "labAwazCnt";
			this.labAwazCnt.Size = new System.Drawing.Size(139, 35);
			this.labAwazCnt.TabIndex = 22;
			this.labAwazCnt.Text = "labAwazCnt";
			this.labAwazCnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(838, 571);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(250, 35);
			this.button2.TabIndex = 23;
			this.button2.Text = "Hemmini Qoy";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1260, 615);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.labAwazCnt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.cmbQisquchlar);
			this.Controls.Add(this.chkWaves);
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "Awaz Ambiri Yashash Qorali( V, /, \\ lar tezletme kunupkilardur) ";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
