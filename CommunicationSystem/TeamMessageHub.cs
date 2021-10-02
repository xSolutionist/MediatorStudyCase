using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSystem
{
    public class TeamMessageHub : MessageHub
    {
        private List<TeamMember> _members = new();
        public override void Register(TeamMember member)
        {
            member.InitializeMessageHub(this);
            _members.Add(member);
        }

        public override void Send(string from, string message)
        {
            throw new NotImplementedException();
        }
    }
}
