namespace Disaheim;

public class ValuableRepository : IPersistable
{
    private List<IValuable> valuables;

    public ValuableRepository()
    {
        valuables = new List<IValuable>();
    }

    public void AddValuable(IValuable valuable)
    {
        valuables.Add(valuable);
    }

    public IValuable ?GetValuable(string id)
    {
        return valuables.FirstOrDefault(v => v.GetId() == id);
    }

    public double GetTotalValue()
    {
        return valuables.Select(v => v.GetValue()).Sum();
    }

    public int Count()
    {
        return valuables.Count();
    }

    public void Save()
    {
        Save("ValuableRepository");
    }

    public void Save(string fileName)
    {
        StreamWriter sw = new StreamWriter(fileName + ".txt");

        foreach (IValuable v in valuables)
        {
            sw.WriteLine(v.InfoString());
        }

        sw.Close();
    }

    public void Load()
    {
        throw new NotImplementedException();
    }

    public void Load(string fileName)
    {
        throw new NotImplementedException();
    }
}