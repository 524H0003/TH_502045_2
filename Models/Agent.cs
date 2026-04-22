namespace TH_502045_2.Models
{
    public class Agent
    {
        public int AgentID { get; set; }
        public string AgentName { get; set; }

        public string Address { get; set; }

        // Navigation property
        public virtual ICollection<Order> Orders { get; set; }
    }
}
