namespace _413Final_Blosil.Models;

public class EFEntertainmentAgencyExample : IEntertainmentAgencyExampleRepository
{
    private EntertainmentAgencyExampleContext _context;

    public EFEntertainmentAgencyExample(EntertainmentAgencyExampleContext temp)
    {
        _context = temp;
    }

    public IQueryable<Entertainer> Entertainers => _context.Entertainers;

    public void UpdateEntertainer(Entertainer entertainer)
    {
        _context.Entertainers.Update(entertainer);
    }

    public void AddEntertainer(Entertainer entertainer)
    {
        _context.Entertainers.Add(entertainer);
    }
    
    public void DeleteEntertainer(int entertainer_ID)
    {
        var entertainerToDelete = _context.Entertainers.FirstOrDefault(e => e.EntertainerID == entertainer_ID);
        if (entertainerToDelete != null)
        {
            _context.Entertainers.Remove(entertainerToDelete);
        }
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}