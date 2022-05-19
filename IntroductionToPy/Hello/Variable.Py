# from operator import truediv


# value = None
# a = 123
# b = 1.23
# # print(type(a))
# # print(type(b))
# # value = 'dsfs'
# # print(type(value))
# s = 'Hello World!'
# # print(s) # вывод строки
# q = "Hello 'World!'" # кавычки
# # print(q)
# w = "Hello \n'World!'" # перенос

# print(a, ' - ', b, ' - ', s, ' - ', q, ' - ', w)

# print('{4} + {3} + {2} + {1} + {0}'.format(a,b,s,q,w))

# print(f'{a} ! {b} ! {s} ! {q} ! {w}')

# f = True
# print(f)

# list = [1, 2, 3]
# list2 = ['text', 1, 2, 3]
# print(list)
# print(list2)

# print('Введите параметр a: ')
# a = input()
# print('Введите параметр b: ')
# b = input()
# print('{} {}'.format(a, b))
# print(f'{a} {b}')

# print('Введите параметр a: ')
# a = int(input())
# print('Введите параметр b: ')
# b = int(input())
# print(a, ' + ', b, ' = ', a+b)

# a = +123
# b = -321
# c = a+b
# print(c)

# a = 8
# b = 4
# z = a+b     # сложение
# c = a-b     # вычитаение
# d = a*b     # умножение
# f = a / b   # деление. По умолчанию для вещественных
# g = a // b  # деление в целых
# x = a % b   # остаток от деления
# v = a ** b  # возведение во вторую степень
# print(z, c, d, f, g, x, v)

# ab = 1.31206
# ba = 3
# cab = ab * ba
# bac = round(ab * ba)
# bac5 = round(ab * ba, 2)
# bac7 = round(ab * ba, 7)
# print(cab, bac, bac5, bac7)

# a = 5
# a = a + 7
# print(a)

# a = 5
# a += 6
# print(a)

# a = 1 < 3 and 5 > 2
# print(a)

# a = 'www'
# b = 'www'
# print(a==b)

# a = [1,2]
# b = [1,2]
# print(a==b)

# a = 1 < 3 < 5 < 10
# print(a)

# func = 1
# t = 4
# x = 123
# print(func < t > x)

# f = 1 > 2 or 4 < 6
# print(f)

# f = [1,2,3,4]
# print(f)
# print(2 in f)
# print(not 2 in f)
# is_odd = not f[0] % 2 == 0
# print(is_odd)

# a = int(input())
# b = int(input())
# if a > b:
#     print(a)
# else:
#     print(b)

# username = input('Введите имя: ')
# if username == 'Маша':
#     print('Приветствую Маша!')
# elif username == 'Марина':
#     print('Приветствую Марина!')
# elif username == 'Ильнар':
#     print('Привет Ильнар!')
# else:
#     print('Привет,', username)

# original = 23
# inverted = 0
# while original != 0:
#     inverted = inverted * 10 + (original % 10)
#     original //= 10
# print(original, ' ', inverted)


# for i in 1,2,3,4,5:
#     print(i**2)

# list = [1,2,3,4,5]
# for i in list:
#     print(i)

# list = [1,2,3,4,5]
# for i in list:
#     print(i**2)

# for i in range(2,8,2):
#     print(i)

# for i in 'qwerty':
#     print(i)

# help(text.format)
# text = 'съещь ещё этих мягких французских булок'
# print(len(text))
# print(text[0])
# print(text[1])
# print(text[-4])
# print(text[:])
# print(text[:2])
# print(text[len(text)-2])


# numbers = [1,2,3,4,5]
# print(numbers)
# ran = range(1,6)
# print(type(ran))
# numbers = list(ran)
# print(type(numbers))
# print(numbers)
# numbers[0] = 10
# print(f'{len(numbers)} len')
# print(numbers)
# for i in numbers:
#     i *= 2
#     print(i)
# print(numbers)

# colors = ['red', 'green', 'blue']

# for e in colors:
#     print(e)
# for e in colors:
#     print(e*2)

# colors.append('gray') # Добавить элемент
# print(colors)
# print(colors == ['red', 'green', 'blue', 'gray'])
# colors.remove('red') # Удалить элемент
# print(colors)

def func_name(x):
    if x == 1:
        return 'Целое'
    elif x == 2.3:
        return 23
    else:
        return

arg = 2
print(func_name(arg))
print(type(func_name(arg)))