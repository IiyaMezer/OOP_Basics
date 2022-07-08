using HW_4.Building;

Building Build1 = new (25,9,36,3);

Console.WriteLine("Высота этажа в доме {0} : {1} м. ",Build1.BuildNum,Building.FloorHeight(Build1));
Console.WriteLine("Количество квартир в подьезде дома №{0} : {1} . ", Build1.BuildNum, Building.FlatInEntrance(Build1));
