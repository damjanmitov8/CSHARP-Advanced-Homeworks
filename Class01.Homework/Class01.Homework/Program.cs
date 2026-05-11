   // Data Sample
using Class01.Homework.Enums;
using Class01.Homework.Models;

List<Product> products = new List<Product>()
{
    new Product(1, "iPhone 9", "An apple mobile which is nothing like apple", 549, 4.69, 94, "Apple", ProductCategory.Smartphones),
    new Product(2, "iPhone X", "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...", 899, 4.44, 34, "Apple", ProductCategory.Smartphones),
    new Product(3, "Samsung Universe 9", "Samsung's new variant which goes beyond Galaxy to the Universe", 1249, 4.09, 36, "Samsung", ProductCategory.Smartphones),
    new Product(4, "OPPOF19", "OPPO F19 is officially announced on April 2021.", 280, 4.3, 123, "OPPO", ProductCategory.Smartphones),
    new Product(5, "Huawei P30", "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.", 499, 4.09, 32, "Huawei", ProductCategory.Smartphones),
    new Product(6, "MacBook Pro", "MacBook Pro 2021 with mini-LED display may launch between September, November", 1749, 4.57, 83, "Apple", ProductCategory.Laptops),
    new Product(7, "Samsung Galaxy Book", "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched", 1499, 4.25, 50, "Samsung", ProductCategory.Laptops),
    new Product(8, "Microsoft Surface Laptop 4", "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.", 1499, 4.43, 68, "Microsoft Surface", ProductCategory.Laptops),
    new Product(9, "Infinix INBOOK", "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty", 1099, 4.54, 96, "Infinix", ProductCategory.Laptops),
    new Product(10, "HP Pavilion 15-DK1056WM", "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10", 1099, 4.43, 89, "HP Pavilion", ProductCategory.Laptops),
    new Product(11, "perfume Oil", "Mega Discount, Impression of Acqua Di Gio by GiorgioArmani concentrated attar perfume Oil", 13, 4.26, 65, "Impression of Acqua Di Gio", ProductCategory.Fragrances),
    new Product(12, "Brown Perfume", "Royal_Mirage Sport Brown Perfume for Men & Women - 120ml", 40, 4, 52, "Royal_Mirage", ProductCategory.Fragrances),
    new Product(13, "Fog Scent Xpressio Perfume", "Product details of Best Fog Scent Xpressio Perfume 100ml For Men cool long lasting perfumes for Men", 13, 4.59, 61, "Fog Scent Xpressio", ProductCategory.Fragrances),
    new Product(14, "Non-Alcoholic Concentrated Perfume Oil", "Original Al Munakh® by Mahal Al Musk | Our Impression of Climate | 6ml Non-Alcoholic Concentrated Perfume Oil", 120, 4.21, 114, "Al Munakh", ProductCategory.Fragrances),
    new Product(15, "Eau De Perfume Spray", "Genuine  Al-Rehab spray perfume from UAE/Saudi Arabia/Yemen High Quality", 30, 4.7, 105, "Lord - Al-Rehab", ProductCategory.Fragrances),
    new Product(16, "Hyaluronic Acid Serum", "L'OrÃ©al Paris introduces Hyaluron Expert Replumping Serum formulated with 1.5% Hyaluronic Acid", 19, 4.83, 110, "L'Oreal Paris", ProductCategory.Skincare),
    new Product(17, "Tree Oil 30ml", "Tea tree oil contains a number of compounds, including terpinen-4-ol, that have been shown to kill certain bacteria,", 12, 4.52, 78, "Hemani Tea", ProductCategory.Skincare),
    new Product(18, "Oil Free Moisturizer 100ml", "Dermive Oil Free Moisturizer with SPF 20 is specifically formulated with ceramides, hyaluronic acid & sunscreen.", 40, 4.56, 88, "Dermive", ProductCategory.Skincare),
    new Product(19, "Skin Beauty Serum.", "Product name: rorec collagen hyaluronic acid white face serum riceNet weight: 15 m", 46, 4.42, 54, "ROREC White Rice", ProductCategory.Skincare),
    new Product(20, "Freckle Treatment Cream- 15gm", "Fair & Clear is Pakistan's only pure Freckle cream which helpsfade Freckles, Darkspots and pigments. Mercury level is 0%, so there are no side effects.", 70, 4.06, 140, "Fair & Clear", ProductCategory.Skincare),
    new Product(21, "- Daal Masoor 500 grams", "Fine quality Branded Product Keep in a cool and dry place", 20, 4.44, 133, "Saaf & Khaas", ProductCategory.Groceries),
    new Product(22, "Elbow Macaroni - 400 gm", "Product details of Bake Parlor Big Elbow Macaroni - 400 gm", 14, 4.57, 146, "Bake Parlor Big", ProductCategory.Groceries),
    new Product(23, "Orange Essence Food Flavou", "Specifications of Orange Essence Food Flavour For Cakes and Baking Food Item", 14, 4.85, 26, "Baking Food Items", ProductCategory.Groceries)
};

