using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;
using Entities.Concrate;

namespace DataAccess.Abstract
{
    public interface IBrandDal: IEntityRepository<Brand>
    {
    }
}
