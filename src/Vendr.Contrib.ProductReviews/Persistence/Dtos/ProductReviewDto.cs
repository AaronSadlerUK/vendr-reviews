﻿using NPoco;
using System;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace Vendr.Contrib.ProductReviews.Persistence.Dtos
{
    [TableName(Constants.DatabaseSchema.Tables.ProductReviews)]
    [PrimaryKey("id", AutoIncrement = false)]
    [ExplicitColumns]
    public class ProductReviewDto
    {
        [Column("id")]
        [PrimaryKeyColumn]
        public Guid Id { get; set; }

        [Column("createDate")]
        public DateTime CreateDate { get; set; }

        [Column("rating")]
        public decimal Rating { get; set; }

        [Column("productReference")]
        public string ProductReference { get; set; }

        [Column("customerReference")]
        public string CustomerReference { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }
    }
}