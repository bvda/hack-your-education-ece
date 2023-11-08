import csv
import os

PATH_DATA = 'states.csv'

def read_file(path):
  dict = {}
  with open(os.path.join(os.getcwd(), path), 'r') as f:
    data = csv.DictReader(f)
    for row in data:
      dict[row['code']] = {'name': row['name'], 'tax': row['tax']}
  return dict

def state_info(code):
  return dict_states['code']

def sales_tax(code):
  dict = state_info(code)
  return dict.get('tax')

def price(number_of_items, item_price):
  return number_of_items * item_price

def discount(price):
  if price >= 1_000:
    discount = 0.03
  elif price >= 5_000:
    discount = 0.05
  elif price >= 7_000: 
    discount = 0.07
  elif price >= 10_000:
    discount = 0.1
  elif price >= 50_000:
    discount = 0.15
  else:
    discount = 0
  return price - discount * price

def tax(price, state_code):
  return price + price * sales_tax(state_code)

def total(number_of_items, items_price, state_code):
  tax(discount(price(number_of_items, items_price)), state_code)


if __name__ == "__main__":
  
  # Load supported states from external source (in this case, a file)
  dict_states = read_file(PATH_DATA)

  state_code = input("Enter state code: ")
  number_of_items = input("Enter # of items")
  item_price = input("Enter item price")

  print(total(number_of_items, item_price, state_code))