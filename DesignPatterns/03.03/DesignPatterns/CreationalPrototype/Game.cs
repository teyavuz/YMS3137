using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPrototype
{
    public class Game:ProtoTypeGame
    {
        public Game(int playerId, string gameName, string gameType, bool isActive)
        {
            PlayerID = playerId;
            GameName = gameName;
            GameType = gameType;
            IsActive = isActive;
        }

        public int PlayerID { get; set; }
        public string GameName { get; set; }
        public string GameType { get; set; }
        public bool IsActive { get; set; }

        public override ProtoTypeGame Clone()
        {
            return this.MemberwiseClone() as ProtoTypeGame;
        }
    }
}
