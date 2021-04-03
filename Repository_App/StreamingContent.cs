using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_App
{
    public class StreamingContent
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int RunTime { get; set; }
        public bool IsFamilyFriendly { get; set; }
        public StreamingContent()
        {

        }

        public StreamingContent(string title, string description, int runTime, bool isFamilyFriendly)
        {
            Title = title;
            Description = description;
            RunTime = runTime;
            IsFamilyFriendly = isFamilyFriendly;
        }

    }
}
