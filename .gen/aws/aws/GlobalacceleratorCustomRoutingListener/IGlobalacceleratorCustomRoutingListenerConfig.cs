using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlobalacceleratorCustomRoutingListener
{
    [JsiiInterface(nativeType: typeof(IGlobalacceleratorCustomRoutingListenerConfig), fullyQualifiedName: "aws.globalacceleratorCustomRoutingListener.GlobalacceleratorCustomRoutingListenerConfig")]
    public interface IGlobalacceleratorCustomRoutingListenerConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/globalaccelerator_custom_routing_listener#accelerator_arn GlobalacceleratorCustomRoutingListener#accelerator_arn}.</summary>
        [JsiiProperty(name: "acceleratorArn", typeJson: "{\"primitive\":\"string\"}")]
        string AcceleratorArn
        {
            get;
        }

        /// <summary>port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/globalaccelerator_custom_routing_listener#port_range GlobalacceleratorCustomRoutingListener#port_range}
        /// </remarks>
        [JsiiProperty(name: "portRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.globalacceleratorCustomRoutingListener.GlobalacceleratorCustomRoutingListenerPortRange\"},\"kind\":\"array\"}}]}}")]
        object PortRange
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/globalaccelerator_custom_routing_listener#id GlobalacceleratorCustomRoutingListener#id}.</summary>
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

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/globalaccelerator_custom_routing_listener#timeouts GlobalacceleratorCustomRoutingListener#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.globalacceleratorCustomRoutingListener.GlobalacceleratorCustomRoutingListenerTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GlobalacceleratorCustomRoutingListener.IGlobalacceleratorCustomRoutingListenerTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlobalacceleratorCustomRoutingListenerConfig), fullyQualifiedName: "aws.globalacceleratorCustomRoutingListener.GlobalacceleratorCustomRoutingListenerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.GlobalacceleratorCustomRoutingListener.IGlobalacceleratorCustomRoutingListenerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/globalaccelerator_custom_routing_listener#accelerator_arn GlobalacceleratorCustomRoutingListener#accelerator_arn}.</summary>
            [JsiiProperty(name: "acceleratorArn", typeJson: "{\"primitive\":\"string\"}")]
            public string AcceleratorArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>port_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/globalaccelerator_custom_routing_listener#port_range GlobalacceleratorCustomRoutingListener#port_range}
            /// </remarks>
            [JsiiProperty(name: "portRange", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.globalacceleratorCustomRoutingListener.GlobalacceleratorCustomRoutingListenerPortRange\"},\"kind\":\"array\"}}]}}")]
            public object PortRange
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/globalaccelerator_custom_routing_listener#id GlobalacceleratorCustomRoutingListener#id}.</summary>
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

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/globalaccelerator_custom_routing_listener#timeouts GlobalacceleratorCustomRoutingListener#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.globalacceleratorCustomRoutingListener.GlobalacceleratorCustomRoutingListenerTimeouts\"}", isOptional: true)]
            public aws.GlobalacceleratorCustomRoutingListener.IGlobalacceleratorCustomRoutingListenerTimeouts? Timeouts
            {
                get => GetInstanceProperty<aws.GlobalacceleratorCustomRoutingListener.IGlobalacceleratorCustomRoutingListenerTimeouts?>();
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
