#Последовательность для задачи:
# 1. Создать список случайной длины 
# 2. Записать в файл случайные позиции элементов из этого списка
# 3. Считать из файла эти позиции
# 4. Взять числа по этим позициям и перемножить


# import random

# a = input() # replace input
# lst = []
# for i in range(0,a):
#     lst.append(random.randint(-a,a))

# print(lst)

# b = random.randint(1,10)

# with open('file.txt', 'w') as data:
#     for i in range(0, b):
#         data.write(str(random.randint(0, a-1))+'\n')

# lst_ = []
# num = 1
# with open('file.txt', 'r') as data:
#     for i in data:
#         num *= lst[int(i[:-1])]
#         lst_.append(int(i[:-1]))

# print(lst_)
# print(num)

#   Дано число. Составить список чисел Фибоначчи, в том числе для отрицательных индексов.
#   т.е. для k = 8, список будет выглядеть так: 
# [-21 ,13, -8, 5, −3,  2, −1,  1, 0, 1, 1, 2, 3, 5, 8, 13, 21] Негафибоначчи

# k = 9
# lst = []
# for i in range(0, k+1):
#     num = i if i == 0 or i == 1 else (lst[i-2] - lst[i-1]) 
#     lst.append(num)
# lst.reverse()
# for i in range(1, k+1): 
#     lst.append(lst[i-1+k] + lst[i-2+k])

# print(lst)


# a = '1 2 3 4 5 6 87 9 23'
# lst = [int(b) for b in a.split() if b.isdigit()]
# print(min(lst), max(lst))
