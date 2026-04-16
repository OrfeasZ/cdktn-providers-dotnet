using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.FlexibleIpMacAddress
{
    [JsiiInterface(nativeType: typeof(IFlexibleIpMacAddressConfig), fullyQualifiedName: "scaleway.flexibleIpMacAddress.FlexibleIpMacAddressConfig")]
    public interface IFlexibleIpMacAddressConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The ID of the flexible IP for which to generate a virtual MAC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/flexible_ip_mac_address#flexible_ip_id FlexibleIpMacAddress#flexible_ip_id}
        /// </remarks>
        [JsiiProperty(name: "flexibleIpId", typeJson: "{\"primitive\":\"string\"}")]
        string FlexibleIpId
        {
            get;
        }

        /// <summary>The type of the virtual MAC.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/flexible_ip_mac_address#type FlexibleIpMacAddress#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>The IDs of the flexible IPs on which to duplicate the virtual MAC.</summary>
        /// <remarks>
        /// <strong>NOTE</strong> : The flexible IPs need to be attached to the same server for the operation to work.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/flexible_ip_mac_address#flexible_ip_ids_to_duplicate FlexibleIpMacAddress#flexible_ip_ids_to_duplicate}
        /// </remarks>
        [JsiiProperty(name: "flexibleIpIdsToDuplicate", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? FlexibleIpIdsToDuplicate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/flexible_ip_mac_address#id FlexibleIpMacAddress#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/flexible_ip_mac_address#timeouts FlexibleIpMacAddress#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.flexibleIpMacAddress.FlexibleIpMacAddressTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        scaleway.FlexibleIpMacAddress.IFlexibleIpMacAddressTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>The zone you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/flexible_ip_mac_address#zone FlexibleIpMacAddress#zone}
        /// </remarks>
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Zone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFlexibleIpMacAddressConfig), fullyQualifiedName: "scaleway.flexibleIpMacAddress.FlexibleIpMacAddressConfig")]
        internal sealed class _Proxy : DeputyBase, scaleway.FlexibleIpMacAddress.IFlexibleIpMacAddressConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the flexible IP for which to generate a virtual MAC.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/flexible_ip_mac_address#flexible_ip_id FlexibleIpMacAddress#flexible_ip_id}
            /// </remarks>
            [JsiiProperty(name: "flexibleIpId", typeJson: "{\"primitive\":\"string\"}")]
            public string FlexibleIpId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The type of the virtual MAC.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/flexible_ip_mac_address#type FlexibleIpMacAddress#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The IDs of the flexible IPs on which to duplicate the virtual MAC.</summary>
            /// <remarks>
            /// <strong>NOTE</strong> : The flexible IPs need to be attached to the same server for the operation to work.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/flexible_ip_mac_address#flexible_ip_ids_to_duplicate FlexibleIpMacAddress#flexible_ip_ids_to_duplicate}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flexibleIpIdsToDuplicate", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? FlexibleIpIdsToDuplicate
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/flexible_ip_mac_address#id FlexibleIpMacAddress#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/flexible_ip_mac_address#timeouts FlexibleIpMacAddress#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"scaleway.flexibleIpMacAddress.FlexibleIpMacAddressTimeouts\"}", isOptional: true)]
            public scaleway.FlexibleIpMacAddress.IFlexibleIpMacAddressTimeouts? Timeouts
            {
                get => GetInstanceProperty<scaleway.FlexibleIpMacAddress.IFlexibleIpMacAddressTimeouts?>();
            }

            /// <summary>The zone you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/flexible_ip_mac_address#zone FlexibleIpMacAddress#zone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Zone
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
