﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,CourseContext>,ICategoryDal
    {

    }
}
