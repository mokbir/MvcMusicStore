using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class MusicStoreDbInitializer:
        System.Data.Entity.CreateDatabaseIfNotExists<MvcMusicStoreDB>
    {
        protected override void Seed(MvcMusicStoreDB context)
        {
            context.Artists.Add(new Artist { Name= "Al Di Meola" });
            context.Genres.Add(new Genre { Name = "Jazz" } );
            context.Genres.Add(new Genre { Name = "R&B" });
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Rush" },
                Genre = new Genre { Name="Rock" },
                Price = 9.9m,
                Title = "Caravan"
            });

            base.Seed(context);
        }
    }
}