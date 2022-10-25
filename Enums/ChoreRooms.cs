using System.Text.Json.Serialization;

namespace bcwChoreScore.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ChoreRoom {
  Kitchen,
  Bathroom,
  Bedroom,
  LivingRoom,
  Yard
}