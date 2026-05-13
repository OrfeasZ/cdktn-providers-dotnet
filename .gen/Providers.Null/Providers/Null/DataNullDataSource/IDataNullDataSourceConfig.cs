using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Providers.Null.DataNullDataSource
{
    [JsiiInterface(nativeType: typeof(IDataNullDataSourceConfig), fullyQualifiedName: "null.dataNullDataSource.DataNullDataSourceConfig")]
    public interface IDataNullDataSourceConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>If set, its literal value will be stored and returned.</summary>
        /// <remarks>
        /// If not, its value defaults to <c>"default"</c>. This argument exists primarily for testing and has little practical use.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/null/3.3.0/docs/data-sources/data_source#has_computed_default DataNullDataSource#has_computed_default}
        /// </remarks>
        [JsiiProperty(name: "hasComputedDefault", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HasComputedDefault
        {
            get
            {
                return null;
            }
        }

        /// <summary>A map of arbitrary strings that is copied into the `outputs` attribute, and accessible directly for interpolation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/null/3.3.0/docs/data-sources/data_source#inputs DataNullDataSource#inputs}
        /// </remarks>
        [JsiiProperty(name: "inputs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Inputs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataNullDataSourceConfig), fullyQualifiedName: "null.dataNullDataSource.DataNullDataSourceConfig")]
        internal sealed class _Proxy : DeputyBase, Providers.Null.DataNullDataSource.IDataNullDataSourceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>If set, its literal value will be stored and returned.</summary>
            /// <remarks>
            /// If not, its value defaults to <c>"default"</c>. This argument exists primarily for testing and has little practical use.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/null/3.3.0/docs/data-sources/data_source#has_computed_default DataNullDataSource#has_computed_default}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hasComputedDefault", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HasComputedDefault
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A map of arbitrary strings that is copied into the `outputs` attribute, and accessible directly for interpolation.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/null/3.3.0/docs/data-sources/data_source#inputs DataNullDataSource#inputs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inputs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Inputs
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
