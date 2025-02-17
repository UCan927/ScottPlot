﻿using FluentAssertions;

namespace ScottPlotCookbook;

internal class CookbookTests
{
    // TODO: recipe descriptions should end with a period
    // TODO: page and chapter descriptions should not end with a period
    // TODO: pages must have unique names
    // TODO: recipes must have unique names within pages
    // TODO: no undefined chapters
    // TODO: all recipes should be public

    [Test]
    public void Test_Recipes_Found()
    {
        List<IRecipe> recipes = Cookbook.GetRecipes();
        recipes.Should().NotBeNull();
        recipes.Should().NotBeEmpty();
        recipes.ForEach(x => TestContext.WriteLine(x));
    }

    [Test]
    public void Test_Pages_Found()
    {
        List<RecipePageBase> pages = Cookbook.GetPages();
        pages.Should().NotBeNull();
        pages.Should().NotBeEmpty();
        pages.ForEach(x => TestContext.WriteLine(x));
    }

    [Test]
    public void Test_Chapters_Found()
    {
        List<Chapter> chapters = Cookbook.GetChapters();
        chapters.Should().NotBeNull();
        chapters.Should().NotBeEmpty();
        chapters.ForEach(x => TestContext.WriteLine(x));
    }
}
