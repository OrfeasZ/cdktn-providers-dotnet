using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareApiShieldOperation
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareApiShieldOperationConfig), fullyQualifiedName: "cloudflare.dataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationConfig")]
    public interface IDataCloudflareApiShieldOperationConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Add feature(s) to the results.</summary>
        /// <remarks>
        /// The feature name that is given here corresponds to the resulting feature object. Have a look at the top-level object description for more details on the specific meaning.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/data-sources/api_shield_operation#feature DataCloudflareApiShieldOperation#feature}
        /// </remarks>
        [JsiiProperty(name: "feature", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Feature
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/data-sources/api_shield_operation#filter DataCloudflareApiShieldOperation#filter}.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        cloudflare.DataCloudflareApiShieldOperation.IDataCloudflareApiShieldOperationFilter? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>UUID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/data-sources/api_shield_operation#operation_id DataCloudflareApiShieldOperation#operation_id}
        /// </remarks>
        [JsiiProperty(name: "operationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OperationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>When true, includes OpenAPI schemas (both uploaded and learned) for the operation in the response.</summary>
        /// <remarks>
        /// Due to the conversion overhead, this parameter is only supported on single-operation retrieval.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/data-sources/api_shield_operation#with_schemas DataCloudflareApiShieldOperation#with_schemas}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "withSchemas", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? WithSchemas
        {
            get
            {
                return null;
            }
        }

        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/data-sources/api_shield_operation#zone_id DataCloudflareApiShieldOperation#zone_id}
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

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareApiShieldOperationConfig), fullyQualifiedName: "cloudflare.dataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareApiShieldOperation.IDataCloudflareApiShieldOperationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Add feature(s) to the results.</summary>
            /// <remarks>
            /// The feature name that is given here corresponds to the resulting feature object. Have a look at the top-level object description for more details on the specific meaning.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/data-sources/api_shield_operation#feature DataCloudflareApiShieldOperation#feature}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "feature", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Feature
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/data-sources/api_shield_operation#filter DataCloudflareApiShieldOperation#filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFilter\"}", isOptional: true)]
            public cloudflare.DataCloudflareApiShieldOperation.IDataCloudflareApiShieldOperationFilter? Filter
            {
                get => GetInstanceProperty<cloudflare.DataCloudflareApiShieldOperation.IDataCloudflareApiShieldOperationFilter?>();
            }

            /// <summary>UUID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/data-sources/api_shield_operation#operation_id DataCloudflareApiShieldOperation#operation_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "operationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OperationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>When true, includes OpenAPI schemas (both uploaded and learned) for the operation in the response.</summary>
            /// <remarks>
            /// Due to the conversion overhead, this parameter is only supported on single-operation retrieval.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/data-sources/api_shield_operation#with_schemas DataCloudflareApiShieldOperation#with_schemas}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "withSchemas", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? WithSchemas
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.21.1/docs/data-sources/api_shield_operation#zone_id DataCloudflareApiShieldOperation#zone_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZoneId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
