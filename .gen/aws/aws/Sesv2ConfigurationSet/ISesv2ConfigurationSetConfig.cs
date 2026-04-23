using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2ConfigurationSet
{
    [JsiiInterface(nativeType: typeof(ISesv2ConfigurationSetConfig), fullyQualifiedName: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetConfig")]
    public interface ISesv2ConfigurationSetConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#configuration_set_name Sesv2ConfigurationSet#configuration_set_name}.</summary>
        [JsiiProperty(name: "configurationSetName", typeJson: "{\"primitive\":\"string\"}")]
        string ConfigurationSetName
        {
            get;
        }

        /// <summary>delivery_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#delivery_options Sesv2ConfigurationSet#delivery_options}
        /// </remarks>
        [JsiiProperty(name: "deliveryOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetDeliveryOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetDeliveryOptions? DeliveryOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#id Sesv2ConfigurationSet#id}.</summary>
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

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#region Sesv2ConfigurationSet#region}
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

        /// <summary>reputation_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#reputation_options Sesv2ConfigurationSet#reputation_options}
        /// </remarks>
        [JsiiProperty(name: "reputationOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetReputationOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetReputationOptions? ReputationOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>sending_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#sending_options Sesv2ConfigurationSet#sending_options}
        /// </remarks>
        [JsiiProperty(name: "sendingOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetSendingOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetSendingOptions? SendingOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>suppression_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#suppression_options Sesv2ConfigurationSet#suppression_options}
        /// </remarks>
        [JsiiProperty(name: "suppressionOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetSuppressionOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetSuppressionOptions? SuppressionOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#tags Sesv2ConfigurationSet#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#tags_all Sesv2ConfigurationSet#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>tracking_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#tracking_options Sesv2ConfigurationSet#tracking_options}
        /// </remarks>
        [JsiiProperty(name: "trackingOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetTrackingOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetTrackingOptions? TrackingOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>vdm_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#vdm_options Sesv2ConfigurationSet#vdm_options}
        /// </remarks>
        [JsiiProperty(name: "vdmOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptions? VdmOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesv2ConfigurationSetConfig), fullyQualifiedName: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#configuration_set_name Sesv2ConfigurationSet#configuration_set_name}.</summary>
            [JsiiProperty(name: "configurationSetName", typeJson: "{\"primitive\":\"string\"}")]
            public string ConfigurationSetName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>delivery_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#delivery_options Sesv2ConfigurationSet#delivery_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deliveryOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetDeliveryOptions\"}", isOptional: true)]
            public aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetDeliveryOptions? DeliveryOptions
            {
                get => GetInstanceProperty<aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetDeliveryOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#id Sesv2ConfigurationSet#id}.</summary>
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

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#region Sesv2ConfigurationSet#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>reputation_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#reputation_options Sesv2ConfigurationSet#reputation_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reputationOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetReputationOptions\"}", isOptional: true)]
            public aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetReputationOptions? ReputationOptions
            {
                get => GetInstanceProperty<aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetReputationOptions?>();
            }

            /// <summary>sending_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#sending_options Sesv2ConfigurationSet#sending_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sendingOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetSendingOptions\"}", isOptional: true)]
            public aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetSendingOptions? SendingOptions
            {
                get => GetInstanceProperty<aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetSendingOptions?>();
            }

            /// <summary>suppression_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#suppression_options Sesv2ConfigurationSet#suppression_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "suppressionOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetSuppressionOptions\"}", isOptional: true)]
            public aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetSuppressionOptions? SuppressionOptions
            {
                get => GetInstanceProperty<aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetSuppressionOptions?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#tags Sesv2ConfigurationSet#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#tags_all Sesv2ConfigurationSet#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsAll
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>tracking_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#tracking_options Sesv2ConfigurationSet#tracking_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trackingOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetTrackingOptions\"}", isOptional: true)]
            public aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetTrackingOptions? TrackingOptions
            {
                get => GetInstanceProperty<aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetTrackingOptions?>();
            }

            /// <summary>vdm_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sesv2_configuration_set#vdm_options Sesv2ConfigurationSet#vdm_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vdmOptions", typeJson: "{\"fqn\":\"aws.sesv2ConfigurationSet.Sesv2ConfigurationSetVdmOptions\"}", isOptional: true)]
            public aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptions? VdmOptions
            {
                get => GetInstanceProperty<aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetVdmOptions?>();
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
