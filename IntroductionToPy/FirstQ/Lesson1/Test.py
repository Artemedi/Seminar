# def square(a,b):
#     if a == b**2:
#         print(f"число {a} является квадратом {b}")
#     else:
#         print(f"число {a} не является квадратом {b}")
# square(2,6)

# list = [1, 2, 3, 4, 6, 8]
# maxn = max(list)
# print("Наибольшее число:", maxn)

# Вывести на экран числа от -N до N

# def lst(a):
#     for a in range(-a,a+1):
#         print(a)
# lst(2)

# Показать первую цифру дробной части числа

# def Inumb(a):
#     num = int((a*10) % 10 )
#     print(num)
# Inumb(123.456)

# n = 99
# if ((n % 5 == 0) and (n % 10 == 0)) or ((n % 15 == 0) and (n % 30 != 0)):
#     print(f"{n} - true")
# else:
#     print(f"{n} = false")



# def int(a):
#     day = ["понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"]
#     if ((a == 6) or (a == 7)):
#         print(f"{day[a-1]}"," - выходной")
#     else:
#         print(f"{day[a-1]}"," - будний день")
# int(6)

#Проверить истинность утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для ВСЕХ значений предика

# def xyz(a,b,c):
#     for a in range(0, 2):
#         for b in range(0, 2):
#             for c in range(0, 2):
#                 false = not (a or b or c)
#                 true = not a and not b and not c
#                 result = true == false
#                 print(result)
# xyz(1,0,1)

#Сообщить в какой четверти координатной плоскости или на какой оси находится точка с координатами Х и У 

# def int(a, b):
#     print([['1', '2'], ['3', '4']][b < 0][a < 0])
# int(10,0)

#Указав номер четверти прямоугольной системы координат, показать допустимые значения координат для точек этой четверти

# import math


# def int(x1,x2,y1,y2):
#     print(round(math.sqrt(((x1 - x2)**2 + (y1 - y2)**2)**0.5)))
# int(-3,6,2,4)

