using Sunny.UI;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
namespace Warehouse
{
    // [ComVisible(true)] //1、必须设置且为true,否则设置webBrowser1.ObjectForScripting对象时会报错
    [System.Runtime.InteropServices.ComVisible(true)]
    public partial class 图形化展示 : UITitlePage
    {
        public 图形化展示()
        {
            InitializeComponent();
            SetWebBrowserFeatures(10);
            //初始化浏览器
            this.initWebBrowser();
            dd();
            string strHtml = Application.StartupPath + "\\htmls\\index.html";
            if (File.Exists(strHtml))
            {
                webBrowser1.Navigate(strHtml);
                webBrowser1.ObjectForScripting = this;
            }
        }
        public void ShowMessage(string mess)
        {
            MessageBox.Show(mess);
        }
        //x轴的数据
        private List<string> GetXAxisData()
        {
            BLL.in_storage bllin = new BLL.in_storage();
            DataSet ds = bllin.GetList("SELECT mat_name FROM in_storage");
            string str = ds.GetXml();
            List<string> reslt = new List<string>
            {
                str
            };
            return reslt;
        }
        //dataset转换成string
        private string DataSetToString(DataSet ds)
        {
            return ds.GetXml();
        }
        private List<SeriesItem> GetSeriesData()
        {
            BLL.in_storage bllin = new BLL.in_storage();
            DataSet ds = bllin.GetList("SELECT in_amount FROM in_storage");
            string  str = ds.GetXml();
            List<SeriesItem> result = new List<SeriesItem>();
            SeriesItem item = new SeriesItem
            {
                type = "柱状图",
                name = "在库",
                //填充数据
                
                data = new List<int>
                {
                   300
                }
            };
            result.Add(item);
            return result;
        }
        private void PagePanel_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 给echart数据赋值
        /// </summary>
        private void dd()
        {
            Option option = new Option
            {
                title = new Title
                {
                    text = "在库物料汇总"
                },
                tooltip = new Tooltip_echart
                {

                },
                legend = new Legend
                {
                    data = new List<string> { "销量2" }
                },
                xAxis = new XAxis
                {
                    type = "category",
                    data = GetXAxisData()
                },
                yAxis = new YAxis
                {
                    type = "value"
                },
                animationDuration = 500,
                series = GetSeriesData()
            };
            //echart option参数序列化
            Option = JsonConvert.SerializeObject(option);
        }
        public object Option { get; set; }
        public void InitialECharts(Option option)
        {
            if (option == null)
                throw new ArgumentNullException();

            Option = JsonConvert.SerializeObject(option);
            string strHtml = Application.StartupPath + "\\htmls\\index.html";
            if (File.Exists(strHtml))
            {
                webBrowser1.Navigate(strHtml);
                webBrowser1.ObjectForScripting = this;
            }
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            object[] objArray = new object[] { Option };
            HtmlDocument htmlDocument = webBrowser1.Document;
            if (htmlDocument != null)
            {
                htmlDocument.InvokeScript("showChart", objArray);

            }
        }
        /// <summary>  
        /// 修改注册表信息来兼容当前程序  
        ///   
        /// </summary>  
        static void SetWebBrowserFeatures(int ieVersion)
        {
            // don't change the registry if running in-proc inside Visual Studio  
            if (LicenseManager.UsageMode != LicenseUsageMode.Runtime)
                return;
            //获取程序及名称  
            var appName = System.IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            //得到浏览器的模式的值  
            UInt32 ieMode = GeoEmulationModee(ieVersion);
            var featureControlRegKey = @"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\";
            //设置浏览器对应用程序（appName）以什么模式（ieMode）运行  
            Registry.SetValue(featureControlRegKey + "FEATURE_BROWSER_EMULATION",
                appName, ieMode, RegistryValueKind.DWord);
            // enable the features which are "On" for the full Internet Explorer browser  
            //不晓得设置有什么用  
            Registry.SetValue(featureControlRegKey + "FEATURE_ENABLE_CLIPCHILDREN_OPTIMIZATION",
                appName, 1, RegistryValueKind.DWord);


            //Registry.SetValue(featureControlRegKey + "FEATURE_AJAX_CONNECTIONEVENTS",  
            //    appName, 1, RegistryValueKind.DWord);  


            //Registry.SetValue(featureControlRegKey + "FEATURE_GPU_RENDERING",  
            //    appName, 1, RegistryValueKind.DWord);  


            //Registry.SetValue(featureControlRegKey + "FEATURE_WEBOC_DOCUMENT_ZOOM",  
            //    appName, 1, RegistryValueKind.DWord);  


            //Registry.SetValue(featureControlRegKey + "FEATURE_NINPUT_LEGACYMODE",  
            //    appName, 0, RegistryValueKind.DWord);  
        }
        /// <summary>  
        /// 获取浏览器的版本  
        /// </summary>  
        /// <returns></returns>  
        static int GetBrowserVersion()
        {
            int browserVersion = 0;
            using (var ieKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer",
                RegistryKeyPermissionCheck.ReadSubTree,
                System.Security.AccessControl.RegistryRights.QueryValues))
            {
                var version = ieKey.GetValue("svcVersion");
                if (null == version)
                {
                    version = ieKey.GetValue("Version");
                    if (null == version)
                        throw new ApplicationException("Microsoft Internet Explorer is required!");
                }
                int.TryParse(version.ToString().Split('.')[0], out browserVersion);
            }
            //如果小于7  
            if (browserVersion < 7)
            {
                throw new ApplicationException("不支持的浏览器版本!");
            }
            return browserVersion;
        }
        /// <summary>  
        /// 通过版本得到浏览器模式的值  
        /// </summary>  
        /// <param name="browserVersion"></param>  
        /// <returns></returns>  
        static UInt32 GeoEmulationModee(int browserVersion)
        {
            UInt32 mode = 10000; // Internet Explorer 10. Webpages containing standards-based !DOCTYPE directives are displayed in IE11 Standards mode.   
            switch (browserVersion)
            {
                case 7:
                    mode = 7000; // Webpages containing standards-based !DOCTYPE directives are displayed in IE7 Standards mode.   
                    break;
                case 8:
                    mode = 8000; // Webpages containing standards-based !DOCTYPE directives are displayed in IE8 mode.   
                    break;
                case 9:
                    mode = 9000; // Internet Explorer 9. Webpages containing standards-based !DOCTYPE directives are displayed in IE9 mode.                      
                    break;
                case 10:
                    mode = 10000; // Internet Explorer 10.  
                    break;
                case 11:
                    mode = 11000; // Internet Explorer 11  
                    break;
            }
            return mode;
        }
        /// <summary>
        /// 初始化浏览器
        /// </summary>
        private void initWebBrowser()
        {
            //防止 WebBrowser 控件打开拖放到其上的文件。
            webBrowser1.AllowWebBrowserDrop = false;

            //防止 WebBrowser 控件在用户右击它时显示其快捷菜单.
            webBrowser1.IsWebBrowserContextMenuEnabled = false;

            //以防止 WebBrowser 控件响应快捷键。
            webBrowser1.WebBrowserShortcutsEnabled = false;

            //以防止 WebBrowser 控件显示脚本代码问题的错误信息。    
            webBrowser1.ScriptErrorsSuppressed = true;

            //（这个属性比较重要，可以通过这个属性，把WINFROM中的变量，传递到JS中，供内嵌的网页使用；但设置到的类型必须是COM可见的，所以要设置     [System.Runtime.InteropServices.ComVisibleAttribute(true)]，因为我的值设置为this,所以这个特性要加载窗体类上）
            webBrowser1.ObjectForScripting = this;
        }

    }
}

