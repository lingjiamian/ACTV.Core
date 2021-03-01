using System;

namespace ACTV.Core.Model.Models
{
    public class Danmaku:RootEntityTkey<int>
    {
        public string Text { set; get; }

        public int Color { set; get; }

        public string Author { set; get; }

        public int Type { set; get; }

        public double Time { set; get; }

        public DateTime CreateTime { set; get; }

        public DateTime UpdateTime { set; get; }

        public int BangumiId { set; get; }

        public int UserId { set; get; }
    }
}
