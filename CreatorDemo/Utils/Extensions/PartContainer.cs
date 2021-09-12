using CreatorDemo.Builders.Base.Interfaces;
using CreatorDemo.Builders.PartBuilder.Parts;

namespace CreatorDemo.Utils
{ 
    public class PartContainer
    {
        public WheelPart Wheel { get => Of<WheelPart>(); }
        public EnginePart Engine { get => Of<EnginePart>(); }
        public HelixPart Helix { get => Of<HelixPart>(); }
        public BackHelixPart BackHelix { get => Of<BackHelixPart>(); }
        public BumperPart Bumper { get => Of<BumperPart>(); }
        public PedalPart Pedal { get => Of<PedalPart>(); }
        public DoorPart Door { get => Of<DoorPart>(); }

        public T Of<T>() where T : IPart, new() => new T();
    }
}