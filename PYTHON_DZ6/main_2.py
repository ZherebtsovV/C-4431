
# Задача 32: Определить индексы элементов массива (списка), значения которых принадлежат заданному диапазону 
# (т.е. не меньше заданного минимума и не больше заданного максимума). Список можно задавать рандомно

import random

def find_indexes(lst, min_val, max_val):
    """Функция возвращает список индексов элементов, значения которых 
    находятся в заданном диапазоне"""

    indexes = []
    for i in range(len(lst)):
        if min_val <= lst[i] <= max_val:
            indexes.append(i)
    return indexes

# генерация списка со случайными значениями
lst = [random.randint(-100, 100) for _ in range(10)]
min_val = -40
max_val = 30

print("Список: {}".format(lst))
print("Диапазон значений: ({}, {})".format(min_val, max_val))

indexes = find_indexes(lst, min_val, max_val)
print("Индексы элементов в заданном диапазоне: {}".format(indexes))

