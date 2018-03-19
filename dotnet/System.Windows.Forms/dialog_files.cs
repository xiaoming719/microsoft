using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.DirectoryServices;
using System.IO;

namespace dialog_files
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void selectFilePathBtn_Click(object sender, RoutedEventArgs e)
        {
            /******************************路径选择**************************/
            //System.Windows.Forms.FolderBrowserDialog fbd = new System.Windows.Forms.FolderBrowserDialog();
            //fbd.Description = "请设置文件保存路径";

            //System.Windows.Forms.DialogResult isok = fbd.ShowDialog();

            //if (isok == System.Windows.Forms.DialogResult.OK || isok == System.Windows.Forms.DialogResult.Yes)
            //{
            //    //selectSavePath = fbd.SelectedPath;
            //    //selectFileTB.Text = selectSavePath;
            //    selectFileTB.Text = fbd.SelectedPath;
            //}
            /******************************直接打开指定目录的文件*******************/
            // System.Diagnostics.Process.Start("ExpLore", "C:\\window");
            /******************************选择文件***************/
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                selectFileTB.Text = dialog.FileName;
            }
        }
    }
}


