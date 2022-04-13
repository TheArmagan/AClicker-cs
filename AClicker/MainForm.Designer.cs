
namespace AClicker
{
    partial class MainForm
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
            this.ChangeIntervalMinInput = new System.Windows.Forms.NumericUpDown();
            this.CpsMinInput = new System.Windows.Forms.NumericUpDown();
            this.CpsMaxInput = new System.Windows.Forms.NumericUpDown();
            this.TargetCpsLabel = new System.Windows.Forms.Label();
            this.ButtonComboBox = new System.Windows.Forms.ComboBox();
            this.MultiplierInput = new System.Windows.Forms.NumericUpDown();
            this.stopButton = new System.Windows.Forms.Button();
            this.ChangeIntervalMaxInput = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.CursorMinShake = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.CursorMaxShake = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TriggerButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeIntervalMinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpsMinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpsMaxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeIntervalMaxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CursorMinShake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CursorMaxShake)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChangeIntervalMinInput
            // 
            this.ChangeIntervalMinInput.Location = new System.Drawing.Point(6, 30);
            this.ChangeIntervalMinInput.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.ChangeIntervalMinInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChangeIntervalMinInput.Name = "ChangeIntervalMinInput";
            this.ChangeIntervalMinInput.Size = new System.Drawing.Size(95, 24);
            this.ChangeIntervalMinInput.TabIndex = 3;
            this.ChangeIntervalMinInput.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ChangeIntervalMinInput.ValueChanged += new System.EventHandler(this.ChangeIntervalMinInput_ValueChanged);
            // 
            // CpsMinInput
            // 
            this.CpsMinInput.Location = new System.Drawing.Point(6, 32);
            this.CpsMinInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CpsMinInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CpsMinInput.Name = "CpsMinInput";
            this.CpsMinInput.Size = new System.Drawing.Size(95, 24);
            this.CpsMinInput.TabIndex = 5;
            this.CpsMinInput.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.CpsMinInput.ValueChanged += new System.EventHandler(this.CpsMinInput_ValueChanged);
            // 
            // CpsMaxInput
            // 
            this.CpsMaxInput.Location = new System.Drawing.Point(123, 32);
            this.CpsMaxInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CpsMaxInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CpsMaxInput.Name = "CpsMaxInput";
            this.CpsMaxInput.Size = new System.Drawing.Size(95, 24);
            this.CpsMaxInput.TabIndex = 7;
            this.CpsMaxInput.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.CpsMaxInput.ValueChanged += new System.EventHandler(this.CpsMaxInput_ValueChanged);
            // 
            // TargetCpsLabel
            // 
            this.TargetCpsLabel.AutoSize = true;
            this.TargetCpsLabel.Location = new System.Drawing.Point(7, 305);
            this.TargetCpsLabel.Name = "TargetCpsLabel";
            this.TargetCpsLabel.Size = new System.Drawing.Size(98, 18);
            this.TargetCpsLabel.TabIndex = 12;
            this.TargetCpsLabel.Text = "Hedef CPS: 0";
            // 
            // ButtonComboBox
            // 
            this.ButtonComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ButtonComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ButtonComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonComboBox.FormattingEnabled = true;
            this.ButtonComboBox.Items.AddRange(new object[] {
            "Sol",
            "Sağ",
            "Orta"});
            this.ButtonComboBox.Location = new System.Drawing.Point(6, 30);
            this.ButtonComboBox.Name = "ButtonComboBox";
            this.ButtonComboBox.Size = new System.Drawing.Size(114, 26);
            this.ButtonComboBox.TabIndex = 16;
            this.ButtonComboBox.Text = "Sol";
            this.ButtonComboBox.SelectedIndexChanged += new System.EventHandler(this.ButtonComboBox_SelectedIndexChanged);
            this.ButtonComboBox.TextChanged += new System.EventHandler(this.ButtonComboBox_TextChanged);
            // 
            // MultiplierInput
            // 
            this.MultiplierInput.Location = new System.Drawing.Point(6, 32);
            this.MultiplierInput.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.MultiplierInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MultiplierInput.Name = "MultiplierInput";
            this.MultiplierInput.Size = new System.Drawing.Size(114, 24);
            this.MultiplierInput.TabIndex = 17;
            this.MultiplierInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stopButton
            // 
            this.stopButton.ForeColor = System.Drawing.Color.Black;
            this.stopButton.Location = new System.Drawing.Point(10, 255);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(358, 38);
            this.stopButton.TabIndex = 19;
            this.stopButton.Text = "Durdur!";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // ChangeIntervalMaxInput
            // 
            this.ChangeIntervalMaxInput.Location = new System.Drawing.Point(123, 30);
            this.ChangeIntervalMaxInput.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.ChangeIntervalMaxInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChangeIntervalMaxInput.Name = "ChangeIntervalMaxInput";
            this.ChangeIntervalMaxInput.Size = new System.Drawing.Size(95, 24);
            this.ChangeIntervalMaxInput.TabIndex = 22;
            this.ChangeIntervalMaxInput.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ChangeIntervalMaxInput.ValueChanged += new System.EventHandler(this.ChangeIntervalMaxInput_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(106, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "-";
            // 
            // CursorMinShake
            // 
            this.CursorMinShake.Location = new System.Drawing.Point(6, 32);
            this.CursorMinShake.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.CursorMinShake.Name = "CursorMinShake";
            this.CursorMinShake.Size = new System.Drawing.Size(95, 24);
            this.CursorMinShake.TabIndex = 24;
            this.CursorMinShake.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.CursorMinShake.ValueChanged += new System.EventHandler(this.cursorMinShake_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 18);
            this.label11.TabIndex = 28;
            this.label11.Text = "-";
            // 
            // CursorMaxShake
            // 
            this.CursorMaxShake.Location = new System.Drawing.Point(123, 32);
            this.CursorMaxShake.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.CursorMaxShake.Name = "CursorMaxShake";
            this.CursorMaxShake.Size = new System.Drawing.Size(95, 24);
            this.CursorMaxShake.TabIndex = 27;
            this.CursorMaxShake.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.CursorMaxShake.ValueChanged += new System.EventHandler(this.cursorMaxShake_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TriggerButton);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 72);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tetikleyici";
            // 
            // TriggerButton
            // 
            this.TriggerButton.ForeColor = System.Drawing.Color.Black;
            this.TriggerButton.Location = new System.Drawing.Point(6, 23);
            this.TriggerButton.Name = "TriggerButton";
            this.TriggerButton.Size = new System.Drawing.Size(114, 37);
            this.TriggerButton.TabIndex = 22;
            this.TriggerButton.Text = "Return (13)";
            this.TriggerButton.UseVisualStyleBackColor = true;
            this.TriggerButton.Click += new System.EventHandler(this.TriggerButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChangeIntervalMinInput);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.ChangeIntervalMaxInput);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(143, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 72);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Değişiklik Hızı";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.CpsMinInput);
            this.groupBox3.Controls.Add(this.CpsMaxInput);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(143, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 72);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tıklama Hızı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "-";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ButtonComboBox);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(10, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 72);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " Düğme";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.MultiplierInput);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(10, 168);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(127, 72);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kat Gücü";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CursorMaxShake);
            this.groupBox6.Controls.Add(this.CursorMinShake);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(143, 168);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(225, 72);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Fare Titretme Gücü";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Aqua;
            this.linkLabel1.Location = new System.Drawing.Point(317, 305);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 18);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(377, 338);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.TargetCpsLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "AClicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChangeIntervalMinInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpsMinInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpsMaxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeIntervalMaxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CursorMinShake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CursorMaxShake)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown ChangeIntervalMinInput;
        private System.Windows.Forms.NumericUpDown CpsMinInput;
        private System.Windows.Forms.NumericUpDown CpsMaxInput;
        private System.Windows.Forms.Label TargetCpsLabel;
        private System.Windows.Forms.ComboBox ButtonComboBox;
        private System.Windows.Forms.NumericUpDown MultiplierInput;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.NumericUpDown ChangeIntervalMaxInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown CursorMinShake;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown CursorMaxShake;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button TriggerButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

