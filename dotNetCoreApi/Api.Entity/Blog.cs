﻿using Dapper;
using System;

namespace Api.Entity
{
    [Table("Blog")]
    public class Blog: BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public DateTime? Date { get; set; }
        public string Author { get; set; }
        public string Tag { get; set; }
    }
}
