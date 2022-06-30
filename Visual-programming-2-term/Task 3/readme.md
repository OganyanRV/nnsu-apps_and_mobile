## «Реализация игры средствами Windows Forms и WPF»

Программа выполнена в среде разработки microsoft visual studio 2017 с помощью Windows Form и WPF (Windows Presentation Foundation**)**. Приложение написано для операционной системы Windows. 

**Суть игры:**

На экране случайным образом с заданным интервалом появляются разноцветные полоски фиксированного размера, которые могут перекрывать друг друга. Поле появления первых N (0.5N) полосок пользователю разрешается убирать их щелчками мышки, причем полоска убирается только если она НЕ перекрыта сверху другими полосками. При убирании всех полосок игра считается выигранной, при появлении 2*N (N) полосок - проигранной.

**Реализация:**

Сам Form.cs и написанный мною класс Rectangles с тремя полями: координата, размер, цвет.

![3](../md_src/3.PNG)

В классе есть 3 метода: 

·    Bool Inside - принимает координаты клика мыши и узнает, попадаем ли мы в прямоугольник

·    Bool Cross - принимает Rectangles и узнает, пересекается ли переданный прямоугольник с текущим

·    Void DrawRec - исходя из полей класса рисует прямоугольник

![31](../md_src/31.PNG)

  

Теперь рассмотрим Form.cs:

Часть блока, рандомно генерирующего объект Rectangles выглядит так:

![32](../md_src/32.PNG)

Для сравнения, в WPF это делается иначе. Например, координата задается отступом от всех рамок, а в самом WPF существует свой класс Rectangle, у которого и так есть методы, задающие размер (Height, Width), цвет(Fill), обводку(Stroke). 

![33](../md_src/33.PNG)

Таймер задается тоже по-разному:

Windows Form:

![34](../md_src/34.PNG)

WPF :

![35](../md_src/35.PNG)

Также WPF сам определяет объект Rectangle,  так что мы просто используем метод IntersectWith, в отличии от Windows Form, где нужно вручную (написанным нами методом) сравнивать элементы массива Reclist по координатам: 

WPF:

![36](../md_src/36.PNG)

Windows form: 

![37](../md_src/37.PNG)

 

В дополнение скажу, что пользователь может регулировать сложность:

![38](../md_src/38.PNG)

Чем меньше timedifficult, тем меньше задержка, т.е сложнее.

Чем меньше RectangleNumberDifficult, тем меньше порог прямугольников, при котором вы проиграете.

P.s: Задержка 1000 - легко. 500 - нужно попотеть. Если вы выигрываете на <400, то вы сверхчеловек. 

![39](../md_src/39.PNG)

Проигрыш и выигрыш соответственно:



![311](../md_src/311.PNG)

 

**Приложение**

**Windows Forms:**

![312](../md_src/312.PNG)