namespace Quiz
{
    private List<int> GetColumn(int total, int column)
    {
    List<int> retList = new List<int>();

    if (total <= 0)
    {
        return retList;
    }

    if (column < 0 || column > 2)
    {
        column = 0;
    }

    int pageSize = total / 3;

    int startIndex = column * pageSize;
    int endIndex = column * pageSize + pageSize;

    if (endIndex > total)
    {
        endIndex = total;
    }

    for (int i = startIndex; i < endIndex; i++)
    {
        retList.Add(i);
    }
    {
        return retList;
    }    
}