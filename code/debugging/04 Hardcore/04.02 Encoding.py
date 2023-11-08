# import csv
import csv

# PATH = ''
PATH = 'code/debugging/04 Hardcore/cities.csv'

# with open(PATH, 'r') as f:
with open(PATH, 'r', encoding='utf-8') as f:
  data = csv.DictReader(f)
  [print(row) for row in data]