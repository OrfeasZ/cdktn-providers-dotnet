using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace random.Integer
{
    [JsiiInterface(nativeType: typeof(IIntegerConfig), fullyQualifiedName: "random.integer.IntegerConfig")]
    public interface IIntegerConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The maximum inclusive value of the range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/integer#max Integer#max}
        /// </remarks>
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
        double Max
        {
            get;
        }

        /// <summary>The minimum inclusive value of the range.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/integer#min Integer#min}
        /// </remarks>
        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}")]
        double Min
        {
            get;
        }

        /// <summary>Arbitrary map of values that, when changed, will trigger recreation of resource.</summary>
        /// <remarks>
        /// See <a href="../index.html">the main provider documentation</a> for more information.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/integer#keepers Integer#keepers}
        /// </remarks>
        [JsiiProperty(name: "keepers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Keepers
        {
            get
            {
                return null;
            }
        }

        /// <summary>A custom seed to always produce the same value.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/integer#seed Integer#seed}
        /// </remarks>
        [JsiiProperty(name: "seed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Seed
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIntegerConfig), fullyQualifiedName: "random.integer.IntegerConfig")]
        internal sealed class _Proxy : DeputyBase, random.Integer.IIntegerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The maximum inclusive value of the range.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/integer#max Integer#max}
            /// </remarks>
            [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
            public double Max
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The minimum inclusive value of the range.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/integer#min Integer#min}
            /// </remarks>
            [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}")]
            public double Min
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Arbitrary map of values that, when changed, will trigger recreation of resource.</summary>
            /// <remarks>
            /// See <a href="../index.html">the main provider documentation</a> for more information.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/integer#keepers Integer#keepers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keepers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Keepers
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>A custom seed to always produce the same value.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/integer#seed Integer#seed}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "seed", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Seed
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
