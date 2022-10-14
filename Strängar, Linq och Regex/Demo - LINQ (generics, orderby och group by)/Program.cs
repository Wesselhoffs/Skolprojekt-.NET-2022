var agents = new Agent[] {
new Agent("Smith", "M100"),
new Agent("Williams", "M200"),
new Agent("Smith", "M300"),
new Agent("Anderson", "M400"),
new Agent("Jones", "M500"),
new Agent("Smith", "M700"),
new Agent("Johnsson", "M700"),
new Agent("Jones", "M600")
};var agentQuery = from agent in agents                 group agent by agent.Name;foreach (var agentGroup in agentQuery)
{
    foreach (var agent in agentGroup)
    {
        Console.WriteLine("Name: " + agent.Name + "\tCode: " + agent.Code);
    }
}public class Agent
{
    public string Name { get; set; }
    public string Code { get; set; }
    public Agent(string name, string code)
    {
        Name = name;
        Code = code;
    }
}