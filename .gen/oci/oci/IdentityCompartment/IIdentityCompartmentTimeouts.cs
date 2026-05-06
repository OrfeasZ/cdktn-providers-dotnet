using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityCompartment
{
    [JsiiInterface(nativeType: typeof(IIdentityCompartmentTimeouts), fullyQualifiedName: "oci.identityCompartment.IdentityCompartmentTimeouts")]
    public interface IIdentityCompartmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_compartment#delete IdentityCompartment#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityCompartmentTimeouts), fullyQualifiedName: "oci.identityCompartment.IdentityCompartmentTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityCompartment.IIdentityCompartmentTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_compartment#delete IdentityCompartment#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
