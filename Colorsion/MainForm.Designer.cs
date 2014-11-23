﻿namespace Colorsion
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
            this.BTNConvert = new System.Windows.Forms.Button();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.tabControlInput = new System.Windows.Forms.TabControl();
            this.tabPageInputInt = new System.Windows.Forms.TabPage();
            this.NUDInputIntAlpha = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NUDInputIntBlue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NUDInputIntGreen = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NUDInputIntRed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageInputFloat = new System.Windows.Forms.TabPage();
            this.TBInputFloatAlpha = new System.Windows.Forms.TextBox();
            this.TBInputFloatBlue = new System.Windows.Forms.TextBox();
            this.TBInputFloatGreen = new System.Windows.Forms.TextBox();
            this.TBInputFloatRed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageInputHex = new System.Windows.Forms.TabPage();
            this.TBInputHex = new System.Windows.Forms.TextBox();
            this.tabPageInputUInt = new System.Windows.Forms.TabPage();
            this.TBInputUInt = new System.Windows.Forms.TextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.tabControlOutput = new System.Windows.Forms.TabControl();
            this.tabPageOutputInt = new System.Windows.Forms.TabPage();
            this.TBOutputIntAlpha = new System.Windows.Forms.TextBox();
            this.TBOutputIntBlue = new System.Windows.Forms.TextBox();
            this.TBOutputIntGreen = new System.Windows.Forms.TextBox();
            this.TBOutputIntRed = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPageOutputFloat = new System.Windows.Forms.TabPage();
            this.TBOutputFloatAlpha = new System.Windows.Forms.TextBox();
            this.TBOutputFloatBlue = new System.Windows.Forms.TextBox();
            this.TBOutputFloatGreen = new System.Windows.Forms.TextBox();
            this.TBOutputFloatRed = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPageOutputHex = new System.Windows.Forms.TabPage();
            this.TBOutputHex = new System.Windows.Forms.TextBox();
            this.tabPageOutputUInt = new System.Windows.Forms.TabPage();
            this.TBOutputUInt = new System.Windows.Forms.TextBox();
            this.PictureBoxColor = new System.Windows.Forms.PictureBox();
            this.groupBoxInput.SuspendLayout();
            this.tabControlInput.SuspendLayout();
            this.tabPageInputInt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInputIntAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInputIntBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInputIntGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInputIntRed)).BeginInit();
            this.tabPageInputFloat.SuspendLayout();
            this.tabPageInputHex.SuspendLayout();
            this.tabPageInputUInt.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.tabControlOutput.SuspendLayout();
            this.tabPageOutputInt.SuspendLayout();
            this.tabPageOutputFloat.SuspendLayout();
            this.tabPageOutputHex.SuspendLayout();
            this.tabPageOutputUInt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNConvert
            // 
            this.BTNConvert.Location = new System.Drawing.Point(311, 173);
            this.BTNConvert.Name = "BTNConvert";
            this.BTNConvert.Size = new System.Drawing.Size(75, 23);
            this.BTNConvert.TabIndex = 3;
            this.BTNConvert.Text = "Convert";
            this.BTNConvert.UseVisualStyleBackColor = true;
            this.BTNConvert.Click += new System.EventHandler(this.ButtonConvert_Click);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.tabControlInput);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(184, 155);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input";
            // 
            // tabControlInput
            // 
            this.tabControlInput.Controls.Add(this.tabPageInputInt);
            this.tabControlInput.Controls.Add(this.tabPageInputFloat);
            this.tabControlInput.Controls.Add(this.tabPageInputHex);
            this.tabControlInput.Controls.Add(this.tabPageInputUInt);
            this.tabControlInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlInput.Location = new System.Drawing.Point(3, 16);
            this.tabControlInput.Name = "tabControlInput";
            this.tabControlInput.SelectedIndex = 0;
            this.tabControlInput.Size = new System.Drawing.Size(178, 136);
            this.tabControlInput.TabIndex = 0;
            // 
            // tabPageInputInt
            // 
            this.tabPageInputInt.Controls.Add(this.NUDInputIntAlpha);
            this.tabPageInputInt.Controls.Add(this.label4);
            this.tabPageInputInt.Controls.Add(this.NUDInputIntBlue);
            this.tabPageInputInt.Controls.Add(this.label3);
            this.tabPageInputInt.Controls.Add(this.NUDInputIntGreen);
            this.tabPageInputInt.Controls.Add(this.label2);
            this.tabPageInputInt.Controls.Add(this.NUDInputIntRed);
            this.tabPageInputInt.Controls.Add(this.label1);
            this.tabPageInputInt.Location = new System.Drawing.Point(4, 22);
            this.tabPageInputInt.Name = "tabPageInputInt";
            this.tabPageInputInt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInputInt.Size = new System.Drawing.Size(170, 110);
            this.tabPageInputInt.TabIndex = 0;
            this.tabPageInputInt.Text = "RGBA";
            this.tabPageInputInt.UseVisualStyleBackColor = true;
            // 
            // NUDInputIntAlpha
            // 
            this.NUDInputIntAlpha.Location = new System.Drawing.Point(112, 84);
            this.NUDInputIntAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDInputIntAlpha.Name = "NUDInputIntAlpha";
            this.NUDInputIntAlpha.Size = new System.Drawing.Size(52, 20);
            this.NUDInputIntAlpha.TabIndex = 4;
            this.NUDInputIntAlpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alpha";
            // 
            // NUDInputIntBlue
            // 
            this.NUDInputIntBlue.Location = new System.Drawing.Point(112, 58);
            this.NUDInputIntBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDInputIntBlue.Name = "NUDInputIntBlue";
            this.NUDInputIntBlue.Size = new System.Drawing.Size(52, 20);
            this.NUDInputIntBlue.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Blue";
            // 
            // NUDInputIntGreen
            // 
            this.NUDInputIntGreen.Location = new System.Drawing.Point(112, 32);
            this.NUDInputIntGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDInputIntGreen.Name = "NUDInputIntGreen";
            this.NUDInputIntGreen.Size = new System.Drawing.Size(52, 20);
            this.NUDInputIntGreen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Green";
            // 
            // NUDInputIntRed
            // 
            this.NUDInputIntRed.Location = new System.Drawing.Point(112, 6);
            this.NUDInputIntRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDInputIntRed.Name = "NUDInputIntRed";
            this.NUDInputIntRed.Size = new System.Drawing.Size(52, 20);
            this.NUDInputIntRed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // tabPageInputFloat
            // 
            this.tabPageInputFloat.Controls.Add(this.TBInputFloatAlpha);
            this.tabPageInputFloat.Controls.Add(this.TBInputFloatBlue);
            this.tabPageInputFloat.Controls.Add(this.TBInputFloatGreen);
            this.tabPageInputFloat.Controls.Add(this.TBInputFloatRed);
            this.tabPageInputFloat.Controls.Add(this.label5);
            this.tabPageInputFloat.Controls.Add(this.label6);
            this.tabPageInputFloat.Controls.Add(this.label7);
            this.tabPageInputFloat.Controls.Add(this.label8);
            this.tabPageInputFloat.Location = new System.Drawing.Point(4, 22);
            this.tabPageInputFloat.Name = "tabPageInputFloat";
            this.tabPageInputFloat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInputFloat.Size = new System.Drawing.Size(170, 110);
            this.tabPageInputFloat.TabIndex = 1;
            this.tabPageInputFloat.Text = "Float";
            this.tabPageInputFloat.UseVisualStyleBackColor = true;
            // 
            // TBInputFloatAlpha
            // 
            this.TBInputFloatAlpha.Location = new System.Drawing.Point(112, 83);
            this.TBInputFloatAlpha.Name = "TBInputFloatAlpha";
            this.TBInputFloatAlpha.Size = new System.Drawing.Size(52, 20);
            this.TBInputFloatAlpha.TabIndex = 4;
            // 
            // TBInputFloatBlue
            // 
            this.TBInputFloatBlue.Location = new System.Drawing.Point(112, 57);
            this.TBInputFloatBlue.Name = "TBInputFloatBlue";
            this.TBInputFloatBlue.Size = new System.Drawing.Size(52, 20);
            this.TBInputFloatBlue.TabIndex = 3;
            // 
            // TBInputFloatGreen
            // 
            this.TBInputFloatGreen.Location = new System.Drawing.Point(112, 31);
            this.TBInputFloatGreen.Name = "TBInputFloatGreen";
            this.TBInputFloatGreen.Size = new System.Drawing.Size(52, 20);
            this.TBInputFloatGreen.TabIndex = 2;
            // 
            // TBInputFloatRed
            // 
            this.TBInputFloatRed.Location = new System.Drawing.Point(112, 5);
            this.TBInputFloatRed.Name = "TBInputFloatRed";
            this.TBInputFloatRed.Size = new System.Drawing.Size(52, 20);
            this.TBInputFloatRed.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Alpha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Blue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Green";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(6, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Red";
            // 
            // tabPageInputHex
            // 
            this.tabPageInputHex.Controls.Add(this.TBInputHex);
            this.tabPageInputHex.Location = new System.Drawing.Point(4, 22);
            this.tabPageInputHex.Name = "tabPageInputHex";
            this.tabPageInputHex.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInputHex.Size = new System.Drawing.Size(170, 110);
            this.tabPageInputHex.TabIndex = 2;
            this.tabPageInputHex.Text = "Hex";
            this.tabPageInputHex.UseVisualStyleBackColor = true;
            // 
            // TBInputHex
            // 
            this.TBInputHex.Location = new System.Drawing.Point(6, 6);
            this.TBInputHex.Name = "TBInputHex";
            this.TBInputHex.Size = new System.Drawing.Size(158, 20);
            this.TBInputHex.TabIndex = 1;
            // 
            // tabPageInputUInt
            // 
            this.tabPageInputUInt.Controls.Add(this.TBInputUInt);
            this.tabPageInputUInt.Location = new System.Drawing.Point(4, 22);
            this.tabPageInputUInt.Name = "tabPageInputUInt";
            this.tabPageInputUInt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInputUInt.Size = new System.Drawing.Size(170, 110);
            this.tabPageInputUInt.TabIndex = 3;
            this.tabPageInputUInt.Text = "UInt";
            this.tabPageInputUInt.UseVisualStyleBackColor = true;
            // 
            // TBInputUInt
            // 
            this.TBInputUInt.Location = new System.Drawing.Point(6, 6);
            this.TBInputUInt.Name = "TBInputUInt";
            this.TBInputUInt.Size = new System.Drawing.Size(158, 20);
            this.TBInputUInt.TabIndex = 1;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.tabControlOutput);
            this.groupBoxOutput.Location = new System.Drawing.Point(202, 12);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(184, 155);
            this.groupBoxOutput.TabIndex = 2;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
            // 
            // tabControlOutput
            // 
            this.tabControlOutput.Controls.Add(this.tabPageOutputInt);
            this.tabControlOutput.Controls.Add(this.tabPageOutputFloat);
            this.tabControlOutput.Controls.Add(this.tabPageOutputHex);
            this.tabControlOutput.Controls.Add(this.tabPageOutputUInt);
            this.tabControlOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOutput.Location = new System.Drawing.Point(3, 16);
            this.tabControlOutput.Name = "tabControlOutput";
            this.tabControlOutput.SelectedIndex = 0;
            this.tabControlOutput.Size = new System.Drawing.Size(178, 136);
            this.tabControlOutput.TabIndex = 0;
            // 
            // tabPageOutputInt
            // 
            this.tabPageOutputInt.Controls.Add(this.TBOutputIntAlpha);
            this.tabPageOutputInt.Controls.Add(this.TBOutputIntBlue);
            this.tabPageOutputInt.Controls.Add(this.TBOutputIntGreen);
            this.tabPageOutputInt.Controls.Add(this.TBOutputIntRed);
            this.tabPageOutputInt.Controls.Add(this.label9);
            this.tabPageOutputInt.Controls.Add(this.label10);
            this.tabPageOutputInt.Controls.Add(this.label11);
            this.tabPageOutputInt.Controls.Add(this.label12);
            this.tabPageOutputInt.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutputInt.Name = "tabPageOutputInt";
            this.tabPageOutputInt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutputInt.Size = new System.Drawing.Size(170, 110);
            this.tabPageOutputInt.TabIndex = 0;
            this.tabPageOutputInt.Text = "RGBA";
            this.tabPageOutputInt.UseVisualStyleBackColor = true;
            // 
            // TBOutputIntAlpha
            // 
            this.TBOutputIntAlpha.Location = new System.Drawing.Point(112, 83);
            this.TBOutputIntAlpha.Name = "TBOutputIntAlpha";
            this.TBOutputIntAlpha.ReadOnly = true;
            this.TBOutputIntAlpha.Size = new System.Drawing.Size(52, 20);
            this.TBOutputIntAlpha.TabIndex = 4;
            // 
            // TBOutputIntBlue
            // 
            this.TBOutputIntBlue.Location = new System.Drawing.Point(112, 57);
            this.TBOutputIntBlue.Name = "TBOutputIntBlue";
            this.TBOutputIntBlue.ReadOnly = true;
            this.TBOutputIntBlue.Size = new System.Drawing.Size(52, 20);
            this.TBOutputIntBlue.TabIndex = 3;
            // 
            // TBOutputIntGreen
            // 
            this.TBOutputIntGreen.Location = new System.Drawing.Point(112, 31);
            this.TBOutputIntGreen.Name = "TBOutputIntGreen";
            this.TBOutputIntGreen.ReadOnly = true;
            this.TBOutputIntGreen.Size = new System.Drawing.Size(52, 20);
            this.TBOutputIntGreen.TabIndex = 2;
            // 
            // TBOutputIntRed
            // 
            this.TBOutputIntRed.Location = new System.Drawing.Point(112, 5);
            this.TBOutputIntRed.Name = "TBOutputIntRed";
            this.TBOutputIntRed.ReadOnly = true;
            this.TBOutputIntRed.Size = new System.Drawing.Size(52, 20);
            this.TBOutputIntRed.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(6, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Alpha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(6, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Blue";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(6, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Green";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(6, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Red";
            // 
            // tabPageOutputFloat
            // 
            this.tabPageOutputFloat.Controls.Add(this.TBOutputFloatAlpha);
            this.tabPageOutputFloat.Controls.Add(this.TBOutputFloatBlue);
            this.tabPageOutputFloat.Controls.Add(this.TBOutputFloatGreen);
            this.tabPageOutputFloat.Controls.Add(this.TBOutputFloatRed);
            this.tabPageOutputFloat.Controls.Add(this.label13);
            this.tabPageOutputFloat.Controls.Add(this.label14);
            this.tabPageOutputFloat.Controls.Add(this.label15);
            this.tabPageOutputFloat.Controls.Add(this.label16);
            this.tabPageOutputFloat.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutputFloat.Name = "tabPageOutputFloat";
            this.tabPageOutputFloat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutputFloat.Size = new System.Drawing.Size(170, 110);
            this.tabPageOutputFloat.TabIndex = 1;
            this.tabPageOutputFloat.Text = "Float";
            this.tabPageOutputFloat.UseVisualStyleBackColor = true;
            // 
            // TBOutputFloatAlpha
            // 
            this.TBOutputFloatAlpha.Location = new System.Drawing.Point(112, 83);
            this.TBOutputFloatAlpha.Name = "TBOutputFloatAlpha";
            this.TBOutputFloatAlpha.ReadOnly = true;
            this.TBOutputFloatAlpha.Size = new System.Drawing.Size(52, 20);
            this.TBOutputFloatAlpha.TabIndex = 4;
            // 
            // TBOutputFloatBlue
            // 
            this.TBOutputFloatBlue.Location = new System.Drawing.Point(112, 57);
            this.TBOutputFloatBlue.Name = "TBOutputFloatBlue";
            this.TBOutputFloatBlue.ReadOnly = true;
            this.TBOutputFloatBlue.Size = new System.Drawing.Size(52, 20);
            this.TBOutputFloatBlue.TabIndex = 3;
            // 
            // TBOutputFloatGreen
            // 
            this.TBOutputFloatGreen.Location = new System.Drawing.Point(112, 31);
            this.TBOutputFloatGreen.Name = "TBOutputFloatGreen";
            this.TBOutputFloatGreen.ReadOnly = true;
            this.TBOutputFloatGreen.Size = new System.Drawing.Size(52, 20);
            this.TBOutputFloatGreen.TabIndex = 2;
            // 
            // TBOutputFloatRed
            // 
            this.TBOutputFloatRed.Location = new System.Drawing.Point(112, 5);
            this.TBOutputFloatRed.Name = "TBOutputFloatRed";
            this.TBOutputFloatRed.ReadOnly = true;
            this.TBOutputFloatRed.Size = new System.Drawing.Size(52, 20);
            this.TBOutputFloatRed.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(6, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Alpha";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(6, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Blue";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(6, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Green";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(6, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Red";
            // 
            // tabPageOutputHex
            // 
            this.tabPageOutputHex.Controls.Add(this.TBOutputHex);
            this.tabPageOutputHex.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutputHex.Name = "tabPageOutputHex";
            this.tabPageOutputHex.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutputHex.Size = new System.Drawing.Size(170, 110);
            this.tabPageOutputHex.TabIndex = 2;
            this.tabPageOutputHex.Text = "Hex";
            this.tabPageOutputHex.UseVisualStyleBackColor = true;
            // 
            // TBOutputHex
            // 
            this.TBOutputHex.Location = new System.Drawing.Point(6, 6);
            this.TBOutputHex.Name = "TBOutputHex";
            this.TBOutputHex.ReadOnly = true;
            this.TBOutputHex.Size = new System.Drawing.Size(158, 20);
            this.TBOutputHex.TabIndex = 1;
            // 
            // tabPageOutputUInt
            // 
            this.tabPageOutputUInt.Controls.Add(this.TBOutputUInt);
            this.tabPageOutputUInt.Location = new System.Drawing.Point(4, 22);
            this.tabPageOutputUInt.Name = "tabPageOutputUInt";
            this.tabPageOutputUInt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOutputUInt.Size = new System.Drawing.Size(170, 110);
            this.tabPageOutputUInt.TabIndex = 3;
            this.tabPageOutputUInt.Text = "UInt";
            this.tabPageOutputUInt.UseVisualStyleBackColor = true;
            // 
            // TBOutputUInt
            // 
            this.TBOutputUInt.Location = new System.Drawing.Point(6, 6);
            this.TBOutputUInt.Name = "TBOutputUInt";
            this.TBOutputUInt.ReadOnly = true;
            this.TBOutputUInt.Size = new System.Drawing.Size(158, 20);
            this.TBOutputUInt.TabIndex = 1;
            // 
            // PictureBoxColor
            // 
            this.PictureBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxColor.Location = new System.Drawing.Point(12, 173);
            this.PictureBoxColor.Name = "PictureBoxColor";
            this.PictureBoxColor.Size = new System.Drawing.Size(23, 23);
            this.PictureBoxColor.TabIndex = 0;
            this.PictureBoxColor.TabStop = false;
            this.PictureBoxColor.MouseHover += new System.EventHandler(this.PictureBoxColor_MouseHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 208);
            this.Controls.Add(this.PictureBoxColor);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.BTNConvert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Colorsion";
            this.groupBoxInput.ResumeLayout(false);
            this.tabControlInput.ResumeLayout(false);
            this.tabPageInputInt.ResumeLayout(false);
            this.tabPageInputInt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInputIntAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInputIntBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInputIntGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDInputIntRed)).EndInit();
            this.tabPageInputFloat.ResumeLayout(false);
            this.tabPageInputFloat.PerformLayout();
            this.tabPageInputHex.ResumeLayout(false);
            this.tabPageInputHex.PerformLayout();
            this.tabPageInputUInt.ResumeLayout(false);
            this.tabPageInputUInt.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.tabControlOutput.ResumeLayout(false);
            this.tabPageOutputInt.ResumeLayout(false);
            this.tabPageOutputInt.PerformLayout();
            this.tabPageOutputFloat.ResumeLayout(false);
            this.tabPageOutputFloat.PerformLayout();
            this.tabPageOutputHex.ResumeLayout(false);
            this.tabPageOutputHex.PerformLayout();
            this.tabPageOutputUInt.ResumeLayout(false);
            this.tabPageOutputUInt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTNConvert;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TabControl tabControlInput;
        private System.Windows.Forms.TabPage tabPageInputInt;
        private System.Windows.Forms.TabPage tabPageInputFloat;
        private System.Windows.Forms.TabPage tabPageInputHex;
        private System.Windows.Forms.TabPage tabPageInputUInt;
        private System.Windows.Forms.NumericUpDown NUDInputIntAlpha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUDInputIntBlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUDInputIntGreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUDInputIntRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBInputFloatAlpha;
        private System.Windows.Forms.TextBox TBInputFloatBlue;
        private System.Windows.Forms.TextBox TBInputFloatGreen;
        private System.Windows.Forms.TextBox TBInputFloatRed;
        private System.Windows.Forms.TextBox TBInputHex;
        private System.Windows.Forms.TextBox TBInputUInt;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TabControl tabControlOutput;
        private System.Windows.Forms.TabPage tabPageOutputInt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPageOutputFloat;
        private System.Windows.Forms.TextBox TBOutputFloatAlpha;
        private System.Windows.Forms.TextBox TBOutputFloatBlue;
        private System.Windows.Forms.TextBox TBOutputFloatGreen;
        private System.Windows.Forms.TextBox TBOutputFloatRed;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPageOutputHex;
        private System.Windows.Forms.TextBox TBOutputHex;
        private System.Windows.Forms.TabPage tabPageOutputUInt;
        private System.Windows.Forms.TextBox TBOutputUInt;
        private System.Windows.Forms.TextBox TBOutputIntAlpha;
        private System.Windows.Forms.TextBox TBOutputIntBlue;
        private System.Windows.Forms.TextBox TBOutputIntGreen;
        private System.Windows.Forms.TextBox TBOutputIntRed;
        private System.Windows.Forms.PictureBox PictureBoxColor;
    }
}
