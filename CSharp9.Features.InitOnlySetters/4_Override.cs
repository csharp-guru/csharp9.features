
namespace CSharp9.Features.InitOnlySetters
{
    // When init is used in a virtual property then all the 
    // overrides must also be marked as init. Likewise it is 
    // not possible to override a simple set with init.
    public class BaseObject
    {
        public virtual int Property { get; init; } 
    }

    public class C1 : BaseObject
    {
        public override int Property { get; init; } 
    }

    public class C2 : BaseObject
    {
        public override int Property { get; set; } // => Error CS8853

        //
        // Error CS8853 'C2.Property' must match by init-only of 
        // overridden member 'BaseObject.Property'
        //

    }
}







