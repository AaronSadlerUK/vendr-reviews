﻿using System.Runtime.Serialization;

namespace Vendr.Contrib.ProductReviews.Web.Dtos
{
    [DataContract(Name = "reviewStatus", Namespace = "")]
    public class ReviewStatusDto
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "alias")]
        public string Alias { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "color")]
        public string Color { get; set; }

        [DataMember(Name = "icon")]
        public string Icon => "icon-light-up";

        [DataMember(Name = "sortOrder")]
        public int SortOrder { get; set; }
    }
}