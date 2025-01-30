


using EntitiesClasses.Entitie;
using Microsoft.EntityFrameworkCore;

namespace EntitiesClasses.DataContext;
   public  class DataContexts : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<UserTypes> UserTypes { get; set; }

    public DbSet<FarqaCategory> FarqaCategories { get; set; }
    public DbSet<BookCategory> BookCategories { get; set; }
    public DbSet<AudioScholars> AudioScholares { get; set; }
    public DbSet<AudioDetail> AudioDetail { get; set; }
    public DbSet<BookDetail> BookDetails { get; set; }
    public DbSet<BookImage> BookImages { get; set; }
    public DbSet<MadrassaClass> MadrassaClasses { get; set; }
    public DbSet<MadrassaBook> MadrassaBooks { get; set; }
    public DbSet<MonthlyMagzine> MonthlyMagzines { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<MessageReply> MessageReplies { get; set; }
    public DbSet<ChatGroup> ChatGroups { get; set; }
    public DbSet<GroupMessage> GroupMessages { get; set; }
    public DbSet<Visitors> Visitors { get; set; }
    public DbSet<News> News { get; set; }
    public DbSet<EmailVerificationCode>  EmailVerificationCodes { get; set; }
    public DbSet<MadrassaBookCatgory> MadrassaBookCatgories { get; set; }
    public DbSet<Scholar> Scholars { get; set; }
    public DataContexts(DbContextOptions<DataContexts> options) : base(options)
    {
        this.ChangeTracker.LazyLoadingEnabled = false;
    }
  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //modelBuilder.Entity<User>().HasQueryFilter((d => EF.Property<bool>(d, "IsDeleted") == false));
        modelBuilder.Entity<Message>()
     .HasOne(m => m.Sender)
     .WithMany()
     .HasForeignKey(m => m.SenderId)
     .OnDelete(DeleteBehavior.NoAction)
     .IsRequired(false); // This line may be needed if SenderId is optional

        modelBuilder.Entity<Message>()
            .HasOne(m => m.Receiver)
            .WithMany()
            .HasForeignKey(m => m.ReceiverId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired(false);
        modelBuilder.Entity<AudioDetail>().HasQueryFilter((d => EF.Property<bool>(d, "IsDeleted") == false));
        modelBuilder.Entity<News>().HasQueryFilter((d => EF.Property<bool>(d, "IsDeleted") == false));
        modelBuilder.Entity<AudioScholars>().HasQueryFilter((d => EF.Property<bool>(d, "IsDeleted") == false));
        modelBuilder.Entity<MadrassaClass>().HasQueryFilter((d => EF.Property<bool>(d, "IsDeleted") == false));
        modelBuilder.Entity<BookCategory>().HasQueryFilter((d => EF.Property<bool>(d, "IsDeleted") == false));
        modelBuilder.Entity<MadrassaBook>().HasQueryFilter((d => EF.Property<bool>(d, "IsDeleted") == false));
        modelBuilder.Entity<FarqaCategory>().HasQueryFilter((d => EF.Property<bool>(d, "IsDeleted") == false));
        modelBuilder.Entity<Scholar>().HasQueryFilter((d => EF.Property<bool>(d, "IsDeleted") == false));
        modelBuilder.Entity<BookDetail>().HasQueryFilter((d => EF.Property<bool>(d, "IsDeleted") == false));
        modelBuilder.Entity<BookDetail>()
// if deleed parenat and child automatlly by remove moethod do not need loops or logic to deleted .ef auto deleted it 

// Configures the Prescription entity
.HasMany(p => p. BookImages)          // Specifies that a Prescription can have multiple PrescriptionItems (one-to-many relationship)
.WithOne(i => i. BookDetail)   // Each PrescriptionItem is associated with one Prescription
.HasForeignKey(i => i.BookDetailId) // The foreign key in PrescriptionItem is PrescriptionId
.OnDelete(DeleteBehavior.Cascade);
        base.OnModelCreating(modelBuilder);
    }




}
 
