SELECT products.name, categories.name 
FROM products 
LEFT JOIN categories ON products.category_id = categories.id;