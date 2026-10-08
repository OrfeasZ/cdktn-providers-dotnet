using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeRegistrationPolicy
{
    [JsiiInterface(nativeType: typeof(IDataSafeRegistrationPolicyConnectionOption), fullyQualifiedName: "oci.dataSafeRegistrationPolicy.DataSafeRegistrationPolicyConnectionOption")]
    public interface IDataSafeRegistrationPolicyConnectionOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_registration_policy#connection_type DataSafeRegistrationPolicy#connection_type}.</summary>
        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectionType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_registration_policy#identifiers DataSafeRegistrationPolicy#identifiers}.</summary>
        [JsiiProperty(name: "identifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Identifiers
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeRegistrationPolicyConnectionOption), fullyQualifiedName: "oci.dataSafeRegistrationPolicy.DataSafeRegistrationPolicyConnectionOption")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeRegistrationPolicy.IDataSafeRegistrationPolicyConnectionOption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_registration_policy#connection_type DataSafeRegistrationPolicy#connection_type}.</summary>
            [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_registration_policy#identifiers DataSafeRegistrationPolicy#identifiers}.</summary>
            [JsiiProperty(name: "identifiers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Identifiers
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
