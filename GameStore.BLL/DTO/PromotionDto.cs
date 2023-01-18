﻿namespace GameStore.BLL.DTO;

public class PromotionDto
{
    public int Id { get; set; }
    public int Procent { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public virtual GameDto? Games { get; set; }
}
