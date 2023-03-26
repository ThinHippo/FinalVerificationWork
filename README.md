# FinalVerificationWork
## Итоговое задание по курсу ВЫБОР СПЕЦИАЛИЗАЦИИ

> Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3-м символам.

> Условием задачи не определен способ создания/заполнения исходного массива.

### Замысел решения:

Исходный массив заполняем разделением строковой переменной (Split) в методе CreateArrayByString. Предварительно этой переменной присваиваем результат считывания текста файла Parma.txt из директории проекта.

Исходный массив передаем в метод GetStringByArray. Кроме массива передаем аргументы - минимальный размер элемента (minSize), максимальный размер элемента (maxSize) и разделитель со значением по умолчанию (separator=" ").

В методе внутри цикла while проверяем размер каждого элемента (size) и при выполнении условия - size>=minSize && size<=maxSize значение этого элемента добавляем к возвращаемой строковой переменной.

Результирующий массив заполняем в методе CreateArrayByString разделением полученного строкового значения переменной.



