using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NetBlog.DAL.Entity;

namespace NetCoreBlog.BLL.Abstract
{
    public interface IBlogRepository
    {
        IQueryable<Blog> GetBlogs();
        bool AddBlog(Blog blog);
        bool DeleteBlog(int id);
        Blog GetById(int id);
        bool UpdateBlog(Blog blog);
    }
}
