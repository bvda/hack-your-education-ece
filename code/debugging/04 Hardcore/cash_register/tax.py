import csv
import os

PATH_DATA = 'code\debugging\\03 Hurt Me Plenty\states.csv'

dict_states = {}

with open(os.path.join(os.getcwd(), PATH_DATA), 'r') as f:
  data = csv.DictReader(f)
  for row in data:
    dict_states[row['code']] = {'name': row['name'], 'tax': row['tax']}

def sales_tax(price, code):
  state = dict_states.get(code)
  # return state.get('tax')
  return price * float(state.get('tax'))