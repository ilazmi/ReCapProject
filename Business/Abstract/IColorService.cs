﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrate;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}