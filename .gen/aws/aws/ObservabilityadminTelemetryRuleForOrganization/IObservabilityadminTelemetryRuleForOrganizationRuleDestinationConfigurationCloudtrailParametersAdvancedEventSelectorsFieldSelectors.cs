using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ObservabilityadminTelemetryRuleForOrganization
{
    [JsiiInterface(nativeType: typeof(IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectorsFieldSelectors), fullyQualifiedName: "aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectorsFieldSelectors")]
    public interface IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectorsFieldSelectors
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#field ObservabilityadminTelemetryRuleForOrganization#field}.</summary>
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
        string Field
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#ends_with ObservabilityadminTelemetryRuleForOrganization#ends_with}.</summary>
        [JsiiProperty(name: "endsWith", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EndsWith
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#equals ObservabilityadminTelemetryRuleForOrganization#equals}.</summary>
        [JsiiProperty(name: "equalTo", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? EqualTo
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#not_ends_with ObservabilityadminTelemetryRuleForOrganization#not_ends_with}.</summary>
        [JsiiProperty(name: "notEndsWith", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NotEndsWith
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#not_equals ObservabilityadminTelemetryRuleForOrganization#not_equals}.</summary>
        [JsiiProperty(name: "notEquals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NotEquals
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#not_starts_with ObservabilityadminTelemetryRuleForOrganization#not_starts_with}.</summary>
        [JsiiProperty(name: "notStartsWith", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NotStartsWith
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#starts_with ObservabilityadminTelemetryRuleForOrganization#starts_with}.</summary>
        [JsiiProperty(name: "startsWith", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? StartsWith
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectorsFieldSelectors), fullyQualifiedName: "aws.observabilityadminTelemetryRuleForOrganization.ObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectorsFieldSelectors")]
        internal sealed class _Proxy : DeputyBase, aws.ObservabilityadminTelemetryRuleForOrganization.IObservabilityadminTelemetryRuleForOrganizationRuleDestinationConfigurationCloudtrailParametersAdvancedEventSelectorsFieldSelectors
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#field ObservabilityadminTelemetryRuleForOrganization#field}.</summary>
            [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}")]
            public string Field
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#ends_with ObservabilityadminTelemetryRuleForOrganization#ends_with}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endsWith", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EndsWith
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#equals ObservabilityadminTelemetryRuleForOrganization#equals}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "equalTo", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? EqualTo
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#not_ends_with ObservabilityadminTelemetryRuleForOrganization#not_ends_with}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notEndsWith", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NotEndsWith
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#not_equals ObservabilityadminTelemetryRuleForOrganization#not_equals}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notEquals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NotEquals
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#not_starts_with ObservabilityadminTelemetryRuleForOrganization#not_starts_with}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notStartsWith", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NotStartsWith
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.1/docs/resources/observabilityadmin_telemetry_rule_for_organization#starts_with ObservabilityadminTelemetryRuleForOrganization#starts_with}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startsWith", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? StartsWith
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
