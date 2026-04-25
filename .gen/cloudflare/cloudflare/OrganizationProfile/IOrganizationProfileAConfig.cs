using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.OrganizationProfile
{
    [JsiiInterface(nativeType: typeof(IOrganizationProfileAConfig), fullyQualifiedName: "cloudflare.organizationProfile.OrganizationProfileAConfig")]
    public interface IOrganizationProfileAConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization_profile#business_address OrganizationProfileA#business_address}.</summary>
        [JsiiProperty(name: "businessAddress", typeJson: "{\"primitive\":\"string\"}")]
        string BusinessAddress
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization_profile#business_email OrganizationProfileA#business_email}.</summary>
        [JsiiProperty(name: "businessEmail", typeJson: "{\"primitive\":\"string\"}")]
        string BusinessEmail
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization_profile#business_name OrganizationProfileA#business_name}.</summary>
        [JsiiProperty(name: "businessName", typeJson: "{\"primitive\":\"string\"}")]
        string BusinessName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization_profile#business_phone OrganizationProfileA#business_phone}.</summary>
        [JsiiProperty(name: "businessPhone", typeJson: "{\"primitive\":\"string\"}")]
        string BusinessPhone
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization_profile#external_metadata OrganizationProfileA#external_metadata}.</summary>
        [JsiiProperty(name: "externalMetadata", typeJson: "{\"primitive\":\"string\"}")]
        string ExternalMetadata
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization_profile#organization_id OrganizationProfileA#organization_id}.</summary>
        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
        string OrganizationId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOrganizationProfileAConfig), fullyQualifiedName: "cloudflare.organizationProfile.OrganizationProfileAConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.OrganizationProfile.IOrganizationProfileAConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization_profile#business_address OrganizationProfileA#business_address}.</summary>
            [JsiiProperty(name: "businessAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string BusinessAddress
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization_profile#business_email OrganizationProfileA#business_email}.</summary>
            [JsiiProperty(name: "businessEmail", typeJson: "{\"primitive\":\"string\"}")]
            public string BusinessEmail
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization_profile#business_name OrganizationProfileA#business_name}.</summary>
            [JsiiProperty(name: "businessName", typeJson: "{\"primitive\":\"string\"}")]
            public string BusinessName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization_profile#business_phone OrganizationProfileA#business_phone}.</summary>
            [JsiiProperty(name: "businessPhone", typeJson: "{\"primitive\":\"string\"}")]
            public string BusinessPhone
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization_profile#external_metadata OrganizationProfileA#external_metadata}.</summary>
            [JsiiProperty(name: "externalMetadata", typeJson: "{\"primitive\":\"string\"}")]
            public string ExternalMetadata
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/organization_profile#organization_id OrganizationProfileA#organization_id}.</summary>
            [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
            public string OrganizationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
