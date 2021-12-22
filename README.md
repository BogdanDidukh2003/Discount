# Discount

1. Install dotnet from [this link](https://download.visualstudio.microsoft.com/download/pr/c1bfbb13-ad09-459c-99aa-8971582af86e/61553270dd9348d7ba29bacfbb4da7bd/dotnet-sdk-5.0.400-win-x64.exe).
2. Open the solution folder in cmd and print `dotnet run -p Discount`
3. To run test cases print `dotnet test`

------------------------------------------------------------

**Laboratory 3 - Discount program **

The fashion store has started a seasonal sale, and offers customers a discount on every 3rd product purchased. You have chosen the products you want to buy and want to take advantage of this offer to save as much money as possible. Of course, the amount you have to pay depends on the order in which you buy the goods. Knowing the price of each product, as well as the percentage of the discount, calculate the most advantageous amount for which you can buy all the products.

Input data

The input file discnt.in consists of two lines.
• The first line contains a list of integers from 0 to 1,000,000,000 (109) inclusive, separated by a space of the price of the individual goods you want to buy. The total number of goods from 1 to 10000.
• The second line contains a discount integer from 0 to 100 inclusive, which means the percentage of the discount for every third product.

Imprint
The source discnt.out file must contain one number, the minimum amount that must be spent to purchase all products.