using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.TagCloudDtos
{
    public class GetByBlogIdTagCloudDto
    {
        public int tagCloudID { get; set; }
        public string title { get; set; }
        public int blogID { get; set; }
    }
}
