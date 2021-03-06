using System;

public class RecipeTest
{
    private string name;
    private int recipeId;
    private int[] ingredientIds;

    public RecipeTest(string nm, int id, int[] ingredients) {
        name = nm;
        recipeId = id;
        ingredientIds = ingredients;
    }

    public string getName() {
        return name;
    }

    public int getId() {
        return recipeId;
    }

    public int[] getIngredients() {
        return ingredientIds;
    }

    public bool checkIfIngredientRequired(int ingredientId) {
        return Array.Exists(ingredientIds, x => x == ingredientId);
    }
}

public static class Recipes
{
    // public RecipeTest[] recipes = new RecipeTest[]{
    //     new RecipeTest("Fried Eggplant", 0, new int[]{0, 2, 3}),
    //     new RecipeTest("Golden Fried Eggplant", 1, new int[]{1, 2, 3}),
    //     new RecipeTest("Pizza", 2, new int[]{2, 3, 4, 5, 6}),
    //     new RecipeTest("Burrito", 3, new int[]{4, 7, 8, 9, 10})
    // };
    public static RecipeTest[] recipes = new RecipeTest[]{
        new RecipeTest("Fried Eggplant", 0, new int[]{4, 4, 11}),  // 2 Eggplant(4) + Potato(11)
        new RecipeTest("Golden Fried Eggplant", 1, new int[]{6}),  // GoldenEggplant(6)
        new RecipeTest("Pizza", 2, new int[]{4, 12, 11}),          // Eggplant(4) + Corn(12) + Potato(11)
        new RecipeTest("Burrito", 3, new int[]{11, 12, 12})        // Potato(11) + 2 Corn(12)
    };
}
