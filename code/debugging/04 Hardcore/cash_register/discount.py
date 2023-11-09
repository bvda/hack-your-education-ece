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