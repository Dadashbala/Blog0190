using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Blog0190.Models.Sinifler
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AddresInformation> AddresInformations { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<LessonInformation> Lessons { get; set; }
        public DbSet<LessonComment> LessonComments { get; set; }
        public DbSet<Foto> Fotos { get; set; }
        public DbSet<ServiceInformation> services { get; set; }
        
    }
}