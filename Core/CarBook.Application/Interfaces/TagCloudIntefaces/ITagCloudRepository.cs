using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.TagCloudIntefaces
{
    public interface ITagCloudRepository
    {
        List<TagCloud> GetTagCloudByBlogID(int id);
    }
}
