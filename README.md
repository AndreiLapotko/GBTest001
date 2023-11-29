## Программа для формирования из имеющегося строкового массива нового массива строк, длина которых меньше, либо равна 3 символам.

Основная работа организована в функции **StringFilter**, которая на вход, в качестве параметров принимает исходный строковый массив и длину фильтра, а на выход формирует новый массив с требуемыми строками.
    
    Исходный массив в данном случае задается на старте выполнения алгоритма.


### Функция **StringFilter**
На начальном этапе инициализируются две локальные целочисленные переменные:
1. _size_ - для определения размера результирующего массива.
2. _count_ - для индексирования результирующего массива.

Далее, в первом цикле производится подсчёт всех строк исходного массива, длина которых меньше либо равна количеству символов, заданных аргументами. Результат сохраняется в ***size***.

Затем создается новый строковый массив размером ***size***, в который, при помощи следующего цикла, из исходного массива поэлементно копируются строки, удовлетворяющие условию.
![алгоритм функции](Test001.png)
    _рис. 1. Алгоритм работы функции._

В алгоритм заложена проверка на отсутствие искомых элементов. В этом случае генерируется массив с одной пустой строкой для последующей обработки.