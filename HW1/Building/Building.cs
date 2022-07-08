namespace HW_4.Building;

public class Building
{
    static int counter = 0;

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
    /// <param name="Build">Здание</param>
    /// <returns></returns>
    public static double FloorHeight(Building Build)
    {
        return ((double)Build.BuildHeight / Build.FloorAmount);
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


