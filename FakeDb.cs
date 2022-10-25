namespace bcwChoreScore.Data;

public class FakeDb 
{
  public List<Chore> chores = new List<Chore>() 
  {
    new Chore("mow lawn", ChoreRoom.Yard, false),
    new Chore("dishes", ChoreRoom.Kitchen, false),
    new Chore("rake leaves", ChoreRoom.Yard, false),
    new Chore("vacuum", ChoreRoom.Bedroom, false),
    new Chore("clean bathroom", ChoreRoom.Bathroom, false),
    new Chore("sweep kitchen", ChoreRoom.Kitchen, false),
    new Chore("mop kitchen", ChoreRoom.Kitchen, false)
  };
}