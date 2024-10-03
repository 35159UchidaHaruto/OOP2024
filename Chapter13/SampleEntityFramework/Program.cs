using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    internal class Program {
        static void Main(string[] args) {

            //UpdateBooks();
            //DeleteBooks();
            //DeleteAuthor();
            //AddAuthor2();
            //AddBooks2(); 
            Exercise1_5();

            //InsertBooks();
        }

        //13.1.2
        private static void Exercise1_2() {
            using (var db = new BooksDbContext()) {
                foreach (var book in db.Books.ToList()) {
                    Console.WriteLine("{0}{1}{2}({3:yyyy/MM/dd})",
                        book.Title, book.PublishedYear,
                        book.Author.Name, book.Author.Birthday);
                }
            }
        }


        //13.1.3
        private static void Exercise1_3() {
            using (var db = new BooksDbContext()) {
                var book = db.Books
                    .Where(b => b.Title.Length == db.Books.Max(x => x.Title.Length));
                foreach (var items in book) {
                    Console.WriteLine($"タイトル: {items.Title}");
                }

            }
            //Console.ReadLine(); //コンソールアプリだが、F5でデバックで実行するために記述
        }


        //13.1.4
        private static void Exercise1_4() {
            using (var db = new BooksDbContext()) {
                var books = db.Books.OrderBy(book => book.PublishedYear)
                                    .Include(nameof(Author))
                                    .Take(3);

                foreach (var book in books) {
                    Console.WriteLine($"タイトル: {book.Title}, 著者名: {book.Author.Name}");
                }
            }
        }


        //13.1.5
        private static void Exercise1_5() {            
            
            using (var db = new BooksDbContext()) {
                var authors = db.Authors.OrderByDescending(author => author.Birthday)
                                        .Select(author => new {
                                            AuthorName = author.Name,
                                            Books = author.Books
                                            .Select(book => new {
                                                book.Title,
                                                book.PublishedYear
                                            }).ToList()

                                        }).ToList();

                foreach (var group in authors) {
                    Console.WriteLine($"著者名: {group.AuthorName}");
                    foreach (var author in group.Books) {
                        Console.WriteLine($"タイトル: {author.Title},発行年: {author.PublishedYear}");
                    }
                }
            }

            //先生の回答
            /*using (var db = new BooksDbContext()) {
                var authors = db.Authors
                    .OrderByDescending(a => a.Birthday).ToList();
                foreach (var author in authors) {
                    Console.WriteLine("{0}", author.Name);
                    foreach(var book in author.Books) {
                        Console.WriteLine("{0}{1}", book.Title, book.PublishedYear);
                    }

                }
            }*/
        }


        static void InsertBooks() {
            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                db.Books.Add(book1);

                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);
                db.SaveChanges();   //データベースを更新

            }
        }

        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var book1 = new Book {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1,
                };
                db.Books.Add(book1);
                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.Books.Add(book2);
                db.SaveChanges();
            }
        }

        private static void AddBooks2() {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book3 = new Book {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = author1,
                };
                db.Books.Add(book3);

                var author4 = db.Authors.Single(a => a.Name == "川端康成");
                var book4 = new Book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = author4,
                };
                db.Books.Add(book4);

                var author3 = db.Authors.Single(a => a.Name == "菊池寛");
                var book5 = new Book {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = author3,
                };
                db.Books.Add(book5);

                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book6 = new Book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = author2,
                };
                db.Books.Add(book6);
                db.SaveChanges();
            }
        }

        static IEnumerable<Book> GetBooks() {

            using (var db = new BooksDbContext()) {
                return db.Books.ToList();
                //Where(book => book.Author.Name.StartsWith("夏目")).ToList();
            }
        }

        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子",
                };

                db.Authors.Add(author1);
                var author2 = new Author {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治",
                };
                db.Authors.Add(author2);
                db.SaveChanges();
            }
        }

        private static void AddAuthor2() {
            using (var db = new BooksDbContext()) {
                var author3 = new Author {
                    Birthday = new DateTime(1888, 12, 26),
                    Gender = "M",
                    Name = "菊池寛",
                };
                db.Authors.Add(author3);

                var author4 = new Author {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "M",
                    Name = "川端康成",
                };
                db.Authors.Add(author4);
                db.SaveChanges();
            }

        }

        private static void UpdateBooks() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.Single(x => x.Title == "銀河鉄道の夜");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }
        }

        private static void DeleteBooks() {
            using (var db = new BooksDbContext()) {
                var book = db.Books.SingleOrDefault(x => x.Id == 4);
                if (book != null) {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
            }
        }

        private static void DeleteAuthor() {
            using (var db = new BooksDbContext()) {
                var auhtor = db.Authors.SingleOrDefault(x => x.Id == 8);
                if (auhtor != null) {
                    db.Authors.Remove(auhtor);
                    db.SaveChanges();
                }
            }
        }
    }
}
