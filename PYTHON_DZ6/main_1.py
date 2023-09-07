
# Задача 30:  Заполните массив элементами арифметической прогрессии. 
# Её первый элемент, разность и количество элементов нужно ввести с клавиатуры. 
# Формула для получения n-го члена прогрессии: an = a1 + (n-1) * d.
# Каждое число вводится с новой строки.

def arithmetic_progression(first, diff, count):
    # Создаем пустой список для хранения элементов прогрессии
    result = []

    # Заполняем список элементами прогрессии в соответствии с формулой
    for i in range(count):
        result.append(first + i * diff)

    # Возвращаем список с элементами прогрессии
    return result

# Запрашиваем у пользователя первый элемент, разность и количество элементов
first = int(input("Введите первый элемент: "))
diff = int(input("Введите разность: "))
count = int(input("Введите количество элементов: "))

# Создаем список элементов прогрессии, используя функцию arithmetic_progression
progression = arithmetic_progression(first, diff, count)

# Выводим полученную прогрессию на экран
print("Арифметическая прогрессия: ")
for element in progression:
    print(element)
















