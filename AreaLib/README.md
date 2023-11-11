# ответ на второе задание
SELECT Product.Name, Category.Name
FROM Product
LEFT JOIN ProductCategory ON Product.Id = ProductCategory.ProductId
LEFT JOIN Category ON ProductCategory.CategoryId = Category.Id;