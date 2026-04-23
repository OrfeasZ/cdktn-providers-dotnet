using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudsearchDomain
{
    [JsiiInterface(nativeType: typeof(ICloudsearchDomainConfig), fullyQualifiedName: "aws.cloudsearchDomain.CloudsearchDomainConfig")]
    public interface ICloudsearchDomainConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudsearch_domain#name CloudsearchDomain#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>endpoint_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudsearch_domain#endpoint_options CloudsearchDomain#endpoint_options}
        /// </remarks>
        [JsiiProperty(name: "endpointOptions", typeJson: "{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainEndpointOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudsearchDomain.ICloudsearchDomainEndpointOptions? EndpointOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudsearch_domain#id CloudsearchDomain#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>index_field block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudsearch_domain#index_field CloudsearchDomain#index_field}
        /// </remarks>
        [JsiiProperty(name: "indexField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainIndexField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IndexField
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudsearch_domain#multi_az CloudsearchDomain#multi_az}.</summary>
        [JsiiProperty(name: "multiAz", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MultiAz
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudsearch_domain#region CloudsearchDomain#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>scaling_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudsearch_domain#scaling_parameters CloudsearchDomain#scaling_parameters}
        /// </remarks>
        [JsiiProperty(name: "scalingParameters", typeJson: "{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainScalingParameters\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudsearchDomain.ICloudsearchDomainScalingParameters? ScalingParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudsearch_domain#timeouts CloudsearchDomain#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CloudsearchDomain.ICloudsearchDomainTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudsearchDomainConfig), fullyQualifiedName: "aws.cloudsearchDomain.CloudsearchDomainConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudsearchDomain.ICloudsearchDomainConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudsearch_domain#name CloudsearchDomain#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>endpoint_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudsearch_domain#endpoint_options CloudsearchDomain#endpoint_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endpointOptions", typeJson: "{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainEndpointOptions\"}", isOptional: true)]
            public aws.CloudsearchDomain.ICloudsearchDomainEndpointOptions? EndpointOptions
            {
                get => GetInstanceProperty<aws.CloudsearchDomain.ICloudsearchDomainEndpointOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudsearch_domain#id CloudsearchDomain#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>index_field block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudsearch_domain#index_field CloudsearchDomain#index_field}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "indexField", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainIndexField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IndexField
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudsearch_domain#multi_az CloudsearchDomain#multi_az}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "multiAz", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MultiAz
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudsearch_domain#region CloudsearchDomain#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>scaling_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudsearch_domain#scaling_parameters CloudsearchDomain#scaling_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scalingParameters", typeJson: "{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainScalingParameters\"}", isOptional: true)]
            public aws.CloudsearchDomain.ICloudsearchDomainScalingParameters? ScalingParameters
            {
                get => GetInstanceProperty<aws.CloudsearchDomain.ICloudsearchDomainScalingParameters?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/cloudsearch_domain#timeouts CloudsearchDomain#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.cloudsearchDomain.CloudsearchDomainTimeouts\"}", isOptional: true)]
            public aws.CloudsearchDomain.ICloudsearchDomainTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.CloudsearchDomain.ICloudsearchDomainTimeouts?>();
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
