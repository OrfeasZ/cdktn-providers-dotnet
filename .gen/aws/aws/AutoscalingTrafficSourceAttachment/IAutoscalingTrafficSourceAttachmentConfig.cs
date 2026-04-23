using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AutoscalingTrafficSourceAttachment
{
    [JsiiInterface(nativeType: typeof(IAutoscalingTrafficSourceAttachmentConfig), fullyQualifiedName: "aws.autoscalingTrafficSourceAttachment.AutoscalingTrafficSourceAttachmentConfig")]
    public interface IAutoscalingTrafficSourceAttachmentConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/autoscaling_traffic_source_attachment#autoscaling_group_name AutoscalingTrafficSourceAttachment#autoscaling_group_name}.</summary>
        [JsiiProperty(name: "autoscalingGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string AutoscalingGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/autoscaling_traffic_source_attachment#id AutoscalingTrafficSourceAttachment#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/autoscaling_traffic_source_attachment#region AutoscalingTrafficSourceAttachment#region}
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/autoscaling_traffic_source_attachment#timeouts AutoscalingTrafficSourceAttachment#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.autoscalingTrafficSourceAttachment.AutoscalingTrafficSourceAttachmentTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AutoscalingTrafficSourceAttachment.IAutoscalingTrafficSourceAttachmentTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>traffic_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/autoscaling_traffic_source_attachment#traffic_source AutoscalingTrafficSourceAttachment#traffic_source}
        /// </remarks>
        [JsiiProperty(name: "trafficSource", typeJson: "{\"fqn\":\"aws.autoscalingTrafficSourceAttachment.AutoscalingTrafficSourceAttachmentTrafficSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AutoscalingTrafficSourceAttachment.IAutoscalingTrafficSourceAttachmentTrafficSource? TrafficSource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutoscalingTrafficSourceAttachmentConfig), fullyQualifiedName: "aws.autoscalingTrafficSourceAttachment.AutoscalingTrafficSourceAttachmentConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AutoscalingTrafficSourceAttachment.IAutoscalingTrafficSourceAttachmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/autoscaling_traffic_source_attachment#autoscaling_group_name AutoscalingTrafficSourceAttachment#autoscaling_group_name}.</summary>
            [JsiiProperty(name: "autoscalingGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string AutoscalingGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/autoscaling_traffic_source_attachment#id AutoscalingTrafficSourceAttachment#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/autoscaling_traffic_source_attachment#region AutoscalingTrafficSourceAttachment#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/autoscaling_traffic_source_attachment#timeouts AutoscalingTrafficSourceAttachment#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.autoscalingTrafficSourceAttachment.AutoscalingTrafficSourceAttachmentTimeouts\"}", isOptional: true)]
            public aws.AutoscalingTrafficSourceAttachment.IAutoscalingTrafficSourceAttachmentTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.AutoscalingTrafficSourceAttachment.IAutoscalingTrafficSourceAttachmentTimeouts?>();
            }

            /// <summary>traffic_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/autoscaling_traffic_source_attachment#traffic_source AutoscalingTrafficSourceAttachment#traffic_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trafficSource", typeJson: "{\"fqn\":\"aws.autoscalingTrafficSourceAttachment.AutoscalingTrafficSourceAttachmentTrafficSource\"}", isOptional: true)]
            public aws.AutoscalingTrafficSourceAttachment.IAutoscalingTrafficSourceAttachmentTrafficSource? TrafficSource
            {
                get => GetInstanceProperty<aws.AutoscalingTrafficSourceAttachment.IAutoscalingTrafficSourceAttachmentTrafficSource?>();
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
