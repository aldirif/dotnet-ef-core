﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetEfCore.DataContext
{
    [Table("tbl_category")]
    public class CategoryEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("category_code")]
        public String CategoryCode { get; set; }

        [Column("category_name")]
        public String CategoryName { get; set; }

        [Column("description")]
        public String Decription { get; set; }

        public CategoryEntity()
        {
        }
    }
}
