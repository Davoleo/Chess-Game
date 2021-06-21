
class ChessPiece : Node2D {
	Vector2 virtual_position = position / (19 * 3);
	Vector2 target;
	EnumTeam team;
	
	
	
	func _init(team):
		self.team = team
		
	func move(target_pos):
		target = target_pos
		
	var selected = false
	 
	func _ready():
		self.selected = true

}
