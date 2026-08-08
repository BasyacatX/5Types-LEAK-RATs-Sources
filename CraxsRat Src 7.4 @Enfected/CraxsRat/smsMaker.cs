using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Eagle_Spy;

[DesignerGenerated]
public class smsMaker : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("phonetext")]
	private DrakeUITextBox _phonetext;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon1")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DrakeUIButtonIcon2")]
	private DrakeUIButtonIcon _DrakeUIButtonIcon2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("remnum")]
	private DrakeUIAvatar _remnum;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("addnum")]
	private DrakeUIAvatar _addnum;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("selectlist")]
	private DrakeUIAvatar _selectlist;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("checkall")]
	private DrakeUICheckBox _checkall;

	internal DrakeUITextBox phonetext
    ;

    [field: AccessedThroughProperty("msgtext")]
	internal DrakeUITextBox msgtext
;

	internal DrakeUIButtonIcon DrakeUIButtonIcon1
;

	internal DrakeUIButtonIcon DrakeUIButtonIcon2
	;

	[field: AccessedThroughProperty("Label1")]
	internal Label Label1
    ;

    [field: AccessedThroughProperty("Label34")]
	internal Label Label34
    ; 
	

	[field: AccessedThroughProperty("numslist")]
	internal DrakeUIListBox numslist
    ;

	internal DrakeUIAvatar remnum
	;

	internal DrakeUIAvatar addnum
