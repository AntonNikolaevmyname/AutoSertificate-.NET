# AutoSertificate-.NET
## Что умеет программа?
Программа умеет "строить" по шаблону **word** (.doc .docx и тд) файла нужное вам количество word документов (например сертификатов, дипломов и тд), заменяя в базовом шаблоне **[ключевое_слово]** на например имя + фамилию, взятые списком из разных столбцов в **excel** файле. Также сразу все это распечатать, если нужно. (**прим.** знаю что certificate, такое название приложения:) )


## Руководство
У приложения есть 3 основных вкладки с разным функционалом: **Главная**, **Печать**, **Настройки**.
Примеры excel и word файлов, а также готовое к запуску приложение (.exe), лежат в папке **CompleteApp**
При первом запуске рекомендую начать с вкладки

>______________________________________________

**Настройки**
 
Здесь нам нужно указать 3 поля.
В первое нужно скопировать (либо прописать вручную) путь в папку, куда будут сохраняться все созданные вами с момощью приложения файлы.
Во втором указать **ключевое_слово** (*если несколько слов отдельно, то разделять их лучше "_"*), которое будет заменяться в шаблоне, либо оставить значение по умолчанию.
В третьем поле нужно указать название организации либо любое удобное для вас слово, нужно это для построения имен word файлов.


Например: Если в каком-то документе имя + фамилия будут Иванов Иван, то название word файла будет **CompanyName_Иванов Иван**.
Данные параметры в настройках мы можете постоянно менять для более удобного поиска по имени.

 **PS** Также внизу панели мы можете поменять стиль приложения, он сохраняется автоматически после выбора.
 
![](https://github.com/AntonNikolaevmyname/AutoSertificate-.NET/blob/master/Images/settings.PNG)

>______________________________________________
**Главная**
 
 Для начала работы нужно выбрать excel файл, из которого мы "вытащем" список формируемым по 1, 2 или 3 столбцам, которые выберем. Также не нужно указать номер страницы (листа) в excel файле.
 
 После нажатия на кнопку **Обновить и отобразить** в правой части окна выведется то, что мы выбрали. (В разных версиях excel отсчет "первой строки" начинается либо с 0 либо с 1). 
 
 Далее нужно подготовить шаблон word файла и выбрать его. Дождитесь загрузки.
 
 ![](https://github.com/AntonNikolaevmyname/AutoSertificate-.NET/blob/master/Images/main.PNG)
 
 >______________________________________________
  **Печать**
  
  В этой вкладке вы можете распечатать выбранные вами файлы (нужен принтер :blush: ).
  
  ![](https://github.com/AntonNikolaevmyname/AutoSertificate-.NET/blob/master/Images/paint.PNG)
  
## Начало работы
Для развертывания приложения на рабочем столе скачайте папку CompleteApp с релизной версией и запустите exe-файл в папке с проектом (либо через ярлык в папке CompleteApp).
