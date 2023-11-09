# import csv
import csv
from cash_register.item import purchase_items

# PATH = ''
PATH = 'code/debugging/04 Hardcore/cities.csv'

# with open(PATH, 'r') as f:
with open(PATH, 'r', encoding='utf-8') as f:
  data = csv.DictReader(f)
  [print(row) for row in data]

price = purchase_items(input("Enter # of items: "), input("Enter price per item: "), input("Enter state code: "))

print(price)