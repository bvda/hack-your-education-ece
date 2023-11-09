# import csv
import csv
from cash_register import item

# PATH = ''
PATH = 'code/debugging/04 Hardcore/cities.csv'

# with open(PATH, 'r') as f:
with open(PATH, 'r', encoding='utf-8') as f:
  data = csv.DictReader(f)
  dict_cities = { row['code']:row['name'] for row in data }

price = item.purchase_items(input("Enter # of items: "), input("Enter price per item: "), input("Enter state code: "))

print('Amount due: %d', price)

postal_code = input("Enter your postal code: ")
print('You entered ', dict_cities.get(postal_code))
