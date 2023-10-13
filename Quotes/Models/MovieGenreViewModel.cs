using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Quotes.Models;

public class MovieGenreViewModel
{
    public List<Quote>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
}