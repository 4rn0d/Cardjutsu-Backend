﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace Super_Cartes_Infinies.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string MessageText { get; set; }

        [ValidateNever]
        public virtual Player Player { get; set; }
        [ForeignKey("Player")]
        public int PlayerId { get; set; }

        [ValidateNever]
        public virtual Match Match { get; set; }
        [ForeignKey("Match")]
        public int MatchId { get; set; }

    }
}