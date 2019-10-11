// ***********************************************************************
// Assembly         : A1CDesk
// Author           : m_c_w
// Created          : 10-05-2019
//
// Last Modified By : m_c_w
// Last Modified On : 10-05-2019
// ***********************************************************************
// <copyright file="Program.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1CDesk
{
    /// <summary>
    /// Class Program.
    /// </summary>
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
            Application.Run(new frmMain());
        }
    }
}
