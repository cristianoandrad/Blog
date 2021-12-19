using System;
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            // using(var context = new BlogDataContext())
            {
                //Create
                // var tag = new Tag { Name = "testeName", Slug = "testeSlug"};
                // context.Tags.Add(tag);
                // context.SaveChanges();

                // var tag2 = new Tag { Name = "ASP.NET", Slug = "aspnet"};
                // context.Tags.Add(tag2);
                // context.SaveChanges();

                // Update
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                // tag.Name=".NET";
                // tag.Slug="dotnet";
                // context.Update(tag);
                // context.SaveChanges();

                // Delete
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 2);                
                // context.Remove(tag);
                // context.SaveChanges();

                // Select
                //var tags = context
                //     .Tags
                //     .AsNoTracking()
                //     .ToList();
                
                // foreach (var tag in tags)
                // {
                //     System.Console.WriteLine(tag.Name);
                // }


                // var tag = context
                //     .Tags
                //     .AsNoTracking()
                //     .FirstOrDefault(x => x.Id == 7);

                // System.Console.WriteLine(tag?.Name);

            }
            
            using var context = new BlogDataContext();

            // var user = new User{
            //     Name = "Cristiano Andrade",
            //     Slug = "cristianoandrade",
            //     Email = "cristianocontabil@gmail.com",
            //     Bio = "ADS",
            //     Image = "www.google.com.br",
            //     PasswordHash = "123456"
            // };

            // var category = new Category {
            //     Name = "Backend",
            //     Slug = "backend"
            // };

            // var post = new Post {
            //     Author = user,
            //     Category = category,
            //     Body = "<p>Hello world</p>",
            //     Slug = "comecando-com-ef-core",
            //     Summary = "Neste artigo vamos aprender ef core",
            //     Title = "Começando com EF Core",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now
            // };

            // context.Posts.Add(post);
            // context.SaveChanges();

            // include
            // var posts = context
            //     .Posts
            //     .AsNoTracking()
            //     .Include(x => x.Author)
            //     .Include(x => x.Category)
            //     .OrderByDescending(x => x.LastUpdateDate)
            //     .ToList();

            // foreach(var post in posts)
            //     System.Console.WriteLine($"{post.Title} escrito por {post.Author?.Name} em {post.Category?.Name}");


            // var post = context
            //     .Posts
            //     .Include(x => x.Author)
            //     .Include(x => x.Category)
            //     .OrderByDescending(x => x.LastUpdateDate)
            //     .FirstOrDefault();

            // post.Author.Name = "teste";

            // context.Posts.Update(post);
            // context.SaveChanges();

            // Testando Relacionamentos
            
            // context.Users.Add(new User
            // {
            //     Name = "Cristiano Andrade",
            //     Slug = "cristianoandrade",
            //     Email = "cristianocontabil@gmail.com",
            //     Bio = "ADS",
            //     Image = "www.google.com.br",
            //     PasswordHash = "123456"
            // });
            // context.SaveChanges();

            // var user = context.Users.FirstOrDefault();

            // var post = new Post
            // {
            //     Author = user,
            //     Body = "Meu Artigo",
            //     Category = new Category{
            //         Name = "Backend",
            //         Slug = "backend"
            //     },
            //     CreateDate = System.DateTime.Now,
            //     //LastUpdateDate=
            //     Slug = "meu-artigo",
            //     Summary = "Neste artigo vamos conferir...",
            //     //Tags = null,
            //     Title = "Meu artigo"
            // };
            // context.Posts.Add(post);
            // context.SaveChanges();


            

        }
    }
}