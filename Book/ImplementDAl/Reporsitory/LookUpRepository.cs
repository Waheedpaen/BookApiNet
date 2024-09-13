using EntitiesClasses.CommonClasses;
using EntitiesClasses.Entities;
using HelperData;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementDAl.Reporsitory;

public class LookUpRepository : ILookUpRepository
{
    protected readonly DbContext Context;
    public LookUpRepository(DbContext context)
    {
        Context = context;

    }

    public async Task<List<AudioDetail>> AudioDetails()
    {
        return await Context.Set<AudioDetail>().ToListAsync();
    }

    public async Task<List<AudioScholars>> AudioScholars()
    {
        return await Context.Set<AudioScholars>().ToListAsync();
    }

    public async Task<List<BookCategory>> BookCategories()
    {
        return await Context.Set<BookCategory>().ToListAsync();
    }

    //public async Task<List<object>> ExecuteQuery (string Operation )
    //{
    //    switch (Operation)
    //    {
    //        case "BookCategories":
    //            return await Context.Set<BookCategory>()
    //            .FromSqlRaw("dbo.GetMethodLists @Operation = {0}", @Operation ).IgnoreQueryFilters().ToListAsync<object>();
    //        case "FarqaCategories":
    //            return await Context.Set<FarqaCategory>()
    //                 .FromSqlRaw("dbo.GetMethodLists @Operation = {0}", @Operation).IgnoreQueryFilters().ToListAsync<object>();
    //        case "GetScholars":
    //            return await Context.Set<Scholar>()
    //            .FromSqlRaw("dbo.GetMethodLists @Operation = {0}", @Operation).IgnoreQueryFilters().ToListAsync<object>();
    //        case "GetBookDetails":
    //            return await Context.Set<BookDetail>()
    //                .FromSqlRaw("dbo.GetMethodLists @Operation = {0}", @Operation).IgnoreQueryFilters().ToListAsync<object>();
    //        case "GetBookImages":
    //            return await Context.Set<BookImage>()
    //               .FromSqlRaw("dbo.GetMethodLists @Operation = {0}", @Operation).IgnoreQueryFilters().ToListAsync<object>();
    //        case "GetMadrassaBooks":
    //            return await Context.Set<MadrassaBook>()
    //           .FromSqlRaw("dbo.GetMethodLists @Operation = {0}", @Operation).IgnoreQueryFilters().ToListAsync<object>();
    //        case "GetMonthlyMagzines":
    //            return await Context.Set<MonthlyMagzine>()
    //        .FromSqlRaw("dbo.GetMethodLists @Operation = {0}", @Operation).IgnoreQueryFilters().ToListAsync<object>();
    //        case "GetNews":
    //            return await Context.Set<News>()
    //           .FromSqlRaw("dbo.GetMethodLists @Operation = {0}", @Operation).IgnoreQueryFilters().ToListAsync<object>();

    //        // Add cases for other operations as needed
    //        default:
    //            throw new ArgumentException("Invalid operation specified.");
    //    }
    //}
    public async Task<List<object>> ExecuteQuery(string Operation)
    {
        switch (Operation)
        {
            case "BookCategories":
                return await Context.Set<BookCategory>().ToListAsync<object>();
            case "FarqaCategories":
                return await Context.Set<FarqaCategory>().ToListAsync<object>();
            case "GetScholars":
                return await Context.Set<Scholar>().ToListAsync<object>();
            case "GetBookDetails":
                return await Context.Set<BookDetail>().ToListAsync<object>();
            case "GetBookImages":
                return await Context.Set<BookImage>().ToListAsync<object>();
            case "GetMadrassaBooks":
                return await Context.Set<MadrassaBook>().ToListAsync<object>();
            case "GetMonthlyMagzines":
                return await Context.Set<MonthlyMagzine>().ToListAsync<object>();
            case "GetNews":
                return await Context.Set<News>().ToListAsync<object>();

            // Add cases for other operations as needed
            default:
                throw new ArgumentException("Invalid operation specified.");
        }
    }

    public async Task<List<FarqaCategory>> FarqaCategories()
    {
        //return await Context.Set<FarqaCategory>().Include(data => data.BookCategory).ToListAsync();
        return await Context.Set<FarqaCategory>().ToListAsync();
    }

    public async Task<List<BookDetail>> GetBookDetails()
    {
        return await Context.Set<BookDetail>().ToListAsync();
    }

    public async Task<List<BookImage>> GetBookImages()
    {
        return await Context.Set<BookImage>().ToListAsync();
    }

    public async Task<List<MadrassaBook>> GetMadrassaBooks()
    {
        return await Context.Set<MadrassaBook>().ToListAsync();
    }

    public async Task<List<BookCategory>> GetMethodLists(string @Operation)
    {
        return await Context.Set<BookCategory>().FromSqlRaw("dbo.CRUD_News @Operation = {0}", @Operation).IgnoreQueryFilters().ToListAsync();

    }

    public async Task<List<Scholar>> GetScholars()
    {
        return await Context.Set<Scholar>().ToListAsync();
    }

    public async Task<List<MonthlyMagzine>> MonthlyMagzines()
    {
        return await Context.Set<MonthlyMagzine>().OrderByDescending(data => data).ToListAsync();
    }

    public async Task<List<News>> News()
    {
        // 1 this line take current date 
        var today = DateTime.Now.Date;
        // 2. this line compare two  current date   .Where(news => news.Created_At.HasValue && news.Created_At.Value.Date == today)
        return await Context.Set<News>().Where(news => news.Created_At.HasValue && news.Created_At.Value.Date == today && news.IsDeleted == false )
            .OrderByDescending(data => data.Title).ToListAsync();
         
    }

    public async Task<List<News>> NewsSql()
    {
      
        return await Context.Set<News>().FromSqlRaw("YourStoredProcedureName").ToListAsync(); 
    }

    public async Task<List<User>> Users()
    {
        return await Context.Set<User>().ToListAsync();
    }
}