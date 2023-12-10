using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
#region 14
/*
Every record in MongoDb is a Document. Documents are stored in Json format

Collections in Mongo = Tables in Relational Databases
Documents in Mongo = Rows in Relational Databases




 */
#endregion
#region 16
//docker exec -it container-name mongosh
//docker exec -it shopping-mongo mongosh
/*
To Create new Db => use dbname 
Example => use CatalogDb

To Crete Collection => db.createCollection('CollectionName')
Example => db.createCollection('Products')

To Create a new item inside a collection => db.CollectionName.Insert(data)
To Create multiple items inside a collection => db.CollectionName.InsertMany(data)
Example => 
db.Products.insertMany([{ 'Name':'Asus Laptop','Category':'Computers', 'Summary':'Summary', 'Description':'Description', 'ImageFile':'ImageFile', 'Price':54.93 }, { 'Name':'HP Laptop','Category':'Computers', 'Summary':'Summary', 'Description':'Description', 'ImageFile':'ImageFile', 'Price':88.93 } ])


To Get items in the collection => db.CollectionName.find({}).pretty()
Curly Brackets represents that there is no filter which means to get all items from the collection
Example => db.Products.find({}).pretty()

To Remove items in a collection => db.CollectionName.deleteMany({})
Example => db.Products.deleteMany({})
*/
#endregion