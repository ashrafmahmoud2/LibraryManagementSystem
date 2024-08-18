﻿namespace LibraryManagementSystem.Core.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }

        [MaxLength(500)]
        public string Title { get; set; } = null!;

        public string Author { get; set; } = null!;

        public string Publisher { get; set; } = null!;

        public DateTime PublishingDate { get; set; }


        public string? ImageUrl { get; set; }

        public string? ImageThmbnailUrl { get; set; }

        public string? ImagePublicUrl { get; set; }

        [MaxLength(50)]
        public string Hall { get; set; } = null!;

        public bool IsDeleted { get; set; }

        public bool IsAvailableForRental { get; set; }

        public string Description { get; set; } = null!;

        public DateTime CreatedOn { get; set; }

        public IEnumerable<string> Categories { get; set; } = null!;

        public IEnumerable<BookCopyViewModel> Copies { get; set; } = null!;



    }
}
