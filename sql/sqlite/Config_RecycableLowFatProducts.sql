-- Description: https://leetcode.com/problems/recyclable-and-low-fat-products/

-- Input: 
-- Products table:
-- +-------------+----------+------------+
-- | product_id  | low_fats | recyclable |
-- +-------------+----------+------------+
-- | 0           | 1        | 0          |
-- | 1           | 1        | 1          |
-- | 2           | 0        | 1          |
-- | 3           | 1        | 1          |
-- | 4           | 0        | 0          |
-- +-------------+----------+------------+
-- Output: 
-- +-------------+
-- | product_id  |
-- +-------------+
-- | 1           |
-- | 3           |
-- +-------------+
-- Explanation: Only products 1 and 3 are both low fat and recyclable.

DROP TABLE IF EXISTS Products; 
CREATE TABLE IF NOT EXISTS Products (
    product_id INTEGER PRIMARY KEY, 
    low_fats NUMERIC(1), 
    recyclable NUMERIC(1)
); 
INSERT INTO Products (product_id, low_fats, recyclable) VALUES (0, 1, 0); 
INSERT INTO Products (product_id, low_fats, recyclable) VALUES (1, 1, 1); 
INSERT INTO Products (product_id, low_fats, recyclable) VALUES (2, 0, 1); 
INSERT INTO Products (product_id, low_fats, recyclable) VALUES (3, 1, 1); 
INSERT INTO Products (product_id, low_fats, recyclable) VALUES (4, 0, 0); 
