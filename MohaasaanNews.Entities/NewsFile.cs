﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohaasaanNews.Entities
{
    public enum FileType
    {
        Picture,
        Video,
        Audio,
        Document
    }
    public class NewsFile : BaseEntity<int>
    {
        public string Path { get; set; }
        public FileType FileType { get; set; }
    }
}
