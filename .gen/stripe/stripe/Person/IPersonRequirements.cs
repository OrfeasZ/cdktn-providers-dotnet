using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Person
{
    [JsiiInterface(nativeType: typeof(IPersonRequirements), fullyQualifiedName: "stripe.person.PersonRequirements")]
    public interface IPersonRequirements
    {

        [JsiiTypeProxy(nativeType: typeof(IPersonRequirements), fullyQualifiedName: "stripe.person.PersonRequirements")]
        internal sealed class _Proxy : DeputyBase, stripe.Person.IPersonRequirements
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
