extends KinematicBody2D

class_name ChessPiece

var virtual_position = position / (19 * 3)
var target = Vector2()
 
func _ready():
	pass

func _on_KinematicBody2D_input_event(_viewport, event, _shapeId):
	if event.is_action_pressed('click'):
		target = get_global_mouse_position()
		self.position = target
		print("Called")
