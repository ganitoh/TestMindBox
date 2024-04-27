Ответ на задание 3:
для связи многие ко многим создается треться таблица (ProductsCategory) которая будет иметь две колонки:
- productId  - ссылается на табличку products
- categoryId - ссылаетсчя на табличку categories

запрос:
SELECT p.Name as 'имя продукта', c.Name as 'имя категории' FROM Products AS p 
LEFT JOIN  ProductsCategory as pc ON p.Id = pc.productId  
LEFT JOIN Categories  AS c ON pc.categoryId = c.Id 

