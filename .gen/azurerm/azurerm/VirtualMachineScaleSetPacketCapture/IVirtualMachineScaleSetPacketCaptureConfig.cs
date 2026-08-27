using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualMachineScaleSetPacketCapture
{
    [JsiiInterface(nativeType: typeof(IVirtualMachineScaleSetPacketCaptureConfig), fullyQualifiedName: "azurerm.virtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCaptureConfig")]
    public interface IVirtualMachineScaleSetPacketCaptureConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#name VirtualMachineScaleSetPacketCapture#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#network_watcher_id VirtualMachineScaleSetPacketCapture#network_watcher_id}.</summary>
        [JsiiProperty(name: "networkWatcherId", typeJson: "{\"primitive\":\"string\"}")]
        string NetworkWatcherId
        {
            get;
        }

        /// <summary>storage_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#storage_location VirtualMachineScaleSetPacketCapture#storage_location}
        /// </remarks>
        [JsiiProperty(name: "storageLocation", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCaptureStorageLocation\"}")]
        azurerm.VirtualMachineScaleSetPacketCapture.IVirtualMachineScaleSetPacketCaptureStorageLocation StorageLocation
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#virtual_machine_scale_set_id VirtualMachineScaleSetPacketCapture#virtual_machine_scale_set_id}.</summary>
        [JsiiProperty(name: "virtualMachineScaleSetId", typeJson: "{\"primitive\":\"string\"}")]
        string VirtualMachineScaleSetId
        {
            get;
        }

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#filter VirtualMachineScaleSetPacketCapture#filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachineScaleSetPacketCapture.IVirtualMachineScaleSetPacketCaptureFilter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCaptureFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#id VirtualMachineScaleSetPacketCapture#id}.</summary>
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

        /// <summary>machine_scope block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#machine_scope VirtualMachineScaleSetPacketCapture#machine_scope}
        /// </remarks>
        [JsiiProperty(name: "machineScope", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCaptureMachineScope\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.VirtualMachineScaleSetPacketCapture.IVirtualMachineScaleSetPacketCaptureMachineScope? MachineScope
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#maximum_bytes_per_packet VirtualMachineScaleSetPacketCapture#maximum_bytes_per_packet}.</summary>
        [JsiiProperty(name: "maximumBytesPerPacket", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumBytesPerPacket
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#maximum_bytes_per_session VirtualMachineScaleSetPacketCapture#maximum_bytes_per_session}.</summary>
        [JsiiProperty(name: "maximumBytesPerSession", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumBytesPerSession
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#maximum_capture_duration_in_seconds VirtualMachineScaleSetPacketCapture#maximum_capture_duration_in_seconds}.</summary>
        [JsiiProperty(name: "maximumCaptureDurationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumCaptureDurationInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#timeouts VirtualMachineScaleSetPacketCapture#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCaptureTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.VirtualMachineScaleSetPacketCapture.IVirtualMachineScaleSetPacketCaptureTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVirtualMachineScaleSetPacketCaptureConfig), fullyQualifiedName: "azurerm.virtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCaptureConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.VirtualMachineScaleSetPacketCapture.IVirtualMachineScaleSetPacketCaptureConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#name VirtualMachineScaleSetPacketCapture#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#network_watcher_id VirtualMachineScaleSetPacketCapture#network_watcher_id}.</summary>
            [JsiiProperty(name: "networkWatcherId", typeJson: "{\"primitive\":\"string\"}")]
            public string NetworkWatcherId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>storage_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#storage_location VirtualMachineScaleSetPacketCapture#storage_location}
            /// </remarks>
            [JsiiProperty(name: "storageLocation", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCaptureStorageLocation\"}")]
            public azurerm.VirtualMachineScaleSetPacketCapture.IVirtualMachineScaleSetPacketCaptureStorageLocation StorageLocation
            {
                get => GetInstanceProperty<azurerm.VirtualMachineScaleSetPacketCapture.IVirtualMachineScaleSetPacketCaptureStorageLocation>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#virtual_machine_scale_set_id VirtualMachineScaleSetPacketCapture#virtual_machine_scale_set_id}.</summary>
            [JsiiProperty(name: "virtualMachineScaleSetId", typeJson: "{\"primitive\":\"string\"}")]
            public string VirtualMachineScaleSetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#filter VirtualMachineScaleSetPacketCapture#filter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azurerm.VirtualMachineScaleSetPacketCapture.IVirtualMachineScaleSetPacketCaptureFilter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.virtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCaptureFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Filter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#id VirtualMachineScaleSetPacketCapture#id}.</summary>
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

            /// <summary>machine_scope block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#machine_scope VirtualMachineScaleSetPacketCapture#machine_scope}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "machineScope", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCaptureMachineScope\"}", isOptional: true)]
            public azurerm.VirtualMachineScaleSetPacketCapture.IVirtualMachineScaleSetPacketCaptureMachineScope? MachineScope
            {
                get => GetInstanceProperty<azurerm.VirtualMachineScaleSetPacketCapture.IVirtualMachineScaleSetPacketCaptureMachineScope?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#maximum_bytes_per_packet VirtualMachineScaleSetPacketCapture#maximum_bytes_per_packet}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumBytesPerPacket", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumBytesPerPacket
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#maximum_bytes_per_session VirtualMachineScaleSetPacketCapture#maximum_bytes_per_session}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumBytesPerSession", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumBytesPerSession
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#maximum_capture_duration_in_seconds VirtualMachineScaleSetPacketCapture#maximum_capture_duration_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumCaptureDurationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumCaptureDurationInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.3.0/docs/resources/virtual_machine_scale_set_packet_capture#timeouts VirtualMachineScaleSetPacketCapture#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.virtualMachineScaleSetPacketCapture.VirtualMachineScaleSetPacketCaptureTimeouts\"}", isOptional: true)]
            public azurerm.VirtualMachineScaleSetPacketCapture.IVirtualMachineScaleSetPacketCaptureTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.VirtualMachineScaleSetPacketCapture.IVirtualMachineScaleSetPacketCaptureTimeouts?>();
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
