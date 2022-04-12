
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
            this.ChangeIntervalInput = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CpsMinInput = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.CpsMaxInput = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TriggerButton = new System.Windows.Forms.Button();
            this.TargetCpsLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ButtonComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MultiplierInput = new System.Windows.Forms.NumericUpDown();
            this.stopButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeIntervalInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpsMinInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpsMaxInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierInput)).BeginInit();
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
            // ChangeIntervalInput
            // 
            this.ChangeIntervalInput.Location = new System.Drawing.Point(35, 153);
            this.ChangeIntervalInput.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.ChangeIntervalInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ChangeIntervalInput.Name = "ChangeIntervalInput";
            this.ChangeIntervalInput.Size = new System.Drawing.Size(95, 24);
            this.ChangeIntervalInput.TabIndex = 3;
            this.ChangeIntervalInput.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ChangeIntervalInput.ValueChanged += new System.EventHandler(this.ChangeIntervalInput_ValueChanged);
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
            // TriggerButton
            // 
            this.TriggerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TriggerButton.ForeColor = System.Drawing.Color.Black;
            this.TriggerButton.Location = new System.Drawing.Point(34, 115);
            this.TriggerButton.Name = "TriggerButton";
            this.TriggerButton.Size = new System.Drawing.Size(96, 32);
            this.TriggerButton.TabIndex = 11;
            this.TriggerButton.Text = "Return (13)";
            this.TriggerButton.UseVisualStyleBackColor = true;
            this.TriggerButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TriggerButton_MouseClick);
            // 
            // TargetCpsLabel
            // 
            this.TargetCpsLabel.AutoSize = true;
            this.TargetCpsLabel.Location = new System.Drawing.Point(136, 159);
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
            this.stopButton.Location = new System.Drawing.Point(268, 115);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(93, 183);
            this.stopButton.TabIndex = 19;
            this.stopButton.Text = "Durdur!";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Aqua;
            this.linkLabel1.Location = new System.Drawing.Point(268, 96);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(373, 314);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MultiplierInput);
            this.Controls.Add(this.ButtonComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TargetCpsLabel);
            this.Controls.Add(this.TriggerButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CpsMaxInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CpsMinInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChangeIntervalInput);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "AClicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ChangeIntervalInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpsMinInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CpsMaxInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplierInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ChangeIntervalInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown CpsMinInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CpsMaxInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button TriggerButton;
        private System.Windows.Forms.Label TargetCpsLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ButtonComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown MultiplierInput;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

