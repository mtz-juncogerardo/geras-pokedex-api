using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace geras_pokemon_api.Models
{
    public class FavoriteItem
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string PokemonId { get; set; }
        public PokemonItem Pokemon { get; set; }
        public UserItem User { get; set; }
    }
}
