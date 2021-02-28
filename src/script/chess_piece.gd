extends Node2D

class_name Pawn

var virtual_position = position / (19 * 3)
var target: Vector2
var team = null

func _init(team):
	self.team = team
	
func move(target_pos):
	target = target_pos
	
var selected = false
 
func _ready():
	self.connect("input_event", get_parent(), "_on_chess_piece_selected")
	self.selected = true
