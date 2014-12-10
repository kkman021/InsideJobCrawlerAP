namespace InsideJobCrawlerAP
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pgb1 = new System.Windows.Forms.ProgressBar();
            this.tbxCrawPage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGoCraw = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbxPayMax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxPayMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxJobInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCompanyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxJobTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lblJobCount = new System.Windows.Forms.Label();
            this.gvResult = new System.Windows.Forms.DataGridView();
            this.SerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobPostDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Joblocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobPayMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobPayMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Joblink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rtbJobInfo = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblJoblocation = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblJobKind = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxJobLocation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(972, 445);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pgb1);
            this.tabPage1.Controls.Add(this.tbxCrawPage);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnGoCraw);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(964, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "資料建立";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(328, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(311, 130);
            this.richTextBox1.TabIndex = 17;
            this.richTextBox1.Text = "使用方式：\n1.先設定要抓取要抓的頁數(一頁有12筆)。\n2.抓取完後會直接跳至工作清單。\n3.要查詢條件請至資料篩選區塊輸入條件後按查詢。\n4.工作清單要看詳細" +
    "資料點選公司名稱會顯示明細。\n5.工作清單點選連結會直接開瀏覽器跳至該文章。\n6.所有工作清單，可以匯出成TXT檔。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "資料所有權屬於 硬塞的股份有限公司。";
            // 
            // pgb1
            // 
            this.pgb1.Location = new System.Drawing.Point(9, 45);
            this.pgb1.Name = "pgb1";
            this.pgb1.Size = new System.Drawing.Size(265, 23);
            this.pgb1.TabIndex = 3;
            // 
            // tbxCrawPage
            // 
            this.tbxCrawPage.Location = new System.Drawing.Point(93, 6);
            this.tbxCrawPage.Name = "tbxCrawPage";
            this.tbxCrawPage.Size = new System.Drawing.Size(100, 22);
            this.tbxCrawPage.TabIndex = 2;
            this.tbxCrawPage.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "抓取幾頁資訊：";
            // 
            // btnGoCraw
            // 
            this.btnGoCraw.Location = new System.Drawing.Point(199, 6);
            this.btnGoCraw.Name = "btnGoCraw";
            this.btnGoCraw.Size = new System.Drawing.Size(75, 23);
            this.btnGoCraw.TabIndex = 0;
            this.btnGoCraw.Text = "開始抓取";
            this.btnGoCraw.UseVisualStyleBackColor = true;
            this.btnGoCraw.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbxJobLocation);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.tbxPayMax);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.tbxPayMin);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.tbxJobInfo);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.tbxCompanyName);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btnSearch);
            this.tabPage3.Controls.Add(this.tbxJobTitle);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(964, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "資料篩選";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbxPayMax
            // 
            this.tbxPayMax.Location = new System.Drawing.Point(223, 86);
            this.tbxPayMax.Name = "tbxPayMax";
            this.tbxPayMax.Size = new System.Drawing.Size(94, 22);
            this.tbxPayMax.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "~";
            // 
            // tbxPayMin
            // 
            this.tbxPayMin.Location = new System.Drawing.Point(88, 86);
            this.tbxPayMin.Name = "tbxPayMin";
            this.tbxPayMin.Size = new System.Drawing.Size(94, 22);
            this.tbxPayMin.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "薪水範圍：";
            // 
            // tbxJobInfo
            // 
            this.tbxJobInfo.Location = new System.Drawing.Point(129, 47);
            this.tbxJobInfo.Name = "tbxJobInfo";
            this.tbxJobInfo.Size = new System.Drawing.Size(100, 22);
            this.tbxJobInfo.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "工作內容(關鍵字)：";
            // 
            // tbxCompanyName
            // 
            this.tbxCompanyName.Location = new System.Drawing.Point(365, 13);
            this.tbxCompanyName.Name = "tbxCompanyName";
            this.tbxCompanyName.Size = new System.Drawing.Size(100, 22);
            this.tbxCompanyName.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "公司名稱(關鍵字)：";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(16, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "查詢";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // tbxJobTitle
            // 
            this.tbxJobTitle.Location = new System.Drawing.Point(129, 13);
            this.tbxJobTitle.Name = "tbxJobTitle";
            this.tbxJobTitle.Size = new System.Drawing.Size(100, 22);
            this.tbxJobTitle.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "職缺名稱(關鍵字)：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.lblJobCount);
            this.tabPage2.Controls.Add(this.gvResult);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(964, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "工作清單";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "匯出成文字檔";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblJobCount
            // 
            this.lblJobCount.AutoSize = true;
            this.lblJobCount.Location = new System.Drawing.Point(6, 15);
            this.lblJobCount.Name = "lblJobCount";
            this.lblJobCount.Size = new System.Drawing.Size(23, 12);
            this.lblJobCount.TabIndex = 5;
            this.lblJobCount.Text = "123";
            // 
            // gvResult
            // 
            this.gvResult.AllowUserToAddRows = false;
            this.gvResult.AllowUserToDeleteRows = false;
            this.gvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerNo,
            this.JobPostDate,
            this.JobCompanyName,
            this.JobTitle,
            this.JobKind,
            this.Joblocation,
            this.JobPayMin,
            this.JobPayMax,
            this.Joblink});
            this.gvResult.Location = new System.Drawing.Point(3, 41);
            this.gvResult.Name = "gvResult";
            this.gvResult.ReadOnly = true;
            this.gvResult.RowTemplate.Height = 24;
            this.gvResult.Size = new System.Drawing.Size(955, 339);
            this.gvResult.TabIndex = 0;
            this.gvResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResult_CellClick);
            // 
            // SerNo
            // 
            this.SerNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SerNo.DataPropertyName = "SerNo";
            this.SerNo.HeaderText = "SerNo";
            this.SerNo.Name = "SerNo";
            this.SerNo.ReadOnly = true;
            this.SerNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SerNo.Visible = false;
            // 
            // JobPostDate
            // 
            this.JobPostDate.DataPropertyName = "JobPostDate";
            this.JobPostDate.HeaderText = "張貼日期";
            this.JobPostDate.Name = "JobPostDate";
            this.JobPostDate.ReadOnly = true;
            // 
            // JobCompanyName
            // 
            this.JobCompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.JobCompanyName.DataPropertyName = "JobCompanyName";
            this.JobCompanyName.HeaderText = "公司名稱";
            this.JobCompanyName.Name = "JobCompanyName";
            this.JobCompanyName.ReadOnly = true;
            this.JobCompanyName.Width = 78;
            // 
            // JobTitle
            // 
            this.JobTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.JobTitle.DataPropertyName = "JobTitle";
            this.JobTitle.HeaderText = "職缺名稱";
            this.JobTitle.Name = "JobTitle";
            this.JobTitle.ReadOnly = true;
            this.JobTitle.Width = 78;
            // 
            // JobKind
            // 
            this.JobKind.DataPropertyName = "JobKind";
            this.JobKind.HeaderText = "職缺種類";
            this.JobKind.Name = "JobKind";
            this.JobKind.ReadOnly = true;
            this.JobKind.Width = 78;
            // 
            // Joblocation
            // 
            this.Joblocation.DataPropertyName = "Joblocation";
            this.Joblocation.HeaderText = "工作地點";
            this.Joblocation.Name = "Joblocation";
            this.Joblocation.ReadOnly = true;
            this.Joblocation.Width = 78;
            // 
            // JobPayMin
            // 
            this.JobPayMin.DataPropertyName = "JobPayMin";
            this.JobPayMin.HeaderText = "薪水下限";
            this.JobPayMin.Name = "JobPayMin";
            this.JobPayMin.ReadOnly = true;
            // 
            // JobPayMax
            // 
            this.JobPayMax.DataPropertyName = "JobPayMax";
            this.JobPayMax.HeaderText = "薪水上限";
            this.JobPayMax.Name = "JobPayMax";
            this.JobPayMax.ReadOnly = true;
            // 
            // Joblink
            // 
            this.Joblink.DataPropertyName = "Joblink";
            this.Joblink.HeaderText = "網頁連結";
            this.Joblink.Name = "Joblink";
            this.Joblink.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rtbJobInfo);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.lblPay);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.lblJoblocation);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.lblJobKind);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.lblJobTitle);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.lblCompanyName);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(964, 419);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "詳細資料";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rtbJobInfo
            // 
            this.rtbJobInfo.Location = new System.Drawing.Point(90, 133);
            this.rtbJobInfo.Name = "rtbJobInfo";
            this.rtbJobInfo.Size = new System.Drawing.Size(607, 235);
            this.rtbJobInfo.TabIndex = 12;
            this.rtbJobInfo.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 10;
            this.label15.Text = "工作說明：";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Location = new System.Drawing.Point(90, 110);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(29, 12);
            this.lblPay.TabIndex = 9;
            this.lblPay.Text = "薪水";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 8;
            this.label14.Text = "薪水：";
            // 
            // lblJoblocation
            // 
            this.lblJoblocation.AutoSize = true;
            this.lblJoblocation.Location = new System.Drawing.Point(90, 88);
            this.lblJoblocation.Name = "lblJoblocation";
            this.lblJoblocation.Size = new System.Drawing.Size(53, 12);
            this.lblJoblocation.TabIndex = 7;
            this.lblJoblocation.Text = "工作地點";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "工作地點：";
            // 
            // lblJobKind
            // 
            this.lblJobKind.AutoSize = true;
            this.lblJobKind.Location = new System.Drawing.Point(90, 64);
            this.lblJobKind.Name = "lblJobKind";
            this.lblJobKind.Size = new System.Drawing.Size(53, 12);
            this.lblJobKind.TabIndex = 5;
            this.lblJobKind.Text = "職缺種類";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "職缺種類：";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(90, 40);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(53, 12);
            this.lblJobTitle.TabIndex = 3;
            this.lblJobTitle.Text = "職缺名稱";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "職缺名稱：";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(90, 18);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(53, 12);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "公司名稱";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "公司名稱：";
            // 
            // tbxJobLocation
            // 
            this.tbxJobLocation.Location = new System.Drawing.Point(365, 47);
            this.tbxJobLocation.Name = "tbxJobLocation";
            this.tbxJobLocation.Size = new System.Drawing.Size(100, 22);
            this.tbxJobLocation.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 12);
            this.label10.TabIndex = 26;
            this.label10.Text = "工作地點(關鍵字)：";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(9, 158);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(630, 199);
            this.richTextBox2.TabIndex = 18;
            this.richTextBox2.Text = "版本記錄：\nCurrent Version 1.1                                  Date:2014/01/06 22:30\n" +
    "    ●若InsideJob網站回應錯誤，直接跳過該職缺。\n    ●排序Bug排除。\n    ●增加工作地點查詢條件。\nOld Version\n     1" +
    ".0  Create Date 2014/01/06 22:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "InsideJob 資料篩選器 資料來源&版權所有：http://jobs.inside.com.tw/ ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbxCrawPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGoCraw;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ProgressBar pgb1;
        private System.Windows.Forms.DataGridView gvResult;
        private System.Windows.Forms.Label lblJobCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbxPayMax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxPayMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxJobInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCompanyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxJobTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblJobKind;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblJoblocation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox rtbJobInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobPostDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobKind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Joblocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobPayMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobPayMax;
        private System.Windows.Forms.DataGridViewLinkColumn Joblink;
        private System.Windows.Forms.TextBox tbxJobLocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

