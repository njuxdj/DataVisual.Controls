using DataVisual.Controls.TimeLine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataVisual.Controls.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            List<EventItem> items = new List<EventItem>();
            items.Add(new EventItem(new DateTime(2012,9,10), true, "发布全新的极速浏览器6.0版本", "升级极速内核到21.0；全新默认界面；新增小窗口播放功能"));
            items.Add(new EventItem(new DateTime(2012, 9, 10), false, "升级极速内核到20.0", "HTML5支持度全球最好，达到469分，测试页面："));
            items.Add(new EventItem(new DateTime(2012, 9, 10), false, "升级极速内核到19.0", "支持网络摄像头，浏览器可直接访问摄像头"));
            items.Add(new EventItem(new DateTime(2011, 9, 10), false, "发布国内首个HTML5实验室", "大力推广HTML5"));
            items.Add(new EventItem(new DateTime(2011, 9, 10), true, "新增了下载文件前扫描下载链接安全性的功能", ""));
            items.Add(new EventItem(new DateTime(2010, 9, 10), false, "W3C联盟首席执行官访华，首站访问360公司", ""));
            items.Add(new EventItem(new DateTime(2010, 9, 10), true, "360受邀出席W3C联盟成员见面会议", ""));
            items.Add(new EventItem(new DateTime(2010, 9, 10), false, "升级极速内核到18.0", "新增多用户使用浏览器的功能"));
            items.Add(new EventItem(new DateTime(2010, 9, 10), true, "发布全新的极速浏览器6.0版本", "升级极速内核到21.0；全新默认界面；新增小窗口播放功能"));
            verticalTimeLine11.EventItems = items;
            verticalTimeLine11.RefreshEvents();
        }
    }
}
