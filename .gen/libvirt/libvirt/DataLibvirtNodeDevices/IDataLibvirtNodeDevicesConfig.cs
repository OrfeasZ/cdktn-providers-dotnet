using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.DataLibvirtNodeDevices
{
    [JsiiInterface(nativeType: typeof(IDataLibvirtNodeDevicesConfig), fullyQualifiedName: "libvirt.dataLibvirtNodeDevices.DataLibvirtNodeDevicesConfig")]
    public interface IDataLibvirtNodeDevicesConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Filter devices by capability type. Valid values include:.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description><c>system</c> - Host system information
        ///
        /// <list type="bullet">
        /// <description><c>pci</c> - PCI devices</description>
        /// <description><c>usb_device</c> - USB devices</description>
        /// <description><c>usb</c> - USB host controllers</description>
        /// <description><c>net</c> - Network interfaces</description>
        /// <description><c>scsi_host</c> - SCSI host adapters</description>
        /// <description><c>scsi</c> - SCSI devices</description>
        /// <description><c>storage</c> - Storage devices</description>
        /// <description><c>drm</c> - DRM devices</description>
        /// <description><c>mdev</c> - Mediated devices</description>
        /// <description><c>ccw</c> - s390 CCW devices</description>
        /// <description><c>css</c> - s390 CSS devices</description>
        /// <description><c>ap_queue</c> - s390 AP queue devices</description>
        /// <description><c>ap_card</c> - s390 AP card devices</description>
        /// <description><c>ap_matrix</c> - s390 AP matrix devices</description>
        /// <description><c>ccw_group</c> - s390 CCW group devices</description>
        /// </list></description>
        /// </list>
        ///
        /// If not specified, all devices are returned.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/data-sources/node_devices#capability DataLibvirtNodeDevices#capability}
        /// </remarks>
        [JsiiProperty(name: "capability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Capability
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataLibvirtNodeDevicesConfig), fullyQualifiedName: "libvirt.dataLibvirtNodeDevices.DataLibvirtNodeDevicesConfig")]
        internal sealed class _Proxy : DeputyBase, libvirt.DataLibvirtNodeDevices.IDataLibvirtNodeDevicesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Filter devices by capability type. Valid values include:.</summary>
            /// <remarks>
            /// <list type="bullet">
            /// <description><c>system</c> - Host system information
            ///
            /// <list type="bullet">
            /// <description><c>pci</c> - PCI devices</description>
            /// <description><c>usb_device</c> - USB devices</description>
            /// <description><c>usb</c> - USB host controllers</description>
            /// <description><c>net</c> - Network interfaces</description>
            /// <description><c>scsi_host</c> - SCSI host adapters</description>
            /// <description><c>scsi</c> - SCSI devices</description>
            /// <description><c>storage</c> - Storage devices</description>
            /// <description><c>drm</c> - DRM devices</description>
            /// <description><c>mdev</c> - Mediated devices</description>
            /// <description><c>ccw</c> - s390 CCW devices</description>
            /// <description><c>css</c> - s390 CSS devices</description>
            /// <description><c>ap_queue</c> - s390 AP queue devices</description>
            /// <description><c>ap_card</c> - s390 AP card devices</description>
            /// <description><c>ap_matrix</c> - s390 AP matrix devices</description>
            /// <description><c>ccw_group</c> - s390 CCW group devices</description>
            /// </list></description>
            /// </list>
            ///
            /// If not specified, all devices are returned.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.8/docs/data-sources/node_devices#capability DataLibvirtNodeDevices#capability}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Capability
            {
                get => GetInstanceProperty<string?>();
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
