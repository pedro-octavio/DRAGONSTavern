using DRAGONSTavern.Domain.ValueObjects;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace DRAGONSTavern.Domain.Entities
{
    public class Notice : Shared
    {
        [JsonConstructor]
        public Notice(string title, string body, DateTime createDate, DateTime updateDate, string bannerImageUrl, string id) : base(id)
        {
            Title = title;
            Body = body;
            CreateDate = createDate;
            UpdateDate = updateDate;
            BannerImageUrl = bannerImageUrl;
        }

        [Required]
        [MaxLength(400)]
        public string Title { get; private set; }
        [Required]
        [MaxLength(35000)]
        public string Body { get; private set; }
        [Required]
        public DateTime CreateDate { get; private set; }
        public DateTime UpdateDate { get; private set; }
        [MaxLength(20)]
        public string BannerImageUrl { get; private set; }
    }
}
