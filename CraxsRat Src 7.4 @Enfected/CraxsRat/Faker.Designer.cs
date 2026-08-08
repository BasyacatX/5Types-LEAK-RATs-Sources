// Token: 0x02000074 RID: 116
//[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
public partial class Faker : global::System.Windows.Forms.Form
{
	// Token: 0x0600055C RID: 1372 RVA: 0x00084BA4 File Offset: 0x00082DA4
	[global::System.Diagnostics.DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x00084BE8 File Offset: 0x00082DE8
	[global::System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.plat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboPrims = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.usdtadress = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button20 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.sButton1 = new Sipaa.Framework.SButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plat,
            this.n,
            this.pass});
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridView1.Location = new System.Drawing.Point(0, 618);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 62;
            this.DataGridView1.Size = new System.Drawing.Size(559, 43);
            this.DataGridView1.TabIndex = 0;
            // 
            // plat
            // 
            this.plat.HeaderText = "Platform";
            this.plat.MinimumWidth = 8;
            this.plat.Name = "plat";
            // 
            // n
            // 
            this.n.HeaderText = "User Name";
            this.n.MinimumWidth = 8;
            this.n.Name = "n";
            // 
            // pass
            // 
            this.pass.HeaderText = "Password";
            this.pass.MinimumWidth = 8;
            this.pass.Name = "pass";
            // 
            // ComboPrims
            // 
            this.ComboPrims.BackColor = System.Drawing.Color.Black;
            this.ComboPrims.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPrims.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboPrims.ForeColor = System.Drawing.Color.White;
            this.ComboPrims.FormattingEnabled = true;
            this.ComboPrims.Items.AddRange(new object[] {
            "metamask",
            "imtoken",
            "tokenpocket",
            "trust",
            "binance",
            "okx"});
            this.ComboPrims.Location = new System.Drawing.Point(143, 114);
            this.ComboPrims.Margin = new System.Windows.Forms.Padding(2);
            this.ComboPrims.Name = "ComboPrims";
            this.ComboPrims.Size = new System.Drawing.Size(241, 21);
            this.ComboPrims.TabIndex = 38;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.Label4.ForeColor = System.Drawing.Color.DarkRed;
            this.Label4.Location = new System.Drawing.Point(73, 231);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(40, 19);
            this.Label4.TabIndex = 43;
            this.Label4.Text = "trc20";
            // 
            // usdtadress
            // 
            this.usdtadress.BackColor = System.Drawing.Color.Black;
            this.usdtadress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usdtadress.ForeColor = System.Drawing.Color.Red;
            this.usdtadress.Location = new System.Drawing.Point(143, 231);
            this.usdtadress.Name = "usdtadress";
            this.usdtadress.Size = new System.Drawing.Size(241, 20);
            this.usdtadress.TabIndex = 42;
            // 
            // Button1
            // 
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Button1.ForeColor = System.Drawing.Color.DarkRed;
            this.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button1.Location = new System.Drawing.Point(308, 346);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(128, 45);
            this.Button1.TabIndex = 41;
            this.Button1.Text = "end";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button20
            // 
            this.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Button20.ForeColor = System.Drawing.Color.DarkRed;
            this.Button20.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button20.Location = new System.Drawing.Point(101, 346);
            this.Button20.Name = "Button20";
            this.Button20.Size = new System.Drawing.Size(128, 45);
            this.Button20.TabIndex = 40;
            this.Button20.Text = "start";
            this.Button20.UseVisualStyleBackColor = true;
            this.Button20.Click += new System.EventHandler(this.Button20_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.DarkRed;
            this.Label2.Location = new System.Drawing.Point(73, 112);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(32, 19);
            this.Label2.TabIndex = 39;
            this.Label2.Text = "app";
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Black;
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(559, 89);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 44;
            this.PictureBox1.TabStop = false;
            // 
            // sButton1
            // 
            this.sButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.sButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.sButton1.BorderRadius = 6;
            this.sButton1.BorderSize = 0;
            this.sButton1.FlatAppearance.BorderSize = 0;
            this.sButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sButton1.ForeColor = System.Drawing.Color.White;
            this.sButton1.Location = new System.Drawing.Point(630, 530);
            this.sButton1.Name = "sButton1";
            this.sButton1.Size = new System.Drawing.Size(95, 40);
            this.sButton1.TabIndex = 45;
            this.sButton1.Text = "sButton1";
            this.sButton1.UseVisualStyleBackColor = false;
            this.sButton1.Click += new System.EventHandler(this.sButton1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(101, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 45);
            this.button2.TabIndex = 46;
            this.button2.Text = "start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.ForeColor = System.Drawing.Color.DarkRed;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(308, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 45);
            this.button3.TabIndex = 47;
            this.button3.Text = "start";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Eagle_Spy_Applications.remo;
            this.pictureBox2.Location = new System.Drawing.Point(204, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // Faker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(559, 661);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sButton1);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.usdtadress);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button20);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.ComboPrims);
            this.Controls.Add(this.DataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Faker";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Craxs Faker";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	// Token: 0x0400075E RID: 1886
	private global::System.ComponentModel.IContainer components;

	// Token: 0x04000767 RID: 1895
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("DataGridView1")]
	internal global::System.Windows.Forms.DataGridView DataGridView1;

	// Token: 0x04000768 RID: 1896
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("plat")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn plat;

	// Token: 0x04000769 RID: 1897
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("n")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn n;

	// Token: 0x0400076A RID: 1898
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("pass")]
	internal global::System.Windows.Forms.DataGridViewTextBoxColumn pass;

	// Token: 0x0400076E RID: 1902
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("ComboPrims")]
	internal global::System.Windows.Forms.ComboBox ComboPrims;

	// Token: 0x0400076F RID: 1903
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label4")]
	internal global::System.Windows.Forms.Label Label4;

	// Token: 0x04000770 RID: 1904
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("usdtadress")]
	internal global::System.Windows.Forms.TextBox usdtadress;

	// Token: 0x04000771 RID: 1905
	internal global::System.Windows.Forms.Button Button1;

	// Token: 0x04000772 RID: 1906
	internal global::System.Windows.Forms.Button Button20;

	// Token: 0x04000773 RID: 1907
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("Label2")]
	internal global::System.Windows.Forms.Label Label2;

	// Token: 0x04000774 RID: 1908
	private global::Sipaa.Framework.SButton sButton1;

	// Token: 0x04000775 RID: 1909
	[global::System.Runtime.CompilerServices.AccessedThroughProperty("PictureBox1")]
	internal global::System.Windows.Forms.PictureBox PictureBox1;
    internal System.Windows.Forms.Button button2;
    internal System.Windows.Forms.Button button3;
    private System.Windows.Forms.PictureBox pictureBox2;
}
