﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataVisual.Controls.TimeLine;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Reflection;

namespace DataVisual.Controls
{
    public partial class VerticalTimeLine1 : UserControl
    {
        public List<EventItem> EventItems { get; set; }
        public string Title { get; set; }
        public VerticalTimeLine1()
        {
            InitializeComponent();
        }
        string itemtemplate = "   <li><h3 > $Date<span > $Year </span ></h3 ><dl ><dt > $Title </dt >  <span>$Detail</span></dl ></li > ";

        string sectionhead= "<div class=\"history-date\"><ul>  <h2 class=\"first\"><a href = \"#nogo\" > $year年</a></h2>";
        public void RefreshEvents()
        {
            StringBuilder builder = new StringBuilder();
            XDocument document = new XDocument();
            int tempyear = 0;
            foreach (var item in EventItems)
            {
                if(tempyear!=item.TimeStamp.Year)
                {
                    if (tempyear != 0)
                    {
                        builder.Append("</ul></ div > ");
                    }
                    builder.Append(sectionhead.Replace("$year", item.TimeStamp.Year.ToString()));
                    tempyear = item.TimeStamp.Year;
                }
                builder.Append(itemtemplate.Replace("$Date",string.Format("{0}.{1}", item.TimeStamp.Month,item.TimeStamp.Day)).Replace("$Year",item.TimeStamp.Year.ToString())
                    .Replace("$Title",item.Title).Replace("$Detail",item.Detail));
            }
            builder.Append("</ul></ div > ");
            /*
            Stream myStream = Assembly.GetAssembly(GetType()).GetManifestResourceStream("template1.html");
            StreamReader myStreamReader = new StreamReader(myStream, System.Text.Encoding.GetEncoding("gb2312"));
            string file = myStreamReader.ReadToEnd();
            */
            string file = File.ReadAllText("template1.html");
            string result=  file.Replace("$Content", builder.ToString());
            string filename =string.Format("{0}{1}.html",AppDomain.CurrentDomain.BaseDirectory, Guid.NewGuid());
            File.WriteAllText(filename, result,Encoding.GetEncoding("utf-8"));
            webBrowser.Navigate(filename);
            //webBrowser.Document.Write(result);

        }
    }
}
