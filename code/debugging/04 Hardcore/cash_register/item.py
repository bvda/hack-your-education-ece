from .discount import discount
from .tax import sales_tax

def purchase_items(price_per_item, number_of_items, state):
  price_before_discount = int(price_per_item) * int(number_of_items)
  price_after_discount = price_before_discount - discount(price_before_discount)
  price_with_taxes = price_after_discount * sales_tax(price_before_discount, state)
  return price_with_taxes