## AssessMainUnit


## Итоговая контрольная работа. Основной блок. Разработчик.

__Задача.__ Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] 

[“1234”, “1567”, “-2”, “computer science”] → [“-2”] 

[“Russia”, “Denmark”, “Kazan”] → []

Описание алгоритма:

1.Размер исходного массива задается пользователем.

2.Массив строк вводится пользователем.

3.Проходимся по массиву и подсчитываем количество строк подходящего размера.

4.Создаем новый массив на подсчитанное количество строк.

5.Снова проходим по исходному массиву, и заносим подходящие строки в новый массив.

6.Выводим полученный массив на консоль.
