﻿using StoreMarket.Models;
using System.ComponentModel.DataAnnotations;

namespace GraphQL.Contracts.Responses.Categories
{
    public class CategoryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }


        public CategoryResponse(Category categories)
        {
            Id = categories.Id;
            Name = categories.Name;
            Description = categories.Description;
        }
    }
}
