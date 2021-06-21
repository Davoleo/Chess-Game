
class ChessPiece : Node2D {
	private Vector2 virtual_position = position / (19 * 3);
	private Vector2 target;
	private EnumTeam team;
	
	void _init(team) {
		self.team = team
	}
		
	func move(target_pos):
		target = target_pos
		
	var selected = false
	 
	func _ready():
		self.selected = true
		self.connect("input_event", get_parent(), "_on_chess_piece_selected")
		self.selected = true

}
