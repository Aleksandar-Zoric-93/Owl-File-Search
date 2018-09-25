using DirectorySearch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OwlFileSearch
{
    public partial class Eula : Form
    {
        public Eula()
        {
            InitializeComponent();
            eulaAgreementTxt.SelectionLength = 0;
            eulaAgreementTxt.Text = "End - User License Agreement(EULA) of Owl File Search" + Environment.NewLine + Environment.NewLine +
            "This End-User License Agreement(EULA) is a legal agreement between you and Aleksandar Zoric." + Environment.NewLine +
            "This EULA agreement governs your acquisition and use of our Owl File Search software(Software) directly from Aleksandar Zoric or indirectly through a Aleksandar Zoric authorized reseller or distributor(a Reseller)." + Environment.NewLine +
            "Please read this EULA agreement carefully before completing the installation process and using the Owl File Search software.It provides a license to use the Owl File Search software and contains warranty information and liability disclaimers." + Environment.NewLine +
            "If you register for a free trial of the Owl File Search software, this EULA agreement will also govern that trial.By clicking accept or installing and / or using the Owl File Search software, you are confirming your acceptance of the Software and agreeing to become bound by the terms of this EULA agreement." + Environment.NewLine +
            "If you are entering into this EULA agreement on behalf of a company or other legal entity, you represent that you have the authority to bind such entity and its affiliates to these terms and conditions.If you do not have such authority or if you do not agree with the terms and conditions of this EULA agreement, do not install or use the Software, and you must not accept this EULA agreement." + Environment.NewLine +
            "This EULA agreement shall apply only to the Software supplied by Aleksandar Zoric herewith regardless of whether other software is referred to or described herein.The terms also apply to any Aleksandar Zoric updates, supplements, Internet - based services, and support services for the Software, unless other terms accompany those items on delivery.If so, those terms apply." + Environment.NewLine +
             Environment.NewLine + "License Grant" + Environment.NewLine +
            "Aleksandar Zoric hereby grants you a personal, non - transferable, non - exclusive licence to use the Owl File Search software on your devices in accordance with the terms of this EULA agreement." + Environment.NewLine +
            "You are permitted to load the Owl File Search software(for example a PC, laptop, mobile or tablet) under your control.You are responsible for ensuring your device meets the minimum requirements of the Owl File Search software." + Environment.NewLine +
             Environment.NewLine + "You are not permitted to:" + Environment.NewLine +
            "-Edit, alter, modify, adapt, translate or otherwise change the whole or any part of the Software nor permit the whole or any part of the Software to be combined with or become incorporated in any other software, nor decompile, disassemble or reverse engineer the Software or attempt to do any such things" + Environment.NewLine +
            "- Reproduce, copy, distribute, resell or otherwise use the Software for any commercial purpose" + Environment.NewLine +
            "- Allow any third party to use the Software on behalf of or for the benefit of any third party" + Environment.NewLine +
            "- Use the Software in any way which breaches any applicable local, national or international law" + Environment.NewLine +
            "- use the Software for any purpose that Aleksandar Zoric considers is a breach of this EULA agreement" + Environment.NewLine +
             Environment.NewLine + "Intellectual Property and Ownership" + Environment.NewLine +
            "Aleksandar Zoric shall at all times retain ownership of the Software as originally downloaded by you and all subsequent downloads of the Software by you.The Software(and the copyright, and other intellectual property rights of whatever nature in the Software, including any modifications made thereto) are and shall remain the property of Aleksandar Zoric." + Environment.NewLine +
            "Aleksandar Zoric reserves the right to grant licences to use the Software to third parties." + Environment.NewLine +
             Environment.NewLine + "Termination" + Environment.NewLine +
            "This EULA agreement is effective from the date you first use the Software and shall continue until terminated. You may terminate it at any time upon written notice to Aleksandar Zoric." + Environment.NewLine +
            "This EULA was created by eulatemplate.com for Owl File Search" + Environment.NewLine +
            "It will also terminate immediately if you fail to comply with any term of this EULA agreement. Upon such termination, the licenses granted by this EULA agreement will immediately terminate and you agree to stop all access and use of the Software.The provisions that by their nature continue and survive will survive any termination of this EULA agreement." + Environment.NewLine +
            "Modyfing the EULA.txt file in any way from Owl File Search user documents folder will result in a immediate termination" + Environment.NewLine +
             Environment.NewLine + "Governing Law" + Environment.NewLine +
            "This EULA agreement, and any dispute arising out of or in connection with this EULA agreement, shall be governed by and construed in accordance with the laws of Ireland.";
        }

        private void declineBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            DirectorySearchMain mainFrm = new DirectorySearchMain();
         
            String resultPath = System.IO.Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Owl File Search", "EULA.txt");

            try
            {
                SetFileReadAccess(resultPath, false);
                using (StreamWriter writer = new StreamWriter(resultPath, true))
                {
                    writer.WriteLine("accepted");
                }
                SetFileReadAccess(resultPath, true);
            }
            catch (Exception exc)
            {
                mainFrm.generateLogFile(exc);
            }

            this.Hide();          
            mainFrm.Closed += (s, args) => this.Close();
            mainFrm.Show();
        }

        //Set File Access to any file passed
        private static void SetFileReadAccess(string FileName, bool SetReadOnly)
        {
            try
            {
                FileInfo fInfo = new FileInfo(FileName);
                fInfo.IsReadOnly = SetReadOnly;

            }
            catch (Exception ex)
            {
                //Do nothing
            }
        }
    }
}
