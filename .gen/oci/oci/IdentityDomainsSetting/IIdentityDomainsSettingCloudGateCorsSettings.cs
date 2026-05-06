using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsSetting
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsSettingCloudGateCorsSettings), fullyQualifiedName: "oci.identityDomainsSetting.IdentityDomainsSettingCloudGateCorsSettings")]
    public interface IIdentityDomainsSettingCloudGateCorsSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#cloud_gate_cors_allowed_origins IdentityDomainsSetting#cloud_gate_cors_allowed_origins}.</summary>
        [JsiiProperty(name: "cloudGateCorsAllowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CloudGateCorsAllowedOrigins
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#cloud_gate_cors_allow_null_origin IdentityDomainsSetting#cloud_gate_cors_allow_null_origin}.</summary>
        [JsiiProperty(name: "cloudGateCorsAllowNullOrigin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CloudGateCorsAllowNullOrigin
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#cloud_gate_cors_enabled IdentityDomainsSetting#cloud_gate_cors_enabled}.</summary>
        [JsiiProperty(name: "cloudGateCorsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CloudGateCorsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#cloud_gate_cors_exposed_headers IdentityDomainsSetting#cloud_gate_cors_exposed_headers}.</summary>
        [JsiiProperty(name: "cloudGateCorsExposedHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CloudGateCorsExposedHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#cloud_gate_cors_max_age IdentityDomainsSetting#cloud_gate_cors_max_age}.</summary>
        [JsiiProperty(name: "cloudGateCorsMaxAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CloudGateCorsMaxAge
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsSettingCloudGateCorsSettings), fullyQualifiedName: "oci.identityDomainsSetting.IdentityDomainsSettingCloudGateCorsSettings")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsSetting.IIdentityDomainsSettingCloudGateCorsSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#cloud_gate_cors_allowed_origins IdentityDomainsSetting#cloud_gate_cors_allowed_origins}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudGateCorsAllowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CloudGateCorsAllowedOrigins
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#cloud_gate_cors_allow_null_origin IdentityDomainsSetting#cloud_gate_cors_allow_null_origin}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudGateCorsAllowNullOrigin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CloudGateCorsAllowNullOrigin
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#cloud_gate_cors_enabled IdentityDomainsSetting#cloud_gate_cors_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudGateCorsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CloudGateCorsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#cloud_gate_cors_exposed_headers IdentityDomainsSetting#cloud_gate_cors_exposed_headers}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudGateCorsExposedHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CloudGateCorsExposedHeaders
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_setting#cloud_gate_cors_max_age IdentityDomainsSetting#cloud_gate_cors_max_age}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudGateCorsMaxAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CloudGateCorsMaxAge
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
