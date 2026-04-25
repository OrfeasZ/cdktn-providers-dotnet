using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.SchemaValidationSettings
{
    [JsiiInterface(nativeType: typeof(ISchemaValidationSettingsConfig), fullyQualifiedName: "cloudflare.schemaValidationSettings.SchemaValidationSettingsConfig")]
    public interface ISchemaValidationSettingsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The default mitigation action used Mitigation actions are as follows:.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description><c>"log"</c> - log request when request does not conform to schema
        ///
        /// <list type="bullet">
        /// <description><c>"block"</c> - deny access to the site when request does not conform to schema</description>
        /// <description><c>"none"</c> - skip running schema validation
        /// Available values: "none", "log", "block".</description>
        /// </list></description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/schema_validation_settings#validation_default_mitigation_action SchemaValidationSettings#validation_default_mitigation_action}
        /// </remarks>
        [JsiiProperty(name: "validationDefaultMitigationAction", typeJson: "{\"primitive\":\"string\"}")]
        string ValidationDefaultMitigationAction
        {
            get;
        }

        /// <summary>When set, this overrides both zone level and operation level mitigation actions.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description><c>"none"</c> - skip running schema validation entirely for the request
        ///
        /// <list type="bullet">
        /// <description><c>null</c> - clears any existing override
        /// Available values: "none".</description>
        /// </list></description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/schema_validation_settings#validation_override_mitigation_action SchemaValidationSettings#validation_override_mitigation_action}
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

        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/schema_validation_settings#zone_id SchemaValidationSettings#zone_id}
        /// </remarks>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZoneId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISchemaValidationSettingsConfig), fullyQualifiedName: "cloudflare.schemaValidationSettings.SchemaValidationSettingsConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.SchemaValidationSettings.ISchemaValidationSettingsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The default mitigation action used Mitigation actions are as follows:.</summary>
            /// <remarks>
            /// <list type="bullet">
            /// <description><c>"log"</c> - log request when request does not conform to schema
            ///
            /// <list type="bullet">
            /// <description><c>"block"</c> - deny access to the site when request does not conform to schema</description>
            /// <description><c>"none"</c> - skip running schema validation
            /// Available values: "none", "log", "block".</description>
            /// </list></description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/schema_validation_settings#validation_default_mitigation_action SchemaValidationSettings#validation_default_mitigation_action}
            /// </remarks>
            [JsiiProperty(name: "validationDefaultMitigationAction", typeJson: "{\"primitive\":\"string\"}")]
            public string ValidationDefaultMitigationAction
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>When set, this overrides both zone level and operation level mitigation actions.</summary>
            /// <remarks>
            /// <list type="bullet">
            /// <description><c>"none"</c> - skip running schema validation entirely for the request
            ///
            /// <list type="bullet">
            /// <description><c>null</c> - clears any existing override
            /// Available values: "none".</description>
            /// </list></description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/schema_validation_settings#validation_override_mitigation_action SchemaValidationSettings#validation_override_mitigation_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validationOverrideMitigationAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ValidationOverrideMitigationAction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/schema_validation_settings#zone_id SchemaValidationSettings#zone_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZoneId
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
