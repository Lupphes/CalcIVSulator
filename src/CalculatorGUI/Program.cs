#region Copyright
// <copyright file="Program.cs" company="Lidé u výtahu">
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalcForm());
        }
    }
}
