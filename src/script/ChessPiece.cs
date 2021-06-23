using Chessgame.script.Utils;
using Godot;

namespace Chessgame.script
{
    class ChessPiece : Node2D
    {
        private readonly Vector2 virtualPosition;
        private readonly EnumTeam team;

        //state
        private Vector2 targetPos;
        private bool selected = false;

        public ChessPiece(Vector2 virtualPosition, EnumTeam team)
        {
            this.virtualPosition = Position / (19 * 3);
            this.team = team;
        }

        void Move(Vector2 pos)
        {
            targetPos = pos;
        }

        public override void _Ready()
        {
            Connect("input_event", GetParent(), "On_ChessPiece_Selected");
            selected = true;
        }
    }
}