number_of_items = int(input("Enter # of items: "))

price_per_item = input("Enter price per item: ")

price = int(number_of_items) * price_per_item

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

price = price - price * discount

state = input("Enter state code: ")

if state == "UT":
  tax = 0.0685
elif state == "NV":
  tax = 0.08
elif state == "TX":
  tax = 0.0625
elif state == "AL":
  tax = 0.04
elif state == "CA":
  tax = 0.0825
else:
  print("Not available in your state")

total = price + price * tax

print(f"Total: {total}")