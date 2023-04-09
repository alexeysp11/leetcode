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

SELECT p.product_id FROM products p WHERE p.low_fats = 1 AND p.recyclable = 1; 
