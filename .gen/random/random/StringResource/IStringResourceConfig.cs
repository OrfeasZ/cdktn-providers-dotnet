using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace random.StringResource
{
    [JsiiInterface(nativeType: typeof(IStringResourceConfig), fullyQualifiedName: "random.stringResource.StringResourceConfig")]
    public interface IStringResourceConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The length of the string desired.</summary>
        /// <remarks>
        /// The minimum value for length is 1 and, length must also be &gt;= (<c>min_upper</c> + <c>min_lower</c> + <c>min_numeric</c> + <c>min_special</c>).
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#length StringResource#length}
        /// </remarks>
        [JsiiProperty(name: "length", typeJson: "{\"primitive\":\"number\"}")]
        double Length
        {
            get;
        }

        /// <summary>Arbitrary map of values that, when changed, will trigger recreation of resource.</summary>
        /// <remarks>
        /// See <a href="../index.html">the main provider documentation</a> for more information.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#keepers StringResource#keepers}
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

        /// <summary>Include lowercase alphabet characters in the result. Default value is `true`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#lower StringResource#lower}
        /// </remarks>
        [JsiiProperty(name: "lower", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Lower
        {
            get
            {
                return null;
            }
        }

        /// <summary>Minimum number of lowercase alphabet characters in the result. Default value is `0`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#min_lower StringResource#min_lower}
        /// </remarks>
        [JsiiProperty(name: "minLower", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinLower
        {
            get
            {
                return null;
            }
        }

        /// <summary>Minimum number of numeric characters in the result. Default value is `0`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#min_numeric StringResource#min_numeric}
        /// </remarks>
        [JsiiProperty(name: "minNumeric", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinNumeric
        {
            get
            {
                return null;
            }
        }

        /// <summary>Minimum number of special characters in the result. Default value is `0`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#min_special StringResource#min_special}
        /// </remarks>
        [JsiiProperty(name: "minSpecial", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinSpecial
        {
            get
            {
                return null;
            }
        }

        /// <summary>Minimum number of uppercase alphabet characters in the result. Default value is `0`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#min_upper StringResource#min_upper}
        /// </remarks>
        [JsiiProperty(name: "minUpper", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinUpper
        {
            get
            {
                return null;
            }
        }

        /// <summary>Include numeric characters in the result.</summary>
        /// <remarks>
        /// Default value is <c>true</c>. If <c>number</c>, <c>upper</c>, <c>lower</c>, and <c>special</c> are all configured, at least one of them must be set to <c>true</c>. <strong>NOTE</strong>: This is deprecated, use <c>numeric</c> instead.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#number StringResource#number}
        /// </remarks>
        [JsiiProperty(name: "number", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Number
        {
            get
            {
                return null;
            }
        }

        /// <summary>Include numeric characters in the result.</summary>
        /// <remarks>
        /// Default value is <c>true</c>. If <c>numeric</c>, <c>upper</c>, <c>lower</c>, and <c>special</c> are all configured, at least one of them must be set to <c>true</c>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#numeric StringResource#numeric}
        /// </remarks>
        [JsiiProperty(name: "numeric", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Numeric
        {
            get
            {
                return null;
            }
        }

        /// <summary>Supply your own list of special characters to use for string generation.</summary>
        /// <remarks>
        /// This overrides the default character list in the special argument.  The <c>special</c> argument must still be set to true for any overwritten characters to be used in generation.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#override_special StringResource#override_special}
        /// </remarks>
        [JsiiProperty(name: "overrideSpecial", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OverrideSpecial
        {
            get
            {
                return null;
            }
        }

        /// <summary>Include special characters in the result. These are `!@#$%&amp;*()-_=+[]{}&lt;&gt;:?`. Default value is `true`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#special StringResource#special}
        /// </remarks>
        [JsiiProperty(name: "special", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Special
        {
            get
            {
                return null;
            }
        }

        /// <summary>Include uppercase alphabet characters in the result. Default value is `true`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#upper StringResource#upper}
        /// </remarks>
        [JsiiProperty(name: "upper", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Upper
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStringResourceConfig), fullyQualifiedName: "random.stringResource.StringResourceConfig")]
        internal sealed class _Proxy : DeputyBase, random.StringResource.IStringResourceConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The length of the string desired.</summary>
            /// <remarks>
            /// The minimum value for length is 1 and, length must also be &gt;= (<c>min_upper</c> + <c>min_lower</c> + <c>min_numeric</c> + <c>min_special</c>).
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#length StringResource#length}
            /// </remarks>
            [JsiiProperty(name: "length", typeJson: "{\"primitive\":\"number\"}")]
            public double Length
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Arbitrary map of values that, when changed, will trigger recreation of resource.</summary>
            /// <remarks>
            /// See <a href="../index.html">the main provider documentation</a> for more information.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#keepers StringResource#keepers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keepers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Keepers
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Include lowercase alphabet characters in the result. Default value is `true`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#lower StringResource#lower}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lower", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Lower
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Minimum number of lowercase alphabet characters in the result. Default value is `0`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#min_lower StringResource#min_lower}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minLower", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinLower
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Minimum number of numeric characters in the result. Default value is `0`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#min_numeric StringResource#min_numeric}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minNumeric", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinNumeric
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Minimum number of special characters in the result. Default value is `0`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#min_special StringResource#min_special}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minSpecial", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinSpecial
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Minimum number of uppercase alphabet characters in the result. Default value is `0`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#min_upper StringResource#min_upper}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minUpper", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinUpper
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Include numeric characters in the result.</summary>
            /// <remarks>
            /// Default value is <c>true</c>. If <c>number</c>, <c>upper</c>, <c>lower</c>, and <c>special</c> are all configured, at least one of them must be set to <c>true</c>. <strong>NOTE</strong>: This is deprecated, use <c>numeric</c> instead.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#number StringResource#number}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "number", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Number
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Include numeric characters in the result.</summary>
            /// <remarks>
            /// Default value is <c>true</c>. If <c>numeric</c>, <c>upper</c>, <c>lower</c>, and <c>special</c> are all configured, at least one of them must be set to <c>true</c>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#numeric StringResource#numeric}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "numeric", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Numeric
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Supply your own list of special characters to use for string generation.</summary>
            /// <remarks>
            /// This overrides the default character list in the special argument.  The <c>special</c> argument must still be set to true for any overwritten characters to be used in generation.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#override_special StringResource#override_special}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "overrideSpecial", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OverrideSpecial
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Include special characters in the result. These are `!@#$%&amp;*()-_=+[]{}&lt;&gt;:?`. Default value is `true`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#special StringResource#special}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "special", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Special
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Include uppercase alphabet characters in the result. Default value is `true`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/random/3.8.1/docs/resources/string#upper StringResource#upper}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "upper", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Upper
            {
                get => GetInstanceProperty<object?>();
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
