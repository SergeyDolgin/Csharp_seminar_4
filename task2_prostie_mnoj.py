# 2'. Задайте натуральное число N. Напишите программу, которая составит список простых множителей числа N.
# * 6 -> [1,2,3]
# * 144 -> [2,3]


print('Введите натуральное число N')
N = int(input())
a = N
i = 2
list = []
while a != 1:
    while a % i == 0:
        list.append(i)
        a //= i
    i += 1

print(f'Простые множители числа {N}:')        
print(set(list))
