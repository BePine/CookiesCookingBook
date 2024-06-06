﻿using Ingredients.@base;
namespace Ingredients
{
    public class Milk : Ingredient
    {
        public Milk()
        {

        }
        public override int Id { get; } = 5;
        public override string Name { get; } = "Milk";
        public override string Instructions { get; } = "Add half a glass and mix by kneading.";
    }
}

