#   В заданном списке вещественных чисел найдите разницу между максимальным и минимальным значением дробной части элементов. 
#   Пример: [1.1, 1.2, 3.1, 5, 10.01] => 0.19

lst = [1.1, 1.2, 3.1, 5, 10.01]
a = len(lst)
for i in range(0,len(lst)):
    lst.append(int(lst[i] % 10))
del lst[0:a]
print(lst)
print(max(lst), min(lst))

#AAAAAAAAAA