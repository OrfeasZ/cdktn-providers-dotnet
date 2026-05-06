using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityTag
{
    [JsiiInterface(nativeType: typeof(IIdentityTagValidator), fullyQualifiedName: "oci.identityTag.IdentityTagValidator")]
    public interface IIdentityTagValidator
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_tag#validator_type IdentityTag#validator_type}.</summary>
        [JsiiProperty(name: "validatorType", typeJson: "{\"primitive\":\"string\"}")]
        string ValidatorType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_tag#values IdentityTag#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityTagValidator), fullyQualifiedName: "oci.identityTag.IdentityTagValidator")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityTag.IIdentityTagValidator
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_tag#validator_type IdentityTag#validator_type}.</summary>
            [JsiiProperty(name: "validatorType", typeJson: "{\"primitive\":\"string\"}")]
            public string ValidatorType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_tag#values IdentityTag#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
