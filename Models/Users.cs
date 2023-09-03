using EventsApplication.Models;

public class Users
{
    public int Id { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Role { get; set; } = "User";
    public string Password { get; set; } = string.Empty;
    public List<Events> RegisteredEvents { get; set; } = new List<Events>();
}
