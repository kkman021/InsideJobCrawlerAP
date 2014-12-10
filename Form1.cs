using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Net;
using System.IO;

/*
    Create By kkman021 2014/01/06
 */
namespace InsideJobCrawlerAP
{
    public partial class Form1 : Form
    {
        public static string oUrl = "http://jobs.inside.com.tw";
        public static DataTable oJobList = EmptyDataTable();

        public Form1()
        {
            InitializeComponent();
        }

        #region 開始抓取網頁資料
        /* 開始抓取 */
        private void button1_Click(object sender, EventArgs e)
        {
            int JobCount = 0;
            pgb1.Maximum = Convert.ToInt16(tbxCrawPage.Text.Trim());

            WebClient client = new WebClient();
            string TargetUrl = oUrl + "/jobs/page/";
            for (int i = 1; i <= Convert.ToInt16(tbxCrawPage.Text.Trim()); i++)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(client.DownloadData(TargetUrl + i.ToString())))
                    {
                        // 讀取 所有HTML
                        HtmlAgilityPack.HtmlDocument oHtml = new HtmlAgilityPack.HtmlDocument();
                        oHtml.Load(ms, Encoding.UTF8);

                        // 載取 目標Table Html
                        HtmlAgilityPack.HtmlDocument HtmlContext = new HtmlAgilityPack.HtmlDocument();
                        string oTargetHtml = oHtml.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[2]/div[1]/div[1]/div[2]/div[1]/ul[1]").InnerHtml;
                        HtmlContext.LoadHtml(oTargetHtml);

                        //寫入每筆資料至資料庫
                        for (int j = 1; j <= HtmlContext.DocumentNode.SelectNodes("/li").Count; j++)
                        {
                            Entity.JobEntity oJob = new Entity.JobEntity();
                            oJob.Joblink = HtmlContext.DocumentNode.SelectSingleNode("/li[" + j + "]/a[1]").Attributes["href"].Value;

                            oJob = GetJobInfo(oJob.Joblink);
                            oJob.JobTitle = HtmlContext.DocumentNode.SelectSingleNode("/li[" + j + "]/a[1]/div[1]/h3[1]").InnerText;
                            oJob.JobCompanyName = HtmlContext.DocumentNode.SelectSingleNode("/li[" + j + "]/a[1]/div[1]/span[1]").InnerText;

                            DataRow oRow = oJobList.NewRow();
                            oRow["SerNo"] = JobCount + 1;
                            oRow["JobTitle"] = oJob.JobTitle;
                            oRow["Joblink"] = oUrl + oJob.Joblink;
                            oRow["JobCompanyName"] = oJob.JobCompanyName;
                            oRow["JobCompanylink"] = oJob.JobCompanylink;
                            oRow["JobKind"] = oJob.JobKind;
                            oRow["JobPayMin"] = oJob.JobPayMin;
                            oRow["JobPayMax"] = oJob.JobPayMax;
                            oRow["Joblocation"] = oJob.Joblocation;
                            oRow["JobPostDate"] = oJob.JobPostDate;
                            oRow["JobExpirationDate"] = oJob.JobExpirationDate;
                            oRow["JobInfo"] = oJob.JobInfo;
                            oJobList.Rows.Add(oRow);
                            JobCount += 1;
                        }
                    }
                }
                catch 
                {
                    continue;
                }
                pgb1.Value = i;
            }
            tabControl1.SelectedIndex = 2;
            btnGoCraw.Text = "重新抓取";
        }
        #endregion

        #region 讀取工作詳細資料
        public static Entity.JobEntity GetJobInfo(string Joblink)
        {
            Entity.JobEntity oJob = new Entity.JobEntity();
            WebClient client = new WebClient();
            using (MemoryStream ms = new MemoryStream(client.DownloadData(oUrl + Joblink)))
            {

                // 讀取 所有HTML
                HtmlAgilityPack.HtmlDocument oHtml = new HtmlAgilityPack.HtmlDocument();
                oHtml.Load(ms, Encoding.UTF8);

                // 載取 目標Table Html
                HtmlAgilityPack.HtmlDocument HtmlContext = new HtmlAgilityPack.HtmlDocument();
                string oTargetHtml = oHtml.DocumentNode.SelectSingleNode("/html[1]/body[1]/div[2]/div[1]/div[1]").InnerHtml;
                HtmlContext.LoadHtml(oTargetHtml);

                oJob.Joblink = Joblink;

                oJob.JobCompanylink = HtmlContext.DocumentNode.SelectSingleNode("/div[2]/div[1]/span[1]/a[1]") != null ?
                    "Http:" + HtmlContext.DocumentNode.SelectSingleNode("/div[2]/div[1]/span[1]/a[1]").Attributes["href"].Value
                    : "";
                oJob.JobKind = HtmlContext.DocumentNode.SelectSingleNode("/div[3]/h1[1]/span[1]").InnerText.Replace("職務分類：", "");
                /* 薪資範圍：NT$ 18,000 ~ NT$ 20,000，年薪可達 NT$ 200,000  */
                string Pay = HtmlContext.DocumentNode.SelectSingleNode("/div[3]/h1[1]/span[2]").InnerText.Replace("薪資範圍：", "");
                string[] PayArry = Pay.Split(null);
                if (PayArry.Length >= 4)
                {
                    try { oJob.JobPayMin = Convert.ToInt32(PayArry[1].Replace(",", "")).ToString(); }
                    catch { oJob.JobPayMin = "0"; }

                    try { oJob.JobPayMax = Convert.ToInt32(PayArry[4].Replace(",", "").Replace("，年薪可達", "")).ToString(); }
                    catch { oJob.JobPayMax = "0"; }
                }
                else
                {
                    oJob.JobPayMin = "0";
                    oJob.JobPayMax = "0";
                }
                /* 張貼日期 2014-01-06 有效期限 2014-06-06 */
                string oDate = HtmlContext.DocumentNode.SelectSingleNode("/div[3]/span[3]").InnerHtml;
                string[] oDateArry = oDate.Split(null);
                if (oDateArry.Length == 6)
                {
                    oJob.JobPostDate = oDateArry[2].Trim();
                    oJob.JobExpirationDate = oDateArry[4].Trim();
                }
                else
                {
                    oJob.JobPostDate = "";
                    oJob.JobExpirationDate = "";
                }

                oJob.Joblocation = HtmlContext.DocumentNode.SelectSingleNode("/div[3]/span[2]").InnerText;
                oJob.JobInfo = HtmlContext.DocumentNode.SelectSingleNode("/div[3]/div[1]/div[1]").InnerText;
            }
            return oJob;
        }
        #endregion

        #region 製做空的DataTable
        public static DataTable EmptyDataTable()
        {
            DataTable workTable = new DataTable("InsideJobDT");
            workTable.Columns.Add("SerNo", typeof(int));
            workTable.Columns.Add("JobTitle", typeof(String));                      //職缺名稱
            workTable.Columns.Add("Joblink", typeof(String));                       //Inside連結
            workTable.Columns.Add("JobCompanyName", typeof(String));                //企業名稱
            workTable.Columns.Add("JobCompanylink", typeof(String));                //企業連結
            workTable.Columns.Add("JobKind", typeof(String));                       //職缺種類
            workTable.Columns.Add("JobPayMin", typeof(int));                        //最少薪水
            workTable.Columns.Add("JobPayMax", typeof(int));                        //最多薪水
            workTable.Columns.Add("Joblocation", typeof(String));                   //工作地點
            workTable.Columns.Add("JobPostDate", typeof(String));                   //張貼日期
            workTable.Columns.Add("JobExpirationDate", typeof(String));             //有效期限
            workTable.Columns.Add("JobInfo", typeof(String));                       //工作內容
            //workTable.Columns.Add("JobApplyInfo", typeof(String));                  //聯絡資訊
            return workTable;
        }
        #endregion

        #region 其他副程式
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                SetData();
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void gvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.RowIndex >= 0)
            {
                string Link = Convert.ToString(gvResult.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                System.Diagnostics.Process.Start(Link);
            }
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                SetData();
                DataRow[] oRow = oJobList.Select(" SerNo = " + Convert.ToString(gvResult.Rows[e.RowIndex].Cells[0].Value));
                tabControl1.SelectedIndex = 3;

                lblCompanyName.Text = Convert.ToString(oRow[0]["JobCompanyName"]);
                lblJobTitle.Text = Convert.ToString(oRow[0]["JobTitle"]);
                lblJobKind.Text = Convert.ToString(oRow[0]["JobKind"]);
                lblJoblocation.Text = Convert.ToString(oRow[0]["Joblocation"]);
                lblPay.Text = Convert.ToString(oRow[0]["JobPayMin"]) + " 至 " + Convert.ToString(oRow[0]["JobPayMax"]);
                rtbJobInfo.Text = Convert.ToString(oRow[0]["JobInfo"]);

            }
        }
        #endregion

        #region 資料篩選
        private void SetData()
        {
            DataView oDV = oJobList.DefaultView;
            string Filter = "";

            if (!string.IsNullOrEmpty(tbxJobTitle.Text.Trim()))
                Filter += " JobTitle like '%" + tbxJobTitle.Text.Trim() + "%' | ";

            if (!string.IsNullOrEmpty(tbxCompanyName.Text.Trim()))
                Filter += " JobCompanyName like '%" + tbxCompanyName.Text.Trim() + "%' | ";

            if (!string.IsNullOrEmpty(tbxJobInfo.Text.Trim()))
                Filter += " JobInfo like '%" + tbxJobInfo.Text.Trim() + "%' | ";

            if (!string.IsNullOrEmpty(tbxPayMin.Text.Trim()))
                Filter += " JobPayMin >= " + tbxPayMin.Text.Trim() + " | ";

            if (!string.IsNullOrEmpty(tbxPayMax.Text.Trim()))
                Filter += " JobPayMax <= " + tbxPayMax.Text.Trim() + " | ";

            if (!string.IsNullOrEmpty(tbxJobLocation.Text.Trim()))
                Filter += " Joblocation  like '%" + tbxJobLocation.Text.Trim() + "%' | ";

            oDV.RowFilter = Filter.Trim().TrimEnd('|').Replace("|", "and");

            lblJobCount.Text = "共有" + oDV.Count.ToString() + "職缺";
            gvResult.AutoGenerateColumns = false;
            gvResult.DataSource = oDV;
        }
        #endregion

        #region 匯出文字檔
        private void button1_Click_1(object sender, EventArgs e)
        {
            string FilePath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "JobListTxt");
            if (!Directory.Exists(FilePath))
                Directory.CreateDirectory(FilePath);

            string FileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + oJobList.Rows.Count.ToString() + ".txt";
            //定义一个ProcessStartInfo实例

            using (StreamWriter oSW = new StreamWriter(Path.Combine(FilePath, FileName), false, Encoding.Default))
            {
                foreach (DataRow oRow in oJobList.Rows)
                {
                    oSW.WriteLine("職缺序號：" + Convert.ToString(oRow["SerNo"]));
                    oSW.WriteLine("職缺名稱：" + Convert.ToString(oRow["JobTitle"]));
                    oSW.WriteLine("Inside連結：" + Convert.ToString(oRow["Joblink"]));
                    oSW.WriteLine("企業名稱：" + Convert.ToString(oRow["JobCompanyName"]));
                    oSW.WriteLine("企業連結：" + Convert.ToString(oRow["JobCompanylink"]));
                    oSW.WriteLine("職缺種類：" + Convert.ToString(oRow["JobKind"]));
                    oSW.WriteLine("最少薪水：" + Convert.ToString(oRow["JobPayMin"]));
                    oSW.WriteLine("最多薪水：" + Convert.ToString(oRow["JobPayMax"]));
                    oSW.WriteLine("工作地點：" + Convert.ToString(oRow["Joblocation"]));
                    oSW.WriteLine("張貼日期：" + Convert.ToString(oRow["JobPostDate"]));
                    oSW.WriteLine("有效期限：" + Convert.ToString(oRow["JobExpirationDate"]));
                    oSW.WriteLine("工作內容：" + Convert.ToString(oRow["JobInfo"]));
                    oSW.WriteLine("=============================================================");
                    oSW.WriteLine("");
                }
            }
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();

            //设置启动进程的初始目录

            info.WorkingDirectory = FilePath;

            //设置启动进程的应用程序或文档名

            info.FileName = FileName;

            //设置启动进程的参数

            info.Arguments = "";
            System.Diagnostics.Process.Start(info);
        }
        #endregion
    }
}
