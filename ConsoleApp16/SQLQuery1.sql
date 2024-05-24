SELECT p.Brand FROM Product p
INNER JOIN StoreInventory si ON p.Id = si.ProductId
WHERE si.StoreId = 1