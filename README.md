# FigureCSharp
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, 
в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.

SELECT products.product_name, categories.category_name
FROM products
LEFT JOIN products_categories 
ON products_categories.product_id = products.product_id
JOIN categories
ON categories.category_id = products_categories.category_id
