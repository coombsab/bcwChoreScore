namespace bcwChoreScore.Services;

public class ChoresService {
  private readonly FakeDb _db;

  public List<Chore> GetChores() {
    return _db.chores;
  }

  public Chore GetChore(string id)
  {
    Chore chore = _db.chores.Find(c => c.Id == id);
    if (chore == null) {
      throw new Exception("Invalid Chore ID");
    }
    return chore;
  }

  public Chore AddChore(Chore choreData)
  {
    _db.chores.Add(choreData);
    return choreData;
  }

  public Chore DeleteChore(string id)
  {
    Chore chore = GetChore(id);
    _db.chores.Remove(chore);
    return chore;
  }

  public Chore EditChore(Chore choreData, string id)
  {
    Chore chore = GetChore(id);
    // chore.Name = choreData.Name ?? chore.Name;
    chore.editChore(choreData);
    return chore;
  }

  public ChoresService(FakeDb db) {
    _db = db;
  }
}