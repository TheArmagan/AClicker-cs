
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeIntervalMinInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CpsMinInput = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.CpsMaxInput = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TargetCpsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MultiplierInput = new System.Windows.Forms.NumericUpDown();
            this.stopButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.TriggerLink = new System.Windows.Forms.LinkLabel();
            this.ChangeIntervalMaxInput = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CursorMinShake = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CursorMaxShake = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeIntervalMinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpsMinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpsMaxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeIntervalMaxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CursorMinShake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CursorMaxShake)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // ChangeIntervalMinInput
            // 
            this.ChangeIntervalMinInput.Location = new System.Drawing.Point(35, 153);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y:";
            // 
            // CpsMinInput
            // 
            this.CpsMinInput.Location = new System.Drawing.Point(35, 183);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Z:";
            // 
            // CpsMaxInput
            // 
            this.CpsMaxInput.Location = new System.Drawing.Point(35, 213);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "A:";
            // 
            // TargetCpsLabel
            // 
            this.TargetCpsLabel.AutoSize = true;
            this.TargetCpsLabel.Location = new System.Drawing.Point(136, 276);
            this.TargetCpsLabel.Name = "TargetCpsLabel";
            this.TargetCpsLabel.Size = new System.Drawing.Size(98, 18);
            this.TargetCpsLabel.TabIndex = 12;
            this.TargetCpsLabel.Text = "Hedef CPS: 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "E:";
            // 
            // ButtonComboBox
            // 
            this.ButtonComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonComboBox.FormattingEnabled = true;
            this.ButtonComboBox.Items.AddRange(new object[] {
            "Sol",
            "Sağ",
            "Orta"});
            this.ButtonComboBox.Location = new System.Drawing.Point(34, 242);
            this.ButtonComboBox.Name = "ButtonComboBox";
            this.ButtonComboBox.Size = new System.Drawing.Size(96, 26);
            this.ButtonComboBox.TabIndex = 16;
            this.ButtonComboBox.Text = "Sol";
            this.ButtonComboBox.SelectedIndexChanged += new System.EventHandler(this.ButtonComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "D:";
            // 
            // MultiplierInput
            // 
            this.MultiplierInput.Location = new System.Drawing.Point(35, 274);
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
            this.MultiplierInput.Size = new System.Drawing.Size(95, 24);
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
            this.stopButton.Location = new System.Drawing.Point(268, 122);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(93, 206);
            this.stopButton.TabIndex = 19;
            this.stopButton.Text = "Durdur!";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Aqua;
            this.linkLabel1.Location = new System.Drawing.Point(317, 340);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 18);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // TriggerLink
            // 
            this.TriggerLink.AutoSize = true;
            this.TriggerLink.LinkColor = System.Drawing.Color.Aqua;
            this.TriggerLink.Location = new System.Drawing.Point(34, 122);
            this.TriggerLink.Name = "TriggerLink";
            this.TriggerLink.Size = new System.Drawing.Size(82, 18);
            this.TriggerLink.TabIndex = 21;
            this.TriggerLink.TabStop = true;
            this.TriggerLink.Text = "Return (13)";
            this.TriggerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TriggerLink_LinkClicked);
            // 
            // ChangeIntervalMaxInput
            // 
            this.ChangeIntervalMaxInput.Location = new System.Drawing.Point(155, 153);
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
            this.label8.Location = new System.Drawing.Point(136, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "S:";
            // 
            // CursorMinShake
            // 
            this.CursorMinShake.Location = new System.Drawing.Point(35, 304);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(283, 18);
            this.label10.TabIndex = 26;
            this.label10.Text = "Fareyi -S ve +S genişliğinde rastgele salla.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(136, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 18);
            this.label11.TabIndex = 28;
            this.label11.Text = "-";
            // 
            // CursorMaxShake
            // 
            this.CursorMaxShake.Location = new System.Drawing.Point(155, 304);
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
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(373, 367);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CursorMaxShake);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CursorMinShake);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ChangeIntervalMaxInput);
            this.Controls.Add(this.TriggerLink);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MultiplierInput);
            this.Controls.Add(this.ButtonComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TargetCpsLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CpsMaxInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CpsMinInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChangeIntervalMinInput);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ChangeIntervalMinInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown CpsMinInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CpsMaxInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TargetCpsLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ButtonComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown MultiplierInput;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel TriggerLink;
        private System.Windows.Forms.NumericUpDown ChangeIntervalMaxInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown CursorMinShake;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown CursorMaxShake;
    }
}

