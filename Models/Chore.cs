namespace bcwChoreScore.Models;

public class Chore {
  public string Id { get; private set; }
  public string Name { get; private set; }
  public ChoreRoom Room { get; private set; }
  public bool IsComplete { get; private set; }


  // public Chore(string name, ChoreRoom room)
  // {
  //   Id = Guid.NewGuid().ToString();
  //   Name = name;
  //   Room = room;
  //   IsComplete = false;
  // }

  public Chore(string name, ChoreRoom room, bool isComplete)
  {
    Id = Guid.NewGuid().ToString();
    Name = name;
    Room = room;
    IsComplete = isComplete;
  }

  public void toggleComplete() {
    IsComplete = !IsComplete;
  }

  public void editChore(Chore choreData) {
    // if (choreData.Name != null) {
    //   Name = choreData.Name;
    // }
    Name = choreData.Name ?? Name;
    IsComplete = choreData.IsComplete;
    Room = choreData.Room;
  }
}