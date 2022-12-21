using BookStore.Dtos.Book;
using BookStore.Dtos.Category;
using BookStoreDomain.Interfaces;
using BookStoreDomain.Models;
using BookStoreDomain.Services;
using BookStoreInfrastructure.Context;
using BookStoreInfrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<BookStoreDbContext>();

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IBookRepository, BookRepository>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IBookService, BookService>();

            return services;
        }
    }
}