﻿using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Abstract
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Add(List<Category> categories);
        void Update(Category category);
        void Remove(Category category);
        void Remove(Guid id);
        void RemoveAll(Expression<Func<Category, bool>> exp);
        Category GetById(Guid id);
        Category GetByDefault(Expression<Func<Category, bool>> exp);
        List<Category> GetActive();
        List<Category> GetDefault(Expression<Func<Category, bool>> exp);
        List<Category> GettAll();
        bool Any(Expression<Func<Category, bool>> exp);
    }
}
