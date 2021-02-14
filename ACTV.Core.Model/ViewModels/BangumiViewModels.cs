using System;

namespace ACTV.Core.Model.ViewModels
{
    public class BangumiViewModels
    {
        public string title { set; get; }

        public string videoUrl { set; get; }

        //public int Like { set; get; }

        public int viewCount { set; get; }

        public DateTime createTime { set; get; }

        public DateTime updateTime { set; get; }
    }
}
