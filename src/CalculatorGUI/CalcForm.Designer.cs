#region Copyright
/// 
/// @cond CalcIVSulator (Simple calculator with GUI and mathematical library)
/// Copyright © 2020 Viktor Rucký, Ondřej Sloup, Vojtěch Vlach
/// This file is part of CalcIVSulator.
/// CalcIVSulator is free software: you can redistribute it and/or modify
/// it under the terms of the GNU General Public License as published by
/// the Free Software Foundation, either version 3 of the License, or
/// (at your option) any later version.
/// CalcIVSulator is distributed in the hope that it will be useful,
/// but WITHOUT ANY WARRANTY; without even the implied warranty of
/// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
/// GNU General Public License for more details.
/// You should have received a copy of the GNU General Public License
/// along with CalcIVSulator.  If not, see <https://www.gnu.org/licenses/>.
/// @endcond
/// 
#endregion

namespace CalculatorGUI
{
    partial class CalcForm
    {
        /// @brief 
        /// Required designer variable.
        /// 
        private System.ComponentModel.IContainer components = null;

        /// @brief 
        /// Clean up any resources being used.
        /// 
        /// @param[in] disposing - true if managed resources should be disposed; otherwise, false.
        /// @retrun void
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// @brief 
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// 
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcForm));
            this.btn_Nbr_3 = new System.Windows.Forms.Button();
            this.btn_Nbr_2 = new System.Windows.Forms.Button();
            this.btn_Nbr_6 = new System.Windows.Forms.Button();
            this.btn_Nbr_5 = new System.Windows.Forms.Button();
            this.btn_Nbr_8 = new System.Windows.Forms.Button();
            this.btn_Nbr_1 = new System.Windows.Forms.Button();
            this.btn_Nbr_4 = new System.Windows.Forms.Button();
            this.btn_Nbr_7 = new System.Windows.Forms.Button();
            this.btn_Nbr_9 = new System.Windows.Forms.Button();
            this.btn_Nbr_0 = new System.Windows.Forms.Button();
            this.btn_Div = new System.Windows.Forms.Button();
            this.btn_Mul = new System.Windows.Forms.Button();
            this.btn_Sub = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Res = new System.Windows.Forms.Button();
            this.btn_PowTo1 = new System.Windows.Forms.Button();
            this.btn_Root = new System.Windows.Forms.Button();
            this.btn_Power = new System.Windows.Forms.Button();
            this.btn_Comma = new System.Windows.Forms.Button();
            this.btn_sin = new System.Windows.Forms.Button();
            this.btn_cos = new System.Windows.Forms.Button();
            this.btn_tan = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lb_Next = new System.Windows.Forms.Label();
            this.btn_Negative = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Fac = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_Out = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Nbr_3
            // 
            this.btn_Nbr_3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Nbr_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Nbr_3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nbr_3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Nbr_3.Location = new System.Drawing.Point(110, 212);
            this.btn_Nbr_3.Name = "btn_Nbr_3";
            this.btn_Nbr_3.Size = new System.Drawing.Size(47, 36);
            this.btn_Nbr_3.TabIndex = 3;
            this.btn_Nbr_3.TabStop = false;
            this.btn_Nbr_3.Text = "3";
            this.btn_Nbr_3.UseVisualStyleBackColor = false;
            this.btn_Nbr_3.Click += new System.EventHandler(this.btn_Nbr_Click);
            // 
            // btn_Nbr_2
            // 
            this.btn_Nbr_2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Nbr_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Nbr_2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nbr_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Nbr_2.Location = new System.Drawing.Point(57, 212);
            this.btn_Nbr_2.Name = "btn_Nbr_2";
            this.btn_Nbr_2.Size = new System.Drawing.Size(47, 36);
            this.btn_Nbr_2.TabIndex = 2;
            this.btn_Nbr_2.TabStop = false;
            this.btn_Nbr_2.Text = "2";
            this.btn_Nbr_2.UseVisualStyleBackColor = false;
            this.btn_Nbr_2.Click += new System.EventHandler(this.btn_Nbr_Click);
            // 
            // btn_Nbr_6
            // 
            this.btn_Nbr_6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Nbr_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Nbr_6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nbr_6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Nbr_6.Location = new System.Drawing.Point(110, 170);
            this.btn_Nbr_6.Name = "btn_Nbr_6";
            this.btn_Nbr_6.Size = new System.Drawing.Size(47, 36);
            this.btn_Nbr_6.TabIndex = 6;
            this.btn_Nbr_6.TabStop = false;
            this.btn_Nbr_6.Text = "6";
            this.btn_Nbr_6.UseVisualStyleBackColor = false;
            this.btn_Nbr_6.Click += new System.EventHandler(this.btn_Nbr_Click);
            // 
            // btn_Nbr_5
            // 
            this.btn_Nbr_5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Nbr_5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Nbr_5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nbr_5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Nbr_5.Location = new System.Drawing.Point(57, 170);
            this.btn_Nbr_5.Name = "btn_Nbr_5";
            this.btn_Nbr_5.Size = new System.Drawing.Size(47, 36);
            this.btn_Nbr_5.TabIndex = 5;
            this.btn_Nbr_5.TabStop = false;
            this.btn_Nbr_5.Text = "5";
            this.btn_Nbr_5.UseVisualStyleBackColor = false;
            this.btn_Nbr_5.Click += new System.EventHandler(this.btn_Nbr_Click);
            // 
            // btn_Nbr_8
            // 
            this.btn_Nbr_8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Nbr_8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Nbr_8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nbr_8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Nbr_8.Location = new System.Drawing.Point(57, 128);
            this.btn_Nbr_8.Name = "btn_Nbr_8";
            this.btn_Nbr_8.Size = new System.Drawing.Size(47, 36);
            this.btn_Nbr_8.TabIndex = 8;
            this.btn_Nbr_8.TabStop = false;
            this.btn_Nbr_8.Text = "8";
            this.btn_Nbr_8.UseVisualStyleBackColor = false;
            this.btn_Nbr_8.Click += new System.EventHandler(this.btn_Nbr_Click);
            // 
            // btn_Nbr_1
            // 
            this.btn_Nbr_1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Nbr_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Nbr_1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nbr_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Nbr_1.Location = new System.Drawing.Point(4, 212);
            this.btn_Nbr_1.Name = "btn_Nbr_1";
            this.btn_Nbr_1.Size = new System.Drawing.Size(47, 36);
            this.btn_Nbr_1.TabIndex = 1;
            this.btn_Nbr_1.TabStop = false;
            this.btn_Nbr_1.Text = "1";
            this.btn_Nbr_1.UseVisualStyleBackColor = false;
            this.btn_Nbr_1.Click += new System.EventHandler(this.btn_Nbr_Click);
            // 
            // btn_Nbr_4
            // 
            this.btn_Nbr_4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Nbr_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Nbr_4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nbr_4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Nbr_4.Location = new System.Drawing.Point(4, 170);
            this.btn_Nbr_4.Name = "btn_Nbr_4";
            this.btn_Nbr_4.Size = new System.Drawing.Size(47, 36);
            this.btn_Nbr_4.TabIndex = 4;
            this.btn_Nbr_4.TabStop = false;
            this.btn_Nbr_4.Text = "4";
            this.btn_Nbr_4.UseVisualStyleBackColor = false;
            this.btn_Nbr_4.Click += new System.EventHandler(this.btn_Nbr_Click);
            // 
            // btn_Nbr_7
            // 
            this.btn_Nbr_7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Nbr_7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Nbr_7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nbr_7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Nbr_7.Location = new System.Drawing.Point(4, 128);
            this.btn_Nbr_7.Name = "btn_Nbr_7";
            this.btn_Nbr_7.Size = new System.Drawing.Size(47, 36);
            this.btn_Nbr_7.TabIndex = 7;
            this.btn_Nbr_7.TabStop = false;
            this.btn_Nbr_7.Text = "7";
            this.btn_Nbr_7.UseVisualStyleBackColor = false;
            this.btn_Nbr_7.Click += new System.EventHandler(this.btn_Nbr_Click);
            // 
            // btn_Nbr_9
            // 
            this.btn_Nbr_9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Nbr_9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Nbr_9.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nbr_9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Nbr_9.Location = new System.Drawing.Point(110, 128);
            this.btn_Nbr_9.Name = "btn_Nbr_9";
            this.btn_Nbr_9.Size = new System.Drawing.Size(47, 36);
            this.btn_Nbr_9.TabIndex = 9;
            this.btn_Nbr_9.TabStop = false;
            this.btn_Nbr_9.Text = "9";
            this.btn_Nbr_9.UseVisualStyleBackColor = false;
            this.btn_Nbr_9.Click += new System.EventHandler(this.btn_Nbr_Click);
            // 
            // btn_Nbr_0
            // 
            this.btn_Nbr_0.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Nbr_0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Nbr_0.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nbr_0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Nbr_0.Location = new System.Drawing.Point(4, 254);
            this.btn_Nbr_0.Name = "btn_Nbr_0";
            this.btn_Nbr_0.Size = new System.Drawing.Size(100, 36);
            this.btn_Nbr_0.TabIndex = 10;
            this.btn_Nbr_0.TabStop = false;
            this.btn_Nbr_0.Text = "0";
            this.btn_Nbr_0.UseVisualStyleBackColor = false;
            this.btn_Nbr_0.Click += new System.EventHandler(this.btn_Nbr_Click);
            // 
            // btn_Div
            // 
            this.btn_Div.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Div.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Div.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Div.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Div.Location = new System.Drawing.Point(216, 128);
            this.btn_Div.Name = "btn_Div";
            this.btn_Div.Size = new System.Drawing.Size(47, 36);
            this.btn_Div.TabIndex = 19;
            this.btn_Div.TabStop = false;
            this.btn_Div.Text = "/";
            this.btn_Div.UseVisualStyleBackColor = false;
            this.btn_Div.Click += new System.EventHandler(this.btn_MultipleValuesOperation_Click);
            // 
            // btn_Mul
            // 
            this.btn_Mul.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Mul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Mul.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Mul.Location = new System.Drawing.Point(216, 170);
            this.btn_Mul.Name = "btn_Mul";
            this.btn_Mul.Size = new System.Drawing.Size(47, 36);
            this.btn_Mul.TabIndex = 18;
            this.btn_Mul.TabStop = false;
            this.btn_Mul.Text = "*";
            this.btn_Mul.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Mul.UseVisualStyleBackColor = false;
            this.btn_Mul.Click += new System.EventHandler(this.btn_MultipleValuesOperation_Click);
            // 
            // btn_Sub
            // 
            this.btn_Sub.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Sub.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Sub.Location = new System.Drawing.Point(216, 212);
            this.btn_Sub.Name = "btn_Sub";
            this.btn_Sub.Size = new System.Drawing.Size(47, 36);
            this.btn_Sub.TabIndex = 17;
            this.btn_Sub.TabStop = false;
            this.btn_Sub.Text = "-";
            this.btn_Sub.UseVisualStyleBackColor = false;
            this.btn_Sub.Click += new System.EventHandler(this.btn_MultipleValuesOperation_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Add.Location = new System.Drawing.Point(216, 254);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(47, 36);
            this.btn_Add.TabIndex = 16;
            this.btn_Add.TabStop = false;
            this.btn_Add.Text = "+";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_MultipleValuesOperation_Click);
            // 
            // btn_Res
            // 
            this.btn_Res.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Res.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Res.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Res.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Res.Location = new System.Drawing.Point(269, 212);
            this.btn_Res.Name = "btn_Res";
            this.btn_Res.Size = new System.Drawing.Size(47, 78);
            this.btn_Res.TabIndex = 20;
            this.btn_Res.TabStop = false;
            this.btn_Res.Text = "=";
            this.btn_Res.UseVisualStyleBackColor = false;
            this.btn_Res.Click += new System.EventHandler(this.btn_Res_Click);
            // 
            // btn_PowTo1
            // 
            this.btn_PowTo1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_PowTo1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_PowTo1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PowTo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_PowTo1.Location = new System.Drawing.Point(269, 170);
            this.btn_PowTo1.Name = "btn_PowTo1";
            this.btn_PowTo1.Size = new System.Drawing.Size(47, 36);
            this.btn_PowTo1.TabIndex = 21;
            this.btn_PowTo1.TabStop = false;
            this.btn_PowTo1.Text = "1/𝑥";
            this.btn_PowTo1.UseVisualStyleBackColor = false;
            this.btn_PowTo1.Click += new System.EventHandler(this.btn_SingleValueOperation_Click);
            // 
            // btn_Root
            // 
            this.btn_Root.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Root.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Root.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Root.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Root.Location = new System.Drawing.Point(216, 86);
            this.btn_Root.Name = "btn_Root";
            this.btn_Root.Size = new System.Drawing.Size(47, 36);
            this.btn_Root.TabIndex = 24;
            this.btn_Root.TabStop = false;
            this.btn_Root.Text = "ⁿ√𝑥";
            this.btn_Root.UseVisualStyleBackColor = false;
            this.btn_Root.Click += new System.EventHandler(this.btn_MultipleValuesOperation_Click);
            // 
            // btn_Power
            // 
            this.btn_Power.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Power.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Power.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Power.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Power.Location = new System.Drawing.Point(163, 86);
            this.btn_Power.Name = "btn_Power";
            this.btn_Power.Size = new System.Drawing.Size(47, 36);
            this.btn_Power.TabIndex = 25;
            this.btn_Power.TabStop = false;
            this.btn_Power.Text = "^";
            this.btn_Power.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Power.UseVisualStyleBackColor = false;
            this.btn_Power.Click += new System.EventHandler(this.btn_MultipleValuesOperation_Click);
            // 
            // btn_Comma
            // 
            this.btn_Comma.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Comma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Comma.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Comma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Comma.Location = new System.Drawing.Point(110, 254);
            this.btn_Comma.Name = "btn_Comma";
            this.btn_Comma.Size = new System.Drawing.Size(47, 36);
            this.btn_Comma.TabIndex = 11;
            this.btn_Comma.TabStop = false;
            this.btn_Comma.Text = ",";
            this.btn_Comma.UseVisualStyleBackColor = false;
            this.btn_Comma.Click += new System.EventHandler(this.btn_Nbr_Click);
            // 
            // btn_sin
            // 
            this.btn_sin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_sin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_sin.Location = new System.Drawing.Point(4, 86);
            this.btn_sin.Name = "btn_sin";
            this.btn_sin.Size = new System.Drawing.Size(47, 36);
            this.btn_sin.TabIndex = 28;
            this.btn_sin.TabStop = false;
            this.btn_sin.Text = "sin";
            this.btn_sin.UseVisualStyleBackColor = false;
            this.btn_sin.Click += new System.EventHandler(this.btn_SingleValueOperation_Click);
            // 
            // btn_cos
            // 
            this.btn_cos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_cos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cos.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cos.Location = new System.Drawing.Point(57, 86);
            this.btn_cos.Name = "btn_cos";
            this.btn_cos.Size = new System.Drawing.Size(47, 36);
            this.btn_cos.TabIndex = 27;
            this.btn_cos.TabStop = false;
            this.btn_cos.Text = "cos";
            this.btn_cos.UseVisualStyleBackColor = false;
            this.btn_cos.Click += new System.EventHandler(this.btn_SingleValueOperation_Click);
            // 
            // btn_tan
            // 
            this.btn_tan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_tan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_tan.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_tan.Location = new System.Drawing.Point(110, 86);
            this.btn_tan.Name = "btn_tan";
            this.btn_tan.Size = new System.Drawing.Size(47, 36);
            this.btn_tan.TabIndex = 26;
            this.btn_tan.TabStop = false;
            this.btn_tan.Text = "tan";
            this.btn_tan.UseVisualStyleBackColor = false;
            this.btn_tan.Click += new System.EventHandler(this.btn_SingleValueOperation_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Back.Location = new System.Drawing.Point(269, 128);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(47, 36);
            this.btn_Back.TabIndex = 22;
            this.btn_Back.TabStop = false;
            this.btn_Back.Text = "←";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lb_Next
            // 
            this.lb_Next.AutoEllipsis = true;
            this.lb_Next.AutoSize = true;
            this.lb_Next.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Next.Location = new System.Drawing.Point(4, 9);
            this.lb_Next.MinimumSize = new System.Drawing.Size(312, 0);
            this.lb_Next.Name = "lb_Next";
            this.lb_Next.Size = new System.Drawing.Size(312, 28);
            this.lb_Next.TabIndex = 30;
            this.lb_Next.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Negative
            // 
            this.btn_Negative.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Negative.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Negative.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Negative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Negative.Location = new System.Drawing.Point(163, 254);
            this.btn_Negative.Name = "btn_Negative";
            this.btn_Negative.Size = new System.Drawing.Size(47, 36);
            this.btn_Negative.TabIndex = 12;
            this.btn_Negative.TabStop = false;
            this.btn_Negative.Text = "±";
            this.btn_Negative.UseVisualStyleBackColor = false;
            this.btn_Negative.Click += new System.EventHandler(this.btn_Negative_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Delete.Location = new System.Drawing.Point(269, 86);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(47, 36);
            this.btn_Delete.TabIndex = 23;
            this.btn_Delete.TabStop = false;
            this.btn_Delete.Text = "AC";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Fac
            // 
            this.btn_Fac.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Fac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Fac.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Fac.Location = new System.Drawing.Point(163, 212);
            this.btn_Fac.Name = "btn_Fac";
            this.btn_Fac.Size = new System.Drawing.Size(47, 36);
            this.btn_Fac.TabIndex = 13;
            this.btn_Fac.TabStop = false;
            this.btn_Fac.Text = "!";
            this.btn_Fac.UseVisualStyleBackColor = false;
            this.btn_Fac.Click += new System.EventHandler(this.btn_SingleValueOperation_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(163, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 36);
            this.button1.TabIndex = 14;
            this.button1.TabStop = false;
            this.button1.Text = "²√";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_SingleValueOperation_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(163, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 36);
            this.button2.TabIndex = 15;
            this.button2.TabStop = false;
            this.button2.Text = "𝑥^2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_SingleValueOperation_Click);
            // 
            // tb_Out
            // 
            this.tb_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Out.BackColor = System.Drawing.SystemColors.Control;
            this.tb_Out.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tb_Out.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F);
            this.tb_Out.Location = new System.Drawing.Point(4, 40);
            this.tb_Out.Name = "tb_Out";
            this.tb_Out.Size = new System.Drawing.Size(312, 38);
            this.tb_Out.TabIndex = 31;
            this.tb_Out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(319, 295);
            this.Controls.Add(this.tb_Out);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Fac);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Negative);
            this.Controls.Add(this.lb_Next);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_tan);
            this.Controls.Add(this.btn_cos);
            this.Controls.Add(this.btn_sin);
            this.Controls.Add(this.btn_Comma);
            this.Controls.Add(this.btn_Power);
            this.Controls.Add(this.btn_Root);
            this.Controls.Add(this.btn_PowTo1);
            this.Controls.Add(this.btn_Res);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Sub);
            this.Controls.Add(this.btn_Mul);
            this.Controls.Add(this.btn_Div);
            this.Controls.Add(this.btn_Nbr_0);
            this.Controls.Add(this.btn_Nbr_3);
            this.Controls.Add(this.btn_Nbr_2);
            this.Controls.Add(this.btn_Nbr_6);
            this.Controls.Add(this.btn_Nbr_5);
            this.Controls.Add(this.btn_Nbr_8);
            this.Controls.Add(this.btn_Nbr_1);
            this.Controls.Add(this.btn_Nbr_4);
            this.Controls.Add(this.btn_Nbr_7);
            this.Controls.Add(this.btn_Nbr_9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalcForm";
            this.Text = "CalcIVSulator";
            this.Load += new System.EventHandler(this.CalcForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalcForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Nbr_3;
        private System.Windows.Forms.Button btn_Nbr_2;
        private System.Windows.Forms.Button btn_Nbr_6;
        private System.Windows.Forms.Button btn_Nbr_5;
        private System.Windows.Forms.Button btn_Nbr_8;
        private System.Windows.Forms.Button btn_Nbr_1;
        private System.Windows.Forms.Button btn_Nbr_4;
        private System.Windows.Forms.Button btn_Nbr_7;
        private System.Windows.Forms.Button btn_Nbr_9;
        private System.Windows.Forms.Button btn_Nbr_0;
        private System.Windows.Forms.Button btn_Div;
        private System.Windows.Forms.Button btn_Mul;
        private System.Windows.Forms.Button btn_Sub;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Res;
        private System.Windows.Forms.Button btn_PowTo1;
        private System.Windows.Forms.Button btn_Root;
        private System.Windows.Forms.Button btn_Power;
        private System.Windows.Forms.Button btn_Comma;
        private System.Windows.Forms.Button btn_sin;
        private System.Windows.Forms.Button btn_cos;
        private System.Windows.Forms.Button btn_tan;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lb_Next;
        private System.Windows.Forms.Button btn_Negative;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Fac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label tb_Out;
    }
}

