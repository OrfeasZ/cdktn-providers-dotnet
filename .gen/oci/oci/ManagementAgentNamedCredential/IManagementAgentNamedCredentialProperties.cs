using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ManagementAgentNamedCredential
{
    [JsiiInterface(nativeType: typeof(IManagementAgentNamedCredentialProperties), fullyQualifiedName: "oci.managementAgentNamedCredential.ManagementAgentNamedCredentialProperties")]
    public interface IManagementAgentNamedCredentialProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_named_credential#name ManagementAgentNamedCredential#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_named_credential#value ManagementAgentNamedCredential#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_named_credential#value_category ManagementAgentNamedCredential#value_category}.</summary>
        [JsiiProperty(name: "valueCategory", typeJson: "{\"primitive\":\"string\"}")]
        string ValueCategory
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IManagementAgentNamedCredentialProperties), fullyQualifiedName: "oci.managementAgentNamedCredential.ManagementAgentNamedCredentialProperties")]
        internal sealed class _Proxy : DeputyBase, oci.ManagementAgentNamedCredential.IManagementAgentNamedCredentialProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_named_credential#name ManagementAgentNamedCredential#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_named_credential#value ManagementAgentNamedCredential#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_agent_named_credential#value_category ManagementAgentNamedCredential#value_category}.</summary>
            [JsiiProperty(name: "valueCategory", typeJson: "{\"primitive\":\"string\"}")]
            public string ValueCategory
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
