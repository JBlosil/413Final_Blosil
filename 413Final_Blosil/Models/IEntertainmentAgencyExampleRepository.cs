namespace _413Final_Blosil.Models;

public interface IEntertainmentAgencyExampleRepository
{
    public IQueryable<Entertainer> Entertainers { get;}
    
    void DeleteEntertainer(int entertainer_ID);
    void UpdateEntertainer(Entertainer entertainer);
    void AddEntertainer(Entertainer entertainer);
    void SaveChanges();
}