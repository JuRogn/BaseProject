﻿using System;

namespace Module.Reviews.ViewModels
{
    public class ReviewItem
    {
        public long Id { get; set; }

        public int Rating { get; set; }

        public string Title { get; set; }

        public string Comment { get; set; }

        public string ReviewerName { get; set; }

        public DateTimeOffset CreatedOn { get; set; }
    }
}
