# import time 
# def rand_val():
#     random = time.time_ns() // 1_000_000 
#     return random%100
# print(rand_val())


# def num(n):
#     a = 1
#     x = 0
#     for i in range(1, n + 1):
#         a = (1 + 1/n)**n
#         x += a
#         print("[", + a, sep = '', end=']')
#     print()
#     print("Общая сумма:", + x)
# num(6)

# import random
 
# abc = ['123 ', '345 ', '678 ', '90 ']
# random.shuffle(abc)
# print(abc)


# txt = ['h3110', '23', 'cat', '444.4', 'rabbit', '11', '2', 'dog']
# print([int(s) for s in txt if s.isdigit()])

txt = ['h3110', '23', 'cat', '444.4', 'ra123bbit', '11', '2', 'dog']
emp_str = ""
for i in txt:
    if i.isdigit():
        emp_str = emp_str + i
print("Найденные символы:",emp_str) 