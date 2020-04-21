using NetBlog.DAL.Context;
using NetBlog.DAL.Entity;
using NetCoreBlog.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetCoreBlog.BLL.Repository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BlogDbContext context;

        public BlogRepository(BlogDbContext context)
        {
            this.context = context;
        }
        public bool AddBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            if (context.SaveChanges() > 0)
                return true;
            return false;

        }

        public bool DeleteBlog(int id)
        {
            
        }

        public IQueryable<Blog> GetBlogs()
        {
         
        }

        public Blog GetById(int id)
        {
           
        }

        public bool UpdateBlog(Blog blog)
        {
          
        }
    }
}
