import csv
import os

PATH_DATA = 'code/debugging/03 Hurt Me Plenty/states.csv' 
# PATH_DATA = 'states.csv'

def read_file(path):
  dict = {}
  with open(os.path.join(os.getcwd(), path), 'r') as f:
    data = csv.DictReader(f)
    for row in data:
      dict[row['code']] = {'name': row['name'], 'tax': float(row['tax'])} # Bug #2: KeyError, remove 'code', insert '1'. Bug #3: TypeError, remove 'float(...)''  
      # dict[row['code']] = {'name': row['name'], 'tax': row['tax']} # Bug #2: KeyError, remove 'code', insert '1'. Bug #3: TypeError, remove 'float(...)''  
  return dict # Bug #1: Remove 'return dict' to return None

def state_info(code):
  # return dict_states['code']
  return dict_states.get(code)

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
  # tax(discount(price(number_of_items, items_price)), state_code)
  return tax(discount(price(number_of_items, items_price)), state_code)

# Load supported states from external source (in this case, a file)
dict_states = read_file(PATH_DATA)

# state_code = input("Enter state code: ")
# number_of_items = input("Enter # of items")
# item_price = input("Enter item price")

state_code = input("Enter state code: ")
number_of_items = int(input("Enter # of items"))
item_price = int(input("Enter item price"))

print(total(number_of_items, item_price, state_code))

#print(dict_states.)
# print("# of items")
# number_of_items = input()
# 
# print("Price per item")
# price_per_item = input()
# 
# price = int(number_of_items) * float(price_per_item)
# 
# if price >= 1_000:
#   discount = 0.03
# elif price >= 5_000:
#   discount = 0.05
# elif price >= 7_000: 
#   discount = 0.07
# elif price >= 10_000:
#   discount = 0.1
# elif price >= 50_000:
#   discount = 0.15
# else:
#   discount = 0
# 
# price = price - price * discount
# 
# print(price)
# print("Add state tax")
# state = input()
# 
# if state == "UT":
#   tax = 0.0685
# elif state == "NV":
#   tax = 0.08
# elif state == "TX":
#   tax = 0.0625
# elif state == "AL":
#   tax = 0.04
# elif state == "CA":
#   tax = 0.0825
# else:
#   print('Invalid state')
#   state = input()
# 
# total = price + price * tax
# 
# print(f"Total: {total}")