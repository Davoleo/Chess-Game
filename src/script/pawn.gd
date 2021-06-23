extends Node2D

class_name Pawn, "res://art/assets/pawn_white.png"

var virtual_position = $Map.world_to_map(position);
var target: Vector2
const team = null;
# var type = MiscEnums.EnumPieces.PAWN

func _init(team):
	self.team = team
	
func move(target_pos):
	target = target_pos
	
var selected = false
 
func _ready():
	var map_node = get_node('Map')
	self.connect("input_event", map_node, "_on_chess_piece_selected")
	self.selected = true
