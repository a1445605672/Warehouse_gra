﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Sunny.UI;


namespace Warehouse
{
	public partial class 数据备份 : UIPage
	{
		public 数据备份()
		{
            
            InitializeComponent();
            this.uiRadioButton1.Checked = true;
            uiDatePicker1.Text = DateTime.Now.ToString("D");
           
            
        }

       

        private void backup_Click(object sender, EventArgs e)
        {
            Execute_bat(DBUtility.Config.Backup_bat);
            UIMessageBox.ShowSuccess("备份成功");
          
           
        }

        private void Execute_bat(string comm)
        {
            using (Process proc = new Process())
            {

                string command = comm;
                proc.StartInfo.FileName = command;
                proc.StartInfo.WorkingDirectory = Path.GetDirectoryName(command);
                proc.StartInfo.Verb = "runas";


                proc.Start();
               

                while (!proc.HasExited)
                {
                    proc.WaitForExit(1000);
                }

            }
        }

        private void uiDatePicker1_Click(object sender, EventArgs e)
        {
            
        }

        private void uiDatePicker1_ValueChanged(object sender, DateTime value)
        {

            string time = uiDatePicker1.Value.ToString("yyyyMMdd");

            DirectoryInfo root = new DirectoryInfo(DBUtility.Config.Backup_folder);
            
            DirectoryInfo[] dics = root.GetDirectories();

            int length = dics.Length;
            int n = 0;

            for(int i = 0; i < length; i++)
            {
                if (dics[i].Name.Contains(time))
                {
                    uiListBox1.Items.Add(dics[i].Name);
                    ++n;
                }
              
            }
            if(n == 0)
            {
                UIMessageBox.ShowInfo("所选日期内无备份内容");
            }
        }

        private void uiListBox1_ItemClick(object sender, EventArgs e)
        {
            //string m = uiListBox1.SelectedItem.ToString();
        
        }


        //恢复数据库
        private void recover_Click(object sender, EventArgs e)
        {
            if (uiListBox1.SelectedItem != null)
            {
                //string v_filepath = DBUtility.Config.Recover_bat + @"\mysql_recover" + ".bat";
                string v_filepath = DBUtility.Config.Recover_bat ;
                string time = uiDatePicker1.Value.ToString("yyyyMMdd");
                
                //源文件夹
                string path_1 = DBUtility.Config.Backup_folder + @"\" + uiListBox1.SelectedItem.ToString().Trim() + @"\*.*";
                //目的文件夹
                string path_2 = DBUtility.Config.Backup_origin;
                string s = "net stop mysql57 \r\n"
                    + "xcopy " +@"""" + path_1 +@""" " + @"""" + path_2 +@"""" + "\r\n"
                    + "net start mysql57";                         

                if(s!= null)
                {
                    UIMessageBox.ShowSuccess("恢复成功");
                }
                else
                {
                    UIMessageBox.ShowError("恢复失败");
                }

                File.WriteAllText(v_filepath,s, Encoding.Default);

                Execute_bat(v_filepath);

                if (s != null)
                {
                    UIMessageBox.ShowSuccess("恢复成功");
                }
                else
                {
                    UIMessageBox.ShowError("恢复失败");
                }


            }
            else
            {
                UIMessageBox.ShowWarning("请选择要恢复的日期");
            }
        }

        private void uiRadioButton2_ValueChanged(object sender, bool value)
        {
            if (uiRadioButton2.Checked)
            {
                uiComboTreeView1.Enabled = true;
                uiRadioButton1.Checked = false;
                backup_button.Enabled = false;
            }
        }

        private void uiRadioButton1_ValueChanged(object sender, bool value)
        {
            if (uiRadioButton1.Checked)
            {
                uiRadioButton2.Checked = false;
                uiComboTreeView1.Enabled = false;
            }
        }

        private void uiComboTreeView1_NodeSelected(object sender, TreeNode node)
        {
            UIMessageBox.ShowInfo("当前备份频率为 " + node.Text);     
        }

        private void uiSwitch1_ValueChanged(object sender, bool value)
        {
            if(DBUtility.Config.connect_type == 0)
            {
                DBUtility.Config.connect_type = 1;
                UIMessageBox.ShowInfo("当前数据库更改为本地数据库，请重启物料管理软件");
            }
            else
            {

                DBUtility.Config.connect_type = 0;
                UIMessageBox.ShowInfo("当前数据库更改为云数据库，请重启物料管理软件");
            }
        }
    }
}
