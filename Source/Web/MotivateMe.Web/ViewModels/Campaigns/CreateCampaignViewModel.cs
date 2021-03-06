﻿namespace MotivateMe.Web.ViewModels.Campaigns
{
    using MotivateMe.Data.Models;
    using MotivateMe.Web.Infrastructure.Mapping;
    using System.ComponentModel.DataAnnotations;

    public class CreateCampaignViewModel : IMapFrom<Campaign>
    {
        [Required]
        [MaxLength(250)]
        [UIHint("SingleLineText")]
        public string Title { get; set; }

        [Required]
        [MaxLength(2500)]
        [UIHint("MultiLineText")]
        public string Goal { get; set; }

        [Required]
        [MaxLength(2500)]
        [UIHint("MultiLineText")]
        public string Info { get; set; }

    }
}