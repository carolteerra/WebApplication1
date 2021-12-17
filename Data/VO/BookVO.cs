﻿using System;
using System.Collections.Generic;
using WebApplication1.Hypermedia;
using WebApplication1.Hypermedia.Abstract;

namespace WebApplication1.Data.VO {
    public class BookVO : ISupportsHyperMedia {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public decimal Price { get; set; }

        public DateTime LaunchDate { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}
