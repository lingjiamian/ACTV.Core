using SqlSugar;
using System;
using System.Collections.Generic;

namespace ACTV.Core.Model.Models
{
    public class Bangumi:RootEntityTkey<int>
    {
        public string Title { set; get; }

        public string VideoUrl { set; get; }

        //public int Like { set; get; }

        public int ViewCount { set; get; }

        public DateTime CreateTime { set; get; }

        public DateTime UpdateTime { set; get; }

        [SugarColumn(IsIgnore = true)]
        public List<Danmaku> Danmakus { set; get; }
    }
}
