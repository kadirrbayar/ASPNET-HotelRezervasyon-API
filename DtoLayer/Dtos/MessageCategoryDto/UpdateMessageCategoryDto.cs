﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.MessageCategoryDto
{
    public class UpdateMessageCategoryDto
    {
        public int MessageCategoryId { get; set; }
        public string? CategoryName { get; set; }
    }
}
