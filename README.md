# WCF DiskInfoModify Task 2

***

Надо модифицировать клиента и службу, которые созданы в первом домашнем задании(`WCF_HW1_DiskInfo`). Уберите на стороне службы явный вызов
метода `AddServiceEndpoint()`. 

Задайте адрес конечной точки и привязку службы в конфигурационном файле. Также опишите в конфигурационном файле mex точку.
Клиента переделайте в WinForms приложение. 

Уберите на стороне клиента явное использование класса `ChannelFactory<>` и явное
описание интерфейса с контрактом службы. Поскольку у службы
теперь есть mex точка, на стороне клиента можно создать прокси-класс. Прокси-класс создается командой «Добавить ссылку на
службу».

Выводить полученный от службы список объектов в окне клиента, например в `ListBox`.
