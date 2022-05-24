#   Найти произведение пар чисел в списке. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
#   Пример: [2, 3, 4, 5, 6] => [12, 15, 16]; [2, 3, 5, 6] => [12, 15]

lst = [2, 3, 4, 5, 6]
print( len(lst), 5/2, round(5/2), int(round(5/2)))
# for i in range(0,round((len(lst)/2))):
#     if (i <= (len(lst)/2)):
#         sum = lst[i] * lst[len(lst) - i -1]
#     elif (i == round(len(lst)/2)):
#         sum = lst[i] * lst[len(lst) - i -1]
#     print(sum, end = ' ')




# int [] process_array2(int [] local_array)
# {
#   int [] ret_array = new int[local_array.Length/2];
#   for (int i=0; i<ret_array.Length;i++)
#   {
#       ret_array[i] = local_array[i] * local_array[local_array.Length - i -1];
#   }
#   return ret_array;
# }