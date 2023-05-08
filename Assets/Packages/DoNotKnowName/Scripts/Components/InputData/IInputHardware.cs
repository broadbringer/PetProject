namespace Packages.Scripts.Components.InputData
{
    public interface IInputHardware
    {
        float HorizontalAxis { get; }
        float VerticalAxis { get; }
        bool IsAnyMoveKeyDown { get; }
        bool IsJumpKeyDown { get; }
        bool IsAttackButtonDown { get; }
    }
}