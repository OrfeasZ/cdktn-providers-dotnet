using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityCompartment
{
    [JsiiByValue(fqn: "oci.identityCompartment.IdentityCompartmentTimeouts")]
    public class IdentityCompartmentTimeouts : oci.IdentityCompartment.IIdentityCompartmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_compartment#delete IdentityCompartment#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
