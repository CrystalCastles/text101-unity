using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextController : MonoBehaviour {

    public Text text;

    private enum States {
        forest, forest_key, apple_0, apple_1, door_0, door_1,
        tin_can, inside_tree_0, inside_tree_1, inside_tree_2,
        ladder_0, ladder_1, ladder_2, cupboard_0, cupboard_1,
        wall_0, tree_top
    };

    private States myState;

	// Use this for initialization
	void Start() {
        myState = States.forest;
	}
	
	// Update is called once per frame
	void Update() {
        print(myState);
        if      (myState == States.forest)          {state_forest();}
        else if (myState == States.forest_key)      {state_forest_key();}
        else if (myState == States.apple_0)         {state_apple_0();}
        else if (myState == States.apple_1)         {state_apple_1();}
        else if (myState == States.door_0)          {state_door_0();}
        else if (myState == States.door_1)          {state_door_1();}
        else if (myState == States.tin_can)         {state_tin_can();}
        else if (myState == States.inside_tree_0)   {state_inside_tree_0();}
        else if (myState == States.inside_tree_1)   {state_inside_tree_1();}
        else if (myState == States.inside_tree_2)   {state_inside_tree_2();}
        else if (myState == States.ladder_0)        {state_ladder_0();}
        else if (myState == States.ladder_1)        {state_ladder_1();}
        else if (myState == States.ladder_2)        {state_ladder_2();}
        else if (myState == States.cupboard_0)      {state_cupboard_0();}
        else if (myState == States.cupboard_1)      {state_cupboard_1();}
        else if (myState == States.wall_0)          {state_wall_0();}
        else if (myState == States.tree_top)        {state_tree_top();}

    }

    void state_forest() {
        text.text = "You awaken dazed and confused, lying naked on the " +
                    "ground of an unknown forest. You take a quick look " +
                    "around, and what immediately catches your eyes is a " +
                    "Tin Can peaking out just beneath a pile of leaves, " +
                    "a random Apple, and what seems to be a hidden door " +
                    "on a tree. Press A to look at the Apple, C for the " +
                    "Tin Can, or D for the door.";
        if (Input.GetKeyDown(KeyCode.A)) {
            myState = States.apple_0;
        }
        if (Input.GetKeyDown(KeyCode.C)) {
            myState = States.tin_can;
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            myState = States.door_0;
        }
    }

    void state_forest_key() {
        text.text = "The random Apple is still there, and what seems to be " +
                    "a hidden door on a tree. Press A to look at the Apple, " +
                    "or D for the door.";
        if (Input.GetKeyDown(KeyCode.A)) {
            myState = States.apple_1;
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            myState = States.door_1;
        }
    }

    void state_apple_0() {
        text.text = "You pick up the apple. You're really hungry, but it seems " +
                    "to have a worm hole, so you decide not to indulge. " +
                    "Press R to return to scavaging the forest.";
        if(Input.GetKeyDown(KeyCode.R)) {
            myState = States.forest;
        }
    }

    void state_apple_1() {
        text.text = "Yep, still has a gross worm hole... Press R to return to " +
                    "scavaging the forest.";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.forest_key;
        }
    }

    void state_tin_can() {
        text.text = "You pick up the Tin Can and take a look inside, there is a " +
                    "tiny key hidden inside. Would you like to take the key? " +
                    "Press T to take or R to return to scavaging the forest.";
        if(Input.GetKeyDown(KeyCode.R)) {
            myState = States.forest;
        }
        if(Input.GetKeyDown(KeyCode.T)) {
            myState = States.forest_key;
        }
    }

    void state_door_0() {
        text.text = "You cannot open the door as appears to have a lock. " +
                    "Press R to return to scavaging the forest.";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.forest;
        }
    }

    void state_door_1() {
        text.text = "You use the key that you found, it works. You slowly " +
                    "open the door and peek inside. Press S to step in.";
        if (Input.GetKeyDown(KeyCode.S)) {
            myState = States.inside_tree_0;
        }
    }

    void state_inside_tree_0() {
        text.text = "You are inside...It seems to be a relatively nice place, " +
                    "if not somewhat sparce. There's a Ladder, a Cupboard " +
                    "and something on the Wall on the opposite side of the " +
                    "room. \n" +
                    "Press L to look at the Ladder, C for the Cupboard, or W " +
                    "for the wall.";
                    
        if (Input.GetKeyDown(KeyCode.L)){
            myState = States.ladder_0;
        }
        if (Input.GetKeyDown(KeyCode.C)) {
            myState = States.cupboard_0;
        }
        if (Input.GetKeyDown(KeyCode.W)) {
            myState = States.wall_0;
        }
    }

    void state_inside_tree_1() {
        text.text = "You feel a bit safer now that you have somewhat of a " +
                    "weapon... Press L to look at the Ladder, or C for the " +
                    "Cupboard.";
        if (Input.GetKeyDown(KeyCode.L)) {
            myState = States.ladder_1;
        }
        if (Input.GetKeyDown(KeyCode.C)) {
            myState = States.cupboard_1;
        }
    }

    void state_inside_tree_2() {
        text.text = "The cupboard contained a set of special magical grippy " +
                    "gloves and boots, you put them on. Press L to look at " +
                    "the Ladder."; 
        if (Input.GetKeyDown(KeyCode.L)) {
            myState = States.ladder_2;
        }
    }

    void state_ladder_0() {
        text.text = "The ladder goes way up, you try to climb it but it " +
                    "has a slime like substance that prevents you from " +
                    "getting a good enough grip. Press R to Return.";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.inside_tree_0;
        }
    }

    void state_ladder_1() {
        text.text = "The ladder is still too slimey to climb. Press R to " +
                    "Return.";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.inside_tree_1;
        }
    }

    void state_ladder_2() {
        text.text = "With your new set of magical gloves and boots, the " +
                    "ladder is now easy to climb. Press C to Climb up or " +
                    "R to Return.";
        if (Input.GetKeyDown(KeyCode.C)) {
            myState = States.tree_top;
        }
    }

    void state_cupboard_0() {
        text.text = "The cupboard is locked, maybe there is another way it " +
                    "can be opened. Press R to Return.";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.inside_tree_0;
        }
    }

    void state_cupboard_1() {
        text.text = "It's still locked, but your trusty tool seems strong " +
                    "enough to break it open. Press B to break the cupboard " +
                    "or R to return.";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.inside_tree_1;
        }
        if (Input.GetKeyDown(KeyCode.B)) {
            myState = States.inside_tree_2;
        }
    }

    void state_wall_0() {
        text.text = "You walk to the opposite end of the room. There is an " +
                    "odd looking two handed sharp tool displayed on the " +
                    "wall. Would you like to take it? Press T to Take or " +
                    "R to Return.";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.inside_tree_0;
        }
        if (Input.GetKeyDown(KeyCode.T)) {
            myState = States.inside_tree_1;
        }
    }

    void state_tree_top() {
        text.text = "After 2 hours of climbing, you reach the top of the tree." +
                    "You take a quick look around, and see nothing but " +
                    "sunlight beeming through the branches. You sit to rest " +
                    "and contemplate, when suddenly you spot a slip of paper " +
                    "stuck in a floor crack. You pick it up and examine it. " +
                    "There's writing on the paper, " +
                    "and it says \"Wake Up\". The end lol. Press P to " +
                    "play again.";
        if (Input.GetKeyDown(KeyCode.P)) {
            myState = States.forest;
        }
    }
}
