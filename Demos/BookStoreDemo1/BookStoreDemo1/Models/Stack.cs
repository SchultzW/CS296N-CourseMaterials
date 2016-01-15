﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreDemo1.Models
{
    public class Stack
    {
        List<Book> books = new List<Book>();

        public string Location { get; set; }
        public List<Book> Books {
            get { return books; }
        }
    }
}