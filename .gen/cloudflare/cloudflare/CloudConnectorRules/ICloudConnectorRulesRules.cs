using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.CloudConnectorRules
{
    [JsiiInterface(nativeType: typeof(ICloudConnectorRulesRules), fullyQualifiedName: "cloudflare.cloudConnectorRules.CloudConnectorRulesRules")]
    public interface ICloudConnectorRulesRules
    {
        /// <summary>Cloud Provider type Available values: "aws_s3", "cloudflare_r2", "gcp_storage", "azure_storage", "oci_storage".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/cloud_connector_rules#cloud_connector_rules_provider CloudConnectorRules#cloud_connector_rules_provider}
        /// </remarks>
        [JsiiProperty(name: "cloudConnectorRulesProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudConnectorRulesProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/cloud_connector_rules#description CloudConnectorRules#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/cloud_connector_rules#enabled CloudConnectorRules#enabled}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/cloud_connector_rules#expression CloudConnectorRules#expression}.</summary>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Expression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Parameters of Cloud Connector Rule.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/cloud_connector_rules#parameters CloudConnectorRules#parameters}
        /// </remarks>
        [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"cloudflare.cloudConnectorRules.CloudConnectorRulesRulesParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.CloudConnectorRules.ICloudConnectorRulesRulesParameters? Parameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudConnectorRulesRules), fullyQualifiedName: "cloudflare.cloudConnectorRules.CloudConnectorRulesRules")]
        internal sealed class _Proxy : DeputyBase, cloudflare.CloudConnectorRules.ICloudConnectorRulesRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Cloud Provider type Available values: "aws_s3", "cloudflare_r2", "gcp_storage", "azure_storage", "oci_storage".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/cloud_connector_rules#cloud_connector_rules_provider CloudConnectorRules#cloud_connector_rules_provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudConnectorRulesProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudConnectorRulesProvider
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/cloud_connector_rules#description CloudConnectorRules#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/cloud_connector_rules#enabled CloudConnectorRules#enabled}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/cloud_connector_rules#expression CloudConnectorRules#expression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Expression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Parameters of Cloud Connector Rule.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.25.0/docs/resources/cloud_connector_rules#parameters CloudConnectorRules#parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"fqn\":\"cloudflare.cloudConnectorRules.CloudConnectorRulesRulesParameters\"}", isOptional: true)]
            public cloudflare.CloudConnectorRules.ICloudConnectorRulesRulesParameters? Parameters
            {
                get => GetInstanceProperty<cloudflare.CloudConnectorRules.ICloudConnectorRulesRulesParameters?>();
            }
        }
    }
}
