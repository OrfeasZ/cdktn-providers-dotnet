using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ApiShieldSchemaValidationSettings
{
    [JsiiInterface(nativeType: typeof(IApiShieldSchemaValidationSettingsConfig), fullyQualifiedName: "cloudflare.apiShieldSchemaValidationSettings.ApiShieldSchemaValidationSettingsConfig")]
    public interface IApiShieldSchemaValidationSettingsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The default mitigation action used when there is no mitigation action defined on the operation.</summary>
        /// <remarks>
        /// Mitigation actions are as follows:
        ///
        /// <list type="bullet">
        /// <description><c>log</c> - log request when request does not conform to schema</description>
        /// <description><c>block</c> - deny access to the site when request does not conform to schema</description>
        /// </list>
        ///
        /// A special value of of <c>none</c> will skip running schema validation entirely for the request when there is no mitigation action defined on the operation
        /// Available values: "none", "log", "block".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/api_shield_schema_validation_settings#validation_default_mitigation_action ApiShieldSchemaValidationSettings#validation_default_mitigation_action}
        /// </remarks>
        [JsiiProperty(name: "validationDefaultMitigationAction", typeJson: "{\"primitive\":\"string\"}")]
        string ValidationDefaultMitigationAction
        {
            get;
        }

        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/api_shield_schema_validation_settings#zone_id ApiShieldSchemaValidationSettings#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
        string ZoneId
        {
            get;
        }

        /// <summary>When set, this overrides both zone level and operation level mitigation actions.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description><c>none</c> will skip running schema validation entirely for the request
        ///
        /// <list type="bullet">
        /// <description><c>null</c> indicates that no override is in place</description>
        /// </list></description>
        /// </list>
        ///
        /// To clear any override, use the special value <c>disable_override</c> or <c>null</c>
        /// Available values: "none", "disable_override".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/api_shield_schema_validation_settings#validation_override_mitigation_action ApiShieldSchemaValidationSettings#validation_override_mitigation_action}
        /// </remarks>
        [JsiiProperty(name: "validationOverrideMitigationAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ValidationOverrideMitigationAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiShieldSchemaValidationSettingsConfig), fullyQualifiedName: "cloudflare.apiShieldSchemaValidationSettings.ApiShieldSchemaValidationSettingsConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ApiShieldSchemaValidationSettings.IApiShieldSchemaValidationSettingsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The default mitigation action used when there is no mitigation action defined on the operation.</summary>
            /// <remarks>
            /// Mitigation actions are as follows:
            ///
            /// <list type="bullet">
            /// <description><c>log</c> - log request when request does not conform to schema</description>
            /// <description><c>block</c> - deny access to the site when request does not conform to schema</description>
            /// </list>
            ///
            /// A special value of of <c>none</c> will skip running schema validation entirely for the request when there is no mitigation action defined on the operation
            /// Available values: "none", "log", "block".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/api_shield_schema_validation_settings#validation_default_mitigation_action ApiShieldSchemaValidationSettings#validation_default_mitigation_action}
            /// </remarks>
            [JsiiProperty(name: "validationDefaultMitigationAction", typeJson: "{\"primitive\":\"string\"}")]
            public string ValidationDefaultMitigationAction
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/api_shield_schema_validation_settings#zone_id ApiShieldSchemaValidationSettings#zone_id}
            /// </remarks>
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string ZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>When set, this overrides both zone level and operation level mitigation actions.</summary>
            /// <remarks>
            /// <list type="bullet">
            /// <description><c>none</c> will skip running schema validation entirely for the request
            ///
            /// <list type="bullet">
            /// <description><c>null</c> indicates that no override is in place</description>
            /// </list></description>
            /// </list>
            ///
            /// To clear any override, use the special value <c>disable_override</c> or <c>null</c>
            /// Available values: "none", "disable_override".
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/api_shield_schema_validation_settings#validation_override_mitigation_action ApiShieldSchemaValidationSettings#validation_override_mitigation_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validationOverrideMitigationAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ValidationOverrideMitigationAction
            {
                get => GetInstanceProperty<string?>();
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
