import csv
import os

def read_file(path):
  dict = {}
  # Make without 'os.path.join(...)'
  # with open(os.path.join(os.getcwd(), path), 'r') as f:
  with open(path, 'r') as f:
    data = csv.DictReader(f)
    for row in data:
      dict[row['code']] = {'name': row['name'], 'tax': float(row['tax'])} # Bug #2: KeyError, remove 'code', insert '1'. Bug #3: TypeError, remove 'float(...)''  
  return dict # Bug #1: Remove 'return dict' to return None

# Are we sure we're on the right path to success?
dict_states = read_file('code\debugging\\03 Hurt Me Plenty\states.csv') # Bug #3: Remove '\' from '\\' to make '\x03' 

state_code = input("Enter state code: ")
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