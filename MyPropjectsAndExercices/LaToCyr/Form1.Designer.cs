namespace LaToCyr
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rctLatin = new System.Windows.Forms.RichTextBox();
            this.rctCyr = new System.Windows.Forms.RichTextBox();
            this.btnToBul = new System.Windows.Forms.Button();
            this.btnPhonTrad = new System.Windows.Forms.Button();
            this.btnPhonetic = new System.Windows.Forms.Button();
            this.btnBulTypewritter = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnToUpper = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.nmrFontSize = new System.Windows.Forms.NumericUpDown();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItallic = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btnRegular = new System.Windows.Forms.Button();
            this.btnLatin = new System.Windows.Forms.Button();
            this.menuTopHorizontal = new System.Windows.Forms.MenuStrip();
            this.toolStripBulgarian = new System.Windows.Forms.ToolStripMenuItem();
            this.преведиМенютоНаБългарскиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translateProgramToEnglishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeYourOwnPhoneticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doYouWantReallyToExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lnkGenKey = new System.Windows.Forms.LinkLabel();
            this.btnYourPhonetic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFontSize)).BeginInit();
            this.menuTopHorizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rctLatin
            // 
            this.rctLatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rctLatin.Location = new System.Drawing.Point(2, 26);
            this.rctLatin.Name = "rctLatin";
            this.rctLatin.Size = new System.Drawing.Size(293, 115);
            this.rctLatin.TabIndex = 0;
            this.rctLatin.Text = "";
            this.rctLatin.TextChanged += new System.EventHandler(this.rctLatin_TextChanged);
            // 
            // rctCyr
            // 
            this.rctCyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rctCyr.Location = new System.Drawing.Point(2, 275);
            this.rctCyr.Name = "rctCyr";
            this.rctCyr.Size = new System.Drawing.Size(293, 114);
            this.rctCyr.TabIndex = 1;
            this.rctCyr.Text = "";
            // 
            // btnToBul
            // 
            this.btnToBul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToBul.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnToBul.Location = new System.Drawing.Point(2, 155);
            this.btnToBul.Name = "btnToBul";
            this.btnToBul.Size = new System.Drawing.Size(84, 23);
            this.btnToBul.TabIndex = 2;
            this.btnToBul.Text = "Bulgarian";
            this.btnToBul.UseVisualStyleBackColor = true;
            this.btnToBul.Click += new System.EventHandler(this.btnToBul_Click);
            // 
            // btnPhonTrad
            // 
            this.btnPhonTrad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhonTrad.Location = new System.Drawing.Point(92, 155);
            this.btnPhonTrad.Name = "btnPhonTrad";
            this.btnPhonTrad.Size = new System.Drawing.Size(118, 23);
            this.btnPhonTrad.TabIndex = 3;
            this.btnPhonTrad.Text = "Phonetic Trad";
            this.btnPhonTrad.UseVisualStyleBackColor = true;
            this.btnPhonTrad.Click += new System.EventHandler(this.btnPhonTrad_Click);
            // 
            // btnPhonetic
            // 
            this.btnPhonetic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhonetic.Location = new System.Drawing.Point(220, 155);
            this.btnPhonetic.Name = "btnPhonetic";
            this.btnPhonetic.Size = new System.Drawing.Size(75, 23);
            this.btnPhonetic.TabIndex = 4;
            this.btnPhonetic.Text = "Phonetic";
            this.btnPhonetic.UseVisualStyleBackColor = true;
            this.btnPhonetic.Click += new System.EventHandler(this.btnPhonetic_Click);
            // 
            // btnBulTypewritter
            // 
            this.btnBulTypewritter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBulTypewritter.Location = new System.Drawing.Point(2, 184);
            this.btnBulTypewritter.Name = "btnBulTypewritter";
            this.btnBulTypewritter.Size = new System.Drawing.Size(84, 23);
            this.btnBulTypewritter.TabIndex = 5;
            this.btnBulTypewritter.Text = "Typewritter";
            this.btnBulTypewritter.UseVisualStyleBackColor = true;
            this.btnBulTypewritter.Click += new System.EventHandler(this.btnBulTypewritter_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaste.Location = new System.Drawing.Point(92, 184);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(118, 23);
            this.btnPaste.TabIndex = 6;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(2, 401);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(84, 23);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnErase
            // 
            this.btnErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErase.Location = new System.Drawing.Point(220, 184);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(75, 23);
            this.btnErase.TabIndex = 8;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnToUpper
            // 
            this.btnToUpper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToUpper.Location = new System.Drawing.Point(92, 401);
            this.btnToUpper.Name = "btnToUpper";
            this.btnToUpper.Size = new System.Drawing.Size(118, 23);
            this.btnToUpper.TabIndex = 9;
            this.btnToUpper.Text = "UPPER";
            this.btnToUpper.UseVisualStyleBackColor = true;
            this.btnToUpper.Click += new System.EventHandler(this.btnToUpper_Click);
            // 
            // btnLower
            // 
            this.btnLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLower.Location = new System.Drawing.Point(220, 401);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(75, 23);
            this.btnLower.TabIndex = 10;
            this.btnLower.Text = "lower";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // nmrFontSize
            // 
            this.nmrFontSize.Location = new System.Drawing.Point(2, 434);
            this.nmrFontSize.Name = "nmrFontSize";
            this.nmrFontSize.Size = new System.Drawing.Size(84, 20);
            this.nmrFontSize.TabIndex = 11;
            this.nmrFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrFontSize.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nmrFontSize.ValueChanged += new System.EventHandler(this.nmrFontSize_ValueChanged);
            // 
            // btnBold
            // 
            this.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBold.Location = new System.Drawing.Point(92, 431);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(25, 23);
            this.btnBold.TabIndex = 12;
            this.btnBold.Text = "B";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItallic
            // 
            this.btnItallic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItallic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnItallic.Location = new System.Drawing.Point(123, 431);
            this.btnItallic.Name = "btnItallic";
            this.btnItallic.Size = new System.Drawing.Size(25, 23);
            this.btnItallic.TabIndex = 13;
            this.btnItallic.Text = "I";
            this.btnItallic.UseVisualStyleBackColor = true;
            this.btnItallic.Click += new System.EventHandler(this.btnItallic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUnderline.Location = new System.Drawing.Point(154, 431);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(25, 23);
            this.btnUnderline.TabIndex = 14;
            this.btnUnderline.Text = "U";
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btnRegular
            // 
            this.btnRegular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegular.Location = new System.Drawing.Point(185, 431);
            this.btnRegular.Name = "btnRegular";
            this.btnRegular.Size = new System.Drawing.Size(25, 23);
            this.btnRegular.TabIndex = 15;
            this.btnRegular.Text = "R";
            this.btnRegular.UseVisualStyleBackColor = true;
            this.btnRegular.Click += new System.EventHandler(this.btnRegular_Click);
            // 
            // btnLatin
            // 
            this.btnLatin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLatin.Location = new System.Drawing.Point(220, 431);
            this.btnLatin.Name = "btnLatin";
            this.btnLatin.Size = new System.Drawing.Size(75, 23);
            this.btnLatin.TabIndex = 16;
            this.btnLatin.Text = "Latin";
            this.btnLatin.UseVisualStyleBackColor = true;
            this.btnLatin.Click += new System.EventHandler(this.btnLatin_Click);
            // 
            // menuTopHorizontal
            // 
            this.menuTopHorizontal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuTopHorizontal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBulgarian,
            this.englishToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuTopHorizontal.Location = new System.Drawing.Point(0, 0);
            this.menuTopHorizontal.Name = "menuTopHorizontal";
            this.menuTopHorizontal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuTopHorizontal.Size = new System.Drawing.Size(297, 24);
            this.menuTopHorizontal.TabIndex = 17;
            this.menuTopHorizontal.Text = "menuStrip1";
            this.menuTopHorizontal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuTopHorizontal_ItemClicked);
            // 
            // toolStripBulgarian
            // 
            this.toolStripBulgarian.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.преведиМенютоНаБългарскиToolStripMenuItem});
            this.toolStripBulgarian.Name = "toolStripBulgarian";
            this.toolStripBulgarian.Size = new System.Drawing.Size(69, 20);
            this.toolStripBulgarian.Text = "Bulgarain";
            // 
            // преведиМенютоНаБългарскиToolStripMenuItem
            // 
            this.преведиМенютоНаБългарскиToolStripMenuItem.Name = "преведиМенютоНаБългарскиToolStripMenuItem";
            this.преведиМенютоНаБългарскиToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.преведиМенютоНаБългарскиToolStripMenuItem.Text = "Преведи менюто на български";
            this.преведиМенютоНаБългарскиToolStripMenuItem.Click += new System.EventHandler(this.преведиМенютоНаБългарскиToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.translateProgramToEnglishToolStripMenuItem});
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // translateProgramToEnglishToolStripMenuItem
            // 
            this.translateProgramToEnglishToolStripMenuItem.Name = "translateProgramToEnglishToolStripMenuItem";
            this.translateProgramToEnglishToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.translateProgramToEnglishToolStripMenuItem.Text = "Translate program to english";
            this.translateProgramToEnglishToolStripMenuItem.Click += new System.EventHandler(this.translateProgramToEnglishToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeYourOwnPhoneticToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // makeYourOwnPhoneticToolStripMenuItem
            // 
            this.makeYourOwnPhoneticToolStripMenuItem.Name = "makeYourOwnPhoneticToolStripMenuItem";
            this.makeYourOwnPhoneticToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.makeYourOwnPhoneticToolStripMenuItem.Text = "Make your own phonetic";
            this.makeYourOwnPhoneticToolStripMenuItem.Click += new System.EventHandler(this.makeYourOwnPhoneticToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doYouWantReallyToExitToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // doYouWantReallyToExitToolStripMenuItem
            // 
            this.doYouWantReallyToExitToolStripMenuItem.Name = "doYouWantReallyToExitToolStripMenuItem";
            this.doYouWantReallyToExitToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.doYouWantReallyToExitToolStripMenuItem.Text = "Do you want really to exit ?";
            this.doYouWantReallyToExitToolStripMenuItem.Click += new System.EventHandler(this.doYouWantReallyToExitToolStripMenuItem_Click);
            // 
            // btnCode
            // 
            this.btnCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCode.Location = new System.Drawing.Point(2, 213);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(84, 23);
            this.btnCode.TabIndex = 18;
            this.btnCode.Text = "Code";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecode.Location = new System.Drawing.Point(220, 213);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 19;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(92, 213);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(46, 23);
            this.txtKey.TabIndex = 20;
            // 
            // lnkGenKey
            // 
            this.lnkGenKey.AutoSize = true;
            this.lnkGenKey.Location = new System.Drawing.Point(155, 217);
            this.lnkGenKey.Name = "lnkGenKey";
            this.lnkGenKey.Size = new System.Drawing.Size(48, 13);
            this.lnkGenKey.TabIndex = 21;
            this.lnkGenKey.TabStop = true;
            this.lnkGenKey.Text = "Gen Key";
            this.lnkGenKey.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGenKey_LinkClicked);
            // 
            // btnYourPhonetic
            // 
            this.btnYourPhonetic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYourPhonetic.Location = new System.Drawing.Point(2, 242);
            this.btnYourPhonetic.Name = "btnYourPhonetic";
            this.btnYourPhonetic.Size = new System.Drawing.Size(293, 23);
            this.btnYourPhonetic.TabIndex = 22;
            this.btnYourPhonetic.Text = "Your phonetic";
            this.btnYourPhonetic.UseVisualStyleBackColor = true;
            this.btnYourPhonetic.Click += new System.EventHandler(this.btnYourPhonetic_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 460);
            this.Controls.Add(this.btnYourPhonetic);
            this.Controls.Add(this.lnkGenKey);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.btnLatin);
            this.Controls.Add(this.btnRegular);
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnItallic);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.nmrFontSize);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnToUpper);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnBulTypewritter);
            this.Controls.Add(this.btnPhonetic);
            this.Controls.Add(this.btnPhonTrad);
            this.Controls.Add(this.btnToBul);
            this.Controls.Add(this.rctCyr);
            this.Controls.Add(this.rctLatin);
            this.Controls.Add(this.menuTopHorizontal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuTopHorizontal;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "LaToCyr";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrFontSize)).EndInit();
            this.menuTopHorizontal.ResumeLayout(false);
            this.menuTopHorizontal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rctLatin;
        private System.Windows.Forms.RichTextBox rctCyr;
        private System.Windows.Forms.Button btnToBul;
        private System.Windows.Forms.Button btnPhonTrad;
        private System.Windows.Forms.Button btnPhonetic;
        private System.Windows.Forms.Button btnBulTypewritter;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnToUpper;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.NumericUpDown nmrFontSize;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItallic;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Button btnRegular;
        private System.Windows.Forms.Button btnLatin;
        private System.Windows.Forms.MenuStrip menuTopHorizontal;
        private System.Windows.Forms.ToolStripMenuItem toolStripBulgarian;
        private System.Windows.Forms.ToolStripMenuItem преведиМенютоНаБългарскиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translateProgramToEnglishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doYouWantReallyToExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeYourOwnPhoneticToolStripMenuItem;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.LinkLabel lnkGenKey;
        private System.Windows.Forms.Button btnYourPhonetic;
    }
}