;

	internal DrakeUIAvatar selectlist
	;

	[field: AccessedThroughProperty("Label2")]
	internal Label Label2
    ;

    [field: AccessedThroughProperty("DrakeUIToolTip1")]
	internal DrakeUIToolTip DrakeUIToolTip1
    ;

	internal DrakeUICheckBox checkall
	;

	public smsMaker()
	{
		base.Load += CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcdsatyud;
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
				components.Dispose();
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
            this.components = new System.ComponentModel.Container();
            this.phonetext = new DrakeUI.Framework.DrakeUITextBox();
            this.msgtext = new DrakeUI.Framework.DrakeUITextBox();
            this.DrakeUIButtonIcon1 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.DrakeUIButtonIcon2 = new DrakeUI.Framework.DrakeUIButtonIcon();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.numslist = new DrakeUI.Framework.DrakeUIListBox();
            this.remnum = new DrakeUI.Framework.DrakeUIAvatar();
            this.addnum = new DrakeUI.Framework.DrakeUIAvatar();
            this.selectlist = new DrakeUI.Framework.DrakeUIAvatar();
            this.Label2 = new System.Windows.Forms.Label();
            this.DrakeUIToolTip1 = new DrakeUI.Framework.DrakeUIToolTip(this.components);
            this.checkall = new DrakeUI.Framework.DrakeUICheckBox();
            this.SuspendLayout();
            // 
            // phonetext
            // 
            this.phonetext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phonetext.FillColor = System.Drawing.Color.White;
            this.phonetext.Font = new System.Drawing.Font("Calibri", 12F);
            this.phonetext.Location = new System.Drawing.Point(76, 348);
            this.phonetext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phonetext.Maximum = 2147483647D;
            this.phonetext.Minimum = -2147483648D;
            this.phonetext.Name = "phonetext";
            this.phonetext.Padding = new System.Windows.Forms.Padding(4);
            this.phonetext.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.phonetext.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.phonetext.Size = new System.Drawing.Size(170, 27);
            this.phonetext.Style = DrakeUI.Framework.UIStyle.Green;
            this.phonetext.TabIndex = 0;
            this.phonetext.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.phonetext.Watermark = "Phone Number";
            this.phonetext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phonetext_KeyPress);
            // 
            // msgtext
            // 
            this.msgtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.msgtext.FillColor = System.Drawing.Color.White;
            this.msgtext.Font = new System.Drawing.Font("Calibri", 12F);
            this.msgtext.Location = new System.Drawing.Point(305, 32);
            this.msgtext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.msgtext.Maximum = 2147483647D;
            this.msgtext.MaxLength = 160;
            this.msgtext.Minimum = -2147483648D;
            this.msgtext.Multiline = true;
            this.msgtext.Name = "msgtext";
            this.msgtext.Padding = new System.Windows.Forms.Padding(4);
            this.msgtext.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.msgtext.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.msgtext.Size = new System.Drawing.Size(274, 294);
            this.msgtext.Style = DrakeUI.Framework.UIStyle.Red;
            this.msgtext.StyleCustomMode = true;
            this.msgtext.TabIndex = 1;
            this.msgtext.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.DrakeUIToolTip1.SetToolTip(this.msgtext, "Max limit 160");
            this.msgtext.Watermark = "";
            // 
            // DrakeUIButtonIcon1
            // 
            this.DrakeUIButtonIcon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon1.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon1.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIButtonIcon1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon1.Location = new System.Drawing.Point(478, 409);
            this.DrakeUIButtonIcon1.Margin = new System.Windows.Forms.Padding(2);
            this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
            this.DrakeUIButtonIcon1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon1.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon1.Size = new System.Drawing.Size(102, 28);
            this.DrakeUIButtonIcon1.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon1.Symbol = 61768;
            this.DrakeUIButtonIcon1.TabIndex = 2;
            this.DrakeUIButtonIcon1.Text = "Send";
            this.DrakeUIButtonIcon1.Click += new System.EventHandler(this.DrakeUIButtonIcon1_click);
            // 
            // DrakeUIButtonIcon2
            // 
            this.DrakeUIButtonIcon2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrakeUIButtonIcon2.FillColor = System.Drawing.Color.Black;
            this.DrakeUIButtonIcon2.Font = new System.Drawing.Font("Calibri", 12F);
            this.DrakeUIButtonIcon2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon2.Location = new System.Drawing.Point(365, 409);
            this.DrakeUIButtonIcon2.Margin = new System.Windows.Forms.Padding(2);
            this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
            this.DrakeUIButtonIcon2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.DrakeUIButtonIcon2.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.DrakeUIButtonIcon2.Size = new System.Drawing.Size(103, 28);
            this.DrakeUIButtonIcon2.Style = DrakeUI.Framework.UIStyle.Custom;
            this.DrakeUIButtonIcon2.Symbol = 61453;
            this.DrakeUIButtonIcon2.TabIndex = 3;
            this.DrakeUIButtonIcon2.Text = "Cancel";
            this.DrakeUIButtonIcon2.Click += new System.EventHandler(this.DrakeUIButtonIcon2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Label1.Location = new System.Drawing.Point(87, 7);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(118, 19);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Phones Numbers";
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.BackColor = System.Drawing.Color.Transparent;
            this.Label34.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label34.ForeColor = System.Drawing.Color.White;
            this.Label34.Location = new System.Drawing.Point(438, 349);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(89, 19);
            this.Label34.TabIndex = 66;
            this.Label34.Text = "All contacts";
            // 
            // numslist
            // 
            this.numslist.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.numslist.Font = new System.Drawing.Font("Calibri", 12F);
            this.numslist.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.numslist.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(245)))), ((int)(((byte)(254)))));
            this.numslist.Location = new System.Drawing.Point(14, 32);
            this.numslist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numslist.Name = "numslist";
            this.numslist.Padding = new System.Windows.Forms.Padding(2);
            this.numslist.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.numslist.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.numslist.Size = new System.Drawing.Size(274, 294);
            this.numslist.Style = DrakeUI.Framework.UIStyle.Custom;
            this.numslist.StyleCustomMode = true;
            this.numslist.TabIndex = 67;
            this.numslist.Text = "DrakeUIListBox1";
            // 
            // remnum
            // 
            this.remnum.AvatarSize = 30;
            this.remnum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remnum.FillColor = System.Drawing.Color.Black;
            this.remnum.Font = new System.Drawing.Font("Calibri", 12F);
            this.remnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.remnum.Location = new System.Drawing.Point(11, 349);
            this.remnum.Name = "remnum";
            this.remnum.Size = new System.Drawing.Size(26, 24);
            this.remnum.Style = DrakeUI.Framework.UIStyle.Custom;
            this.remnum.Symbol = 61526;
            this.remnum.SymbolSize = 30;
            this.remnum.TabIndex = 69;
            this.remnum.Text = "DrakeUIAvatar2";
            this.DrakeUIToolTip1.SetToolTip(this.remnum, "Remove numer from list");
            this.remnum.Click += new System.EventHandler(this.Remnum_Click);
            // 
            // addnum
            // 
            this.addnum.AvatarSize = 30;
            this.addnum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addnum.FillColor = System.Drawing.Color.Black;
            this.addnum.Font = new System.Drawing.Font("Calibri", 12F);
            this.addnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.addnum.Location = new System.Drawing.Point(44, 349);
            this.addnum.Name = "addnum";
            this.addnum.Size = new System.Drawing.Size(26, 24);
            this.addnum.Style = DrakeUI.Framework.UIStyle.Custom;
            this.addnum.Symbol = 61525;
            this.addnum.SymbolSize = 30;
            this.addnum.TabIndex = 68;
            this.addnum.Text = "DrakeUIAvatar1";
            this.DrakeUIToolTip1.SetToolTip(this.addnum, "add number to list");
            this.addnum.Click += new System.EventHandler(this.Addnum_Click);
            // 
            // selectlist
            // 
            this.selectlist.AvatarSize = 30;
            this.selectlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectlist.FillColor = System.Drawing.Color.Black;
            this.selectlist.Font = new System.Drawing.Font("Calibri", 12F);
            this.selectlist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.selectlist.Location = new System.Drawing.Point(260, 348);
            this.selectlist.Name = "selectlist";
            this.selectlist.Size = new System.Drawing.Size(26, 24);
            this.selectlist.Style = DrakeUI.Framework.UIStyle.Custom;
            this.selectlist.Symbol = 61462;
            this.selectlist.SymbolSize = 30;
            this.selectlist.TabIndex = 70;
            this.selectlist.Text = "DrakeUIAvatar1";
            this.DrakeUIToolTip1.SetToolTip(this.selectlist, "get numbers from text file");
            this.selectlist.Click += new System.EventHandler(this.Selectlist_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.Label2.Location = new System.Drawing.Point(398, 7);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(97, 19);
            this.Label2.TabIndex = 71;
            this.Label2.Text = "Message text";
            // 
            // DrakeUIToolTip1
            // 
            this.DrakeUIToolTip1.BackColor = System.Drawing.Color.Black;
            this.DrakeUIToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.DrakeUIToolTip1.OwnerDraw = true;
            this.DrakeUIToolTip1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            // 
            // checkall
            // 
            this.checkall.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(5)))), ((int)(((byte)(17)))));
            this.checkall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkall.Font = new System.Drawing.Font("Calibri", 12F);
            this.checkall.Location = new System.Drawing.Point(401, 344);
            this.checkall.Margin = new System.Windows.Forms.Padding(2);
            this.checkall.Name = "checkall";
            this.checkall.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkall.Size = new System.Drawing.Size(32, 24);
            this.checkall.Style = DrakeUI.Framework.UIStyle.Custom;
            this.checkall.StyleCustomMode = true;
            this.checkall.TabIndex = 72;
            this.checkall.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Checkall_MouseClick);
            // 
            // smsMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(590, 447);
            this.ControlBox = false;
            this.Controls.Add(this.checkall);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.selectlist);
            this.Controls.Add(this.remnum);
            this.Controls.Add(this.addnum);
            this.Controls.Add(this.numslist);
            this.Controls.Add(this.Label34);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DrakeUIButtonIcon2);
            this.Controls.Add(this.DrakeUIButtonIcon1);
            this.Controls.Add(this.msgtext);
            this.Controls.Add(this.phonetext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(606, 486);
            this.MinimumSize = new System.Drawing.Size(606, 486);
            this.Name = "smsMaker";
            this.Opacity = 0.1D;
            this.ShowIcon = false;
            this.Text = "SEND SMS";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
	{
		base.DialogResult = DialogResult.Cancel;
		Close();
	}

	private void DrakeUIButtonIcon1_click(object sender, EventArgs e)
	{
		if (!checkall.Checked && numslist.Items.Count == 0)
		{
			Interaction.MsgBox("Add Phone Number to list First");
			return;
		}
		base.DialogResult = DialogResult.OK;
		Close();
	}

	private void Phonetext_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (Strings.Asc(e.KeyChar) != 8 && ((Strings.Asc(e.KeyChar) < 48) | (Strings.Asc(e.KeyChar) > 57)))
			e.Handled = true;
	}

	private void CraxsRatkfvuiorkenfudpajrsnCraxsRatszxcdsatyud(object sender, EventArgs e)
	{
	}

	private void Checkall_Load(object sender, EventArgs e)
	{
	}

	private void Addnum_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(phonetext.Text) | string.IsNullOrWhiteSpace(phonetext.Text))
			Interaction.MsgBox("Enter Phone Number First");
		else
			numslist.Items.Add(phonetext.Text);
	}

	private void Remnum_Click(object sender, EventArgs e)
	{
		if (numslist.Items.Count == 0)
			Interaction.MsgBox("Add Phone Number to list First");
		else if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(numslist.SelectedItem, null, "Count", new object[0], null, null, null), 0, TextCompare: false))
		{
			Interaction.MsgBox("select number from list to remove");
		}
		else
		{
			object CounterResult = default(object);
			object LoopForResult = default(object);
			if (!ObjectFlowControl.ForLoopControl.ForLoopInitObj(CounterResult, 0, Operators.SubtractObject(NewLateBinding.LateGet(numslist.SelectedItem, null, "Count", new object[0], null, null, null), 1), 1, ref LoopForResult, ref CounterResult))
				return;
			do
			{
				try
				{
					numslist.Items.Remove(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(numslist.SelectedItem, new object[1] { CounterResult }, null)));
				}
				catch (Exception)
				{
					//ProjectData.SetProjectError(projectError);
					//////CraxsAlert.Showinformation("Sorry");
				}
			}
			while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(CounterResult, LoopForResult, ref CounterResult));
		}
	}

	private void Selectlist_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.InitialDirectory = "C:\\";
		openFileDialog.Title = "Open a Text File";
		openFileDialog.Filter = "Text Files|*.txt";
		if (openFileDialog.ShowDialog() != DialogResult.OK)
			return;
		checked
		{
			try
			{
				string fileName = openFileDialog.FileName;
				if (string.IsNullOrEmpty(fileName) || string.IsNullOrWhiteSpace(fileName))
					return;
				string[] array = File.ReadAllLines(fileName);
				if (array.Length <= 0)
					return;
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					string text = array[i].Replace(" ", "");
					if (Versioned.IsNumeric(text))
						numslist.Items.Add(text);
				}
			}
			catch (Exception)
			{
				//ProjectData.SetProjectError(projectError);
				//////CraxsAlert.Showinformation("Sorry");
			}
		}
	}

	private void Checkall_MouseClick(object sender, MouseEventArgs e)
	{
		if (checkall.Checked)
		{
			phonetext.Text = "";
			phonetext.Enabled = false;
			numslist.Items.Clear();
			numslist.Enabled = false;
			selectlist.Enabled = false;
			addnum.Enabled = false;
			remnum.Enabled = false;
		}
		else
		{
			phonetext.Text = "";
			phonetext.Enabled = true;
			numslist.Enabled = true;
			selectlist.Enabled = true;
			addnum.Enabled = true;
			remnum.Enabled = false;
		}
	}
}
