using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworksecuritymanagerScope
{
    [JsiiInterface(nativeType: typeof(INetworksecuritymanagerScopeScopeConfigurationAccountFilterExclude), fullyQualifiedName: "aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationAccountFilterExclude")]
    public interface INetworksecuritymanagerScopeScopeConfigurationAccountFilterExclude
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#account_ids NetworksecuritymanagerScope#account_ids}.</summary>
        [JsiiProperty(name: "accountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AccountIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#organizational_units NetworksecuritymanagerScope#organizational_units}.</summary>
        [JsiiProperty(name: "organizationalUnits", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OrganizationalUnits
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworksecuritymanagerScopeScopeConfigurationAccountFilterExclude), fullyQualifiedName: "aws.networksecuritymanagerScope.NetworksecuritymanagerScopeScopeConfigurationAccountFilterExclude")]
        internal sealed class _Proxy : DeputyBase, aws.NetworksecuritymanagerScope.INetworksecuritymanagerScopeScopeConfigurationAccountFilterExclude
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#account_ids NetworksecuritymanagerScope#account_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AccountIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.72.0/docs/resources/networksecuritymanager_scope#organizational_units NetworksecuritymanagerScope#organizational_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "organizationalUnits", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OrganizationalUnits
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
