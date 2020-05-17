using System;
using System.ComponentModel.DataAnnotations;

namespace CandyBars.Models
{
public class CandyBarsItem
    {
        public Guid Id { get; set; }

        public string Title { get; set; }
        public DateTimeOffset? DueAt { get; set; }

        public bool IsDone { get; set; }
        }
}