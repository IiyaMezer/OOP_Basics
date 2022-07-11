namespace HW_4.Building;

public class Building
{
    private static int counter = 0;

    private int _BulidHeight;
    private int _FloorAmount;
    private int _FlatAmount;
    private int _EntranceAmount;
    private int _BuildNum;

    #region Свойства полей
    public int BuildHeight
    {
        get => _BulidHeight;
        set => _BulidHeight = value;
    }

    public int FloorAmount
    {
        get => _FloorAmount;
        set => _FloorAmount = value;
    }

    public int FlatAmount
    {
        get => _FlatAmount;
        set => _FlatAmount = value;
    }

    public int EntranceAmount
    {
        get => _EntranceAmount;
        set => _EntranceAmount = value;
    }

    public int BuildNum
    {
        get => _BuildNum;
    }
    #endregion
      

    #region Methods
    private void BuildCounter()
    {
        counter++;
        _BuildNum = counter;
    }
    /// <summary>
    /// Высота этажа, принебрегаем наличием верхнего и нижнего сервисного этажа.
    /// </summary>
    /// <param name="building">Здание</param>
    /// <returns></returns>
    public static double FloorHeight(Building building)
    {
        return ((double)building.BuildHeight / building.FloorAmount);
    }

    /// <summary>
    /// Количество квартир в одном пдьезде
    /// </summary>
    /// <param name="building"></param>
    /// <returns></returns>
    public static int FlatInEntrance (Building building)
    {
        return (building.FlatAmount / building.EntranceAmount);
    }

    public static int FlatsOnFloor(Building building)
    {
        return (Building.FlatInEntrance(building) / building.FloorAmount);
    }
    #endregion

    public Building(int bulidHeight, int floorAmount, int flatAmount, int entranceAmount)
    {
        this._BulidHeight = bulidHeight;
        this._FloorAmount = floorAmount;
        this._FlatAmount = flatAmount;
        this._EntranceAmount = entranceAmount;

        BuildCounter();
    }






}


