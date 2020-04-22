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

        public bool DeleteBlog(int id)//10
        {
           Blog blog= context.Blogs.Find(id);
            context.Blogs.Remove(blog);
            if (context.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public IQueryable<Blog> GetBlogs()
        {
            return context.Blogs;
        }

        public Blog GetById(int id)//2
        {
           return context.Blogs.Find(id);//2
        }

        public bool UpdateBlog(Blog blog)//a - b
        {
            context.Entry(blog).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            if (context.SaveChanges() > 0)
                return true;
            return false;
        }
    }
}
