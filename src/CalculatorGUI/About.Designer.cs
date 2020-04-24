#region Copyright
// <copyright file="About.Designer.cs" company="Lidé u výtahu">
// CalcIVSulator (Simple calculator with GUI and mathematical library)
// Copyright © 2020 Viktor Rucký, Ondřej Sloup, Vojtěch Vlach
// 
// This file is part of CalcIVSulator.
// 
// CalcIVSulator is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// CalcIVSulator is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with CalcIVSulator.  If not, see <https://www.gnu.org/licenses/>.
// </copyright>
#endregion

namespace CalculatorGUI
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.lb_Next = new System.Windows.Forms.Label();
            this.lb_version = new System.Windows.Forms.Label();
            this.lb_team = new System.Windows.Forms.Label();
            this.lb_text = new System.Windows.Forms.Label();
            this.lb_name2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.license = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Next
            // 
            this.lb_Next.AutoEllipsis = true;
            this.lb_Next.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lb_Next.Location = new System.Drawing.Point(12, 9);
            this.lb_Next.Name = "lb_Next";
            this.lb_Next.Size = new System.Drawing.Size(257, 42);
            this.lb_Next.TabIndex = 38;
            this.lb_Next.Text = "CalcIVSulator";
            this.lb_Next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_version
            // 
            this.lb_version.AutoSize = true;
            this.lb_version.BackColor = System.Drawing.Color.PowderBlue;
            this.lb_version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lb_version.Location = new System.Drawing.Point(196, 120);
            this.lb_version.Name = "lb_version";
            this.lb_version.Size = new System.Drawing.Size(46, 13);
            this.lb_version.TabIndex = 39;
            this.lb_version.Text = "v1.0.0.0";
            // 
            // lb_team
            // 
            this.lb_team.AutoEllipsis = true;
            this.lb_team.BackColor = System.Drawing.Color.PowderBlue;
            this.lb_team.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_team.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lb_team.Location = new System.Drawing.Point(1, -1);
            this.lb_team.Name = "lb_team";
            this.lb_team.Size = new System.Drawing.Size(109, 28);
            this.lb_team.TabIndex = 40;
            this.lb_team.Text = "Lidé u výtahu";
            this.lb_team.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_text
            // 
            this.lb_text.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lb_text.Location = new System.Drawing.Point(12, 41);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(256, 25);
            this.lb_text.TabIndex = 41;
            this.lb_text.Text = "Nejlepší kalkulačka na trhu!";
            this.lb_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_name2
            // 
            this.lb_name2.AutoEllipsis = true;
            this.lb_name2.BackColor = System.Drawing.Color.PowderBlue;
            this.lb_name2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lb_name2.Location = new System.Drawing.Point(14, 121);
            this.lb_name2.Name = "lb_name2";
            this.lb_name2.Size = new System.Drawing.Size(167, 28);
            this.lb_name2.TabIndex = 42;
            this.lb_name2.Text = "Ondřej Sloup (xsloup02)";
            this.lb_name2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(2, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 28);
            this.label1.TabIndex = 43;
            this.label1.Text = "Viktor Rucký (xrucky01)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(14, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 28);
            this.label2.TabIndex = 44;
            this.label2.Text = "Vojtěch Vlach (xvlach22)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // license
            // 
            this.license.AutoSize = true;
            this.license.BackColor = System.Drawing.Color.PowderBlue;
            this.license.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.license.Location = new System.Drawing.Point(3, 120);
            this.license.Name = "license";
            this.license.Size = new System.Drawing.Size(108, 13);
            this.license.TabIndex = 45;
            this.license.Text = "GNU GPL-3.0-or-later";
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.PowderBlue;
            this.pnl.Controls.Add(this.license);
            this.pnl.Controls.Add(this.label1);
            this.pnl.Controls.Add(this.lb_version);
            this.pnl.Controls.Add(this.lb_team);
            this.pnl.Location = new System.Drawing.Point(12, 66);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(257, 133);
            this.pnl.TabIndex = 46;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(281, 208);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_name2);
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.lb_Next);
            this.Controls.Add(this.pnl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About";
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Next;
        private System.Windows.Forms.Label lb_version;
        private System.Windows.Forms.Label lb_team;
        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.Label lb_name2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label license;
        private System.Windows.Forms.Panel pnl;
    }
}