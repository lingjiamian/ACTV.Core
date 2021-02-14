using System;

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


    }
}
