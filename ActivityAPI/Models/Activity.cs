using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ActivityAPI.Models
{
    public class Activity
    {
        /// <summary>
        /// 活動ID
        /// </summary>
        public int ActivityId { get; set; }

        /// <summary>
        /// 活動名稱
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 活動說明與描述
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 活動日期
        /// </summary>
        public string ActivityDate { get; set; }

        /// <summary>
        /// 圖片連結
        /// </summary>
        public string ImgUrl { get; set; }

        /// <summary>
        /// 講師
        /// </summary>
        public string Teacher { get; set; }

        /// <summary>
        /// 活動費用
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 活動早鳥價
        /// </summary>
        public decimal EarlyPrice { get; set; }

        /// <summary>
        /// 以報名人數
        /// </summary>
        public int RegisterCount { get; set; }

        /// <summary>
        /// 活動額滿人數
        /// </summary>
        public int Count { get; set; }
    }
}