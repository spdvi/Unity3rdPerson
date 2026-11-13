using UnityEngine;

public abstract class PlayerBaseState : State
{
    // Reference to the player so that every single player state can reference the player
    protected PlayerStateMachine stateMachine;

    public PlayerBaseState(PlayerStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }
    
    // Shared methods between the different player states
}
