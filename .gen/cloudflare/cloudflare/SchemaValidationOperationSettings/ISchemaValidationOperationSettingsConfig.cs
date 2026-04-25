using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.SchemaValidationOperationSettings
{
    [JsiiInterface(nativeType: typeof(ISchemaValidationOperationSettingsConfig), fullyQualifiedName: "cloudflare.schemaValidationOperationSettings.SchemaValidationOperationSettingsConfig")]
    public interface ISchemaValidationOperationSettingsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>When set, this applies a mitigation action to this operation.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description><c>"log"</c> - log request when request does not conform to schema for this operation
        ///
        /// <list type="bullet">
        /// <description><c>"block"</c> - deny access to the site when request does not conform to schema for this operation</description>
        /// <description><c>"none"</c> - will skip mitigation for this operation</description>
        /// <description><c>null</c> - clears any mitigation action
        /// Available values: "log", "block", "none".</description>
        /// </list></description>
        /// </list>
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/schema_validation_operation_settings#mitigation_action SchemaValidationOperationSettings#mitigation_action}
        /// </remarks>
        [JsiiProperty(name: "mitigationAction", typeJson: "{\"primitive\":\"string\"}")]
        string MitigationAction
        {
            get;
        }

        /// <summary>UUID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/schema_validation_operation_settings#operation_id SchemaValidationOperationSettings#operation_id}
        /// </remarks>
        [JsiiProperty(name: "operationId", typeJson: "{\"primitive\":\"string\"}")]
        string OperationId
        {
            get;
        }

        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/schema_validation_operation_settings#zone_id SchemaValidationOperationSettings#zone_id}
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

        [JsiiTypeProxy(nativeType: typeof(ISchemaValidationOperationSettingsConfig), fullyQualifiedName: "cloudflare.schemaValidationOperationSettings.SchemaValidationOperationSettingsConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.SchemaValidationOperationSettings.ISchemaValidationOperationSettingsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>When set, this applies a mitigation action to this operation.</summary>
            /// <remarks>
            /// <list type="bullet">
            /// <description><c>"log"</c> - log request when request does not conform to schema for this operation
            ///
            /// <list type="bullet">
            /// <description><c>"block"</c> - deny access to the site when request does not conform to schema for this operation</description>
            /// <description><c>"none"</c> - will skip mitigation for this operation</description>
            /// <description><c>null</c> - clears any mitigation action
            /// Available values: "log", "block", "none".</description>
            /// </list></description>
            /// </list>
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/schema_validation_operation_settings#mitigation_action SchemaValidationOperationSettings#mitigation_action}
            /// </remarks>
            [JsiiProperty(name: "mitigationAction", typeJson: "{\"primitive\":\"string\"}")]
            public string MitigationAction
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>UUID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/schema_validation_operation_settings#operation_id SchemaValidationOperationSettings#operation_id}
            /// </remarks>
            [JsiiProperty(name: "operationId", typeJson: "{\"primitive\":\"string\"}")]
            public string OperationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/schema_validation_operation_settings#zone_id SchemaValidationOperationSettings#zone_id}
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
