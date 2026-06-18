using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudImage
{
    [JsiiInterface(nativeType: typeof(IDataHcloudImageConfig), fullyQualifiedName: "hcloud.dataHcloudImage.DataHcloudImageConfig")]
    public interface IDataHcloudImageConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>ID of the Image.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.66.0/docs/data-sources/image#id DataHcloudImage#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Include deprecated images.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.66.0/docs/data-sources/image#include_deprecated DataHcloudImage#include_deprecated}
        /// </remarks>
        [JsiiProperty(name: "includeDeprecated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeDeprecated
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sort results by created date, and return the most recent result.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.66.0/docs/data-sources/image#most_recent DataHcloudImage#most_recent}
        /// </remarks>
        [JsiiProperty(name: "mostRecent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MostRecent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of the Image, only present when the type is `system`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.66.0/docs/data-sources/image#name DataHcloudImage#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/cloud#label-selector).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.66.0/docs/data-sources/image#selector DataHcloudImage#selector}
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Selector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter results by architecture, for example `x86` (default) or `arm`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.66.0/docs/data-sources/image#with_architecture DataHcloudImage#with_architecture}
        /// </remarks>
        [JsiiProperty(name: "withArchitecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WithArchitecture
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/hetzner#label-selector).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.66.0/docs/data-sources/image#with_selector DataHcloudImage#with_selector}
        /// </remarks>
        [JsiiProperty(name: "withSelector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WithSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter results by statuses, for example `creating` or `available`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.66.0/docs/data-sources/image#with_status DataHcloudImage#with_status}
        /// </remarks>
        [JsiiProperty(name: "withStatus", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? WithStatus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataHcloudImageConfig), fullyQualifiedName: "hcloud.dataHcloudImage.DataHcloudImageConfig")]
        internal sealed class _Proxy : DeputyBase, hcloud.DataHcloudImage.IDataHcloudImageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ID of the Image.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.66.0/docs/data-sources/image#id DataHcloudImage#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Id
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Include deprecated images.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.66.0/docs/data-sources/image#include_deprecated DataHcloudImage#include_deprecated}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "includeDeprecated", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeDeprecated
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Sort results by created date, and return the most recent result.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.66.0/docs/data-sources/image#most_recent DataHcloudImage#most_recent}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mostRecent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MostRecent
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Name of the Image, only present when the type is `system`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.66.0/docs/data-sources/image#name DataHcloudImage#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/cloud#label-selector).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.66.0/docs/data-sources/image#selector DataHcloudImage#selector}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Selector
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter results by architecture, for example `x86` (default) or `arm`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.66.0/docs/data-sources/image#with_architecture DataHcloudImage#with_architecture}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "withArchitecture", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WithArchitecture
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter results using a [Label Selector](https://docs.hetzner.cloud/reference/hetzner#label-selector).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.66.0/docs/data-sources/image#with_selector DataHcloudImage#with_selector}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "withSelector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WithSelector
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter results by statuses, for example `creating` or `available`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.66.0/docs/data-sources/image#with_status DataHcloudImage#with_status}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "withStatus", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? WithStatus
            {
                get => GetInstanceProperty<string[]?>();
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
