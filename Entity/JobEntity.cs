using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsideJobCrawlerAP.Entity
{
    public class JobEntity
    {

        private string _JobTitle;
        private string _Joblink;
        private string _JobCompanyName;
        private string _JobKind;
        private string _JobPayMin;
        private string _JobPayMax;
        private string _Joblocation;
        private string _JobPostDate;
        private string _JobExpirationDate;
        private string _JobInfo;
        private string _JobApplyInfo;
        private string _JobCompanylink;

        public string JobTitle { get { return _JobTitle; } set { _JobTitle = value; } }
        public string Joblink { get { return _Joblink; } set { _Joblink = value; } }
        public string JobCompanyName { get { return _JobCompanyName; } set { _JobCompanyName = value; } }
        public string JobKind { get { return _JobKind; } set { _JobKind = value; } }
        public string JobPayMin { get { return _JobPayMin; } set { _JobPayMin = value; } }
        public string JobPayMax { get { return _JobPayMax; } set { _JobPayMax = value; } }
        public string Joblocation { get { return _Joblocation; } set { _Joblocation = value; } }
        public string JobPostDate { get { return _JobPostDate; } set { _JobPostDate = value; } }
        public string JobExpirationDate { get { return _JobExpirationDate; } set { _JobExpirationDate = value; } }
        public string JobInfo { get { return _JobInfo; } set { _JobInfo = value; } }
        public string JobApplyInfo { get { return _JobApplyInfo; } set { _JobApplyInfo = value; } }
        public string JobCompanylink { get { return _JobCompanylink; } set { _JobCompanylink = value; } }
    }
}

