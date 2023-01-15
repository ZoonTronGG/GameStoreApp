﻿namespace GameStore.DAL.Models;

public class GamePublisher
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public virtual ICollection<Game>? Games { get; set; }
}