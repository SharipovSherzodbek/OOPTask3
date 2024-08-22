using System;
public enum Mark
{
    Excellent,
    Good,
    Average,
    Poor 
}

public class Student
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }
    public int Class { get; set; }
    public Mark StudentMark { get; set; }

}