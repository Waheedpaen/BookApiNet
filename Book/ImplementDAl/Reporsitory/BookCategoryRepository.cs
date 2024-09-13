using EntitiesClasses.DataContext;
using ImplementDAL.Reporsitory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ImplementDAl.Reporsitory;

public class BookCategoryRepository : Reporsitory<BookCategory, int>, IBookCategoryRepository
{
    public BookCategoryRepository(DataContexts context) : base(context)
    {

    }
    public DataContexts DataContexts => Context as DataContexts;

    public async Task<BookCategory> BookCategoryAlreadyExit(string name)
    {
    return await DataContexts.Set<BookCategory>().FirstOrDefaultAsync(data => data.Name == name); 
    }

    public async Task<List<BookCategory>> BookCategoryCrudSqlQuery(BookCategory model, string Operation)
    {
     return   await DataContexts.Set<BookCategory>().FromSqlRaw("dbo.CRUD_News @Operation = {0}, @id = {1},  @description = {2},@imageUrl = {3}", @Operation, model.Id, model.Description,model.ImageUrl).IgnoreQueryFilters().ToListAsync();
    }

    public async Task<List<BookCategory>> GetSuggestions(string searchword)
    {
   var matchingSuggestions = await DataContexts.Set<BookCategory>().Where(s => s.Name.ToLower().Contains(searchword.ToLower())).ToListAsync();

        return matchingSuggestions;
    }
}