//1.Get the title of the first product in the Fragrances category with a price above $100.
var firstProductInFragrancesCategory = products.Where(p => p.Category == ProductCategory.Fragrances && p.Price > 100).FirstOrDefault().Title;
Console.WriteLine(firstProductInFragrancesCategory);

//2.Select the brand of the last product that has a stock lower than 40.
var brandWithLowerStock = products.Where(p => p.Stock < 40).LastOrDefault().Brand;
Console.WriteLine(brandWithLowerStock);

//3.Retrieve the description of the first product with a rating equal to 4.43.
var descOfTheFirstProduct = products.Where(p => p.Rating == 4.43).FirstOrDefault().Description;
Console.WriteLine(descOfTheFirstProduct);

//4.Get the title of the last Skincare product with a price under $50.
var titleOfTheLastSkincareProduct = products.Where(p => p.Category == ProductCategory.Skincare && p.Price < 50).LastOrDefault().Title;
Console.WriteLine(titleOfTheLastSkincareProduct);

//5.Select the rating of the first product with a brand that contains the word "Apple".
var productConstainsWordApple = products.Where(p => p.Brand.Contains("Apple")).Select(p => p.Rating).FirstOrDefault();
Console.WriteLine(productConstainsWordApple);

//6.Get the description of the last product with "display" in the description.
var descOfLastProduct = products.Where(p => p.Description.Contains("display")).Select(p => p.Description).LastOrDefault();
Console.WriteLine(descOfLastProduct);

//7.Select the title of the first Laptop that has a stock greater than 80.
var laptopWithGreaterStock = products.Where(p => p.Category == ProductCategory.Laptops && p.Stock > 80).FirstOrDefault().Title;
Console.WriteLine(laptopWithGreaterStock);

//8.Get the brand of the last product with "Pro" in the title.
var productWithProInTitle = products.Where(p => p.Title.Contains("Pro")).Select(p => p.Brand).LastOrDefault();
Console.WriteLine(productWithProInTitle);

//9.Retrieve the title of the first product that has a price above $1200.
var titleWithPriceAbove = products.Where(p => p.Price > 1200).Select(p => p.Title).FirstOrDefault();
Console.WriteLine(titleWithPriceAbove);

//10.Select the stock count of the last product that belongs to the Smartphones category.
var stockCount = products.Where(p => p.Category == ProductCategory.Smartphones).Select(p => p.Stock).LastOrDefault();
Console.WriteLine(stockCount);

//11.Get the description of the first product with a brand name starting with 'H'.
var brandNameStartWithH = products.Where(p => p.Brand.StartsWith("H")).Select(p => p.Description).FirstOrDefault();
Console.WriteLine(brandNameStartWithH);

//12.Retrieve the price of the last product that has "Essence" in its title.
var essenceInTitle = products.Where(p => p.Title.Contains("Essence")).Select(p => p.Price).LastOrDefault();
Console.WriteLine(essenceInTitle);

//13.Select the brand of the first product with a description longer than 100 characters.
var descLongerThan100char = products.Where(p => p.Description.Length > 100).Select(p => p.Brand).FirstOrDefault();
Console.WriteLine(descLongerThan100char);

//14.Get the title of the last product with a rating below 4.1 and stock over 30.
var titleWithRatingBelow = products.Where(p => p.Rating < 4.1 && p.Stock > 30).Select(p => p.Title).LastOrDefault();
Console.WriteLine(titleWithRatingBelow);

//15.Retrieve the description of the first product that has "Serum" in the title.
var descWithSerumInTitle = products.Where(p => p.Title.Contains("Serum")).Select(p => p.Description).FirstOrDefault();
Console.WriteLine(descWithSerumInTitle);

//16.Use a dictionary to map products by their category.
var groupByCategory = products.GroupBy(p => p.Category).ToDictionary(p => p.Key, p => p.ToList());
foreach (var group in groupByCategory)
{
    Console.WriteLine($"{group.Key}:");

    foreach (var product in group.Value)
    {
        Console.Write($"{product.Title} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}