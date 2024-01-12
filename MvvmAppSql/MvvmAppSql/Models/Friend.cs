using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmAppSql.Models
{
    [Table("Friends")]
    public class Friend
    {
        [PrimaryKey, AutoIncrement, Column("_id")]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Age { get; set; }

    }
}
