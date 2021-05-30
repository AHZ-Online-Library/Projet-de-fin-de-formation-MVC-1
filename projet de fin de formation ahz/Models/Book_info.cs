namespace projet_de_fin_de_formation_ahz.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    public partial class Book_info
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DisplayName("Book ID")]
        public int BookID { get; set; }

        [DisplayName("Book Name")]
        public string Book_Name { get; set; }

        [DisplayName("Book Language")]
        public string Language_ { get; set; }

        [DisplayName("Publisher Name")]
        public string Publisher_Name { get; set; }

        [DisplayName("Author Name")]
        public string Author_Name { get; set; }

        [DisplayName("Publish Date")]
        public DateTime? Publish_date { get; set; }

        [DisplayName("Book Genre")]
        public string Genre { get; set; }

        [DisplayName("Book Edition")]
        public string Edition { get; set; }

        [DisplayName("Pages Numbre")]
        public int? Pages { get; set; }

        [DisplayName("Book Description")]
        public string Book_Description { get; set; }

        [DisplayName("Book Cover")]
        public string Image_Book { get; set; }

        [NotMapped]
        public HttpPostedFile BookIMG{ get; set; }

        [DisplayName("Book PDF")]
        public string file_book { get; set; }

        [NotMapped]
        public HttpPostedFile BookPDF { get; set; }
    }
}
