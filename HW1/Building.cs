namespace HW_4;

public class Building
{
    static int counter = 0;

    private int _BulidHeight;
    private int _FloorNum;
    private int _FlatNum;
    private int _Entrance;
    private int _BuildNum;

    public int BuildHeight
    {
        get => _BulidHeight;
        set => _BulidHeight = value;
    }

    public int FloorNum
    {
        get => _FloorNum;
        set => _FloorNum = value;
    }

    public int FlatNum
    {
        get => _FlatNum;
        set => _FlatNum = value;
    }

    public int Entrance
    {
        get => _Entrance;
        set => _Entrance = value;
    }

    public int BuildNum
    {
        get => _BuildNum;
       
    }

    private void BuildCounter ()
    {
        counter++;
        _BuildNum = counter;
    }

}


